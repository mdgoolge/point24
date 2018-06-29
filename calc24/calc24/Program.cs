using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc24
{
    class Program
    {
        static void Main(string[] args)
        {
            var permuteOfNums = Permute(new List<int> { 4, 5, 6, 7 });

            foreach (var op1 in new List<string> { "+", "-", "*", "/" })
            {
                foreach (var op2 in new List<string> { "+", "-", "*", "/" })
                {
                    foreach (var op3 in new List<string> { "+", "-", "*", "/" })
                    {
                        var ops = new List<string> { op1, op2, op3 };

                        foreach (var node in AllCompleteBinaryTreesOf7Nodes())
                        {
                            foreach (var nums in permuteOfNums)
                            {
                                var tree = CreateOne24CalculationFormula(node, nums, ops);
                                try
                                {
                                    var result = Evaluate(tree);

                                    if (Math.Abs(result - 24) < 0.0001)
                                    {
                                        Console.WriteLine(BinaryTreeString(tree));
                                    }
                                }
                                catch (DivideByZeroException)
                                {

                                }
                            }
                        }
                    }
                }
            }
        }
        static float Evaluate(Node node)
        {
            switch (node.Data)
            {
                case "+":
                    return Evaluate(node.Left) + Evaluate(node.Right);
                case "-":
                    return Evaluate(node.Left) - Evaluate(node.Right);
                case "*":
                    return Evaluate(node.Left) * Evaluate(node.Right);
                case "/":
                    return Evaluate(node.Left) / Evaluate(node.Right);
                default:
                    return float.Parse(node.Data);
            }
        }

        static Node CreateOne24CalculationFormula(Node node, List<int> nums, List<string> operators)
        {

            Node result = null;
            var iNums = 0;
            var iOps = 0;

            Func<Node, Node> copy = null;

            copy = (src) =>
            {
                Node dest;

                if (src.Left == null && src.Right == null)
                {
                    dest = new Node(null, null, nums[iNums++].ToString());
                }
                else
                {
                    var left = copy(src.Left);
                    var right = copy(src.Right);

                    dest = new Node(left, right, operators[iOps++]);
                }

                return dest;
            };

            result = copy(node);

            return result;
        }

        static IEnumerable<List<T>> Permute<T>(List<T> elements)
        {
            if (elements.Count == 1)
                return EnumerableOfOneElement(elements);

            IEnumerable<List<T>> result = null;

            foreach (var first in elements)
            {
                var remaining = elements.ToArray().ToList();
                remaining.Remove(first);

                var permutesOfRemaining = Permute(remaining);

                foreach (var p in permutesOfRemaining)
                {
                    var arr = new List<T> { first };
                    arr.AddRange(p);

                    var seq = EnumerableOfOneElement(arr);

                    if (result == null)
                    {
                        result = seq;
                    }
                    else
                    {
                        result = Enumerable.Union(result, seq);
                    }
                }
            }

            return result;
        }

        static IEnumerable<T> EnumerableOfOneElement<T>(T element)
        {
            yield return element;
        }

        static IEnumerable<Node> AllCompleteBinaryTreesOf7Nodes()
        {
            var trees = AllBinaryTrees(7);
            return (from t in trees
                    where IsCompleteBinaryTree(t)
                    select t);
        }

        static bool IsCompleteBinaryTree(Node node)
        {
            if (node == null)
                return true;

            if (node.Left == null && node.Right != null ||
                node.Left != null && node.Right == null)
                return false;

            return IsCompleteBinaryTree(node.Left) && IsCompleteBinaryTree(node.Right);
        }

        static IEnumerable<Node> AllBinaryTrees(int size)
        {
            if (size == 0)
                return new Node[] { null };
            return from i in Enumerable.Range(0, size)
                   from left in AllBinaryTrees(i)
                   from right in AllBinaryTrees(size - 1 - i)
                   select new Node(left, right, "");
        }

        public static string BinaryTreeString(Node node)
        {
            var sb = new StringBuilder();
            Action<Node> f = null;
            f = n =>
            {
                if (n == null)
                {
                    //sb.Append ("x");
                }
                else if (new[] { "+", "-", "*", "/" }.Contains(n.Data))
                {

                    sb.Append("(");
                    f(n.Left);

                    sb.Append(" " + n.Data + " ");

                    f(n.Right);
                    sb.Append(")");

                }
                else
                {
                    sb.Append(n.Data);
                }
            };
            f(node);
            return sb.ToString();
        }
    }

    class Node
    {
        public Node Left { get; set; }

        public Node Right { get; set; }

        public string Data { get; set; }

        public Node()
        {

        }

        public Node(Node left, Node right, string data)
        {
            this.Left = left;
            this.Right = right;
            this.Data = data;
        }
    }
}

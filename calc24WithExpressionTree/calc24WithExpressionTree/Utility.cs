using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace calc24WithExpressionTree
{
    public class Utility
    {
        public static IEnumerable<Node> AllBinaryTrees(int size)
        {
            if (size == 0)
                return new Node[] { null };
            return from i in Enumerable.Range(0, size)
                   from left in AllBinaryTrees(i)
                   from right in AllBinaryTrees(size - 1 - i)
                   select new Node(left, right);
        }
        public static Expression Build(Node node, List<double> numbers, List<Func<Expression, Expression, BinaryExpression>> operators)
        {
            var iNum = 0;
            var iOprt = 0;

            Func<Node, Expression> f = null;
            f = n =>
            {
                Expression exp;
                if (n == null)
                    exp = Expression.Constant(numbers[iNum++]);
                else
                {
                    var left = f(n.Left);
                    var right = f(n.Right);
                    exp = operators[iOprt++](left, right);
                }
                return exp;
            };
            return f(node);
        }

        public static IEnumerable<List<T>> FullPermute<T>(List<T> elements)
        {
            if (elements.Count == 1)
                return EnumerableOfOneElement(elements);

            IEnumerable<List<T>> result = null;
            foreach (T first in elements)
            {
                List<T> remaining = elements.ToArray().ToList();
                remaining.Remove(first);
                IEnumerable<List<T>> fullPermuteOfRemaining = FullPermute(remaining);

                foreach (List<T> permute in fullPermuteOfRemaining)
                {
                    var arr = new List<T> { first };
                    arr.AddRange(permute);

                    var seq = EnumerableOfOneElement(arr);
                    if (result == null)
                        result = seq;
                    else
                        result = result.Union(seq);
                }
            }
            return result;
        }

        public static IEnumerable<T> EnumerableOfOneElement<T>(T element)
        {
            yield return element;
        }
        public static IEnumerable<IEnumerable<Func<Expression, Expression, BinaryExpression>>> OperatorPermute(List<Func<Expression, Expression, BinaryExpression>> operators)
        {
            return from operator1 in operators
                   from operator2 in operators
                   from operator3 in operators
                   select new[] { operator1, operator2, operator3 };
        }
    }
}

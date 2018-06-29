using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace calc24WithExpressionTree
{
    class Program
    {
        static int no = 1;
        static void Main(string[] args)
        {
            int max = 13;
            List<List<double>> list = new List<List<double>>();
            for (int i1 = 1; i1 <= max; i1++)
            {
                for (int i2 = 1; i2 <= max; i2++)
                {
                    for (int i3 = 1; i3 <= max; i3++)
                    {
                        for (int i4 = 1; i4 <= max; i4++)
                        {

                            bool isContains = false;
                            foreach (var item in list)
                            {
                                if (item.Contains(i1) && item.Contains(i2) && item.Contains(i3) && item.Contains(i4))
                                {
                                    isContains = true;
                                    break;
                                }
                            }
                            if (isContains)
                            {
                                continue;
                            }
                            list.Add(new List<double> { i1, i2, i3, i4 });
                        }
                    }
                }
            }
            foreach (var item in list)
            {
                CalcOneIsBad(item);
            }

            //CalcOne(new List<double> { 1, 2, 3, 4 });


            Console.Read();
        }

        private static void CalcOne(List<double> numbers)
        {

            var operators = new List<Func<Expression, Expression, BinaryExpression>> {
        Expression.Add,Expression.Subtract,Expression.Multiply,Expression.Divide 
    };

            foreach (var operatorCombination in Utility.OperatorPermute(operators))
            {
                foreach (Node node in Utility.AllBinaryTrees(3))
                {
                    foreach (List<double> permuteOfNumbers in Utility.FullPermute(numbers))
                    {
                        Expression expression = Utility.Build(node, permuteOfNumbers, operatorCombination.ToList());
                        Func<double> compiled = Expression.Lambda<Func<double>>(expression).Compile();
                        try
                        {
                            var value = compiled();
                            if (Math.Abs(value - 24) < 0.01)
                                Console.WriteLine("{0} = {1}", expression, value);
                        }
                        catch (DivideByZeroException) { }
                    }
                }
            }
        }
        private static void CalcOneIsBad(List<double> numbers)
        {
            var operators = new List<Func<Expression, Expression, BinaryExpression>> 
            {
                Expression.Add,Expression.Subtract,Expression.Multiply,Expression.Divide 
            };

            bool isok = false;
            foreach (var operatorCombination in Utility.OperatorPermute(operators))
            {
                foreach (Node node in Utility.AllBinaryTrees(3))
                {
                    foreach (List<double> permuteOfNumbers in Utility.FullPermute(numbers))
                    {
                        Expression expression = Utility.Build(node, permuteOfNumbers, operatorCombination.ToList());
                        Func<double> compiled = Expression.Lambda<Func<double>>(expression).Compile();
                        try
                        {
                            var value = compiled();
                            if (Math.Abs(value - 24) < 0.01) { isok = true; break; }

                        }
                        catch (DivideByZeroException) { }
                    }
                    if (isok)
                    {
                        break;
                    }
                }
                if (isok)
                {
                    break;
                }
            }
            if (!isok)
            {
                Console.WriteLine(no++ + ":" + numbers[0] + "," + numbers[1] + "," + numbers[2] + "," + numbers[3]);
            }

        }
    }
}

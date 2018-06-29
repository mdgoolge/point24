using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace calc24WithExpressionTree
{
    public class UtilityMain
    {
        /// <summary>
        /// 计算一组数是否可以凑出24，如果可以则列出，否则返回false
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool CalcOne(List<double> numbers, out List<string> result)
        {
            result = new List<string>();

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
                            if (Math.Abs(value - 24) < 0.01)
                            {
                                //Console.WriteLine("{0} = {1}", expression, value);
                                result.Add(expression.ToString());
                                isok = true;
                            }

                        }
                        catch (DivideByZeroException) { }
                    }

                }
            }

            return isok;
        }

        public static bool CalcOneIsBad(List<double> numbers)
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
                            if (Math.Abs(value - 24) < 0.01)
                            {
                                isok = true;
                                break;
                            }

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

            return !isok;
        }
        /// <summary>
        /// 计算max以内的所有不能凑出24的组合
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        public static List<List<double>> CalcBadList(int max)
        {
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

            List<List<double>> listresult = new List<List<double>>();
            foreach (var item in list)
            {
                if (CalcOneIsBad(item))
                {
                    listresult.Add(item);
                }
            }

            return listresult;
        }
    }
}

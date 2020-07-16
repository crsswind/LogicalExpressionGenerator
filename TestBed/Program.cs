using System;
using LogicalExpressionGenerator;

namespace TestBed
{
    internal class Program
    {
        #region Private Methods

        private static void Main(string[] args)
        {
            ComparativeOperatorTest();
            ComparativeOperatorTest2();
            ComparativeOperatorTest3();
            LikeOperatorTest();
            IsNullFunctionTest2();
            ComplexComparativeOperatorTest();
            ComplexExpressionAndComparativeOperatorTest();
            InOperatorTest();
            IsNullFunctionTest();
            DateTimeConstantTest();

            Console.ReadLine();
        }

        private static void IsNullFunctionTest()
        {
            var weight = new DecimalVariable("weight");
            var replacementValue = new DecimalConstant(10.0m);
            var myFunction = new IsNullFunction<decimal>(weight, replacementValue);
            Console.WriteLine(myFunction.ToSql());
        }

        private static void InOperatorTest()
        {
            var columnName = new StringVariable("City");
            var city1 = new StringConstant("Tehran");
            var city2 = new StringConstant("Melbourne");
            var city3 = new StringConstant("Paris");
            var city4 = new StringConstant("Frankfurt");

            var cities = new Constant<string>[] {city1, city2, city3, city4};
            var inOperator = new InOperator<string>(columnName, cities);
            Console.WriteLine(inOperator.ToSql());
        }

        private static void ComplexExpressionAndComparativeOperatorTest()
        {
            var x = new IntegerVariable("X");
            var three = new IntegerConstant(3);
            var leftExpression = new ComplexExpression<int>(ComplexExpressionType.Divide, x, three);
            var rightExpression = new IntegerConstant(20);
            var finalCondition = new ComparativeOperator<int>(ComparativeOperatorType.GreaterThan, leftExpression, rightExpression);
            Console.WriteLine(finalCondition.ToSql());
        }

        private static void ComplexComparativeOperatorTest()
        {
            var d = new IntegerVariable("D");
            var ten = new IntegerConstant(10);
            var condition1 = new ComparativeOperator<int>(ComparativeOperatorType.GreaterThan, d, ten);

            var a = new IntegerVariable("A");
            var seventeen = new IntegerConstant(17);
            var condition2 = new ComparativeOperator<int>(ComparativeOperatorType.LessThanOrEqual, a, seventeen);

            var innerCondition = new BinaryLogical(BinaryLogicalType.And, condition1, condition2);
            var unaryCondition = new Not(innerCondition);

            var c = new StringVariable("C");
            var qwer = new StringConstant("QWER");
            var condition3 = new ComparativeOperator<string>(ComparativeOperatorType.GreaterThanOrEqual, c, qwer);

            var outerCondition = new BinaryLogical(BinaryLogicalType.Or, unaryCondition, condition3);

            Console.WriteLine(outerCondition.ToSql());
        }

        private static void IsNullFunctionTest2()
        {
            var color = new StringVariable("Color");
            var expression = new IsNull<string>(color);
            Console.WriteLine(expression.ToSql());
        }

        private static void ComparativeOperatorTest3()
        {
            var d = new IntegerVariable("D");
            var ten = new IntegerConstant(10);
            var left = new ComparativeOperator<int>(ComparativeOperatorType.GreaterThan, d, ten);

            var a = new IntegerVariable("A");
            var seventeen = new IntegerConstant(17);
            var right = new ComparativeOperator<int>(ComparativeOperatorType.LessThanOrEqual, a, seventeen);

            var condition = new BinaryLogical(BinaryLogicalType.And, left, right);
            Console.WriteLine(condition.ToSql());
        }

        private static void LikeOperatorTest()
        {
            var c = new StringVariable("C");
            var like = new StringConstant("10");
            var condition = new ComparativeOperator<string>(ComparativeOperatorType.Like, c, like);
            Console.WriteLine(condition.ToSql());
        }

        private static void ComparativeOperatorTest2()
        {
            var b = new StringVariable("B");
            var abc = new StringConstant("ABC");
            var condition = new ComparativeOperator<string>(ComparativeOperatorType.GreaterThanOrEqual, b, abc);
            ComparativeOperator<int> x = new IntegerVariable("A").IsEqualTo(new IntegerConstant(10));
            Console.WriteLine(x.ToSql());
            Console.WriteLine(condition.ToSql());
        }

        private static void DateTimeConstantTest()
        {
            var date = new DatetimeVariable("Date");
            var now = new DatetimeConstant(DateTime.Now);
            var condition = new ComparativeOperator<DateTime>(ComparativeOperatorType.Equal, date, now);
            Console.WriteLine(condition.ToSql());
        }

        private static void ComparativeOperatorTest()
        {
            var a = new IntegerVariable("A");
            var ten = new IntegerConstant(10);
            var condition = new ComparativeOperator<int>(ComparativeOperatorType.Equal, a, ten);
            Console.WriteLine(condition.ToSql());
        }

        #endregion
    }
}
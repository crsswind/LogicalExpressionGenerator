using System;

namespace LogicalExpressionGenerator
{
    public class ComplexExpression<T> : Expression<T>
    {
        #region Fields

        private readonly Expression<T> _left;

        private readonly Expression<T> _right;

        private readonly ComplexExpressionType _type;

        #endregion

        #region Constructors

        public ComplexExpression(ComplexExpressionType type, Expression<T> left, Expression<T> right)
        {
            _type = type;
            _left = left;
            _right = right;
        }

        #endregion

        #region  Public Methods

        public override string ToSql()
        {
            string mathOperator = "";

            switch (_type)
            {
                case ComplexExpressionType.Add:
                    mathOperator = "+";
                    break;
                case ComplexExpressionType.Subtract:
                    mathOperator = "-";

                    break;
                case ComplexExpressionType.Multiply:
                    mathOperator = "*";

                    break;
                case ComplexExpressionType.Divide:
                    mathOperator = "/";
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            return $"({_left.ToSql()} {mathOperator} {_right.ToSql()})";
        }

        #endregion
    }
}
using System;

namespace LogicalExpressionGenerator
{
    public class ComparativeOperator<T> : Condition
    {
        #region Fields

        private readonly Expression<T> _left;
        private readonly Expression<T> _right;
        private readonly ComparativeOperatorType _type;

        #endregion

        #region Constructors

        public ComparativeOperator(ComparativeOperatorType type, Expression<T> left, Expression<T> right)
        {
            _type = type;
            _left = left;
            _right = right;
        }

        #endregion

        #region  Public Methods

        public override string ToSql()
        {
            string operatorSign;

            switch (_type)
            {
                case ComparativeOperatorType.Equal:
                    operatorSign = "=";
                    break;
                case ComparativeOperatorType.GreaterThan:
                    operatorSign = ">";
                    break;
                case ComparativeOperatorType.GreaterThanOrEqual:
                    operatorSign = ">=";
                    break;
                case ComparativeOperatorType.LessThan:
                    operatorSign = "<";
                    break;
                case ComparativeOperatorType.LessThanOrEqual:
                    operatorSign = "<=";
                    break;
                case ComparativeOperatorType.IsNotEqual:
                    operatorSign = "<>";
                    break;
                case ComparativeOperatorType.Like:
                    if (_right.Type != typeof(string))
                        throw new ArgumentException("Not supported data type");

                    operatorSign = "Like";
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            if (typeof(T).Name != "String")
                return $"{_left.ToSql()} {operatorSign} {_right.ToSql()}";

            if (operatorSign == "Like")
                return $"{_left.ToSql()} {operatorSign} '{"%" + _right.ToSql()}'";

            return $"{_left.ToSql()} {operatorSign} '{_right.ToSql()}'";
        }

        #endregion
    }
}
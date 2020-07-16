using System;

namespace LogicalExpressionGenerator
{
    public class IsNullFunction<T> : Expression<T>
    {
        #region Fields

        private readonly Expression<T> _expression;

        private readonly Constant<T> _newValue;

        #endregion

        #region Constructors

        public IsNullFunction(Variable<T> expression, Constant<T> replacementValue)
        {
            _expression = expression ?? throw new ArgumentNullException(nameof(expression));
            _newValue = replacementValue;
        }

        #endregion

        #region  Public Methods

        public override string ToSql()
        {
            return $"ISNULL ({_expression.ToSql()}, {_newValue.ToSql()})";
        }

        #endregion
    }
}
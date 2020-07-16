using System;

namespace LogicalExpressionGenerator
{
    public class IsNull<T> : Expression<T>
    {
        #region Fields

        private readonly Variable<T> _variable;

        #endregion

        #region Constructors

        public IsNull(Variable<T> variable)
        {
            _variable = variable;
        }

        #endregion

        #region  Public Methods

        public override string ToSql()
        {
            return $"{_variable.ToSql()} IS NULL";
        }

        #endregion
    }
}
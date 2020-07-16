using System;

namespace LogicalExpressionGenerator
{
    public abstract class Expression<T>
    {
        #region Properties

        public Type Type => typeof(T);

        #endregion

        #region  Public Methods

        public abstract string ToSql();

        #endregion
    }
}
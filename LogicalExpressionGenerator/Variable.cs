namespace LogicalExpressionGenerator
{
    public abstract class Variable<T> : Expression<T>
    {
        #region Properties

        public abstract string Name { get; set; }

        #endregion

        #region  Public Methods

        public abstract override string ToSql();

        #endregion
    }
}
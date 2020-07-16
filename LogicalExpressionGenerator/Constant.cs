namespace LogicalExpressionGenerator
{
    public abstract class Constant<T> : Expression<T>
    {
        #region Properties

        public abstract T Value { get; set; }

        #endregion

        #region  Public Methods

        public abstract override string ToSql();

        #endregion
    }
}
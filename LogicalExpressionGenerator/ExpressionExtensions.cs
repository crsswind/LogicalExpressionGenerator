namespace LogicalExpressionGenerator
{
    public static class ExpressionExtensions
    {
        #region  Public Methods

        public static ComparativeOperator<T> IsEqualTo<T>(this Expression<T> left, Expression<T> right)
        {
            return new ComparativeOperator<T>(ComparativeOperatorType.Equal, left, right);
        }

        #endregion
    }
}
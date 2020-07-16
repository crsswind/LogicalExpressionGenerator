namespace LogicalExpressionGenerator
{
    public class Not : Condition
    {
        #region Fields

        private readonly Condition _condition;

        #endregion

        #region Constructors

        public Not(Condition condition)
        {
            _condition = condition;
        }

        #endregion

        #region  Public Methods

        public override string ToSql()
        {
            return $"Not {_condition.ToSql()}";
        }

        #endregion
    }
}
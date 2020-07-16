namespace LogicalExpressionGenerator
{
    public class IntegerConstant : Constant<int>
    {
        #region Constructors

        public IntegerConstant(int value)
        {
            Value = value;
        }

        #endregion

        #region Properties

        public sealed override int Value { get; set; }

        #endregion

        #region  Public Methods

        public override string ToSql()
        {
            return Value.ToString();
        }

        #endregion
    }
}
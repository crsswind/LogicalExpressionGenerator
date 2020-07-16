namespace LogicalExpressionGenerator
{
    public class StringConstant : Constant<string>
    {
        #region Constructors

        public StringConstant(string value)
        {
            Value = value;
        }

        #endregion

        #region Properties

        public sealed override string Value { get; set; }

        #endregion

        #region  Public Methods

        public override string ToSql()
        {
            return Value;
        }

        #endregion
    }
}
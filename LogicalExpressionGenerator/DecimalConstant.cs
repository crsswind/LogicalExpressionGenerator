using System.Globalization;

namespace LogicalExpressionGenerator
{
    public class DecimalConstant : Constant<decimal>
    {
        #region Constructors

        public DecimalConstant(decimal value)
        {
            Value = value;
        }

        #endregion

        #region Properties

        public sealed override decimal Value { get; set; }

        #endregion

        #region  Public Methods

        public override string ToSql()
        {
            return Value.ToString(CultureInfo.InvariantCulture);
        }

        #endregion
    }
}
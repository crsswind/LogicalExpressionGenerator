using System;
using System.Globalization;

namespace LogicalExpressionGenerator
{
    public class DatetimeConstant : Constant<DateTime>
    {
        #region Constructors

        public DatetimeConstant(DateTime value)
        {
            Value = value;
        }

        #endregion

        #region Properties

        public sealed override DateTime Value { get; set; }

        #endregion

        #region  Public Methods

        public override string ToSql()
        {
            return $"'{Value.ToString(CultureInfo.InvariantCulture)}'";
        }

        #endregion
    }
}
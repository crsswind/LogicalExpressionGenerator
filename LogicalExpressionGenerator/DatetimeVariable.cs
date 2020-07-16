using System;

namespace LogicalExpressionGenerator
{
    public class DatetimeVariable : Variable<DateTime>
    {
        #region Constructors

        public DatetimeVariable(string name)
        {
            Name = name;
        }

        #endregion

        #region Properties

        public sealed override string Name { get; set; }

        #endregion

        #region  Public Methods

        public override string ToSql()
        {
            return Name;
        }

        #endregion
    }
}
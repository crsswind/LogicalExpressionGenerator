namespace LogicalExpressionGenerator
{
    public class DecimalVariable : Variable<decimal>
    {
        #region Constructors

        public DecimalVariable(string name)
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
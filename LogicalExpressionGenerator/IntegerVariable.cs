namespace LogicalExpressionGenerator
{
    public class IntegerVariable : Variable<int>
    {
        #region Constructors

        public IntegerVariable(string name)
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
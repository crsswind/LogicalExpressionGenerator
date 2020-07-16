namespace LogicalExpressionGenerator
{
    public class StringVariable : Variable<string>
    {
        #region Constructors

        public StringVariable(string name)
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
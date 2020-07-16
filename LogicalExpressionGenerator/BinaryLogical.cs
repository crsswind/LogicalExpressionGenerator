using System;

namespace LogicalExpressionGenerator
{
    public class BinaryLogical : Condition
    {
        #region Fields

        private readonly Condition _left;
        private readonly Condition _right;
        private readonly BinaryLogicalType _type;

        #endregion

        #region Constructors

        public BinaryLogical(BinaryLogicalType type, Condition left, Condition right)
        {
            _type = type;
            _left = left;
            _right = right;
        }

        #endregion

        #region  Public Methods

        public override string ToSql()
        {
            if (_type == BinaryLogicalType.And)
                return $"({_left.ToSql()}) And ({_right.ToSql()})";

            if (_type == BinaryLogicalType.Or)
                return $"({_left.ToSql()}) Or ({_right.ToSql()})";

            throw new NotSupportedException("Logical type is not supported");
        }

        #endregion
    }
}
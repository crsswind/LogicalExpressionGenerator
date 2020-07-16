using System;
using System.Text;

namespace LogicalExpressionGenerator
{
    public class InOperator<T> : Expression<T>
    {
        #region Fields

        private readonly Expression<T>[] _domain;

        private readonly Expression<T> _expression;

        #endregion

        #region Constructors

        public InOperator(Expression<T> element, Expression<T>[] domain)
        {
            _expression = element;
            _domain = domain;
        }

        #endregion

        #region  Public Methods

        public override string ToSql()
        {
            var stb = new StringBuilder();

            foreach (Expression<T> expression in _domain)
                stb.AppendFormat(",{0}", expression.ToSql());

            stb.Remove(0, 1);

            return $"{_expression.ToSql()} In ({stb})";
        }

        #endregion
    }
}
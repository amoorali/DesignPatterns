using DataVisualiser.Contracts;
using System.Text;

namespace DataVisualiser.Implementations
{
    public class QueryBuilder : IKeyValueCollectionBuilder
    {
        private StringBuilder _queryStringBuilder = new StringBuilder();

        public IKeyValueCollectionBuilder Add(string key, object value)
        {
            _queryStringBuilder.Append(_queryStringBuilder.Length == 0 ? "?" : "&");
            _queryStringBuilder.Append(key);
            _queryStringBuilder.Append("=");
            _queryStringBuilder.Append(Uri.EscapeDataString((string)value));

            return this;
        }

        public string Build()
        {
            return _queryStringBuilder.ToString(); 
        }
    }
}

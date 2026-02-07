using DataVisualiser.Contracts;
using System.Text;

namespace DataVisualiser.Implementations
{
    public class FormBodyBuilder : IKeyValueCollectionBuilder
    {
        private StringBuilder _queryStringBuilder = new StringBuilder();

        public IKeyValueCollectionBuilder Add(string key, object value)
        {
            _queryStringBuilder.Append(key);
            _queryStringBuilder.Append("-");
            _queryStringBuilder.Append((string)value);
            _queryStringBuilder.AppendLine();

            return this;
        }

        public string Build()
        {
            return _queryStringBuilder.ToString();
        }
    }
}

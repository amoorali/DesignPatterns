using DataVisualiser.Contracts;

namespace DataVisualiser.Implementations
{
    public class DictionaryBuilder : IKeyValueCollectionBuilder
    {
        private readonly Dictionary<string, object> _dictionary
            = new Dictionary<string, object>();

        public IKeyValueCollectionBuilder Add(string key, object value)
        {
            _dictionary[key] = value;

            return this;
        }

        public Dictionary<string, object> Build()
        {
            return _dictionary;
        }
    }
}

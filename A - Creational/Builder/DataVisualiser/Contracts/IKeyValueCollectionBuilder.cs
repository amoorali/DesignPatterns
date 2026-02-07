namespace DataVisualiser.Contracts
{
    public interface IKeyValueCollectionBuilder
    {
        IKeyValueCollectionBuilder Add(string key, object value);
    }
}

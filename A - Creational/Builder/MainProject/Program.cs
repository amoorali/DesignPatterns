using DataVisualiser.Contracts;
using DataVisualiser.Implementations;

namespace MainProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            QueryBuilder builder = new QueryBuilder();
            //FormBodyBuilder builder = new FormBodyBuilder();
            //HttpHeaderBuilder builder = new HttpHeaderBuilder();
            //DictionaryBuilder builder = new DictionaryBuilder();
            ConstructionProcess(builder);

            var result = builder.Build();

            Console.WriteLine(result);
        }

        public static void ConstructionProcess(IKeyValueCollectionBuilder builder)
        {
            builder
                .Add("make", "lada")
                .Add("color", "red")
                .Add("year", 1990.ToString());
        }
    }
}

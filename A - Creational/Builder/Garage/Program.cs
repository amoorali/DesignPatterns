public class Program
{
    public static void Main()
    {
        var builder = new CarBuilder();
        var result = BuildRedLada1980(builder);

        Console.WriteLine(result);
    }

    public static Car BuildRedLada1980(ICarBuilder carBuilder)
    {
        carBuilder
            .setMake("lada")
            .setColor("red")
            .setManufactureDate(new DateTime(1980, 1, 1));

        return carBuilder.Result();
    }

}
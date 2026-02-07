public class CarBuilder : ICarBuilder
{
    private Car _car = new();

    public ICarBuilder setMake(string make)
    {
        _car.Make = make;

        return this;
    }

    public ICarBuilder setColor(string color)
    {
        List<string> colors = ["white", "black", "red", "blue", "green"];

        if (!colors.Contains(color))
            throw new Exception("Invalid colour");

        _car.Color = color;

        return this;
    }

    public ICarBuilder setManufactureDate(DateTime manufactureDate)
    {
        _car.ManufactureDate = manufactureDate.ToString("dd-MM-yyyy");

        return this;
    }

    public Car Result() => _car;
}
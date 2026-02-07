public class Car
{
    public string Make { get; set; }
    public string Color { get; set; }
    public string ManufactureDate { get; set; }

    public override string ToString()
        => $"{Make} | {Color} | {ManufactureDate:yyyy}";
}
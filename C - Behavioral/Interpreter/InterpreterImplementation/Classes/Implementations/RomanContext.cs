namespace InterpreterImplementation.Classes.Implementations
{
    public class RomanContext
    {
        public int Input { get; set; }
        public string Output { get; set; } = string.Empty;

        public RomanContext(int intput)
        {
            Input = intput;
        }
    }
}

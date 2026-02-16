using InterpreterImplementation.Classes.Contracts;

namespace InterpreterImplementation.Classes.Implementations
{
    public class RomanHundredExpression : IRomanExpression
    {
        // 900 = CM
        // 800 = DCCC
        // 700 = DCC
        // 600 = DC
        // 500 = D
        // 400 = CD
        // 300 = CCC
        // 200 = CC
        // 100 = C

        // simplified - each combination is reachable with subtraction:
        // 900 = CM
        // 500 = D
        // 400 = CD
        // 100 = C

        public void Interpret(RomanContext value)
        {
            while ((value.Input - 900) >= 0)
            {
                value.Output += "CM";
                value.Input -= 900;
            }

            while ((value.Input - 500) >= 0)
            {
                value.Output += "D";
                value.Input -= 500;
            }

            while ((value.Input - 400) >= 0)
            {
                value.Output += "CD";
                value.Input -= 400;
            }

            while ((value.Input - 100) >= 0)
            {
                value.Output += "C";
                value.Input -= 100;
            }
        }
    }
}

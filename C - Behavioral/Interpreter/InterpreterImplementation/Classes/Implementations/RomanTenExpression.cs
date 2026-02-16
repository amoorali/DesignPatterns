using InterpreterImplementation.Classes.Contracts;

namespace InterpreterImplementation.Classes.Implementations
{
    public class RomanTenExpression : IRomanExpression
    {
        // 90 = XC
        // 80 = LIII
        // 70 = LII
        // 60 = LX
        // 50 = L
        // 40 = XL
        // 30 = XXX
        // 20 = XX
        // 10 = X

        // simplified - each combination is reachable with subtraction:
        // 90 = XC
        // 50 = L
        // 40 = XL
        // 10 = X

        public void Interpret(RomanContext value)
        {
            while ((value.Input - 90) >= 0)
            {
                value.Output += "XC";
                value.Input -= 90;
            }

            while ((value.Input - 50) >= 0)
            {
                value.Output += "L";
                value.Input -= 50;
            }

            while ((value.Input - 40) >= 0)
            {
                value.Output += "XL";
                value.Input -= 40;
            }

            while ((value.Input - 10) >= 0)
            {
                value.Output += "X";
                value.Input -= 10;
            }
        }
    }
}

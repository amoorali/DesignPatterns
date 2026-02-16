using InterpreterImplementation.Classes.Contracts;

namespace InterpreterImplementation.Classes.Implementations
{
    public class RomanOneExpression : IRomanExpression
    {
        // 9 = IX
        // 8 = VIII
        // 7 = VII
        // 6 = VI
        // 5 = V
        // 4 = IV
        // 3 = III
        // 2 = II
        // 1 = I

        // simplified - each combination is reachable with subtraction:
        // 9 = IX
        // 5 = V
        // 4 = IV
        // 1 = I

        public void Interpret(RomanContext value)
        {
            while((value.Input - 9) >= 0)
            {
                value.Output += "IX";
                value.Input -= 9;
            }

            while ((value.Input - 5) >= 0)
            {
                value.Output += "V";
                value.Input -= 5;
            }

            while ((value.Input - 4) >= 0)
            {
                value.Output += "IV";
                value.Input -= 4;
            }

            while ((value.Input - 1) >= 0)
            {
                value.Output += "I";
                value.Input -= 1;
            }
        }
    }
}

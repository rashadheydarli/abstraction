using System;
namespace test
{
	public sealed class Multiplication: Calculation
	{
        public override int Operate(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}


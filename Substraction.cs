using System;
namespace test
{
	public sealed class Substraction : Calculation
	{
        public override int Operate(int number1, int number2)
        {
            return number1 - number2;
        }

    }
}


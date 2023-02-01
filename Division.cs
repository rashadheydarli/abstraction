using System;
using System.Collections.Generic;

namespace test
{
	public sealed class Division: Calculation
	{
        public override int Operate(int number1, int number2)
        {
            return number1 / number2;
            
        }
    }
}


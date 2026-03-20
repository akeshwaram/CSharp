using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace InputOutput.Exercises;

internal class BitOperations
{
	public static int CountSetBits(int number)
	{ 
		if(number ==0) return 0;

		if (number < 0) number *= -1;

		var count = 0;
		
		while (number > 0) {
			
			if ((number & 1) == 1)
			{
				count++; 
			}

			number = number >> 1;

		}

		return 0;
	}
}

using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace InputOutput.C_6
{
	internal class ExpressionBodiedMembers
	{
		public double Length { get; set; }

		//can use it with a read-only property. no setter.
		public double Area => Pow(Length, 2);

		//can also use it with a method to perform an action and/or return a value
		public double CalculatePerimeter() => Length * 4;

		// can also use it with a prop that has both setter and getter
		public double Diagonal {
			get => Sqrt(2) * Length;
			set => Length = (value / Sqrt(2));
		}
	}
}

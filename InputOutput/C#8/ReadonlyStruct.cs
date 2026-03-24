using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_8;

//class cannot be readonly, only struct can be readonly; class props can be readonly, etc.
internal readonly struct Person
{
	//auto-property inside a readonly struct must be readonly - no setter allowed
	public string Name { get; }

	public void Demo()
	{
		//Name is readonly
		//this.Name = "";
	}

}

//if you can't make the struct readonly, you can make the method readonly, which means it cannot modify the state of the struct
internal struct Customer
{
	string Name { get; set; }

	public readonly void Demo()
	{
		//readonly method cannot modify the state of the struct
		//this.Name = "";
	}
		public void Demo2()
	{
		this.Name = "";
	}
}
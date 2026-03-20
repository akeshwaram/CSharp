using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace InputOutput.C_3;

internal class ObjectAndCollectionInitializers
{
	public void Demo() {
		//are the parentheses optional when using object initializers? 
		var cat = new Cat { Name = "Cat1", Age = 5};
		var cat2 = new Cat("Cat2") { Age = 5 };

		//object initializers can be used with anonymous types as well
		var pet = new { Age = 6, Name = "Cat3" };

		//{} - traditional collection initializer syntax - works everywhere
		//you want a specific type - List<int> in this case
		//required if you need a constructor with parameters
		var digits = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

		//[] - collection expression - introduced in C#12
		//does not allow contructors
		//compiler decides what to create
		List<int> list = [1, 2, 3]; // List<int>
		int[] array = [1, 2, 3];        // int[]
		IEnumerable<int> e = [1, 2, 3]; // IEnumerable<int>

		//var list = [1, 2, 3]; // ❌ ERROR (no target type)
	}

}

public class Cat { 
	public int Age { get; set; }
	public string? Name { get; set; }

	
	public Cat() {}
	public Cat(string name) {
		Name = name;
	}
}

using InputOutput.DataTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_3;

internal class AnonymousTypes
{
	public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
	public void Demo() {

		//used to create a type without explcitly declaring a class
		var vehicle = new
		{
			Make = "Anonymous",
			Year = 2024
		};

		// The following lines will cause compile-time errors because anonymous types are immutable and their properties cannot be modified after initialization.
		//vehicle.Make = "";

		var vehicle1 = new Vehicle() { Year = 2020, Make = "Toyota", Mileage = 15000 };
		var vehicle2 = new Vehicle() { Year = 2021, Make = "Suzuki", Mileage = 16000 };
		var vehicle3 = new Vehicle() { Year = 2022, Make = "Honda", Mileage = 17000 };
		var vehicle4 = new Vehicle() { Year = 2023, Make = "Mazda", Mileage = 18000 };
		Vehicles.Add(vehicle1);
		Vehicles.Add(vehicle2);
		Vehicles.Add(vehicle3);
		Vehicles.Add(vehicle4);

		//most common use of anonymous types is in LINQ queries to create a new type with only the properties you need
		var anonymouseVehicles = Vehicles.Select(v => new { v.Year, v.Make, v.Mileage });

		//Select - each elements produces exactly one result
		var vehicleNames = Vehicles.Select(v => v.Make);

		//SelectMany gets multiple values for each element and flattens them into a single sequence
		var names = Vehicles.SelectMany(v => v.Make);
		var names2 = Vehicles.SelectMany(v => v.Make.ToCharArray());

		//students:
		//[
		//	["Math", "Physics"],
		//	["History"]
		//]

		//using Select
		//[ ["Math","Physics"], ["History"] ]

		//using SelectMany
		//["Math","Physics","History"]
	}
}

public class Vehicle { 
	public int Year { get; set; }
	public required string Make { get; set; }
	public double Mileage { get; set; }

}

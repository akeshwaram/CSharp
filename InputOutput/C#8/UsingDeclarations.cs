using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_8;

internal class UsingDeclarations
{
	public void LegacyExample()
	{
		var filePath = "";
		using (var reader = File.OpenText(filePath))
		{

		} //fileStream is disposed off at the end of the using block
	}

	public void DeclarationExample()
	{
		var filePath = "";
		using StreamReader reader = File.OpenText(filePath);

		string line;

		while ((line = reader.ReadLine()) is not null)
		{

		}

		return;
	} //disposal happens at the end of the method
}
using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_10;

internal class Leetcode
{


	public static string LongestSubstring(string input)
	{
		if (string.IsNullOrEmpty(input))
		{
			return string.Empty;
		}

		if (input.Length == 1)
		{
			return input;
		}

		int start = 0, end = 0;
		string longestSubstring = "";
		HashSet<char> set = new HashSet<char>();
		var length = input.Length;

		//start = 10 , end = 12
		//"geeksforgeeksabcdef"
		//
		//set - eks

		// Input: s = "abcpqabcdepqra"
		// Output: "abcdepqr" (length 8)

		for (int i = 0; i < length - 1; i++)
		{
			var c = input[i];

			if (!set.Contains(c))
			{
				set.Add(c);
				end = i;
				Console.WriteLine($"{c} added to set");
				continue;
			}

			//13-5
			//5, 8
			if ((i - start) > longestSubstring.Length || i == length - 1)
			{
				longestSubstring = input.Substring(start, i - start); //ge
				start = i;
				
				Console.WriteLine($"{c} added to set");
				set.Add(c);
			}

			set.Clear();
		}

		return longestSubstring;
	}

}

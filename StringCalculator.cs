/*
create a simple class class StringCalculator with a method public int Add(string numbers)

The method can take 0, 1 or 2 numbers, and will return their sum (for an empty string it will return 0) for example “” == 0 , “1” == 1 , “1,2” == 3

Allow the Add method to handle an unknown amount of numbers

Allow the Add method to handle new lines between numbers (instead of commas).

The following input is ok: “1\n2,3” == 6

The following is INVALID input so do not expect it : “1,\n”
*/

using System;
					
public class StringCalculator
{
	public static void Main()
	{
		string input = "1,2,3,\n";
		int output = Add(input);
		Console.WriteLine(output);
	}
	
	public static int Add(string inputString)
	{
		char[] charArr = inputString.ToCharArray();  
		int sum = 0;
		foreach (char ch in charArr)  
		{  
    		if (ch != ',' && ch != '\n')
				sum = sum + (int)Char.GetNumericValue(ch);;
		}
		return sum;
	}
}

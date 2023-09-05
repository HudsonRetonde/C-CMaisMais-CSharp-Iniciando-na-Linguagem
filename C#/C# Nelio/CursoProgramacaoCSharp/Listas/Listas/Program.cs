using System;

namespace Listas 
{
	internal class Program
	{

		static void Main(string[] args)
		{
			Boolean valid = true;
			string inputValueType;

			Console.WriteLine("Enter a value: ");
			string inputValue = Console.ReadLine();

			Console.WriteLine("Select the Data type validate the input you have entered");
			Console.WriteLine("Press 1 for String");
			Console.WriteLine("Press 2 for Integer");
			Console.WriteLine("Press 3 for Boolean");

			Console.WriteLine("Enter :");
			int inpytType = Convert.ToInt32(Console.ReadLine());


			switch (inpytType) 
			{ 
				case 1:
					valid = IsAllAlphabetic(inputValue);
					inputValueType = "String";
					break;

				case 2:
					int retValue = 0;
					valid = int.TryParse(inputValue, out retValue);
					inputValueType = "Integer";
					break;

				case 3:
					bool retFlag = false;
					valid = bool.TryParse(inputValue, out retFlag);
					inputValueType= "Boolean";
					break;

				default:
					inputValueType= "unknown";
					Console.WriteLine("Not able to detect the input type, something is wrong");
					break;
			}

		}
		static bool IsAllAlphabetic(string value)
		{
			foreach (var c in value)
			{
				if (!char.IsLetter(c))
				{
					return false;
				}
			}
			return true;
		}
	}
}
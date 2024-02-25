
namespace Class_Inheritance_HW
{
	public class CustomMath
	{
		public int SumOfOddNumbers(int[]arr)
		{
			int sum = 0;
			foreach (var number in arr)
			{
				if (number % 2 != 0)
				{
					sum+=number;
				}
			}
			return sum;
		}

		public string EvenOrOdd(int number)
		{
			if (number % 2 == 0)
			{
				return "Cutdur";
			}
			return "Tekdir";
		}

		public int SquareOfEven(int[]arr)
		{
			int result = 1;
			int sum = 0;
			foreach (var item in arr)
			{
				if (item % 2 == 0)
				{
					sum += item;
				}
			}
			return sum * sum;
		}

		public int MultiplicationOfNumbers(int n)
		{
			int result = 1;
			for (int i = 1; i<n; i++)
			{
				result *= i;
			}
			return result;
		}
	}
}


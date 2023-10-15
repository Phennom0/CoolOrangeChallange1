using System;

namespace coolOrange_CandidateChallenge
{
	public class Array
	{
		//ToDo

		public static int FindMaxValue(int[] array, int position1, int position2)
		{
			int maxValue = int.MinValue;
			for (int i = position1; i <= position2; i++)
			{
				if (array[i] > maxValue) maxValue = array[i];
			}
			return maxValue;
		}

		public static int FindMinPosition(int[] array, int position1, int position2)
		{
            int minPosition = position1;

            for (int i = position1; i <= position2; i++)
            {
				if (array[i] < array[minPosition]) minPosition = i;
            }
			return minPosition;
        }

		public static void Swap(int[] array, int position1, int position2)
		{
			int save = array[position1];
			array[position1] = array[position2];
			array[position2] = save;
		}

		public static void ShiftLeftByOne(int[] array, int position1, int position2)
		{
			int save = array[position1];
			for (int i = position1; i < position2 - 1; ++i)
			{
				array[i] = array[i + 1];
			}
			array[position2 - 1] = save;
		}

		public static int[] CreateRandomArray(int size, int minValue, int maxValue)
		{
			int[] random = new int[size];
			Random rand = new Random();

            for (int i = 0; i < size; i++)
			{
				random[i] = rand.Next(minValue, maxValue);
			}
			return random;
		}

		public static int[,] CreateRandomMatrix(int rows, int columns, int minValue, int maxValue)
		{
            int[,] random = new int[rows,columns];
            Random rand = new Random();

			for (int x = 0; x < rows; x++)
			{
				for (int y = 0; y < columns; y++)
				{
					random[x, y] = rand.Next(minValue, maxValue);
				}
			}
            return random;
        }

		public static int[,] CopyArray(int[] array)
		{
			int[,] copy = new int[2, array.Length];

			for(int i = 0; i < array.Length; i++)
			{
				copy[0, i] = array[i];
				copy[1, i] = array[i];
			}
            return copy;
        }

		public static int FindInSortedArray(int[] array, int number)
		{
			int anfang = 0;
			int ende = array.Length - 1;

			while (anfang <= ende)
			{
				int mitte = (anfang + ende) / 2;
				if (array[mitte] == number)
				{
					return mitte;
				}
				if (number > array[mitte])
				{
					anfang = mitte + 1;
				}
				else
				{
					ende = mitte - 1;
				}
			}
			return -1;
		}

	}
}

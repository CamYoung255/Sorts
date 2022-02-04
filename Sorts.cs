using System;

namespace Sorts

{

	class Program


	{
		//function for the bubble sort algorithm

		public static void BubbleSort(int[] array)
        {
			bool sorted = false;

			/* loops until the list is sorted, this is done by counting how many times a number is succeeded by a larger
			number, if this is the same as the length of the list then the list must have been sorted*/

			while (sorted == false)
			{
				int sorted_count = 0;

				// loops through the whole array

				for (int i = 0; i < array.Length - 1; i++)
				{
					/* if the number after the current number is less than current number than they are swapped, if not one is
					added to the sorted counter */

					if (array[i] > array[i + 1])
					{
						int temp = array[i];
						array[i] = (int)array[i + 1];
						array[i + 1] = temp;
					}
					else
					{
						sorted_count += 1;					
					}

					/* if the sorted count is equal to the length then the list must be sorted and then the loop will end,
					if not then the loop will continue */

					if (sorted_count == array.Length - 1)
                    {
						sorted = true;
					}
				}
			}
		}

		// function for the insertion sort algorithm

		public static void InsertionSort(int[] array)
        {

			// this loops though the whole array from one to the end

			for (int i = 0; i <= array.Length - 1; i++)
            {
				int key = array[i];
				int position = i - 1;

				/* loops while the position is greater than 0 and while the original value (key) is greater than the value
				before it (position) */

				while (position >= 0 && key < array[position])
                {
					// while this loop is happening the value is moved up the list

					array[position + 1] = array[position];
					position -= 1;
                }

				// once this is done it sets the key to the next value
				array[position + 1] = key;
            }
        }

		// procedure for performing a binary search
		public static string BinarySearch(int[] array, int item)
        {
			int begin_index = 0;
			int end_index = array.Length - 1;

			// loops between the start and end of the section

			while (begin_index <= end_index)
            {
				// assigns midpoint, % 2 ensures there is no remainder
				int midpoint = begin_index + (end_index - begin_index) % 2;
				int midpoint_value = array[midpoint];

				/* returns where the number that was specified is in the array, if ti si not found then the end index or begin
				index will be changed accordingly.
				if the number is lower than the midpoint then the start index is changed
				and the the opposite is true the start index is changed */

				if (midpoint_value == item)
                {
					return Convert.ToString(midpoint);
                }
				else if (midpoint_value > item)
                {
					end_index = midpoint - 1;
                } 
				else
                {
					begin_index = midpoint + 1;
                }            
			}

			return "not in array";
		}

		static void Main(string[] args)
		{
			int[] ArrayBubble = { 1, 5, 17, 8, 4, 9, 8, 11};
			BubbleSort(ArrayBubble);

			int[] ArrayInsert = { 1, 5, 17, 8, 4, 9, 8, 11 };
			InsertionSort(ArrayInsert);
			
		
			for (int i = 0; i < ArrayInsert.Length; i++)
            {
				Console.WriteLine(ArrayInsert[i]);
            }


			string result = BinarySearch(ArrayInsert, 9);
			Console.WriteLine("The value 9 is found at position {0}", result);
			result = BinarySearch(ArrayInsert, 5);
			Console.WriteLine("The value 5 is found at position {0}", result);
			result = BinarySearch(ArrayInsert, 3);
			Console.WriteLine("The value 3 is found at position {0}", result);

		}
	}
}
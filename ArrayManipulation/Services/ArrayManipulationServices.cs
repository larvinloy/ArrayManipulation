namespace ArrayManipulation.Services
{
	/// <summary>
	/// Service class with helper methods to manipulate arrays
	/// </summary>
	public class ArrayManipulationServices
	{
		/// <summary>
		/// Reverses entire array
		/// </summary>
		/// <param name="arr"></param>
		public static void Reverse(int[] arr)
		{
			ReverseSection(arr, 0, arr.Length - 1);
		}

		/// <summary>
		/// Reverses a section of an array
		/// </summary>
		/// <param name="arr"></param>
		/// <param name="start"></param>
		/// <param name="end"></param>
		public static void ReverseSection(int[] arr, int start, int end)
		{
			int temp;
			if (start >= end)
				return;

			temp = arr[start];
			arr[start] = arr[end];
			arr[end] = temp;

			ReverseSection(arr, start + 1, end - 1);
		}

		/// <summary>
		/// Deletes element at a particular index in an array
		/// </summary>
		/// <param name="arr"></param>
		/// <param name="position"></param>
		/// <returns></returns>
		public static bool DeleteElement(ref int[] arr, int position)
		{
			// Check if position is valid
			if (position < 1 || position > arr.Length)
			{
				return false;
			}

			int indexToDelete = position - 1;
			int[] newArr = new int[arr.Length - 1];

			// Copying array, removing element
			for (int i = 0, j = 0; j < newArr.Length; i++, j++)
			{
				if (i == indexToDelete)
				{
					j--;
					continue;
				}
				newArr[j] = arr[i];
			}

			arr = newArr;

			return true;
		}
	}
}
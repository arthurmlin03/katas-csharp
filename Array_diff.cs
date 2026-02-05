// Code Wars
// Array.diff
// Write a function that removes all elements from list a that are present in list b, while preserving the original order of list a.

public class KataCSharp
{
	public static int[] ArrayDiff(int[] a, int[] b)
	{
		List<int> numbers = new List<int>();

		for (int i = 0; i < a.Length; i++)
		{
			bool found = false;
			for (int j = 0; j < b.Length; j++)
			{
				if (a[i] == b[j])
				{
					found = true;
					break;
				}
			}

			if (!found)
				numbers.Add(a[i]);
		}
		return numbers.ToArray();
	}
}
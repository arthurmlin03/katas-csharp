// Code Wars
// Unique Sum
// Given a list of integers, return the sum of the unique values.
// If a number appears multiple times, count it only once.
public static class KataCSharp
{
	public static int? UniqueSum(List<int> lst)
	{

		if (lst == null || lst.Count == 0)
			return null;

		HashSet<int> uniqueValues = new HashSet<int>(lst);

		int sum = uniqueValues.Sum();

		return sum;
	}
}
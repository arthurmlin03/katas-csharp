// CodeWars
// Sum of Multiples
// Find the sum of all multiples of n below m.
// n and m should be natural numbers, and m is excluded.
public static class KataCSharp
{
	public static int SumMul(int n, int m)
	{
		if (n <= 0 || m <= n)
			throw new System.ArgumentException();

		int sum = 0;

		for (int i = n; i < m; i += n)
		{
			sum += i;
		}

		return sum;
	}
}
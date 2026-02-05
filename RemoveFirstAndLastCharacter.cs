// CodeWars
// Remove First and Last Character
// The function must handle strings longer than 2 characters.
// If the string has exactly 2 characters, return an empty string.
public class KataCSharp
{
	public static string Remove_char(string s)
	{
		if (s.Length <= 2)
		{
			return "";
		}

		return s.Substring(1, s.Length - 2);
	}
}
namespace IjsOpReis.Extentions;

public static class StringExtentions
{
    public static string NormalizeFlavorName(this string str)
    {
        return str.Trim()
            .ToLower()
            .ToUpperFirstLetter();
    }

    public static string ToUpperFirstLetter(this string source)
    {
        if (string.IsNullOrEmpty(source))
            return string.Empty;
        char[] letters = source.ToCharArray();
        letters[0] = char.ToUpper(letters[0]);
        return new string(letters);
    }
}

using System.Globalization;

namespace IJsOpReis;

public static class Extensions
{
    extension (DateTime dateTime)
    {
        public string ToNlString()
        {
            return dateTime.ToString(new CultureInfo("nl-NL"));
        }

        public static DateTime GetCurrentNlTime()
        {
            DateTime utcNow = DateTime.UtcNow;
            TimeZoneInfo netherlandsTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Europe/Amsterdam");
            DateTime netherlandsTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, netherlandsTimeZone);

            return netherlandsTime;
        }
    }


    extension(string value)
    {
        public string NormalizeFlavorName()
        {
            return value.Trim()
                .ToLower()
                .ToUpperFirstLetter();
        }

        public string ToUpperFirstLetter()
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            char[] letters = value.ToCharArray();
            letters[0] = char.ToUpper(letters[0]);
            return new string(letters);
        }
    }
}

namespace SubstringCount
{
    public static class StringHelper
    {
        public static int CountOccurences(string text, string lookupFragment)
        {
            if (string.IsNullOrEmpty(text))
            {
                return 0;
            }

            if (string.IsNullOrEmpty (lookupFragment))
            {
                throw new ArgumentNullException(nameof(lookupFragment), "The lookup fragment must be not-null and not empty");
            }

            int indexStart = 0;
            int counter = 0;
            while (indexStart < text.Length)
            {
                int foundAt = text.IndexOf(lookupFragment, indexStart, StringComparison.OrdinalIgnoreCase);
                if (foundAt >= 0)
                {
                    counter++;
                    indexStart = foundAt + 1;
                }
                else
                {
                    break;
                }
            }

            return counter;
        }
    }
}

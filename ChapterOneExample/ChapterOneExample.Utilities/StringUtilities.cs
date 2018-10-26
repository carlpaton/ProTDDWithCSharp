using System;

namespace ChapterOneExample.Utilities
{
    public class StringUtilities
    {
        public int CountOccurrences(string stringToCheck,
            string stringToFind)
        {
            var stringAsCharArray = stringToCheck.ToCharArray();
            var stringToCheckForAsChar =
                stringToFind.ToCharArray()[0];
            var occuranceCount = 0;
            for (var characterIndex = 0;
                characterIndex < stringAsCharArray.GetUpperBound(0);
                characterIndex++)
            {
                if (stringAsCharArray[characterIndex] ==
                    stringToCheckForAsChar)
                {
                    occuranceCount++;
                }
            }
            return occuranceCount;
        }
    }
}

namespace System
{
    static class StringExtensions
    {
        public static string Cut(this string thisObjs, int count)
        {
            if (thisObjs.Length <= count)
            {
                return thisObjs;
            }
            else
            {
                return thisObjs.Substring(0, count) + "...";
            }
        }
    }
}
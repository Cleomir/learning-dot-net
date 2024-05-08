namespace Casting
{
    internal static class Casting
    {
        public static int ConvertToInt(double y)
        {
            return Convert.ToInt32(y);
        }

        public static double ConvertToDouble(int x)
        {
            return Convert.ToDouble(x);
        }

        public static string ConvertToString(bool z)
        {
            return Convert.ToString(z);
        }
    }
}

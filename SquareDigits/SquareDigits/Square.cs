using System.Text;

namespace SquareDigits
{
    static class Square
    {
        public static int SquareDigits(int n)
        {

            StringBuilder sb = new StringBuilder();
            foreach (char c in n.ToString())
            {
                int digit = int.Parse(c.ToString());
                sb.Append(digit * digit);
            }

            return int.Parse(sb.ToString());
        }
    }
}

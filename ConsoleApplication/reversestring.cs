using System.Text;

namespace ConsoleApplication
{
    public class reversestring
    {
        public static StringBuilder stringReverse(string str)
        {

            //reverse should be olleh

            StringBuilder stringBuilder= new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(str[i]);

            }
            return stringBuilder;

        }

    }
}
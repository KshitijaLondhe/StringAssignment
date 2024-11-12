using System;
using System.Text;
//1.Reverse the string word by word

namespace StringAssignment
{
    public class ReverseByWord
    {
        static void Main(string[] args)
        {
            String str = "kshitija raj londhe";
            String[] str1 = str.Split(' ');
            String str3 = "";
            for (int i = str1.Length - 1; i >= 0; i--)
            {
                str3 = str3 + str1[i]+" ";
            }
            Console.WriteLine(str);
            Console.WriteLine(str3);
        }
    }
}

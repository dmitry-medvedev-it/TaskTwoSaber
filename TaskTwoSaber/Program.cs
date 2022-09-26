using System.Text;

namespace TaskTwo
{
    class Programm
    {
        static void Main()
        {
            var data = new StringBuilder("AAA BBB AAA");

            RemoveDups(data);

            Console.WriteLine(data); // "A B A"
        }
        static void RemoveDups(StringBuilder str)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(str[0]);
            for(int index = 1; index < str.Length; index++) 
            {
                if(str[index] != sb[sb.Length-1]) 
                {
                    sb.Append(str[index]);
                }
            }

            str.Replace(str.ToString(),sb.ToString());
        }
    }
}
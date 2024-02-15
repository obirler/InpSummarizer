using System.Text;

namespace InpSummarizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            using (var str = new StreamReader("ss4_640_ship_1200_sea_1200.inp"))
            {
                while(str.Peek() > 0)
                {
                    var line = str.ReadLine();
                    if (line.StartsWith("*") && !line.StartsWith("**"))
                    {
                        sb.AppendLine(line);
                    }
                }
            }

            using (var stw = new StreamWriter("summarized.inp"))
            {
                stw.Write(sb.ToString());
            }
            Console.Write("Finished!");
        }
    }
}

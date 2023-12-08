
using Algorithms.Searching.Arrays;

namespace Algorithms
{
    public class Program
    {
        public static Random Random = new Random(10000);

        public static void Main(string[] args)
        {
            Random = new Random(new Random().Next());

            Program program = new Program();
            program.Run();
        }

        public void Run()
        {
            SearchArrayRunner runner = new SearchArrayRunner();
            runner.Run();
        }
    }
}
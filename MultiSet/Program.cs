namespace MultiSet
{
    public class Program
    {
        static void Main(string[] args)
        {
            char[] znaki = new char[] { 'a', 'a', 'a', 'b', 'c', 'c', 'd', 'e', 'e', 'e', 'e', 'e', 'a', 'a' };
            var mz = new MultiSet<char>(znaki);
            Console.WriteLine(mz.ToString());
            foreach (var x in mz)
                Console.WriteLine(x);
        }
    }
}
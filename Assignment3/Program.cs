namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region Q1
            //double []pirce = { 25.5, 40.0, 33.75 };
            //Console.WriteLine($"he second price {pirce[1]}");
            #endregion

            #region Q2
            int[,] shelfCopies = new int[2,2] { { 3, 5 }, { 1, 4 } };
            Console.WriteLine($"number of copies on shelf 1, slot 0 : {shelfCopies[1,0]}");
            #endregion
        }
    }
}

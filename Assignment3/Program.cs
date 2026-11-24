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
            //int[,] shelfCopies = new int[2,2] { { 3, 5 }, { 1, 4 } };
            //Console.WriteLine($"number of copies on shelf 1, slot 0 : {shelfCopies[1,0]}");
            #endregion

            #region Q3
            // PrintWelcomeMessage();
            #endregion

            #region Q4
            //string title = "Clean Code";
            //PrintBookTitle(title);
            #endregion

            #region Q5
            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine($"page after add : {pages}");
            // نفس الرقم بسبب كدا عملت متغير جديد مش بيشوار علي نفس المكان
            // ممكن اعمل return استقبل المتغير الجديد
            #endregion
        }

        #region Q3
        //static void PrintWelcomeMessage()
        //{ 
        //    Console.WriteLine("Welcome to the Library!");
        //}
        #endregion

        #region Q4
        //static void PrintBookTitle(string title)
        //{
        //    Console.WriteLine("Book title: " + title);
        //}
        #endregion

        #region Q5
        static void AddBonusPages(int pages)
        {
            pages = pages + 50;
        }
        #endregion
    }
}

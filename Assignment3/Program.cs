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
            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine($"page after add : {pages}");
            // نفس الرقم بسبب كدا عملت متغير جديد مش بيشوار علي نفس المكان
            // ممكن اعمل return استقبل المتغير الجديد
            #endregion

            #region Q6
            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine($"price after : {prices[0]}");
            //هنا طرح عشان array بتكون بتشاور علي مكان في ال heep
            // يعتبر بعنله مكان المتغير 
            #endregion

            #region Q7
            //int pages = 400;
            //AddBonusPagesByRef(ref pages);
            //Console.WriteLine($"page after add : {pages}");
            // هنا التغير سمع عشان بعتله مكان المتغير 
            #endregion

            #region Q8
            //double []prices=null;
            //ReplaceArray(ref prices);
            //Console.WriteLine($"the lenght of array prices : {prices.Length}");
            #endregion

            #region Q9
            string title = "Clean Code";
            double price=0;
            TryGetPrice(title,out price);
            Console.WriteLine($"the price of {title} : {price}");
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
        //static void AddBonusPages(int pages)
        //{
        //    pages = pages + 50;
        //}
        #endregion

        #region Q6
        //static void ApplyDiscount(double[] prices)
        //{
        //    prices[0] = prices[0] - 5;
        //}
        #endregion

        #region Q7
        //static void AddBonusPagesByRef(ref int pages)
        //{
        //     pages = pages + 50;
        //}
        #endregion

        #region Q8
        //static void ReplaceArray(ref double[] prices)
        //{
        //    prices = new double []{10.0, 12.5, 15.0};
        //}
        #endregion

        #region Q9
        static bool TryGetPrice(string title, out double price)
        {
            if(title== "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
           
        }
        #endregion
    }
}

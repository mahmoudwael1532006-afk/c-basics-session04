using System;

class Program
{
    static void Main()
    {
        Q01();
        Q02();
        Q03();
        Q04();
        Q05();
        Q06();
        Q07();
        Q08();
        Q09();
        Q10();
        Q11();
        Q12();
    }

    #region Q01
    static void Q01()
    {
        double[] prices = { 25.5, 40.0, 33.75 };
        Console.WriteLine(prices[1]);
    }
    #endregion

    #region Q02
    static void Q02()
    {
        int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
        Console.WriteLine(shelfCopies[1, 0]);
    }
    #endregion

    #region Q03
    static void PrintWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Library!");
    }

    static void Q03()
    {
        PrintWelcomeMessage();
    }
    #endregion

    #region Q04
   static void PrintBookTitle(string title)
    {
        Console.WriteLine("Book title: " + title);
    }

    static void Q04()
    {
        PrintBookTitle("Clean Code");
    }
    #endregion

    #region Q05
    static void AddBonusPages(int pages)
    {
        pages = pages + 50;
    }

    static void Q05()
    {
        int pages = 400;
        AddBonusPages(pages);
        Console.WriteLine(pages);
    }
    #endregion

    #region Q06
    static void ApplyDiscount(double[] prices)
    {
        prices[0] = prices[0] - 5;
    }

    static void Q06()
    {
        double[] prices = { 25.5, 40.0 };
        ApplyDiscount(prices);
        Console.WriteLine(prices[0]);
    }
    #endregion

    #region Q07
    static void AddBonusPagesByRef(ref int pages)
    {
        pages = pages + 50;
    }

    static void Q07()
    {
        int pages = 400;
        AddBonusPagesByRef(ref pages);
        Console.WriteLine(pages);
    }
    #endregion

    #region Q08
    static void ReplaceArray(ref double[] prices)
    {
        prices = new double[] { 10.0, 12.5, 15.0 };
    }

    static void Q08()
    {
        double[] prices = { 25.5, 40.0 };
        ReplaceArray(ref prices);
        Console.WriteLine(prices.Length);
    }
    #endregion

    #region Q09
    static bool TryGetPrice(string title, out double price)
    {
        if (title == "Clean Code")
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

    static void Q09()
    {
        double bookPrice;
        bool found = TryGetPrice("Clean Code", out bookPrice);
        if (found)
        {
            Console.WriteLine(bookPrice);
        }
    }
    #endregion

    #region Q10
    static void PrintBookInfo(string title, int pages = 300)
    {
        Console.WriteLine("Title: " + title + ", Pages: " + pages);
    }

    static void Q10()
    {
        PrintBookInfo("Clean Code");
        PrintBookInfo("Clean Code", 464);
    }
    #endregion

    #region Q11
    static void Q11()
    {
        PrintBookInfo(pages: 500, title: "Clean Code");
    }
    #endregion

    #region Q12
    static void PrintAllTitles(params string[] titles)
    {
        for (int i = 0; i < titles.Length; i++)
        {
            Console.WriteLine(titles[i]);
        }
    }

    static void Q12()
    {
        PrintAllTitles("Clean Code", "Refactoring", "The Pragmatic Programmer");
    }
    #endregion
}
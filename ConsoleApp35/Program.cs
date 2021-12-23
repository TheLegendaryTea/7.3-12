using System;

namespace ConsoleApp33
{
    class Program
    {
        struct football
        {
            public string Familia;
            public DateTime DateOFBirth;
            public string PlaceOFBirth;
            public string Amplua;
            public int AmountOFgames;
            public int AmountOFyellowcards;
        }
        static void Main(string[] args)
        {
            football[] footballs = new football[3];
            for (int i = 0; i < footballs.Length; i++)
            {
                Console.WriteLine("введите Фамилию " + (i + 1) + " футболиста");
                footballs[i].Familia = Console.ReadLine();
                Console.WriteLine("введите дату рождения " + (i + 1) + " футболиста");
                footballs[i].DateOFBirth = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("введите место рождения " + (i + 1) + " футболиста");
                footballs[i].PlaceOFBirth = Console.ReadLine();
                Console.WriteLine("введите амплуа" + (i + 1) + " футболиста");
                footballs[i].Amplua = Console.ReadLine();
                Console.WriteLine("введите колличество игр" + (i + 1) + " футболиста");
                footballs[i].AmountOFgames = int.Parse(Console.ReadLine());
                Console.WriteLine("введите колличество жёлтых карточек которые получил " + (i + 1) + " футболист");
                footballs[i].AmountOFyellowcards = int.Parse(Console.ReadLine());
            }
            foreach (football i in footballs)
            {
                var now = DateTime.Now.Year;
                var date = now - i.DateOFBirth.Year;
                if (date - 20 >= 0)
                {
                    if (i.AmountOFyellowcards <= 1 && i.AmountOFgames <= 10) Console.WriteLine(i.Familia + " " + i.DateOFBirth + " " + i.PlaceOFBirth + " " + i.Amplua + " " + i.AmountOFgames + " " + i.AmountOFyellowcards);
                }
                else Console.WriteLine();
            }
        }
    }
}

using System;

namespace frågesport
{
    class Program
    {
        static void Main(string[] args)
        {

            string fråga1 = "";
            string fråga2 = "";
            string fråga3 = "";
            string fråga4 = "";
            string fråga5 = "";
            string fråga6 = "";
            int points = 0;

            while (fråga1 != "A" && fråga1 != "B" && fråga1 != "C" && fråga1 != "D")
            {



                Console.WriteLine("Where does The Elder Scrolls 5 take place? A:Hammer fell  B:High rock  C:Skyrim  D:Detroit");
                fråga1 = Console.ReadLine();
            }
            if (fråga1 == "C")
            {
                points = points + 1;


            }
            while (fråga2 != "A" && fråga2 != "B" && fråga2 != "C" && fråga2 != "D")
            {
                Console.WriteLine("What is the name of the Jarl taken by the Empire in the begining of the game?  A:Ulfric StormCloak  B:Jarl Balgruuf  C:Barack Obama  D:Jizargo");

                fråga2 = Console.ReadLine();
            }

            if (fråga2 == "A")
            {
                points = points + 1;

            }
            while (fråga3 != "A" && fråga3 != "B" && fråga3 != "C" && fråga3 != "D")
            {
                Console.WriteLine("What minority in skyrim is known for abusing skooma, stealing and there for is not alowed into bigger citys   A:Orcs  B:Nords  C:Sweds  D:Khajits");
                fråga3 = Console.ReadLine();
            }
            if (fråga3 == "D")
            {
                points = points + 1;
            }

            while (fråga4 != "A" && fråga4 != "B" && fråga4 != "C" && fråga4 != "D")
            {
                Console.WriteLine("What is the main charakter in the game called?  A:Dovakin  B:The Dark Knight  C:Dragon Born  D:Steve");
                fråga4 = Console.ReadLine();
            }
            if (fråga4 == "A" || fråga4 == "C")
            {
                points = points + 1;
            }

            while (fråga5 != "A" && fråga5 != "B")
            {
                Console.WriteLine("When The Blades ask you to kill The Gray Beards leader Paarthurnax do you do it?  A:Yes i love the blades  B:No Paarthunax is super chill ");
                fråga5 = Console.ReadLine();
            }
            if (fråga5 == "B")
            {
                points = points + 1;
            }
            if (fråga5 == "A")
            {
                points = points - 10000;
            }

            while (fråga6 != "A" && fråga6 != "B" && fråga6 != "C" && fråga6 != "D")
            {
                Console.WriteLine("What guild is known for being hired assains that you call upon by doing the black sacrament?  A:The Thives Guild  B:The Sheild Brothers  C:The Darkbrotherhood  D:Dawn Guard");
                fråga6 = Console.ReadLine();
            }
            if (fråga6 == "C")
            {
                points = points + 1;
            }


            Console.WriteLine("You got: " + points);






            Console.ReadLine();
        }
    }
}

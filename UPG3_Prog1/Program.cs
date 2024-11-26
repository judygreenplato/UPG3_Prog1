using System.ComponentModel.Design;

namespace UPG3_Prog1
{
    internal class Program
    {
        static bool programQuit = false; 
        static void Main(string[] args)    // Huvudmetod
        {
            while (programQuit == false)
            {
                BreakLine();
                MainMenuText();
                BreakLine('_', 20);
                UserChoise(UserInput());
                BreakLine('_', 20);
                BreakLine();

            }
        }
        static void MainMenuText()                         // För att visa menyalternativ
        {
            Console.WriteLine("Gör ditt val");
            Console.WriteLine("1 : Skriv ut 1 till 100.");
            Console.WriteLine("2 : Skriv ut 100 till 1.");
            Console.WriteLine("3 : Avsluta program");
        }
        static int UserInput()                           
        {
            string inputString = Console.ReadLine();    // Att ta värde från användaren
            int inputNum;
            Int32.TryParse(inputString, out inputNum);
            return inputNum;
        }
        static void UserChoise(int userInput)      // Att utföra olika jobb enligt valt val
        {
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Du har gjort Val1");
                    Counter(true);
       
                    break;
                case 2:
                    Console.WriteLine("Du har gjort Val2");
                    Counter(false);
                    break;
                case 3:
                    Console.WriteLine("Programmet Avsluttas");
                    programQuit = true;
                    break;
                default:
                    Console.WriteLine("Ditt val är ej giltigt , prova igen. ");
                    UserChoise(UserInput());
                    break;




            }
        }
        static void Counter(bool countUP)               //För att skriva ut nummer från 1 till 100 och 
        {                                               //  skriva ut baklänges från 100 till 1.
            if (countUP)
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(i + 1);
                }
            }
            else
            {
                for (int i = 100; i > 0; i--)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void BreakLine()                //För att sätta en bra understrykning                  
        {

            BreakLine('*', 20);

        }
        static void BreakLine(char breakLineType, int length)    // Att skriva ett visst tecken under en viss upprepad tid
        {
            string breakLine = new string(breakLineType, length);
            Console.WriteLine(breakLine);

        }
    }
}

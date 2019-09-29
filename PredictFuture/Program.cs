using System;

namespace PredictFuture
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int month;
            int age;
            int siblings;
            
            

            Console.WriteLine("Good Day, What is your first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("and " + firstName + " what is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("Alright " + firstName + " " + lastName + " what number month were you born?");
            month = Convert.ToInt32(Console.ReadLine());

            
            
            Console.WriteLine("Okie Dookie " + firstName + " " + lastName + ", How old are you?");
            age = Convert.ToInt32(Console.ReadLine());

            string retire = null;

                if (age % 2 == 1)
                {
                 retire = "14 years"; 
                }

            else if (age % 2 == 0)
                {
                 retire = "11 years"; 
                }

            string season;

                while (true) { 
                Console.WriteLine(firstName + " what is your favorite season");
                season =Console.ReadLine().ToLower();

                
                    if (season == "winter")
                    {
                        season = "blue";
                        break;
                    }
                    else if (season == "spring")
                    {
                        season = "green";
                        break;
                    }
                    else if (season == "summer")
                    {
                        season = "pink";
                        break;
                    }
                    else if (season == "fall")
                    {
                        season = "orange";
                        break;
                    }
                else Console.WriteLine("That is not a valid color can you try again");
                }





            //color decision
            string color;
            
                Console.WriteLine(firstName + " What is your favorite ROYGBIV color? Enter \"Help\" for color list");
                
             do {
                color = Console.ReadLine().ToLower();
                if (color == "help")
                {
                    Console.WriteLine("Colors are; Red, Orange, Yellow, Green, Blue, Indigo, and Violet");
                    Console.WriteLine("Please state your favorite color?");
                }
                else if (color == "red")
                {
                    color = "Lamborgini";
                }

                else if (color == "orange")
                {
                    color = "fishing boat";
                }
                else if (color == "yellow")
                {
                    color = "banana pepper";
                }
                else if (color == "green")
                {
                    color = "Tesla";
                }
                else if (color == "blue")
                {
                    color = "Wild Stallion";
                }
                else if (color == "indigo")
                {
                    color = "Cessna";
                }
                else if (color == "violet")
                {
                    color = "Giant Panda";
                }
            } while (color.Equals("help"));


            
                Console.WriteLine(firstName + ", how many siblings you have");
                siblings = Convert.ToInt32(Console.ReadLine());
           
                Console.WriteLine("calculating...");

                {
                    System.Threading.Thread.Sleep(2000);
                }

                Console.WriteLine("calculating...");

                {
                    System.Threading.Thread.Sleep(1000);
                }


            //age to retire//

            string moneyMoney = null;

                //how much you will retire with//
                if (month == 1 || month == 4)

                {
                    moneyMoney = "$1,000";
                }

                else if (month == 5 || month == 8)
                {
                    moneyMoney = "$250,000,000";
                }

                else if (month == 9 || month == 12)
                {
                    moneyMoney = "$15,000,000";
                }




            //how many sibling = where retiring at//
            string location = null;
              
                if (siblings <= 1)
                {
                    location =  "Panama";
                }
                else if (siblings == 2)
                {
                location = "Mexico";
                }
                else if (siblings == 3)
                {
                location = "Pig Pen";
                }
                else if (siblings == 4)
                {
                location = "Antartica";
                }
                else if (siblings >= 5)
                {
                location = "Tennessee";
                }
                





            Console.WriteLine(firstName + " " + lastName + " will retire in " + retire + "with " + moneyMoney + " in the bank,");
            Console.WriteLine(", a vacation home in " + location + ", and will travel by a " + season + " " + color);







            
        }
    }
}

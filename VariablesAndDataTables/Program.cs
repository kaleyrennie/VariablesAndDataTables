using System;

namespace VariablesAndDataTables
{
    class Program
    {
        static void Main(string[] args)
        {

            //This is a simple program - control KC
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is yout favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            //bool isStudying = false;
            //byte hoursWorked = 42;
            //sbyte currentTemperature = -23;
            //char questionMark = '\u2103';
            //decimal moneyInBank = 100.5m;
            //double heightInCentimeters = 211.38215322;
            //float secondsLeft = 2.6f;
            //short temperatureOnMars = -341;
            //string myName = "kaley";

            //int currentAge = 24;
            //string yearsOld = currentAge.ToString();

            //bool isRaining = true;
            //string rainingStatus = Convert.ToString(isRaining);

            //Console.WriteLine(rainingStatus);
            //Console.ReadLine();


            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            Console.WriteLine("What Course are you on?");
            string courseName = Console.ReadLine();
            
       
            Console.WriteLine("What Page Number are you on?");
            string pageNum = Console.ReadLine();
            int pageNummber = Convert.ToInt32(pageNum);
            

            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            string helpResult = Console.ReadLine();
            bool needsHelp = true;
            bool noHelp = false;
            

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string experiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int hoursStudies = Convert.ToInt32(studyHours);
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();




        }
    }
}

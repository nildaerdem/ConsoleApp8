using System;
using System.IO;

//    Jean-Luc Picard’s journal.
//Write a program which reads lines of text written by the user in the console and writes them into
//Captain’s journal. To start writing into the journal the user should enter “start”. To end writing into
//the journal the user should enter “stop”. Whatever the user enters before “start” or after “stop”
//should be discarded.After entering the whole content, the program should create a file titled
//<current-date>.txt with the content in the following format:
//Captain’s log
//Stardate<current-date>
//First line…
//Second line…
//…
//Jean-Luc Picard

namespace ExampleOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            string temp = "";
            string not = "";
            //not start
            do
            {
                temp = Console.ReadLine();
            } while (temp != "start");

            //not write 
            do
            {
                temp = Console.ReadLine();
                if (temp != "stop")
                    not += temp + "\n";

            } while (temp != "stop");

            //not save
            var currentDate = DateTime.Now.ToString("dd.MM.yyyy ");

            not = "Captain’s log\nStardate <" + currentDate + ">\n\n" + not + "\n" + name;

            File.WriteAllText(currentDate + ".txt", not);

            Console.ReadKey();
        }
    }
}

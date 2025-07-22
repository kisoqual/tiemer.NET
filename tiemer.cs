using System;
using static System.Console;
using static System.Threading.Thread;
using static System.ConsoleColor;

//maybe ill use later
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiemer.NET
{
    internal class tiemer
    {
        static void count(int sec = 0)
        {
            sec = Int32.Parse(ReadLine());
            if (sec < 0)
            {
                while (sec < 0)
                {
                    Clear();
                    ForegroundColor = Yellow;
                    Write("\aIncorrect value! ");
                    ForegroundColor = White;
                    WriteLine("Try again");
                    Write("Seconds: ");
                    sec = Int32.Parse(ReadLine());
                }
            }
            Clear();
            for (int i = sec; ; i--)
            {
                ForegroundColor = Yellow;
                Write(i);
                ForegroundColor = White;
                Write(" sec remaining");
                Sleep(1000);
                Clear();
                if (i <= 1)
                {
                    Clear();
                    ForegroundColor = Yellow;
                    WriteLine("\aTIME UP!1!!");
                    ForegroundColor = White;
                    Sleep(1000);
                    break;
                }
            }
        }

        static void Main()
        {
            Title = "Tiemer.net";
            Clear();
            BackgroundColor = White;
            ForegroundColor = Black;
            WriteLine("Type some seconds to begin");
            BackgroundColor = Black;
            ForegroundColor = White;
            WriteLine("1 min = 60 sec");
            Write("Seconds: ");
            count();
            WriteLine("Press any key to exit . . .");
            ReadKey();
            Clear();
        }
    }
}

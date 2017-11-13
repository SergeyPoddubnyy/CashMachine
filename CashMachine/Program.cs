using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, string, int> Messenge = new Action<int, string, int>(encashment);
            Messenge += menegers;
            Action<int> Displey = new Action<int>(disleymessege);
            ATM CashMachine = new ATM(125, "Televizionaya street 4-a", Messenge, Displey);
            do
            {
                Console.WriteLine("\n"+CashMachine.ToString());
                Console.WriteLine("Set Summ please!");
                int Summ = Convert.ToInt32(Console.ReadLine());
                CashMachine.WithdrawMoney(Summ);
                Console.WriteLine("Set esc for exite please!");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
        static void encashment(int _nomber,string _adress, int _currentRest)
        {
            Console.WriteLine($"Encashment! In ATM nomber {_nomber}, adress {_adress} rest {_currentRest} $");
        }
        static void menegers(int _nomber, string _adress, int _currentRest)
        {
            Console.WriteLine($"Menegers! In ATM nomber {_nomber}, adress {_adress} rest {_currentRest} $");
        }
        static void disleymessege(int _summ)
        {
            Console.WriteLine($"ATM don't have {_summ} $! Set other summ please!");
        }
    }
}

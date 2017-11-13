using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    class ATM
    {
        private int Namber { get; }
        private string Adress { get; }
        private int CurrentRest { get; set; }
        private int MinRest { get; }
        private Action<int, string, int> FewManey;
        private Action<int> NoManey;
        public  ATM(int _namber, string _adress,Action<int, string, int> _func_few, Action<int> _func_no)
        {
            Namber = _namber;
            Adress = _adress;
            CurrentRest = 20000;
            MinRest = 2000;
            FewManey = _func_few;
            NoManey = _func_no;
        }
        public void WithdrawMoney(int summ)
        {
             if(CurrentRest-summ<0)
            {
                NoManey(summ);
                return;
             }
            CurrentRest -= summ;
            Console.WriteLine($"Take your {summ} $ please.");
            if (CurrentRest < MinRest)
            {
                FewManey(Namber, Adress, CurrentRest);
                AddMoney(10000);
            }
        }
        public void AddMoney(int summ)
        {
            CurrentRest += summ;
        }
        public override string ToString()
        {
            return $"Rest is {CurrentRest} $";
        }
    }
}

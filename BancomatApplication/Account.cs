using System.Collections.Generic;

namespace BancomatApplication
{
    public class Account
    {
        Bancomat bankomat = new Bancomat();
        public readonly string UserName;
        public readonly string Password;
        public bool StatoConto;
        public double Saldo { get; private set; }
        public Account(string Username, string pw)
        {
            UserName = Username;
            Password = pw;
            ContoCorrente conto = new ContoCorrente();
            Saldo = conto.SaldoIniziale;
            StatoConto = true;

        }
        public void RichiestaPrelievo(Account selezionato, List<Account> accounts, double Richiestapr)
        {

            double ChangeSaldo = bankomat.Prelievo(Saldo, Richiestapr);
            foreach (var i in accounts)
            {
                if (selezionato == i)
                {
                    i.Saldo = ChangeSaldo;
                }
            }
        }
        public void RichiestaVersamento(Account selezionato, List<Account> accounts, double Richiestavers)
        {

            double ChangeSaldo = bankomat.Versamento(Saldo, Richiestavers);
            foreach (var i in accounts)
            {
                if (selezionato == i)
                {
                    i.Saldo = ChangeSaldo;
                }
            }
        }
        //public void ShowSaldo(Account selezionato, List<Account> accounts)
        //{
        //    DateTime dateTime = DateTime.Now;
        //    foreach (var i in accounts)
        //    {
        //        if (selezionato == i) 
        //            Console.WriteLine($"Saldo Corrente : {i.Saldo} - {dateTime}");

        //    }
        //}
    }
}

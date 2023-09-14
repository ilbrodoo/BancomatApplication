using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancomatApplication
{
    public class Bancomat
    {
        List<ContoCorrente> ContiCorrenti = new List<ContoCorrente> { };
        public   double  Prelievo(double saldo , double richiestaprelievo )
        {
            if (richiestaprelievo < 0)
            {
                Console.WriteLine("Valore Inserito non Prelevabile");
                return saldo;
            }
            else 
            {
                double changesaldo = _Prelievo(saldo, richiestaprelievo);
                return changesaldo;
            }
        }

        public  double Versamento(double saldo, double richiestavers)
        {
            if (richiestavers < 0)
            {
                Console.WriteLine("Valore Inserito non Versabile");
                return saldo;
            }
            else
            {
                double changesaldo = _Prelievo(saldo, richiestavers);
                return changesaldo;
            }
        }

        private double _Versamento(double saldo, double richiestaprelievo)
        {

            Console.WriteLine("Versamento  effettuato con successo  ");
            saldo = saldo + richiestaprelievo;
            return saldo;

        }
        private double _Prelievo(double  saldo, double richiestaprelievo) 
        {
            if (richiestaprelievo <= saldo)
            {
                Console.WriteLine("Prelievo effettuato con successo , Ritirare i soldi ");
                saldo = saldo - richiestaprelievo;
                return saldo;
            }
            else
            {
                Console.WriteLine("Prelievo non possibile , Saldo insufficiente ");
                return saldo;
            }
        }
    }
}

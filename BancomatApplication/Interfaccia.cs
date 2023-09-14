using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Transactions;

namespace BancomatApplication
{
    public class Interfaccia
    {
        public static Account Menu(List<Account> accounts)
        {

            var numTentativiPippo = 0;
            var numTentativiPluto = 0;
            var numTentativiSamuele = 0;
            bool checkaccount = true;
            //Account account1 = new Account("Pippo", "1234");
            //Account account2 = new Account("Pluto", "4321");
            //Account account3 = new Account("Samuele", "1423");

            //List<Account> accounts = new List<Account>();
            //accounts.Add(account1);
            //accounts.Add(account2);
            //accounts.Add(account3);

            Account accountSelezionato = null;
            while (checkaccount)
            {
                Console.WriteLine("Salve , Inserisci Username e Password ");
                var username = Console.ReadLine().ToLower();
                var password = Console.ReadLine().ToLower();

                //switch (username)
                //{
                //    case "pippo":
                //        numTentativiPippo++;

                //        break;
                //    case "pluto":
                //        numTentativiPluto++;
                //        break;
                //    case "samuele":
                //        numTentativiSamuele++;
                //        break;
                //    default:
                //        Console.WriteLine("Account Username Non Riconosciuto ")
                //            ; break;
                //}
                foreach (var x in accounts)
                {
                    
                    if (x.StatoConto)
                    {
                        {
                            if (username == x.UserName.ToLower() & password == x.Password.ToLower())
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Accesso Riuscito \n ");
                                Console.ResetColor();
                                Console.WriteLine($"  Benvenuto {username} ");
                                checkaccount = false;
                                accountSelezionato = x;
                                return accountSelezionato;
                            }
                            else {
                               
                            }

                        }
                       
                    }else { Console.WriteLine($"Account {username} Bloccato , Contattare l'Assistenza "); }

                    if (x.UserName.ToLower() == username)
                    {
                        x.NTemp = x.NTemp + 1;
                       if (x.NTemp > 2 ) 
                        {
                            x.StatoConto = false;
                        }
                    }
                    //if (numTentativiPippo > 2)
                    //{

                        
                    //    x.StatoConto = false;
                        
                    //    break;
                    //}
                    //else if (numTentativiPluto > 2)
                    //{

                       
                    //    x.StatoConto = false;
                    //    numTentativiPluto = 0;
                    //    break;
                    //}
                    //else if (numTentativiSamuele > 2)
                    //{
                        
                    //    x.StatoConto = false;
                    //    numTentativiSamuele = 0;
                    //    break;
                    //}
                   
                }
                if (checkaccount)
                {
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Errore, Riprova ");
                }
            }
            
            return null;
        }

        public  static bool MenuPrincipale(Account accountSelezionato, List<Account> accounts)
        {
            bool Restart = false;
            
            Console.WriteLine("Quale funzionalità desideri utilizzare \n (1) - Prelievo  (2) - Visualizza Saldo  (3) - Versamento   (4) - Exit ");
            string funzionalita = Console.ReadLine();

            switch (funzionalita)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("-----------------------------------------------------------------------------------");
                    
                    Console.WriteLine("Quanto vuoi Prelevare ? ");
                    double Richiestapr = Convert.ToDouble(Console.ReadLine());

                    accountSelezionato.RichiestaPrelievo(accountSelezionato,accounts,Richiestapr);
                    ShowSaldo(accountSelezionato, accounts);
                    Console.WriteLine("Premere invio per tornare al Menu");
                    Console.ReadLine();
                    break;

                case "2":
                    Console.Clear();
                    ShowSaldo(accountSelezionato, accounts);
            
            Console.WriteLine("Premere invio per tornare al Menu");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("-----------------------------------------------------------------------------------");
                    Console.WriteLine("Quanto vuoi Versare ? ");
                    double Richiestavers = Convert.ToDouble(Console.ReadLine());
                    accountSelezionato.RichiestaVersamento(accountSelezionato, accounts,Richiestavers);
                    ShowSaldo(accountSelezionato, accounts);
                    Console.WriteLine("Premere invio per tornare al Menu");
                    Console.ReadLine();
                    break;
                case "4":
                    Restart = true;
                    
                    break;
            }
            Console.Clear();
            return Restart;
        }

        private static void ShowSaldo(Account accountSelezionato, List<Account> accounts)
        {
            DateTime dateTime = DateTime.Now;
            //accountSelezionato.ShowSaldo(accountSelezionato, accounts);
            foreach (var i in accounts)
            {
                if (accountSelezionato == i)
                    Console.WriteLine($"Saldo Corrente : {i.Saldo} - {dateTime}");
            }
        }

        //public static  bool AccessoUtente(bool checkaccount, string username, string password, Account x)

        //public static void MenuPrincipale( )
        //{
        //    Console.WriteLine("Quale funzionalità desideri utilizzare \n (1) - Prelievo  (2) - Visualizza Saldo ");
        //    string funzionalita = Console.ReadLine();
        //    Account account = null;
        //    switch (funzionalita)
        //    {
        //        case "1":
        //            account.RichiestaPrelievo();
        //            break;
        //        case "2":
        //            account.ShowSaldo();
        //            break; 
        //    }
        //}

    }
}




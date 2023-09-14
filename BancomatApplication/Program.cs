using System.Collections.Generic;

namespace BancomatApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Account account1 = new Account("Pippo", "1234");
            Account account2 = new Account("Pluto", "4321");
            Account account3 = new Account("Samuele", "1423");
            bool restart = false  ;
            List<Account> accounts = new List<Account>();
            accounts.Add(account1);
            accounts.Add(account2);
            accounts.Add(account3);
       
            var currentAccount = Interfaccia.Menu(accounts);
            while (true)
            {
                  
                  restart = Interfaccia.MenuPrincipale(currentAccount, accounts);

                if (restart == true)
                {
                    currentAccount = Interfaccia.Menu(accounts);
                }
            }
            
            //Interfaccia.MenuPrincipale();
        }
    }
}

//while (true)
//{
//var numTentativiPippo = 0;
//var numTentativiPluto = 0;
//var numTentativiSamuele = 0;
//bool checkaccount = true;
//Account account1 = new Account("Pippo", "1234");
//    Account account2 = new Account("Pluto", "4321");
//    Account account3 = new Account("Samuele", "1423");

//    List<Account> accounts = new List<Account>();
//    accounts.Add(account1);
//    accounts.Add(account2);
//    accounts.Add(account3);

//            while (checkaccount)
//            {
//                Console.WriteLine("Salve , Inserisci Username e Password ");
//                var username = Console.ReadLine().ToLower();
//                var password = Console.ReadLine().ToLower();

//                switch (username)
//                {
//                    case "pippo":
//                        numTentativiPippo++;

//                        break;
//                    case "pluto":
//                        numTentativiPluto++;
//                        break;
//                    case "samuele":
//                        numTentativiSamuele++;
//                        break;
//                    default : Console.WriteLine("Account Username Non Riconosciuto ")
//                            ; break;
//                }
//                foreach (var x in accounts)
//                {

//                    if (x.StatoConto)

//                        checkaccount = AccessoUtente(checkaccount, username, password, x);


//                    if (numTentativiPippo > 3 )
//                    {

//                        Console.WriteLine($"Account {username} Bloccato ");
//                        x.StatoConto = false;
//                        break;
//                    }
//                    else if (numTentativiPluto > 3)
//                    {

//                        Console.WriteLine($"Account {username} Bloccato ");
//                        x.StatoConto = false;
//                        break;
//                    }
//                    else if (numTentativiSamuele > 3)
//                    {
//                        Console.WriteLine($"Account {username} Bloccato ");
//                        x.StatoConto = false;
//                        break;
//                    }

//                }
//            }
//                //}
//        }

//        private static bool AccessoUtente(bool checkaccount, string username, string password, Account x)
//        {
//            if (username == x.UserName & password == x.Password)
//            {
//                Console.WriteLine($"Accesso Riuscito \n  Benveuto {username} ");
//                checkaccount = false;
//            }
//            else { }

//            return checkaccount;
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownSimulatorEngine
{
    public class Bank
    {
        public static List<Account> AccountList = new List<Account>();

        public static Account SearchAccountByID(int id)
        {
            foreach (Account account in AccountList)
            {
                if (account.ID == id)
                {
                    return account;
                }
            }
            return null;
        }
        
        public class Account
        {
            public string Name;
            public string FullName;
            public int ID;
            public decimal Amount;
            public bool IsBroke;

            /// <summary>
            /// Create a new instance of Account with given parameters:
            /// </summary>
            /// <param first name of the account="name"></param>
            /// <param full name of the account="fullName"></param>
            /// <param unique identifier of the account="id"></param>
            /// <param amount of money the account starts with="amount"></param>
            /// <param checks if the account is broke="isBroke"></param>
            public Account(string name, string fullName, int id, decimal amount, bool isBroke = false)
            {
                Name = name;
                FullName = fullName;
                ID = id;
                Amount = amount;
                IsBroke = isBroke;
                AccountList.Add(this);
            }

            /// <summary>
            /// Reduces a given amount of money from the account
            /// </summary>
            /// <param the amount to deduct from the account="amount"></param>
            /// <returns></returns>
            public bool ReduceMoney(decimal amount)
            {
                try
                {
                    if (!IsBroke)
                    {
                        Amount -= amount;

                        if (Amount < 0)
                        {
                            IsBroke = true;
                        }
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Unable to withdraw " + amount + "!\nThe account is broke!");
                        return false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
            }

            /// <summary>
            /// Increases a given amount of money to the account
            /// </summary>
            /// <param the amount to deposit to the account="amount"></param>
            /// <returns></returns>
            public bool IncreaseMoney(decimal amount)
            {

                {
                    try
                    {
                        if (!IsBroke)
                        {
                            Amount += amount;
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Unable to deposit " + amount + "!\nThe account is broke!");
                            return false;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return false;
                    }
                }
            }
        }
    }
}

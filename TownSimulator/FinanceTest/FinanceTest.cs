using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TownSimulatorEngine;

namespace FinanceTest
{
    [TestClass]
    public class FinanceTest
    {
        [TestMethod]
        public void TestBank()
        {
            Bank.Account account1 = new Bank.Account("Milan", "Milan Dierick", 001, 10000);
            Bank.Account account2 = new Bank.Account("Jacques", "Jacques van Oost", 002, 12000);
            Bank.Account account3 = new Bank.Account("Maxim", "Maxim Dewitte", 003, 14000);
            Bank.Account account4 = new Bank.Account("Natan", "Natan Muyle", 004, 14000);
            Bank.Account accountassert1 = Bank.SearchAccountByID(001);
            Bank.Account accountassert2 = Bank.SearchAccountByID(002);
            Bank.Account accountassert3 = Bank.SearchAccountByID(003);
            Bank.Account accountassert4 = Bank.SearchAccountByID(004);

            Assert.AreEqual(accountassert1, account1);
            Assert.AreEqual(accountassert2, account2);
            Assert.AreEqual(accountassert3, account3);
            Assert.AreEqual(accountassert4, account4);


            Assert.AreEqual(account1.Amount, 10000);
            Assert.AreEqual(account1.Name, "Milan");
            Assert.AreEqual(account1.FullName, "Milan Dierick");
            Assert.AreEqual(account1.ID, 001);
            Assert.AreEqual(account1.IsBroke, false);
        }
    }
}

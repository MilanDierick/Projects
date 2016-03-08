using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TownSimulatorEngine;

namespace FinanceTest
{
    [TestClass]
    public class HumanTest
    {
        [TestMethod]
        public void HumanTestMethod()
        {
            Bank.Account account = account = new Bank.Account("testhumanaccount", "testhumanbankaccount", 005, 10000);
            Human TestHuman = new Human("testhumanname", "testhumanfullname", 30, "male", new Bank.Account("testhumanaccount", "testhumanbankaccount", 005, 10000));
            
            Assert.AreEqual("testhumanname", TestHuman.Name);
            Assert.AreEqual("testhumanfullname", TestHuman.FullName);
            Assert.AreEqual(30, TestHuman.Age);
            Assert.AreEqual("male", TestHuman.Gender);

            Assert.AreEqual(account.Name, TestHuman.Account.Name);
            Assert.AreEqual(account.FullName, TestHuman.Account.FullName);
            Assert.AreEqual(account.ID, TestHuman.Account.ID);
            Assert.AreEqual(account.Amount, TestHuman.Account.Amount);
        }
    }
}

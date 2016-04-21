using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Labb2TestKurs;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Labb2UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StrCount()
        {
            Solution sl = new Solution();
            string str = "string";
            var result = sl.StrCount(str);
            Assert.IsTrue(result.Length == str.Length);

            TestContext.WriteLine(result);



        }

        [TestMethod]
        public void StrTypeIsNumber()
        {
            Solution sl = new Solution();
            string n = "2";
            var result = sl.StrType(n);
            Regex ex = new Regex(@"[0-9]+$");

            Assert.IsTrue(ex.IsMatch(result));

            TestContext.WriteLine(result);


        }

        [TestMethod]
        public void StrTypeIsWord()
        {
            Solution sl = new Solution();
            string n = "abc";
            var result = sl.StrType(n);
            Regex ex = new Regex(@"[A-Za-z]+$");

            Assert.IsTrue(ex.IsMatch(result));

            TestContext.WriteLine(result);


        }

        [TestMethod]
        public void StrTypeisNone()
        {
            Solution sl = new Solution();
            string n = "abc, defghi, jklmn";
            var result = sl.StrType(n);
            Regex ex = new Regex(@"^([A-Za-z0-9]\s?)+([,]\s?([A-Za-z0-9]\s?)+)*$");

            Assert.IsTrue(ex.IsMatch(result));

            TestContext.WriteLine(result);


        }

        [TestMethod]
        public void NextPalindrome()
        {
            Solution sl = new Solution();

            int num1 = 165;

            int num2 = 171;

            var result = sl.NextPalindrome(num1);

            Assert.AreEqual(num2, result);



        }

        [TestMethod]
        public void NextPrime()
        {
            Solution sl = new Solution();

            int num1 = 11;

            List<int> primes = new List<int> { 13, 17, 19 };
            

            var result = sl.NextPrime(num1);

            CollectionAssert.AreEqual(primes, result);

            TestContext.WriteLine(result.ToString());
        }


        private TestContext testContextInstance;
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
    }
}

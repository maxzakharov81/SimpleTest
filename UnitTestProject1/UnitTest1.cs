using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleProject;

namespace UnitTestProject1
{
    
    [TestClass]
    public class UnitTest1
    {
        private MyClass TestClass;

        [TestInitialize]
        public void TestInit()
        { TestClass = new.MyClass();
        }


        [TestMethod]
        public void TestNotcontainNull()
        {
            // arrange
            List<double> vector = new.List<double>();
            vector.Add(1);
            vector.Add(2);
            vector.Add(3);

            //act
            List<double> expectedResult = new.List<double>();
            expectedResult.Add(2);
            expectedResult.Add(3);
            expectedResult.Add(4);

            List<double> realResult = TestClass.increment_vector();

            CollectionAssert.AreEqual

        }


        [TestMethod]
        public void TestTypeDouble()
        {

        }



        {
        }
    }
}

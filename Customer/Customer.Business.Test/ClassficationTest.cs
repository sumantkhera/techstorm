using Customer.Business.Test.Helper;
using Customer.BusinessLayer.Classes.Classification;
using Customer.BusinessLayer.Interface.Classification;
using Customer.DataLayer.Classes.Classification;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Business.Test
{
    [TestClass]
    public class ClassficationTest
    {
        private static IClassificationBL classificationManager;
        private static ClassificationHelper classificationHelper;

        [TestInitialize]
        public void TestInitialize()
        {
            classificationManager = new ClassificationBL(new ClassificationRepository());
            classificationHelper = new ClassificationHelper();
        }
        [TestMethod]
        public void GetClassificationList()
        {
            var classificationCount = classificationManager.GetClassificationList().Count();
            Assert.AreEqual(classificationCount, classificationHelper.ClassificationCount);

        }
    }
}

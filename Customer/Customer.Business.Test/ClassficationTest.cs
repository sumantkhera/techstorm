using Customer.Business.Test.Helper;
using Customer.BusinessLayer.IService.Classification;
using Customer.BusinessLayer.Service.Classification;
using Customer.DataLayer.Repository.Classification;
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
        private static IClassificationService classificationManager;
        private static ClassificationHelper classificationHelper;

        [TestInitialize]
        public void TestInitialize()
        {
            classificationManager = new ClassificationService(new ClassificationRepository());
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

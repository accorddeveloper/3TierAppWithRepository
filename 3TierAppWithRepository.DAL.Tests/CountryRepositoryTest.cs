using _3TierAppWithRepository.DAL.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3TierAppWithRepository.DAL.Tests
{
    [TestClass]
    public class CountryRepositoryTest
    {
        TestContext context;
        CountryRepository repo;

        [TestInitialize]
        public void Init()
        {
            context = new TestContext();
            repo = new CountryRepository(context);
        }

        [TestMethod]
        public void Country_Repository_Get_All()
        {
            //Act
            var result = repo.GetAll().ToList();

            //Assert

            Assert.IsNotNull(result);
            Assert.AreEqual(4, result.Count);
            Assert.AreEqual("USA", result[0].Name);
            Assert.AreEqual("Russia", result[1].Name);
            Assert.AreEqual("Italy", result[2].Name);
            Assert.AreEqual("Spain", result[3].Name);
        }

    }
}

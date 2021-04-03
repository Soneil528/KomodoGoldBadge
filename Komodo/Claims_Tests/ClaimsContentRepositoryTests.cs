using System;
using Claims_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Claims_Tests
{
    [TestClass]
    public class ClaimsContentRepositoryTests
    {
        ClaimsContentRepository _repo;
        [TestInitialize]
        public void AddClaimsContentToList()
        {
            _repo = new ClaimsContentRepository();

            ClaimsContent one = new ClaimsContent("1", ClaimType.Car, "Accident on 465.", 400,
               DateTime.Parse("4 / 25 / 18"), DateTime.Parse("4 / 27 / 18"), false, false);
            ClaimsContent two = new ClaimsContent("2", ClaimType.Home, "House fire in kitchen.", 4000,
                DateTime.Parse("4 / 11 / 18"), DateTime.Parse("4 / 12 / 18"), false, false);
            ClaimsContent three = new ClaimsContent("3", ClaimType.Theft, "Stolen pancakes.", 4,
                DateTime.Parse("4 / 27 / 18"), DateTime.Parse("6 / 01 / 18"), false, true);

            _repo.AddClaimsContentToList(one);
            _repo.AddClaimsContentToList(two);
            _repo.AddClaimsContentToList(three);
        }
        [TestMethod]
        public void AddClaimsContentToList_Test()
        {
            _repo.AddClaimsContentToList(new ClaimsContent());

            Assert.AreEqual(4, _repo.GetClaimsContentsList().Count);
        }

        [TestMethod]
        public void RemoveClaimContentFromList_Test()
        {
            _repo.RemoveClaimContentFromList("1");

            Assert.AreEqual(2, _repo.GetClaimsContentsList().Count);
        }
    }
}

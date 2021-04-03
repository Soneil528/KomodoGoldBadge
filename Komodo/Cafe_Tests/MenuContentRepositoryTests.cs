using System;
using System.Collections.Generic;
using Cafe_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cafe_Tests
{
    [TestClass]
    public class MenuContentRepositoryTests
    {
        MenuContentRepository _repo;

        [TestInitialize]
        public void AddMenuContentToList()
        {
            _repo = new MenuContentRepository();

            MenuContent one = new MenuContent(MealNumber.One, "Number One", "Hamburger & Fries", "Quarter Pound Beef patty, Ketchup, Mustard & French Fries",
                "$10");
            _repo.AddMenuContentToList(one);
        }

        [TestMethod]
        public void AddMenuContentToList_Test()
        {
            _repo.AddMenuContentToList(new MenuContent());

            Assert.AreEqual(2, _repo.GetMenuContentList().Count);

        }
        [TestMethod]
        public void RemoveMenuContentFromList_Test()
        {
            _repo.RemoveMenuContentFromList(new MealNumber());

            Assert.AreEqual(1, _repo.GetMenuContentList().Count);
        }

        [TestMethod]
        public void GetContentByMealNumber_Test()
        {
            _repo.GetContentByMealNumber(new MealNumber());

            Assert.AreEqual(1, _repo.GetMenuContentList().Count);
        }
    }
}

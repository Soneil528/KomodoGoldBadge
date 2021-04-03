using System;
using System.Collections.Generic;
using Cafe_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cafe_Tests
{   
    [TestClass]
    public class MenuContentRepositoryTests
    {
        // Testing Methods AddMenuContentToList
        [TestMethod]
        public void TestMethod1_AddMenuContentToList()
        {
            // Arrange
            MenuContent content = new MenuContent();
            MenuContentRepository repo = new MenuContentRepository();
            List<MenuContent> localList = repo.GetMenuContentList();

            // Act
            int beforeCount = localList.Count;
            repo.AddMenuContentToList(content);
            int acutual = localList.Count;
            int expected = beforeCount + 1;

            // Assert
            Assert.AreEqual(expected, acutual);
        }
        //[TestMethod]
        //public bool MyTestMethod_RemoveMenuContentFromList()
        //{
        //    // Arrange
        //    MenuContent MealNumber = new MenuContent();
        //    MenuContentRepository repo = new MenuContentRepository();
        //    List<MenuContent> localList = repo.GetMenuContentList();

        //    // Act
        //    repo.RemoveMenuContentFromList(MealNumber);


        //    // Assert

        //}
    }
}

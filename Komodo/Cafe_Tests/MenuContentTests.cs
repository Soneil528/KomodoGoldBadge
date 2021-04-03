using System;
using Cafe_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cafe_Tests
{
    [TestClass]
    public class MenuContentTests
    {
        //    [TestMethod]
        //    public void SetMealNumber_Enum()
        //    {
        //        MenuContent content = new MenuContent();
        //        content.MealNumber = 

        //        enum MealNumber.expected = 
        //    }
        [TestMethod]
        public void SetMealName_String()
        {
            MenuContent content = new MenuContent();
            content.MealName = "Pad Thai";

            string expected = "Pad Thai";
            string actual = content.MealName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetMealDescription_String()
        {
            MenuContent content = new MenuContent();
            content.MealDescription = "Spicy Noodles";

            string expected = "Spicy Noodles";
            string acutual = content.MealDescription;

            Assert.AreEqual(expected, acutual);
        }

        [TestMethod]
        public void SetMealIngredients_String()
        {
            MenuContent content = new MenuContent();
            content.MealIngredients = "Noodles and peanuts";

            string expected = "Noodles and peanuts";
            string actual = content.MealIngredients;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SetMealPrice_String()
        {
            MenuContent content = new MenuContent();
            content.MealPrice = "$5";

            string expected = "$5";
            string actual = content.MealPrice;

            Assert.AreEqual(expected, actual);
        }

    }
}

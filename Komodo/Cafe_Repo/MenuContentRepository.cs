using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Repo
{
    // Contains CRUD Methods but in this instance there is no update needed
    public class MenuContentRepository
    {
        private List<MenuContent> _menuContent = new List<MenuContent>();

        // Create
        public void AddMenuContentToList(MenuContent content)
        {
            _menuContent.Add(content);
        }

        // Read
        public List<MenuContent> GetMenuContentList()
        {
            return _menuContent;
        }

        // Delete
        public bool RemoveMenuContentFromList(MealNumber mealNumber)
        {
            MenuContent content = GetContentByMealNumber(mealNumber);
            if (content == null)
            {
                return false;
            }

            int initialCount = _menuContent.Count;
            _menuContent.Remove(content);

            if (initialCount > _menuContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Helper Method
        public MenuContent GetContentByMealNumber(MealNumber mealNumber)
        {
            foreach (MenuContent content in _menuContent)
            {
                if (content.MealNumber == mealNumber)
                {
                    return content;
                }
            }

            return null;
        }
    }
}

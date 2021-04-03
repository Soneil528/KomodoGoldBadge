using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Repo
{
    public class InsuranceContentRepository
    {
        private Dictionary<int, List<string>> _listOfBadges = new Dictionary<int, List<string>>();

        // Create
        public void AddBadge(InsuranceContent badge)
        {
            if(badge != null)
            {
                _listOfBadges.Add(badge.BadgeID, badge.DoorNames);
            }
        }

        // Read
        public Dictionary<int, List<string>> GetListOfBadges()
        {
            return _listOfBadges;
        }

        // New door access
        public void AddDoorAccess(int badgeID, string doorNames)
        {
            List<string> door = _listOfBadges[badgeID];
            door.Add(doorNames);
            _listOfBadges[badgeID] = door;
        }

        // Get door list
        public List<string> GetDoorList(int badgeNum)
        {
            if (! _listOfBadges.ContainsKey(badgeNum))
            {
                Console.WriteLine("That badgeID could not be found.");
                return new List<string>();
            }
            return _listOfBadges[badgeNum];
        }

        // Remove door access
        public void RemoveDoorAccess(int badgeID, string doorNames)
        {
            if(! _listOfBadges.ContainsKey(badgeID))
            {
                Console.WriteLine("That badgeID could not be found.");
            }

            List<string> door = _listOfBadges[badgeID];
            door.Remove(doorNames);
            _listOfBadges[badgeID] = door;
        }
    }
}

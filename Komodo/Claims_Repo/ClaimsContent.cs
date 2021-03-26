using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claims_Repo

{   public enum ClaimType
    {
        Car = 1,
        Home = 2,
        Theft = 3
    }
    // POCO
    public class ClaimsContent
    {
        public string ClaimID { get; set; }
        public ClaimType TypeOfClaim { get; set; }
        public string ClaimDescription { get; set; }
        public int ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }
        public ClaimsContent() { }
        public ClaimsContent(string claimID, ClaimType type, string claimDescription, int claimAmount, DateTime dateOfIncident, DateTime dateOfClaim, bool isValid)
        {
            ClaimID = claimID;
            TypeOfClaim = type;
            ClaimDescription = claimDescription;
            ClaimAmount = ClaimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
        }
    }

}

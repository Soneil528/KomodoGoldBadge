using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claims_Repo
{
    public class ClaimsContentRepository
    {
        private List<ClaimsContent> _claimsContent = new List<ClaimsContent>();

        // Create
        public void AddClaimsContentToList(ClaimsContent content)
        {
            _claimsContent.Add(content);
        }

        // Read
        public List<ClaimsContent> GetClaimsContentsList()
        {
            return _claimsContent;
        }

        // Update

        // Delete
        public bool RemoveClaimContentFromList(string claimID)
        {
            ClaimsContent content = GetClaimsContentByClaimID(claimID);
            if(content == null)
            {
                return false;
            }
            int initialCount = _claimsContent.Count;
            _claimsContent.Remove(content);
            if (initialCount > _claimsContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }   

        // Helper Method
        public ClaimsContent GetClaimsContentByClaimID(string claimID)
        {
            foreach(ClaimsContent content in _claimsContent)
            {
                if (content.ClaimID == claimID)
                {
                    return content;
                }
            }
            return null;
        }

    }
}

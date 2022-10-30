using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectoralApp.BAL.Repository.Model
{
    public class ExtendedDataModel
    {
        public long Id { get; set; }
        public long VoterId { get; set; }
        public bool IsAccurate { get; set; }
        public Nullable<bool> IsHead { get; set; }
        public string HeadMobileNo { get; set; }
        public string AltMobileNo { get; set; }
        public string WhatsAppNo { get; set; }
        public Nullable<int> SubCasteId { get; set; }
        public Nullable<int> PoliticalPartyId { get; set; }
        public Nullable<bool> IsNRIVote { get; set; }
        public string GeoTagInfo { get; set; }
        public string Notes { get; set; }
        public string Remarks { get; set; }
        public int VerifyStatus { get; set; }
        public bool VerifyAuthorizeStatus { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<long> CommunityId { get; set; }
        public Nullable<long> OldCommunityId { get; set; }
    }
}

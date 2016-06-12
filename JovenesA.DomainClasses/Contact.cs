// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace JovenesA.DomainClasses
{
  // Contacts
  public class Contact
    {
        public int ContactId { get; set; } // MemberID (Primary key)
        public string LastNames { get; set; } // LastNames
        public string FirstNames { get; set; } // FirstNames
        public int? ContactStatusId { get; set; } // ContactStatusID
        public string SmaPhone { get; set; } // SMA_Phone
        public string NonSmaPhone { get; set; } // NonSMA_Phone
        public string Email { get; set; } // Email
        public string Comments { get; set; } // Comments
        public DateTime? UpdateDtTm { get; set; } // UpdateDtTm

        public Contact()
        {
            UpdateDtTm = System.DateTime.Now;
        }
    }

}

// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;

namespace JovenesA.DomainClasses
{
  // Prepas
  public class Prepa
    {
        public int PrepaId { get; set; } // PrepaID (Primary key)
        public string PrepaAbbrev { get; set; } // PrepaAbbrev
        public string PrepaName { get; set; } // PrepaName
        public string PrepaCity { get; set; } // PrepaCity
        public DateTime? UpdtDtTm { get; set; } // UpdtDtTm
        public byte[] Timestamp { get; set; } // Timestamp
        
        public Prepa()
        {
            UpdtDtTm = System.DateTime.Now;
        }
    }

}

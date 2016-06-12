// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;

namespace JovenesA.DomainClasses
{
  // StudentTransactions
  public class StudentTransaction
    {
        public int StudentTransactionId { get; set; } // StudentTransactionID (Primary key)
        public int StudentId { get; set; } // StudentID
        public int? TransctionTypeId { get; set; } // TransctionTypeID
        public decimal? TransactionAmount { get; set; } // TransactionAmount
        public DateTime? UpdateDtTm { get; set; } // UpdateDtTm
        public byte[] Timestamp { get; set; } // Timestamp
        
        public StudentTransaction()
        {
            UpdateDtTm = System.DateTime.Now;
        }
    }

}

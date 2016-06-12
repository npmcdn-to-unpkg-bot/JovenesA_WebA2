// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;

namespace JovenesA.DomainClasses
{
    // CodeValues
    public class CodeValue
    {
        public int CodeValueId { get; set; } // CodeValueID (Primary key)
        public string CodeSet { get; set; } // CodeSet
        public string KeyValue { get; set; } // KeyValue
        public string StringValue { get; set; } // StringValue
        public string EsStringValue { get; set; } // EsStringValue
        public int? IntValue { get; set; } // IntValue
        public DateTime? DateTimeValue { get; set; } // DateTimeValue
    }

}

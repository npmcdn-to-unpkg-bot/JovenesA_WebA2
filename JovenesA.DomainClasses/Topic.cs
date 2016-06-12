// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.Collections.Generic;

namespace JovenesA.DomainClasses
{
  // Topics
  //[GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.14.3.0")]
    public class Topic
    {
        public int Id { get; set; } // Id (Primary key)
        public string Title { get; set; } // Title
        public string Body { get; set; } // Body
        public DateTime Created { get; set; } // Created
        public bool Flagged { get; set; } // Flagged

    // Reverse navigation
    public virtual ICollection<Reply> Replies { get; set; } // Replies.FK_dbo.Replies_dbo.Topics_TopicId
    //public ICollection<Reply> Replies { get; set; } // Replies.FK_dbo.Replies_dbo.Topics_TopicId
    public Topic()
    {
      Replies = new List<Reply>();
    }
  }

}
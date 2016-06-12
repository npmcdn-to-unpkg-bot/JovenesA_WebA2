using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JovenesA.DomainClasses
{
    // Replies
    public class Reply
    {
        public int Id { get; set; } // Id (Primary key)
        public string Body { get; set; } // Body
        public DateTime Created { get; set; } // Created
        public int TopicId { get; set; } // TopicId

        // Foreign keys
        //public virtual Topic Topic { get; set; } // FK_dbo.Replies_dbo.Topics_TopicId
    }

}

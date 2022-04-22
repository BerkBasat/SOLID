using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entity
{
    public class UserComments:BaseEntity
    {
        public int UserId { get; set; }
        public int CommentId { get; set; }

        public User User { get; set; }
        public Comment Comment { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entity
{
    public class Comment:BaseEntity
    {
        public int ID { get; set; }
        public string CommentText { get; set; }
        public DateTime CreatedDate { get; set; }

        public Comment()
        {
            CreatedDate = DateTime.Now;
        }
    }
}

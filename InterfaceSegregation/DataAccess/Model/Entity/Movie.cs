using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entity
{
    public class Movie:BaseEntity
    {
        public int ID { get; set; }
        public string MovieName { get; set; }
        public string Description { get; set; }
        public TimeSpan Duration { get; set; }

        public List<MoviesAndCategories> MoviesAndCategories { get; set; }
        public List<UserComments> UserComments { get; set; }
    }
}

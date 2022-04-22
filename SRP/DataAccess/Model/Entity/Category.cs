using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entity
{
    public class Category:BaseEntity
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }

        public List<MoviesAndCategories> MoviesAndCategories { get; set; }
    }
}

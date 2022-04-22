using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entity
{
    public class MoviesAndCategories:BaseEntity
    {
        public int MovieId { get; set; }
        public int CategoryId { get; set; }

        public Movie Movies { get; set; }
        public Category Categories { get; set; }
    }
}

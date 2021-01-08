using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIM313_Group5_FinalProject.Models
{
    class Book
    {
        public int ID { get; set; }
        public string title { get; set; }
        public DateTime publicationYear { get; set; }
        public short pageNumber { get; set; }
        public int authorID { get; set; }
        public int genreID { get; set; }
        public int publisherID { get; set; }

    }
}

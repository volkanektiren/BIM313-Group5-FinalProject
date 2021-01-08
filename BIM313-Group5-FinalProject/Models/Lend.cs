using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIM313_Group5_FinalProject.Models
{
    class Lend
    {
        public int ID { get; set; }
        public int bookID { get; set; }
        public int visitorID { get; set; }
        public DateTime lendDate { get; set; }
        public int tenancy { get; set; }
        public bool state { get; set; }

    }
}

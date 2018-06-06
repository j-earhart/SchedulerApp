using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace schhedulerApp.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Comments { get; set; }

        //Add local property to link to foreign key
        [ForeignKey("Services")]
        public int ServiceId { get; set; }

        //-----------------------------------------------------------
        //Define the foreign key
        public virtual Service Services { get; set; }

    }
}

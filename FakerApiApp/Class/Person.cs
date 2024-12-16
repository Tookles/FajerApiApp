using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerApiApp.Class
{
    public class Person
    {
        public int Id { get; set; }

        public String firstname { get; set; }

        public String lastname { get; set; }

        public String email { get; set; }

        public String phone { get; set; }

        public DateTime birthday { get; set; }


    }
}

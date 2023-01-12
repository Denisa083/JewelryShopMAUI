using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JewelryShop.Models
{
    class Bijuterie
    {
        public string Nume { get; set; }
        public string Imagine { get; set; }

        public string Descriere { get; set; }

       

    }
}

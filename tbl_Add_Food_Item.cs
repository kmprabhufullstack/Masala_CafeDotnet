using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Masala_Cafe
{
    public class tbl_Add_Food_Item
    {
        public int Id { get; set; }
        [DisplayName("Food Name")]
        public string Food_Name { get; set; }
        [DisplayName("Food Type")]
        public string Food_Type { get; set; }
    }
}
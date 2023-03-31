using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ders1.Models.Siniflar
{
    public class Class2 // Bu sınıf dropdown listte yaptıgımız  proplar denem atlı yerde tutuyoruz . 
    {
        public IEnumerable<SelectListItem> Kategoriler { get; set; }
        public IEnumerable<SelectListItem> Urunler { get; set; }
    }
}
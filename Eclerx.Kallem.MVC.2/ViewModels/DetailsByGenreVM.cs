using Eclerx.Kallem.MVC._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eclerx.Kallem.MVC._2.ViewModels
{
    public class DetailsByGenreVM
    {
        public IEnumerable<SelectListItem> Genre { get; set; }

        public IEnumerable<Books> books { get; set; }


    }
}
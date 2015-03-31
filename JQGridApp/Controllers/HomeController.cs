using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JQGridApp.Models;
using Newtonsoft.Json;

using System.Globalization;
using TheTime.DataAccessLevel;



namespace JQGridApp.Controllers
{
    public class HomeController : Controller
    {
        //static List<Catalog> adr = new List<Catalog>();
        static HomeController()
        {
          /*  adr.Add(new Catalog { Id = 1, Name = "Война и мир", Author = "Л. Толстой", Year = 1863, Price = 220 });
            adr.Add(new Catalog { Id = 2, Name = "Отцы и дети", Author = "И. Тургенев", Year = 1862, Price = 195 });
            adr.Add(new Catalog { Id = 3, Name = "Чайка", Author = "А. Чехов", Year = 1895, Price = 158 });
            adr.Add(new Catalog { Id = 4, Name = "Подросток", Author = "Ф. Достоевский", Year = 1875, Price = 210 });

            adr.Add(new Catalog { Id = 5, Name = "Война и мир", Author = "Л. Толстой", Year = 1863, Price = 220 });
            adr.Add(new Catalog { Id = 6, Name = "Отцы и дети", Author = "И. Тургенев", Year = 1862, Price = 195 });
            adr.Add(new Catalog { Id = 7, Name = "Чайка", Author = "А. Чехов", Year = 1895, Price = 158 });
            adr.Add(new Catalog { Id = 8, Name = "Подросток", Author = "Ф. Достоевский", Year = 1875, Price = 210 });

            adr.Add(new Catalog { Id = 9, Name = "Война и мир", Author = "Л. Толстой", Year = 1863, Price = 220 });
            adr.Add(new Catalog { Id = 10, Name = "Отцы и дети", Author = "И. Тургенев", Year = 1862, Price = 195 });
            adr.Add(new Catalog { Id = 11, Name = "Чайка", Author = "А. Чехов", Year = 1895, Price = 158 });
            adr.Add(new Catalog { Id = 12, Name = "Подросток", Author = "Ф. Достоевский", Year = 1875, Price = 210 });
           */
        }

        public ActionResult Index()
        {
            return View();
        }

        public string GetData()
        {
            string formatsrc = "dd-MM-yyyy";
             SQLiteDatabaseWorker SQLworker = new SQLiteDatabaseWorker();
            List<Catalog> table = new List<Catalog>();
            SQLworker.SetConnect();
            table = SQLworker.GetTable();
            SQLworker.CloseConnect();
            return JsonConvert.SerializeObject(table);
        }
        
    }
}
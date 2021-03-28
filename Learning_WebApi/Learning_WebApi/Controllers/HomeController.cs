using Learning_WebApi.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Learning_WebApi.Controllers
{
    public class HomeController : Controller
    {
        db10861113Entities db = new db10861113Entities();

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }


        //分別以Model及Viewbag傳送資料到前端
        public ActionResult Show()
        {
            //----------建立User型別的串列，以Viewbag傳送到前端-------------
            List<User> users = new List<User>
            {
                new User
                {
                    Id = 9,Gender = "M",Name = "ㄏㄏ",Phone = 123456789
                },
                new User
                {
                    Id = 10,Gender = "W",Name = "ㄎㄎ",Phone = 777777777
                },
                new User
                {
                    Id = 11,Gender = "W",Name = "ㄖㄖ",Phone= 999999999
                },
            };
            
            string jsonUsers = JsonConvert.SerializeObject(users); //將List集合轉為Json物件結構字串
            ViewBag.jsonUsers = jsonUsers;
            //----------建立User型別的串列，以Viewbag傳送到前端 End-------------

            return View(users);
        }
    }
}

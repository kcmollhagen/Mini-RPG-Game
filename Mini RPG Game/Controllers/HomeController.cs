using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mini_RPG_Game.Models;
using System.Data.Entity;
namespace Mini_RPG_Game.Controllers
{
    public class HomeController : Controller
    {
        private DBPlayerContext  p = new DBPlayerContext();
        private DBMonsterContext m = new DBMonsterContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ChooseMonster(Player player)
        {
            Session["Player"] = player.Name;
            return View();
        }

        public ActionResult ChoosePlayer()
        {
            ViewBag.players = p.Players.ToList();  
            ViewBag.monsters = m.Monsters.ToList();

            return View();
        }

        public ActionResult Fight(Monster monster, Player player)
        {
            Session["Monster"] = monster.Name;
            return View();
        }
    }
}
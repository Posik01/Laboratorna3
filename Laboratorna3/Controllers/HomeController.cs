using Laboratorna3.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laboratorna3.Controllers
{
    public class HomeController : Controller
    {
        
        ProtocolContext2 db = new ProtocolContext2();
        public ActionResult Index()
        {
            return View(db.Protocols);
        }


        [HttpGet]
        public ActionResult EditProtocol(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Protocol protocol = db.Protocols.Find(id);
            if (protocol == null)
            {
                return HttpNotFound();
            }
         return View(protocol);
        }
        [HttpPost]
        public ActionResult EditProtocol(Protocol protocol)
        {
            db.Entry(protocol).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Protocol protocol)
        {
            db.Protocols.Add(protocol);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Protocol p = db.Protocols.Find(id);
            if (p == null)
            {
                return HttpNotFound();
            }
            return View(p);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Protocol p = db.Protocols.Find(id);
            if (p == null)
            {
                return HttpNotFound();
            }
            db.Protocols.Remove(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }

}
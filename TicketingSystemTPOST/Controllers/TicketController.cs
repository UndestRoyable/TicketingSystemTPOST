using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TicketingSystemTPOST.Models;

namespace TicketingSystemTPOST
{
    public class TicketController : Controller
    {
        private TicketingSystemTPOSTDBContext db = new TicketingSystemTPOSTDBContext();

        // GET: /Ticket/
        public ActionResult Index()
        {
            return View(db.TicketType.ToList());
        }

        // GET: /Ticket/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TicketType tickettype = db.TicketType.Find(id);
            if (tickettype == null)
            {
                return HttpNotFound();
            }
            return View(tickettype);
        }

        // GET: /Ticket/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Ticket/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ticketTypeID,ticketName,ticketPrice")] TicketType tickettype)
        {
            if (ModelState.IsValid)
            {
                db.TicketType.Add(tickettype);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tickettype);
        }

        // GET: /Ticket/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TicketType tickettype = db.TicketType.Find(id);
            if (tickettype == null)
            {
                return HttpNotFound();
            }
            return View(tickettype);
        }

        // POST: /Ticket/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ticketTypeID,ticketName,ticketPrice")] TicketType tickettype)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tickettype).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tickettype);
        }

        // GET: /Ticket/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TicketType tickettype = db.TicketType.Find(id);
            if (tickettype == null)
            {
                return HttpNotFound();
            }
            return View(tickettype);
        }

        // POST: /Ticket/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TicketType tickettype = db.TicketType.Find(id);
            db.TicketType.Remove(tickettype);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

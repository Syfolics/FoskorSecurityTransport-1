using FoskorSecurityTransport.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using PagedList;



namespace FoskorSecurityTransport.Controllers
{
    public class TripsController : Controller
    {
        private SecurityTransportTestEntities db = new SecurityTransportTestEntities();
        private Vehicle dbVehicle = new Vehicle();

        // GET: Trips
        public ActionResult Index(int page=1)
        {
            int pageSize = 10;
            return View(db.Trips.OrderByDescending(x => x.DateOut).ToPagedList(page, pageSize));
          
        }

        // GET: Trips/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trip trip = db.Trips.Find(id);
            if (trip == null)
            {
                return HttpNotFound();
            }
            return View(trip);
        }

        // GET: Trips/Create
        public ActionResult Create()
        {
            var VMake = db.Vehicles.ToList();
            return View();
        }

        // POST: Trips/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TripID,DateOut,DateIn,StartingPoint,Passenger1,CompanyNumber1,Destination1,Passenger2,CompanyNumber2,Destination2,Passenger3,CompanyNumber3,Destination3,Passenger4,CompanyNumber4,Destination4,Department1,Supervisor1,Reason,Driver,Vehicle,KMOut,KMIn,TotalKMs,TimeOut,TimeIn,Status,SDateTime,Capturer,Supervisor2,Supervisor3,Supervisor4,Department2,Department3,Department4,noOfPassengers")] Trip trip)
        {
            {
                                 
                db.Trips.Add(trip);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(trip);
        }


        // GET: Trips/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trip trip = db.Trips.Find(id);
            if (trip == null)
            {
                return HttpNotFound();
            }
            return View(trip);
        }

        // POST: Trips/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TripID,DateOut,DateIn,StartingPoint,Passenger1,CompanyNumber1,Destination1,Passenger2,CompanyNumber2,Destination2,Passenger3,CompanyNumber3,Destination3,Passenger4,CompanyNumber4,Destination4,Department1,Supervisor1,Reason,Driver,Vehicle,KMOut,KMIn,TotalKMs,TimeOut,TimeIn,Status,SDateTime,Capturer,Supervisor2,Supervisor3,Supervisor4,Department2,Department3,Department4,noOfPassengers")] Trip trip)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trip).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trip);
        }

        // GET: Trips/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trip trip = db.Trips.Find(id);
            if (trip == null)
            {
                return HttpNotFound();
            }
            return View(trip);
        }

        // POST: Trips/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Trip trip = db.Trips.Find(id);
            db.Trips.Remove(trip);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bilijar.Models;
using System.Data.Entity;
using AutoMapper;
using bilijar.ViewModels;
using Microsoft.AspNet.Identity;

namespace bilijar.Controllers
{
    public class ReservationsController : Controller
    {
        private ApplicationDbContext _context;

        public ReservationsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var tabletypes = _context.TableTypes.ToList();
            var viewmodel = new NewReservationViewModel
            {
                TableTypes = tabletypes
            };
            return View(viewmodel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(NewReservationViewModel reservationVm)
        {
            if (!ModelState.IsValid)
            {
                var viewmodel = new NewReservationViewModel
                {
                    TableTypes = _context.TableTypes.ToList()
                };
                return View("New", viewmodel);

            }

            var reservation = Mapper.Map<NewReservationViewModel, Reservation>(reservationVm);

            reservation.UserId = string.IsNullOrWhiteSpace(reservationVm.UserId) ? User.Identity.GetUserId() : reservationVm.UserId;

            if (reservation.Id == 0)
                _context.Reservations.Add(reservation);
            else
            {
                var reservationInDb = _context.Reservations.FirstOrDefault(c => c.Id == reservation.Id);

                if (reservationInDb != null)
                {
                    reservationInDb.Name = reservation.Name;
                    reservationInDb.ReservationDate = reservation.ReservationDate;
                    reservationInDb.TableTypeId = reservation.TableTypeId;
                }
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        [Authorize(Roles = "CanManageReservations")]
        public ActionResult Edit(int id)
        {
            var reservation = _context.Reservations.SingleOrDefault(c => c.Id == id);

            if (reservation == null)
                return HttpNotFound();

            var viewmodel = Mapper.Map<Reservation, NewReservationViewModel>(reservation);

            viewmodel.TableTypes = _context.TableTypes.ToList();
            return View("EditForm", viewmodel);
        }

        // GET: Reservations
        [Authorize(Roles = "CanManageReservations")]
        public ViewResult Index()
        {

            return View();
        }

        [Authorize(Roles = "CanManageReservations")]
        public ActionResult Details(int id)
        {
            var reservation = _context.Reservations.Include(c=>c.TableType).SingleOrDefault(c => c.Id == id);
            if (reservation == null)
                return HttpNotFound();
            return View(reservation);
        }

    }
}
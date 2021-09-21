using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using AutoMapper;
using bilijar.Dtos;
using bilijar.Models;
using Microsoft.AspNet.Identity;

namespace bilijar.Controllers.Api
{
    public class ReservationsController : ApiController
    {
        private ApplicationDbContext _context;

        public ReservationsController()
        {
                _context = new ApplicationDbContext();
        }

        [Authorize(Roles = "CanManageReservations")]
        public IEnumerable<ReservationDto> GetReservations()
        {
            return _context.Reservations.ToList().Select(Mapper.Map<Reservation, ReservationDto>);
        }

        //public IEnumerable<ReservationDto> GetReservationsForCurrentUser()
        //{
        //    //var userId = User.Identity.GetUserId();

        //    return _context.Reservations.ToList().Select(Mapper.Map<Reservation, ReservationDto>);
        //}

        [Authorize(Roles = "CanManageReservations")]
        public IHttpActionResult GetReservation(int id)
        {
            var reservation = _context.Reservations.SingleOrDefault(c => c.Id == id);

            if (reservation == null)
                return NotFound();
            return Ok(Mapper.Map<Reservation, ReservationDto>(reservation));
        }

        [HttpPost]
        public IHttpActionResult CreateReservation(ReservationDto reservationDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var reservation = Mapper.Map<ReservationDto, Reservation>(reservationDto);
            _context.Reservations.Add(reservation);
            _context.SaveChanges();

            reservationDto.Id = reservation.Id;

            return Created(new Uri(Request.RequestUri + "/" + reservation.Id), reservationDto);

        }
        [Authorize(Roles = "CanManageReservations")]
        [HttpPut]

        public void UpdateReservation(int id, ReservationDto reservationDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            var reservationInDb = _context.Reservations.SingleOrDefault(c => c.Id == id);

            if(reservationInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            Mapper.Map(reservationDto, reservationInDb);
            
            _context.SaveChanges();

        }
        [Authorize(Roles = "CanManageReservations")]
        [HttpDelete]

        public void DeleteReservation(int id)
        {
            var reservationInDb = _context.Reservations.SingleOrDefault(c => c.Id == id);

            if (reservationInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            _context.Reservations.Remove(reservationInDb);
            _context.SaveChanges();
        }
    }
}

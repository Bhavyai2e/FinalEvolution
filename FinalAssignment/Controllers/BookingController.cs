using System.Diagnostics;
using FinalAssignment.Models;
using Microsoft.AspNetCore.Mvc;
using VehicleRepository.Vehicle;


namespace FinalAssignment.Controllers
{
    public class BookingController : Controller
    {
        private readonly Ivehiclerepository _repo;

        private readonly ILogger<BookingController> _logger;

        public BookingController(Ivehiclerepository repo, ILogger<BookingController> logger)
        {
            _repo = repo;
            _logger = logger;
        }


        public IActionResult index()
        {
            var bookings = _repo.GetAll();
            return View(bookings);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Booking booking)
        {
            if (ModelState.IsValid)
            {
                _repo.Add(booking);
                return RedirectToAction("Index");
            }
            return View(booking);
        }

        public IActionResult Edit(int id)
        {
            var booking = _repo.GetAll();
            if (booking == null)
            {
                return NotFound();
            }
            return View(booking);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Booking booking)
        {
            if (ModelState.IsValid)
            {
                _repo.Update(booking);
                return RedirectToAction("Index");
            }
            return View(booking);
        }


        public IActionResult Delete(int id)
        {
            _repo.Delete(id);
            return RedirectToAction("Index");
        }


    }
}

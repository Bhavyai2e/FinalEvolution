using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalAssignment.Models;

namespace VehicleRepository.Vehicle
{
    public class vehiclerepository : Ivehiclerepository
    {
        private static List<Booking> _bookings = new List<Booking>

        {
            new Booking
            {
                id=1,
                CustomerName = "Bhavya Paliwal",
                vehicleNumber = "AB-123",
                vehicleType= "Car",
                Make = "Toyota",
                Model = "Camry",
                Year = 2020,
                ServiceType = "General service",
                Notes = "Oil change and check properly",
                BookingDate = DateTime.Today.AddDays(-1),
                EstimateDeliveryDate = DateTime.Today.AddDays(1),
                Status = BookingStatus.scheduled
            },

            new Booking
            {
                id=2,
                CustomerName = "ABC",
                vehicleNumber = "BC-123",
                vehicleType= "Bike",
                Make = "Honda",
                Model = "splendor",
                Year = 2018,
                ServiceType = "Oil Change",
                Notes = "Check break,and oiling chain",
                BookingDate = DateTime.Today,
                EstimateDeliveryDate = DateTime.Today.AddDays(2),
                Status = BookingStatus.completed

            }
        };


        public List<Booking> GetAll()
        {
            return _bookings;
        }

        public Booking GetById(int id)
        {
            return _bookings.FirstOrDefault(x => x.id == id);
        }

        public void Add(Booking booking)
        {
            booking.id = _bookings.Count > 0 ? _bookings.Max(x => x.id) + 1 : 1;
            _bookings.Add(booking);
        }

        public void Update(Booking booking)
        {
            var existing = GetById(booking.id);

            if (existing != null)
            {
                _bookings.Remove(existing);
                _bookings.Add(booking);
            }
        }

        public void Delete(int Id)
        {
            var booking = GetById(Id);
            if (booking != null)
            {
                _bookings.Remove(booking);
            }
        }

        Booking Ivehiclerepository.GetbyID(int id)
        {
            throw new NotImplementedException();
        }
    }
    }

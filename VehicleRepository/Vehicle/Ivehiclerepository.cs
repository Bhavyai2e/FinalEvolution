using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalAssignment.Models;

namespace VehicleRepository.Vehicle
{
    public interface Ivehiclerepository
    {
        List<Booking> GetAll();

        Booking GetbyID(int id);

        void Add(Booking booking);

        void Update(Booking booking);

        void Delete(int id);
	}
}

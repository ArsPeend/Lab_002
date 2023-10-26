using Lab_002;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;




namespace Lab_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDbContex())
            {
                EFGenericRepository<Ticket> ticketRepo = new EFGenericRepository<Ticket>(context);

                IEnumerable<Ticket> tickets = ticketRepo.Get();

                foreach (Ticket p in tickets)
                {
                    Console.WriteLine($"Id: {p.Id}\t, First name:{p.FirstName}\t, Last name: {p.LastName}\t, Boarding station: {p.BoardingStation}\t,Arrival station: {p.ArrivalStation}\t, Trip number: {p.TripNumber}");
                }

            }

            using (var context = new MyDbContex())
            {

                EFGenericRepository<Trip> tripRepo = new EFGenericRepository<Trip>(context);

                IEnumerable<Trip> trips = tripRepo.Get();

                foreach (Trip p in trips)
                {
                    Console.WriteLine($"Id: {p.Id}\t, DepartureStation:{p.DepartureStation}\t, ArrivalStation: {p.ArrivalStation}");
                }


            }


            Console.ReadLine();
        }
    }
}





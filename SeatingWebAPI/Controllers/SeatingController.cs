using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CineSeatDataAccess;

namespace SeatingWebAPI.Controllers
{
    
    public class SeatingController : ApiController
    {
        [BasicAuthentication]
        public IEnumerable<CinemaHall> getAll()
        {
            using (CinemaSeatingEntities entities = new CinemaSeatingEntities())
            {
                return entities.CinemaHalls.ToList();
            }
        }
        public IEnumerable<CinemaHall> getAll(int x)
        {
            using (CinemaSeatingEntities entities = new CinemaSeatingEntities())
            {
                return entities.CinemaHalls.ToList();
            }
        }
        public Visitor Get(string ID)
        {
            using(CinemaSeatingEntities entities = new CinemaSeatingEntities())
            {
                return entities.Visitors.FirstOrDefault(e => e.VisitorID == ID);
            }
        }





    }
}

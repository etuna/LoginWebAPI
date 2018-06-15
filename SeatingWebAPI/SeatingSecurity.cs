using CineSeatDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeatingWebAPI
{
    public class SeatingSecurity
    {
        public static bool Login(string username, string Password)
        {

            using (CinemaSeatingEntities entities = new CinemaSeatingEntities())
            {
                //It returns something according to the db records
                return entities.Users.Any(User => User.username == username && User.password == Password);
            }


        }


    }
}
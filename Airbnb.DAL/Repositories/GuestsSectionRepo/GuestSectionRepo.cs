﻿using Airbnb.DAl;
using Airbnb.DAL.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL.Repositories.GuestsSectionRepo
{
    public class GuestSectionRepo : IGuestSectionRepo
    {

        private readonly AircbnbContext _context;

        public GuestSectionRepo(AircbnbContext context)
        {
            _context = context;
        }

        public Booking GetGuestBooking(Guid BookTd)
        {
            return _context.Bookings.Where(p => p.Id == BookTd).FirstOrDefault();

        }


        public IEnumerable<Booking> GetGuestBookings(string UserTd)
        {
            return _context.Bookings
                .Include(p =>p.Property)
                .Include(p=>p.User)
                .Where(p => p.UserId == UserTd).ToList();
        }

        //public User GuestProfileRead(string UserId)
        //{
        //    return _context.Users.Where(p => p.Id == UserId).FirstOrDefault(); 
        //}

        public void RemoveFromDB(Guid booking)
        {

            _context.Bookings.Where(p => p.Id == booking).ExecuteDelete();


        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}

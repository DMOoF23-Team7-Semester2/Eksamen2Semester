﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlatreKongen.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Qualifications { get; set; }
        public Membership Membership { get; set; }
        public List<Entry> Checkins { get; set; }
        //public List<Booking> Bookings { get; set; }

        // With Membership
        public Customer(string name, DateTime dateOfBirth,
            string phoneNumber, string email, string qualifications,
            Membership membership)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Email = email;
            Qualifications = qualifications;
            Membership = membership;
        }

        // Without Membership
        public Customer(string name, DateTime dateOfBirth, string phone, string email, string qualifications)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phone;
            Email = email;
            Qualifications = qualifications;
        }
    }
}
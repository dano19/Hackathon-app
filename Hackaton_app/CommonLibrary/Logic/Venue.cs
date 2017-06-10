using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibrary.Utility;

namespace CommonLibrary.Logic
{
    public class Venue
    {
        public static Database.Venue GetById(int id)
        {
            using (var db = new DatabaseContent())
                return db.Venues.FirstOrDefault(x => x.Id.Equals(id));
        }

        public static List<Database.Venue> GetList()
        {
            using (var db = new DatabaseContent())
                return db.Venues.ToList();
        }

        public static StatusResult Create(string name, int type, string description, string country, string city, string street, string phone, string email, string facebook, string website, string mapsPlaceId)
        {
            using (var db = new DatabaseContent())
            {
                var venue = new Database.Venue()
                {
                    Name = name,
                    Type = type,
                    Description = description,
                    AddressCountry = country,
                    AddressCity = city,
                    AddressStreet = street,
                    Website = website,
                    PhoneNumber = phone,
                    Email = email,
                    Facebook = facebook,
                    PlaceId = mapsPlaceId, 
                    RevisionDate = DateTime.Now
                };
                db.Venues.Add(venue);
                db.SaveChanges();
                return new StatusResult() { Message = "Venue has been added!", Success = true, ReturnId = venue.Id };
            }
        }
    }
}

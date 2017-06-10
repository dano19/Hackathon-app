using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibrary.Utility;

namespace CommonLibrary.Logic
{
    public class Comment
    {
        public static List<Database.Comment> GetList(int venueId)
        {
            using (var db = new DatabaseContent())
                return db.Comments.Where(x => x.VenueId.Equals(venueId)).ToList();
        }

        public static StatusResult Create(string comment, int rate, int venueId, int userId)
        {
            using (var db = new DatabaseContent())
            {
                db.Comments.Add(new Database.Comment(){ CommentContent = comment, Date = DateTime.Now, Rating= rate, VenueId = venueId, UserId = userId });
                db.SaveChanges();
                return new StatusResult(){ Message = "Rating and comment has been posted!", Success = true };
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CommonLibrary.Utility;

namespace CommonLibrary.Logic
{
    public class User
    {
        public static StatusResult Login(string email, string password)
        {
            password = Security.Sha256(password);
            using (var db = new DatabaseContent())
            {
                var result = db.Users.FirstOrDefault(x => x.Email.Equals(email) && x.Password.Equals(password));
                if(result == null)
                    return new StatusResult(){ Success = true, Message = "You have logged in!", ReturnId = result.Id };
                
                return new StatusResult(){ Success = false, Message = "Wrong email or password!" };
            }
        }

        public static StatusResult Register(string email, string password, string confirmPassword)
        {
            if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
                return new StatusResult(){ Success = false, Message = "Please fill in email and both password fields."};
            
            if(!password.Equals(confirmPassword))
                return new StatusResult(){ Success = false, Message = "The passwords needs to be the same!"};
            
            using (var db = new DatabaseContent())
            {
                var user = new Database.User(){ Email = email, Password = Security.Sha256(password), };
                db.SaveChanges();
                return new StatusResult(){ Success = true, Message = "Your account has been registered. You can log in now.", ReturnId = user.Id };
            }
        }
    }
}

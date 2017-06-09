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
                    return new StatusResult(){ Success = true, Message = "Zostałeś zalogowany!", ReturnId = result.Id };
                
                return new StatusResult(){ Success = false, Message = "Zły email lub hasło!" };
            }
        }

        public static StatusResult Register(string email, string password, string confirmPassword)
        {
            if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
                return new StatusResult(){ Success = false, Message = "Proszę podać email, hasło oraz potwierdzenie hasła."};
            
            if(!password.Equals(confirmPassword))
                return new StatusResult(){ Success = false, Message = "Hasła muszą być takie same!"};
            
            using (var db = new DatabaseContent())
            {
                var user = new Database.User(){ Email = email, Password = Security.Sha256(password), };
                db.SaveChanges();
                return new StatusResult(){ Success = true, Message = "Twoje konto zostało zarejestrowane. Zostałeś zalogowany automatycznie", ReturnId = user.Id };
            }
        }
    }
}

using Save__Your__Apps.Connection;
using Save__Your__Apps.Models;

namespace Save__Your__Apps.Work
{
    public class User_W
    {
        public static bool Authorization(string mail, string pass)
        {//true - пользователь есть
            using (User_C db = new User_C())
            {
                User usr = db.Users
                    .Where(b => b.Email == mail)
                    .Where(b => b.Password == pass)
                    .FirstOrDefault();

                if (usr == null)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool CheckingMail(string mail)
        {//true - пользователь уже есть
            using (User_C db = new User_C())
            {
                User usr = db.Users
                    .Where(b => b.Email == mail)
                    .FirstOrDefault();

                if (usr == null)
                {
                    return false;
                }
            }

            return true;
        }
        public static int MailId(string mail)
        {
            using (User_C db = new User_C())
            {
                User usr = db.Users
                .Where(b => b.Email == mail)
                .FirstOrDefault();

                if (usr == null)
                {
                    return -1;
                }
                return usr.Id;
            }
        }
        public static void AddUser(User usr)
        {
            using (User_C db = new User_C())
            {
                User newUser = usr;
                db.Add(newUser);
                db.SaveChanges();
            }
        }
    }
}

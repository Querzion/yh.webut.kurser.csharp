//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Models
//{
//    internal class UserService
//    {
//        // Field
//        private readonly List<User> _users;
//        // Constructor
//        public UserService()
//        {
//            _users = new List<User>();
//        }
//        // Methods
//        public void AddUser(User user)
//        {
//            _users.Add(user);
//        }
//        public IEnumerable<User> GetAll()
//        {
//            return _users;
//        }
//        public IEnumerable<User> GetOne(int id)
//        {
//            return _users.FirstOrDefault(x => x.Id == id);
//        }
//    }
//}

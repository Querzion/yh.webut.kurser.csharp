using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_005_classes.Models
{
    internal class UserService
    {
        // Only use readonly on variables that isn't going to change.
        // It's not really that optimal to use it on lists and arrays.
        //private readonly TokenGenerator _tokenGenerator;


        private List<User> _users;

        // Constructor
        public UserService()
        {
            _users = new List<User>();

            //_tokenGenerator = new TokenGenerator();
        }

        // This is a shorter version of the constructor.
        private List<User> _usersList = [];

    }
}

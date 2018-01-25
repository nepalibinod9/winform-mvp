using System.Collections.Generic;

namespace PassiveView.Models.User
{
    public class UserRepository : IUserRepository
    {
        #region Private Data
        private User _user;
        private List<User> _users;
        #endregion

        #region Constructor

        public UserRepository()
        {
            _users = new List<User>();
        }
        #endregion

        #region IUserRepository Implementation
        public bool CreateUser(string firstName, string lastName)
        {
            _user = new User { FirstName = firstName, LastName = lastName };
            _users.Add(_user);
            return true;
        }

        public User GetUser()
        {
            return _user;
        }

        public int GetCreatedUsersNumber()
        {
            return _users.Count;
        }

        #endregion
    }
}

namespace PassiveView.Models.User
{
    /// <summary>
    /// An interface for a class capable of creating user model
    /// </summary>
    public interface IUserRepository
    {
        #region Methods
        /// <summary>
        /// Create user
        /// </summary>
        /// <param name="firstName">User first name</param>
        /// <param name="lastName">User last name</param>
        bool CreateUser(string firstName, string lastName);

        /// <summary>
        /// Gets the created user
        /// </summary>
        /// <returns>Created user</returns>
        User GetUser();

        int GetCreatedUsersNumber();

        #endregion
    }
}

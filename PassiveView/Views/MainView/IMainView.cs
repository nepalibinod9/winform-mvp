using PassiveView.Models.User;

namespace PassiveView.Views.MainView
{
    /// <summary>
    /// An interface for a class capable of getting and setting the view components
    /// </summary>
    public interface IMainView
    {
        #region Properties
        /// <summary>
        /// Gets  user first name
        /// </summary>
        string FirstName { get; }

        /// <summary>
        /// Gets user last name
        /// </summary>
        string LastName { get; }
        #endregion

        #region Methods
        /// <summary>
        /// Sets the  status label
        /// </summary>
        /// <param name="status">Status</param>
        void SetCreatedStatus(string status);

        /// <summary>
        /// Sets the number of created users label
        /// </summary>
        /// <param name="nrofCreatedUsers">Number of created users</param>
        void SetNumberOfCreatedUsers(int nrofCreatedUsers);

        /// <summary>
        /// Add user to the list box
        /// </summary>
        /// <param name="user">Created Users</param>
        void AddUserToListBox(User user);

        void ClearListBox();

        #endregion
    }
}

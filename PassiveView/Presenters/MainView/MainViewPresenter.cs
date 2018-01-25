using PassiveView.Models.User;
using PassiveView.Views.MainView;

namespace PassiveView.Presenters.MainView
{
    public class MainViewPresenter : IMainViewPresenter
    {
        private readonly IUserRepository _userRepository;
        private IMainView _mainView;

        #region Constructor

        public MainViewPresenter(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        #endregion

        #region IMainViewPresenter
        public void SetView(IMainView mainView)
        {
            _mainView = mainView;
        }

        public void OnCreateUserButtonClick()
        {
            bool isCreated = _userRepository.CreateUser(_mainView.FirstName, _mainView.LastName);

            _mainView.AddUserToListBox(_userRepository.GetUser());

            _mainView.SetCreatedStatus(isCreated ? "Created" : "not created");

            _mainView.SetNumberOfCreatedUsers(_userRepository.GetCreatedUsersNumber());
        }

        public void OnClearAllButtonClick()
        {
            _mainView.ClearListBox();
        }
    }
    #endregion
}

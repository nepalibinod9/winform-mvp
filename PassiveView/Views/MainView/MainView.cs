using PassiveView.Models.User;
using PassiveView.Presenters.MainView;
using System.Windows.Forms;

namespace PassiveView.Views.MainView
{
    public partial class MainView : Form, IMainView
    {
        #region Private Data

        private readonly IMainViewPresenter _mainViewPresenter;
        #endregion

        #region Constructor
        public MainView()
        {
            InitializeComponent();
            _mainViewPresenter = new MainViewPresenter(new UserRepository());
            _mainViewPresenter.SetView(this);
        }
        #endregion

        #region Private Button Click Handlers Methods
        private void btnCreateUser_Click(object sender, System.EventArgs e)
        {
            _mainViewPresenter.OnCreateUserButtonClick();
        }

        private void btnClearAllUsers_Click(object sender, System.EventArgs e)
        {
            _mainViewPresenter.OnClearAllButtonClick();
        }
        #endregion

        #region IMainView Implementation
        public string FirstName => tbxFirstName.Text;
        public string LastName => tbxLastName.Text;

        public void SetCreatedStatus(string status)
        {
            lblStatus.Text = status;
        }

        public void SetNumberOfCreatedUsers(int nrofCreatedUsers)
        {
            lblNrOfCreatedUsers.Text = nrofCreatedUsers.ToString();
        }

        public void AddUserToListBox(User user)
        {
            lstbxCreatedUsers.Items.Add(user.FirstName + " " + user.LastName + " is created...");
        }

        public void ClearListBox()
        {
            lstbxCreatedUsers.Items.Clear();
        }

        #endregion
    }
}

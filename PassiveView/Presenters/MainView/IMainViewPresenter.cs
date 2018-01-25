using PassiveView.Views.MainView;

namespace PassiveView.Presenters.MainView
{
    /// <summary>
    /// An interface for a class capable of providing main view actions
    /// </summary>
    public interface IMainViewPresenter
    {
        #region Methods
        /// <summary>
        /// Sets the main view
        /// </summary>
        /// <param name="mainView">Reference to the main view</param>
        void SetView(IMainView mainView);

        /// <summary>
        /// Forward the creating user action
        /// </summary>
        void OnCreateUserButtonClick();

        /// <summary>
        /// Forward the clear action
        /// </summary>
        void OnClearAllButtonClick();

        #endregion
    }
}

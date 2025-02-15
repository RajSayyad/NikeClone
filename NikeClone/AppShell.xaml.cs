using NikeClone.MVVM.ViewModels;

namespace NikeClone
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            BindingContext = new GlobalViewModel();
        }
    }
}

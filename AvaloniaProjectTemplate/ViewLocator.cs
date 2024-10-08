using Andromeda.ROOTNAMESPACE.Avalonia.ViewModels;
using Andromeda.ROOTNAMESPACE.Avalonia.Views;
using HanumanInstitute.MvvmDialogs.Avalonia;

namespace Andromeda.ROOTNAMESPACE.Avalonia
{
    public class ViewLocator : StrongViewLocator
    {
        public ViewLocator()
        {
            Register<MainViewModel, MainView, MainWindow>();
        }
    }
}
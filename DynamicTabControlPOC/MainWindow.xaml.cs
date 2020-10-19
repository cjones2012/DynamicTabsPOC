using DynamicTabControlPOC.ViewModels;
using ReactiveUI;
using System.Reactive.Disposables;

namespace DynamicTabControlPOC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ReactiveWindow<MainViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new MainViewModel();

            this.WhenActivated(disposables =>
            {

            });
        }
    }
}

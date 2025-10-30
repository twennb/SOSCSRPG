using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Engine.Models;
using Engine.ViewModels;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameSession _gameSession; // declare the private _gameSession variable

        public MainWindow()
        {
            InitializeComponent();

            _gameSession = new GameSession(); // instantiate the new GameSession object into _gameSession

            DataContext = _gameSession; // tells the XAML file to use this data
        }
    }
}
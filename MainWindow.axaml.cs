using Avalonia.Controls;

namespace AniLib;

public partial class MainWindow : Window{
    public MainWindow(){
        this.MinWidth = 720;
        this.MinHeight = 480;
        this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        InitializeComponent();
    }
}
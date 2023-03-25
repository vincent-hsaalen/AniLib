using AniLib.windows;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AniLib.custom_controls;

public partial class NavigationBar : UserControl{
    public NavigationBar(){
        InitializeComponent();
    }

    private void InitializeComponent(){
        AvaloniaXamlLoader.Load(this);
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e){
        MainWindow mainWindow = (MainWindow) ((IClassicDesktopStyleApplicationLifetime) Application.Current.ApplicationLifetime).MainWindow;
        SearchWindow searchWindow = new SearchWindow();
        mainWindow.Content = searchWindow.Content;
    }
}
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

    private void HomeButton_OnClick(object? sender, RoutedEventArgs e){
        MainWindow mw = new();
        MainWindow mainWindow = (MainWindow) ((IClassicDesktopStyleApplicationLifetime) Application.Current.ApplicationLifetime).MainWindow;
        // check if the current window is the MainWindow and if it is, do nothing
        if (mainWindow.Content == mw.Content){
        }
        else {
            mainWindow.Content = mw.Content;
        }
    }

    private void SearchButton_OnClick(object? sender, RoutedEventArgs e){
        MainWindow mainWindow = (MainWindow) ((IClassicDesktopStyleApplicationLifetime) Application.Current.ApplicationLifetime).MainWindow;
        SearchWindow searchWindow = new();
        mainWindow.Content = searchWindow.Content;
    }

    private void LibraryButton_OnClick(object? sender, RoutedEventArgs e){
        MainWindow mainWindow = (MainWindow) ((IClassicDesktopStyleApplicationLifetime) Application.Current.ApplicationLifetime).MainWindow;
        LibraryWindow libraryWindow = new();
        mainWindow.Content = libraryWindow.Content;
    }
}
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AniLib.windows;

public partial class LibraryWindow : Window{
    public LibraryWindow(){
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent(){
        AvaloniaXamlLoader.Load(this);
    }
}
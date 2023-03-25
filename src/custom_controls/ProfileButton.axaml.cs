using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AniLib.custom_controls;

public partial class ProfileButton : UserControl{
    public ProfileButton(){
        InitializeComponent();
    }

    private void InitializeComponent(){
        AvaloniaXamlLoader.Load(this);
    }
}
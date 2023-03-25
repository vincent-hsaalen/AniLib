using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AniLib.custom_controls;

public partial class AnimeCard : UserControl{
    public AnimeCard(){
        InitializeComponent();
    }

    private void InitializeComponent(){
        AvaloniaXamlLoader.Load(this);
    }
}
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO.Enumeration;
using System.Threading.Tasks;
using AniLib.classes;
using AniLib.custom_controls;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Markup.Xaml.Templates;
using Avalonia.Media;

namespace AniLib.windows;

public partial class SearchWindow : Window{
    public SearchWindow(){
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent(){
        AvaloniaXamlLoader.Load(this);
    }

    private void SearchButton_OnClick(object? sender, RoutedEventArgs e){
        TextBox textBox = this.FindControl<TextBox>("searchBar");
        AnimeCard card = this.FindControl<AnimeCard>("anicard");
        card.titleLabel.Text = textBox.Text;
    }
}
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AniLib.classes;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using JikanDotNet;

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

    private async void Button_OnClick(object? sender, RoutedEventArgs e){
        
        List<string> titles = new List<string>();
        
        JikanAPI jikan = new JikanAPI();
        var animes = await jikan.SearchAnime(searchBar.Text);
        foreach (Anime anime in animes){
            foreach(TitleEntry title in anime.Titles){
                titles.Add(title.Title);
            }
        }

        testLabel.Content = titles.First();
    }
}
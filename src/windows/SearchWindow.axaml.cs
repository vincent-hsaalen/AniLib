using System.Collections.Generic;
using AniLib.classes;
using AniLib.custom_controls;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using JikanDotNet.Exceptions;
using log4net;

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
        JikanAPI jikan = new JikanAPI();
        List<string> titles = new List<string>();
        
        // find/get control search bar
        var sb = this.FindControl<TextBox>("searchBar");
        // get text from search bar
        var query = sb.Text;
        // search for anime
        try{
            titles = await jikan.GetAnimeTitles(query);
        }
        catch (JikanRequestException ex){
            ILog log = LogManager.GetLogger(typeof(SearchWindow));
            log.Error(ex);
        }
        // find/get control list box
        var lb = this.FindControl<ListBox>("resultsListBox");
        // add AnimeCards with titles to list box
        
        // foreach (var title in titles){
        //     foreach (ListBoxItem item in lb.Items){
        //         ListBoxItem.
        //     }
        
        
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using JikanDotNet;

namespace AniLib.classes;

public class JikanAPI{
    private IJikan jikan = new Jikan();

    public JikanAPI(){
        
    }
    
    /// <summary>
    /// Searches for anime with string query
    /// </summary>
    /// <param name="query">anime name</param>
    /// <returns>list of anime object</returns>
    public async Task<List<Anime>> SearchAnime(string query){
        var result = await jikan.SearchAnimeAsync(query);
        List<Anime> animeList = new List<Anime>();
        foreach (var anime in result.Data){
            animeList.Add(anime);
        }

        return animeList;
    }
    
    // print all anime titles
    public async Task<List<string>> GetAnimeTitles(string query){
        var animes = await SearchAnime(query);
        List<string> titles = new List<string>();
        foreach(Anime anime in animes){
            foreach(TitleEntry title in anime.Titles){
                titles.Add(title.Title);
            }
        }
        return titles;
    }
}
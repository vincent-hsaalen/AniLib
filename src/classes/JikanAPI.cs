using System.Collections.Generic;
using System.Threading.Tasks;
using JikanDotNet;
using MongoDB;

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
    
    
    

}
using System.Collections.Generic;
using System.Threading.Tasks;
using AniLib.custom_controls;
using JikanDotNet;

namespace AniLib.classes;

public class JikanAPI{
    
    private IJikan jikan = new Jikan();

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
    
    /* Functions to get anime data */
    
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
    
    // get result count
    public async Task<int> GetAnimeCount(string query){
        var animes = await SearchAnime(query);
        return animes.Count;
    }
    
public async Task<List<string>> GetAnimeSynopsis(string query){
        var animes = await SearchAnime(query);
        List<string> synopsis = new List<string>();
        foreach(Anime anime in animes){
            synopsis.Add(anime.Synopsis);
        }
        return synopsis;
    }

    public async Task<List<JikanDotNet.Image>> GetAnimeImages(string query){
        var animes = await SearchAnime(query);
        List<JikanDotNet.Image> images = new List<JikanDotNet.Image>();
        foreach(Anime anime in animes){
            images.Add(anime.Images.JPG);
        }
        return images;
    }
    
    public async Task<List<string>> GetAnimeEpisodes(string query){
        var animes = await SearchAnime(query);
        List<string> episodes = new List<string>();
        foreach(Anime anime in animes){
            episodes.Add(anime.Episodes.ToString());
        }
        return episodes;
    }
    
    public async Task<List<string>> GetAnimeGenres(string query){
        var animes = await SearchAnime(query);
        List<string> genres = new List<string>();
        foreach(Anime anime in animes){
            foreach (var genre in anime.Genres){
                genres.Add(genre.Name);
            }
        }
        return genres;
    }
    
    public async Task<List<string>> GetAnimeScores(string query){
        var animes = await SearchAnime(query);
        List<string> scores = new List<string>();
        foreach(Anime anime in animes){
            scores.Add(anime.Score.ToString());
        }
        return scores;
    }
}
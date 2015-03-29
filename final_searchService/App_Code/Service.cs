using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{

    ShowTrackerEntities db = new ShowTrackerEntities();
    
    public List<string> GetArtists()
    {
        var arts = from a in db.Artists
                   orderby a.ArtistName
                   select new { a.ArtistName };
        List<string> artists = new List<string>();
        foreach (var a in arts)
        {
            artists.Add(a.ArtistName);
        }
        return artists;
    }
    public List<string> GetVenues()
    {
        var vens = from a in db.Venues
                   orderby a.VenueName
                   select new { a.VenueName };
        List<string> venues = new List<string>();
        foreach (var a in vens)
        {
            venues.Add(a.VenueName);
        }
        return venues;
    }
    public List<string> GetGenres()
    {
        var vens = from a in db.Genres
                   orderby a.GenreName
                   select new { a.GenreName };
        List<string> genres = new List<string>();
        foreach (var a in vens)
        {
            genres.Add(a.GenreName);
        }
        return genres;
    }
}

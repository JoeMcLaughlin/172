using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AddShowService" in code, svc and config file together.
public class AddShowService : IAddShowService
{
    ShowTrackerEntities db = new ShowTrackerEntities();

    public bool AddArtist(Artist a)
    {
        bool result = true;
        try
        {
            Artist au = new Artist();
            au.ArtistName = a.ArtistName;
            db.Artists.Add(au);
            db.SaveChanges();
        }
        catch
        {
            result = false;
        }
        return result;
    }   
    public bool AddShow(Show s, Artist a, ShowDetail Details)
    {
        bool result = true;
        /*try
        {*/
            Show sw = new Show();
            sw.ShowName = s.ShowName;   
            sw.VenueKey = s.VenueKey;
            sw.ShowDate = s.ShowDate;
            sw.ShowTime = s.ShowTime;
            sw.ShowTicketInfo = s.ShowTicketInfo;
            sw.ShowDateEntered = DateTime.Now;
            Artist artist = new Artist();
            artist.ArtistName = a.ArtistName;
            artist.ArtistEmail = a.ArtistEmail;
            artist.ArtistWebPage = a.ArtistWebPage;
            artist.ArtistDateEntered = a.ArtistDateEntered;
            //sw.Artists.Add(artist);
            ShowDetail det = new ShowDetail();
            det.ShowDetailAdditional = Details.ShowDetailAdditional;
            det.Show = sw;
            det.ArtistKey = a.ArtistKey;
            det.ShowDetailArtistStartTime = Details.ShowDetailArtistStartTime;
            db.Artists.Add(artist);
            db.Shows.Add(sw);
            db.ShowDetails.Add(det);

            //sw.ShowDateEntered = DateTime.Now;

            
            db.SaveChanges();

        /*}
        catch
        {
            result = false;

        }*/
        return result;
    }

    public bool AddDetails(ShowDetail r)
    {
        bool result = true;
        try
        {
            int key;
            ShowDetail rev = new ShowDetail();
            if (r.ShowDetailKey == 0)
            {
                key = db.ShowDetails.Max(b => b.ShowDetailKey);

            }
            else
            {
                key = r.ShowDetailKey;

            }
            rev.ShowKey = r.ShowKey;
            rev.ShowDetailKey = key;
           // rev.ReviewTitle = r.ReviewTitle;
            //rev.ReviewDate = r.ReviewDate;
            //rev.ReviewRating = r.ReviewRating;
            //rev.ReviewText = r.ReviewText;

            db.ShowDetails.Add(rev);
            db.SaveChanges();

        }
        catch
        {
            result = false;

        }
        return result;
    }
    public List<string> GetVenues()
    {
        var shw = from c in db.Shows
                   orderby c.ShowKey
                   select new { c.ShowName };
        List<string> details = new List<string>();
        foreach (var c in shw)
        {
            details.Add(c.ShowName);
        }
        return details;
    }
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
    public List<Show> GetShows()
    {
        var tls = from b in db.Shows
                  orderby b.ShowName
                  select b;
        List<Show> shows = new List<Show>();
        foreach (var t in tls)
        {
            Show b = new Show();
            b.ShowName = t.ShowName;
            b.ShowKey = t.ShowKey;
            b.ShowDateEntered = t.ShowDateEntered;
            b.ShowDate = t.ShowDate;
            shows.Add(b);

        }
        return shows;

    }

}

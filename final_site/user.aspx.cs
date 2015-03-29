using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        
        userServiceNS.IService addService = new userServiceNS.ServiceClient();

        ddlArtist.Items.Clear();
        ddlVenue.Items.Clear();
        for (int i = 0; i < addService.GetArtists().Length; i++)
        {
            ddlArtist.Items.Add(addService.GetArtists()[i]);
        }
        for (int i = 0; i < addService.GetVenues().Length; i++)
        {
            ddlVenue.Items.Add(addService.GetVenues()[i]);
        }
        for (int i = 0; i < addService.GetGenres().Length; i++)
        {
            ddlGenre.Items.Add(addService.GetGenres()[i]);
        }

      
        if (artist.Checked == true) { artists.Attributes["class"] = "visible"; venue.Checked = false; artist.Checked = false; genres.Attributes["class"] = "invisible"; venues.Attributes["class"] = "invisible"; }
        else if (venue.Checked == true) { venues.Attributes["class"] = "visible"; artist.Checked = false; venue.Checked = false; genres.Attributes["class"] = "invisible"; artists.Attributes["class"] = "invisible"; }
        else if (genre.Checked == true) { genres.Attributes["class"] = "visible"; genre.Checked = true; artist.Checked = false; venue.Checked = false; venues.Attributes["class"] = "invisible";  artists.Attributes["class"] = "invisible"; }

        else { artists.Attributes["class"] = "invisible"; venues.Attributes["class"] = "invisible"; }
       

        
        
    }
}
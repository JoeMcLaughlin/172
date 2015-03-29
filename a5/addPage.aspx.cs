using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class addPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        venueRegistrationServiceNS.IVenueRegistrationService vs = new venueRegistrationServiceNS.VenueRegistrationServiceClient();
        addShowServiceNS.AddShowServiceClient addService = new addShowServiceNS.AddShowServiceClient();

        //TimeSpan usersDate = TimeSpan.Parse("10:02:02");

        //txtSTime.Text = usersDate.ToString();

        ddlArtist.Items.Clear();
        ddlSName.Items.Clear();
        for (int i = 0; i < addService.GetArtists().Length; i++)
        {
            ddlArtist.Items.Add(addService.GetArtists()[i]);
        }

        for (int i = 0; i < addService.GetShows().Length; i++)
        {
            
            ddlSName.Items.Add(addService.GetShows()[i].ShowName);
        }

    }
    protected void btnSave_Click(object sender, EventArgs e)
    {


        venueRegistrationServiceNS.IVenueRegistrationService vs = new venueRegistrationServiceNS.VenueRegistrationServiceClient();
        addShowServiceNS.AddShowServiceClient addService = new addShowServiceNS.AddShowServiceClient();
        addShowServiceNS.Artist artistsService = new addShowServiceNS.Artist();
        addShowServiceNS.Genre genreService = new addShowServiceNS.Genre();
        addShowServiceNS.Show showService = new addShowServiceNS.Show();
        addShowServiceNS.ShowDetail detailsService = new addShowServiceNS.ShowDetail();
        
/*      name artist
        email
        web

        name show
        ticket info
        time 
*/
        artistsService.ArtistName = txtArtist.Text;
        artistsService.ArtistEmail = txtAEmail.Text;
        artistsService.ArtistWebPage = txtAWebpage.Text;

        showService.ShowName = txtSName.Text;
        showService.ShowTicketInfo = txtSTicket.Text;
        TimeSpan usersDate = TimeSpan.Parse(txtSTime.Text);

        showService.ShowTime = usersDate;

        bool result = addService.AddShow(showService, artistsService, detailsService);

        if (result)
        {
            lbResult.Text = "You have successfully registered";
        }
        else
        {
            lbResult.Text = "Registration Failed";
        }
        

        
        
    }
}
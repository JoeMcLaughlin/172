using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        venueRegistrationServiceNS.IVenueRegistrationService vs = new venueRegistrationServiceNS.VenueRegistrationServiceClient();
        venueRegistrationServiceNS.VenueLite venLite = new venueRegistrationServiceNS.VenueLite();

        venLite.UserName = txtUserName.Text ;
        venLite.Password = txtPassword.Text;
        venLite.VenueAddress = txtAddress.Text;
        venLite.VenueCity = txtCity.Text;
        venLite.VenueName = txtVenueName.Text;
        venLite.VenuePhone = txtPhone.Text;
        venLite.VenueState = txtState.Text;
        venLite.VenueZip = txtZip.Text;

        bool result = vs.RegisterVenue(venLite);

        if (result)
        {
            lblResult.Text = "You have successfully registered";
        }
        else
        {
            lblResult.Text = "Registration Failed";
        }

    }
}
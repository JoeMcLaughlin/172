using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    ShowTrackerEntities showentities = new ShowTrackerEntities();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            var artists = from Artist in showentities.Artists
                          orderby Artist.ArtistName
                          select new { Artist.ArtistName, Artist.ArtistKey };
            DropDownList1.DataSource = artists.ToList();
            DropDownList1.DataTextField = "ArtistName";
            DropDownList1.DataValueField = "ArtistKey";
            DropDownList1.DataBind();
        }
        
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        var show = from Show in showentities.Shows
                  from Artist in showentities.Artists
                  from ShowDetail in showentities.ShowDetails
                  where Artist.ArtistName == DropDownList1.SelectedItem.Text
                     select new {Show.ShowName, ShowDetail.ShowDetailArtistStartTime };
        GridView1.DataSource = show.ToList();
        GridView1.DataBind();


        
    }
}
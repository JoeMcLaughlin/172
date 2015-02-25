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
            var artist = from Artist in showentities.Artists
                          orderby Artist.ArtistName
                          select new { Artist.ArtistName, Artist.ArtistKey };
            DropDownList1.DataSource = artist.ToList();
            DropDownList1.DataTextField = "ArtistName";
            DropDownList1.DataValueField = "ArtistKey";
             
            DropDownList1.DataBind();
        }
        
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        var shows = from Show in showentities.Shows
                    from a in showentities.Artists
                    from ShowDetail in showentities.ShowDetails
                    where a.ArtistName == DropDownList1.SelectedItem.Text
                    where ShowDetail.ArtistKey == a.ArtistKey
                    where ShowDetail.ShowKey == Show.ShowKey
                    select new { Show.ShowName, ShowDetail.ShowDetailArtistStartTime, a.ArtistName };
        GridView1.DataSource = shows.ToList();
        GridView1.DataBind();


        
    }
}
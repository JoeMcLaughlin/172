using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Timer2_Tick(object sender, EventArgs e)
    {

        timerMinutes.IminutesSerivce minutes = new timerMinutes.IminutesSerivceClient();
        DateTime myBday = new DateTime(1985, 11, 21);
        double diff = minutes.DoWork(myBday);

        Label1.Text = "There are " + diff + " minutes since my birth";
    }
} 
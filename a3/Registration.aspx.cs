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
        //instantiate classes
        ShowTrackerEntities ste = new ShowTrackerEntities();
        //using (BookReviewDbEntities brde = new BookReviewDbEntities())
        //{
        KeyCode k = new KeyCode();
        int seed = k.GetKeyCode(); //get the seed
        PasswordHash phash = new PasswordHash();

        //brde.Database.Connection.Open();
        // the rest

        //try // try the code for errors
        //{
        //get the hashed password
        byte[] pass = phash.HashIt(txtConfirm.Text, seed.ToString());

        //assignthe values tot the fields of the Reviewer Class
        FanLogin fanLogin = new FanLogin();
        Fan fan = new Fan(); 
        fan.FanName = txtFirstName.Text;
        //fan.FanLastName = txtLastName.Text;
        fanLogin.FanLoginUserName = txtFanName.Text;
        fan.FanEmail = txtEmail.Text;
        //fan.ReviewerKeyCode = seed;
        fanLogin.FanLoginRandom = seed;
        fanLogin.FanLoginPasswordPlain = txtConfirm.Text;
        fanLogin.FanLoginHashed = pass;
        fanLogin.FanLoginDateAdded = DateTime.Now;

        //save changes

        ste.Fans.Add(fan);
        ste.FanLogins.Add(fanLogin);
        ste.SaveChanges();
        lblErrorSuccess.Text = "You were successfully registered;";


        //}catch (Exception ex)
        //{
        //lblErrorSuccess.Text = ex.Message;
        //}
        //}
    }
}
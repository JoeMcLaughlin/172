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
        BookReviewDbEntities1 brde = new BookReviewDbEntities1();
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
            Reviewer rev = new Reviewer();
            rev.ReviewerFirstName = txtFirstName.Text;
            rev.ReviewerLastName = txtLastName.Text;
            rev.ReviewerUserName = txtUserName.Text;
            rev.ReviewerEmail = txtEmail.Text;
            rev.ReviewerKeyCode = seed;
            rev.ReviewPlainPassword = txtConfirm.Text;
            rev.ReviewerHashedPass = pass;
            rev.ReviewerDateEntered = DateTime.Now;

            //save changes
            brde.Reviewers.Add(rev);
            brde.SaveChanges();
            lblErrorSuccess.Text = "You were successfully registered;";


        //}catch (Exception ex)
        //{
            //lblErrorSuccess.Text = ex.Message;
        //}
        //}
    }
}
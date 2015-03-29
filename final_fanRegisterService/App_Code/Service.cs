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


    public bool RegisterFan(FanReg f)
    {
        
        bool result = true;
        //try
       // { 
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
        byte[] pass = phash.HashIt(f.FanLoginPasswordPlain, seed.ToString());

        //assignthe values tot the fields of the Reviewer Class
        
        Fan fan = new Fan();
        FanLogin fanLogin = new FanLogin();

        fan.FanName = f.FanName;
        fan.FanEmail = f.FanEmail;

        fanLogin.FanKey = fan.FanKey;
        fanLogin.FanLoginUserName = f.FanLoginUserName;
        fanLogin.FanLoginPasswordPlain = f.FanLoginPasswordPlain;
        fanLogin.FanLoginRandom = seed;
        
        
        fanLogin.Fan = fan;
        fanLogin.FanLoginHashed = pass;        //fanLogin.FanKey = f.Fan.FanKey;
        fanLogin.FanLoginDateAdded = DateTime.Now;
        //fan.FanLastName = txtLastName.Text;
     
        
        //fan.ReviewerKeyCode = seed;
        
        
        //save changes

        ste.Fans.Add(fan);
        ste.SaveChanges();
        ste.FanLogins.Add(fanLogin);
        ste.SaveChanges();
        //}
        /*catch
        {
            result = false;
        }*/
        
        return result;

    }

    public int FanLogin(string userName, string Password)
    {
        int id = 0;

        LoginClass lc = new LoginClass(Password, userName);
        id = lc.ValidateLogin();

        return id;
    }
    
}

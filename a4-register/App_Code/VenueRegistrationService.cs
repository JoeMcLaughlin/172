using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "VenueRegistrationService" in code, svc and config file together.
public class VenueRegistrationService : IVenueRegistrationService
{
    ShowTrackerEntities db = new ShowTrackerEntities();

    public bool RegisterVenue(VenueLite v)
    {
        
        bool result = true;
        try
        {            

            PasswordHash ph = new PasswordHash();
            KeyCode kc = new KeyCode();
            int code = kc.GetKeyCode();

            byte[] hashed = ph.HashIt(v.Password, code.ToString());

            Venue ven = new Venue();
            VenueLogin log = new VenueLogin();

            ven.VenueName = v.VenueName;
            ven.VenueAddress = v.VenueAddress;
            ven.VenueCity = v.VenueCity;
            ven.VenueState = v.VenueState;
            ven.VenueZipCode = v.VenueZip;
            ven.VenuePhone = v.VenuePhone;
            

            
            log.VenueLoginUserName = v.UserName;
            log.VenueLoginPasswordPlain = v.Password;
            log.VenueLoginRandom = code;
            log.Venue = ven;
            log.VenueLoginHashed = hashed;
            log.VenueLoginDateAdded = DateTime.Now;





            /*db.Venues.Add(ven);
            var venKey = from j in db.Venues

                         where j.VenueName.Equals(v.VenueName)
                         select new { log.VenueKey };
            

            int venueKey = Convert.ToInt32(venKey);
            ven.VenueAgeRestriction = venueKey;*/

            db.Venues.Add(ven);
            db.SaveChanges();

            //log.VenueKey = venueKey;
            
            db.VenueLogins.Add(log);
            db.SaveChanges();
            
            
        }
        catch
        {
            result = false;
        }
        return result;

    }

    public int VenueLogin(string userName, string Password)
    {
        int id = 0;

        LoginClass lc = new LoginClass(Password, userName);
        id = lc.ValidateLogin();

        return id;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IVenueRegistrationService" in both code and config file together.
[ServiceContract]
public interface IVenueRegistrationService
{
    [OperationContract]
    bool RegisterVenue(VenueLite r);//Changed name register and lite

    [OperationContract]
    int VenueLogin(string UserName, string Password); // changed name
}
public class VenueLite
{
    //[DataMember]
    //public string LastName { set; get; }


    [DataMember]
    public string UserName { set; get; }
      
    [DataMember]
    public string Password { set; get; }

    [DataMember]
    public string VenueName { set; get; }

    [DataMember]
    public string VenueAddress { set; get; }
    
    [DataMember]
    public string VenueCity { set; get; }

    [DataMember]
    public string VenueState { set; get; }

    [DataMember]
    public string VenueZip { set; get; }

    [DataMember]
    public string VenuePhone { set; get; }
    




    
}

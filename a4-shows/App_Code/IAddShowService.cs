﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAddShowService" in both code and config file together.
[ServiceContract]
public interface IAddShowService
{
    [OperationContract]
    bool AddArtist(Artist a);

    [OperationContract]
    bool AddShow(Show b, Artist a, ShowDetail Venue);

    [OperationContract]
    bool AddDetails(ShowDetail r);

    [OperationContract]
    List<string> GetVenues();

    [OperationContract]
    List<string> GetArtists();

    [OperationContract]
    List<Show> GetShows();

}

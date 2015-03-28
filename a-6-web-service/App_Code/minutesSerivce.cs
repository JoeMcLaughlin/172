using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "minutesSerivce" in code, svc and config file together.
public class minutesSerivce : IminutesSerivce
{
  
    public Double DoWork(DateTime userIn)
	{
        
        DateTime now = DateTime.Now;
        DateTime userData = userIn;
        TimeSpan differenceTime = now - userData;
        double minutes = differenceTime.TotalMinutes;
        if (minutes > 0) { return minutes; }
        else { return minutes*(-1); }
        
	}
}

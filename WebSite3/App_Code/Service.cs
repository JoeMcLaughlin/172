using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	public int DoWork(DateTime time)
	{
        int userTime = time.Minute;
        int now = Int32.Parse(DateTime.Now.ToShortTimeString());

        return now;
	}
}

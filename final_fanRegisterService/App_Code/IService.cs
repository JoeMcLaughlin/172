using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
    [OperationContract]
    bool RegisterFan(FanReg r);//Changed name register and lite

    [OperationContract]
    int FanLogin(string UserName, string Password); // changed name

	// TODO: Add your service operations here
}

// Use a data contract as illustrated in the sample below to add composite types to service operations.
public class FanReg
{
    [DataMember]
    public string FanName { get; set; }
    [DataMember]
    public string FanEmail { get; set; }
    [DataMember]
    public string FanLoginUserName { get; set; }
    [DataMember]
    public string FanLoginPasswordPlain { get; set; }


}



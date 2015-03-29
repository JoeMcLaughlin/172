using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        registerServiceNS.IService rs = new registerServiceNS.ServiceClient();
        registerServiceNS.FanReg fanReg = new registerServiceNS.FanReg();

        fanReg.FanLoginUserName = txtUserName.Text;
        fanReg.FanLoginPasswordPlain = txtPassword.Text;
        fanReg.FanEmail = txtFanEmail.Text;
        fanReg.FanName = txtFanName.Text;

        bool result = rs.RegisterFan(fanReg);

        if (result)
        {
            lblResult.Text = "You have successfully registered";
        }
        else
        {
            lblResult.Text = "Registration Failed";
        }
    }
}
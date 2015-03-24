using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BirthDate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }
    protected void userName_TextChanged(object sender, EventArgs e)
    {
        
    }

    protected void submit_Click(object sender, EventArgs e)
    {
        string n = String.Format("{0}", Request.Form["userName"]);
        DateTime today = DateTime.Today;
        int todaysMonth = today.Month;
        int todaysDay = today.Day;
        int todaysYear = today.Year;
        int usersMonth = Int32.Parse(month.SelectedValue.ToString());
        int usersDay = Int32.Parse(dayBirth.Text);
        int usersYear = Int32.Parse(yearBirth.Text);
        string usrMonth ="";
        string days = "";
        string year = "";
        if(todaysMonth > usersMonth){
            int valueMonth = todaysMonth - usersMonth;  usrMonth = valueMonth.ToString();
        }
        else { int valueMonth = usersMonth - todaysMonth;  usrMonth = valueMonth.ToString(); }

        if (todaysDay > usersDay) { int valueDays = todaysDay - usersDay;  days = valueDays.ToString(); }
        else { int valueDays = usersDay - todaysDay;  days = valueDays.ToString(); }

        
        if (todaysYear > usersYear) { int valueYear = todaysYear - usersYear;  year = valueYear.ToString(); }
        else { int valueYear = usersYear - todaysYear;  year = valueYear.ToString(); }
   
        


        lblDays.Text = "You have "+year +" years, " +usrMonth+ "months, and "+days+" days from your day of birth to today";
        
    }
    protected void Selection_Change(Object sender, EventArgs e)
    {
        string mon = String.Format("{0}", Request.Form["month"]);
        lblDays.Text = mon;
        return;
        

    }
}
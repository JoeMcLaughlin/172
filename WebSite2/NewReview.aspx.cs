using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewReview : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        ReviewService.INewReviewService rs = new ReviewService.NewReviewServiceClient();

        ddlTitles.Items.Clear();
        for (int i = 0; i < rs.GetBooks().Length; i++)
        {
            ddlTitles.Items.Add(rs.GetBooks()[i].BookTitle);
        }

        ddlAuthor.Items.Clear();
        for (int i = 0; i < rs.GetBooks().Length; i++)
            {
                ddlAuthor.Items.Add(rs.GetAuthors()[i]);
            }
        ddlCategory.Items.Clear();
        for (int i = 0; i < rs.GetBooks().Length; i++)
            {
                ddlCategory.Items.Add(rs.GetCategories()[i]);
            }
        ddlRating.Items.Clear();
        for (int i = 1; i < 6; i++)
            {
                string counter = i.ToString();
                ddlRating.Items.Add(counter);
            }

        
        /* 
        Author
        
        Book

        Review

        getCategories

        getauthor

        getbook */

       



    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        ReviewService.INewReviewService rs = new ReviewService.NewReviewServiceClient();
        string title = "";
        string author = "";
        string reviewTitle = "";
        string review = "";
        string category = "";

        if (txtTitle != null) { title = txtTitle.Text;}else{title = ddlTitles.SelectedValue; }
        
        if (txtAuthor != null) { } else {author = ddlAuthor.SelectedValue;}

        if (txtReviewTitle !=null) { } else {reviewTitle}

        if (txtReview != null) { } else {review} 
        
        category = ddlCategory.SelectedValue;
        

        rs.Author = title;
        rs.AddBook(title, author, category);
    }
}
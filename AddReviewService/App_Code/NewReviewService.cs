using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NewReviewService" in code, svc and config file together.
public class NewReviewService : INewReviewService
{
    BookReviewDbEntities db = new BookReviewDbEntities();

    public bool AddAuthor(Author a)
    {
        bool result = true;
        try
        {
            Author au = new Author();
            au.AuthorName = a.AuthorName;
            db.Authors.Add(au);
            db.SaveChanges();
        }
        catch
        {
            result = false;
        }
        return result;
    }
    public bool AddBook(Book b, Author a, string category)
    {
        bool result = true;
        try
        {
            Book bk = new Book();
            bk.BookTitle = b.BookTitle;
            Author author = db.Authors.FirstOrDefault(x => x.AuthorName == a.AuthorName);
            bk.Authors.Add(author);
            Category cat = db.Categories.FirstOrDefault(c => c.CategoryName == category);
            bk.Categories.Add(cat);

            bk.BookEntryDate = DateTime.Now;

            db.Books.Add(bk);
            db.SaveChanges();

        }
        catch
        {
            result = false;

        }
        return result;
    }
    public bool AddReview(Review r)
    {
        bool result = true;
        try
        {
            int key;
            Review rev = new Review();
            if (r.BookKey == 0 )
            {
                key = db.Books.Max(b => b.BookKey);

            }
            else
            {
                key = r.BookKey;

            }
            rev.ReviewerKey = r.ReviewerKey;
            rev.BookKey = key;
            rev.ReviewTitle = r.ReviewTitle;
            rev.ReviewDate = r.ReviewDate;
            rev.ReviewRating = r.ReviewRating;
            rev.ReviewText = r.ReviewText;

            db.Reviews.Add(rev);
            db.SaveChanges();

        }
        catch
        {
            result = false;

        }
        return result;
    }
    public List<string> GetCategories()
    {
        var cats = from c in db.Categories
                   orderby c.CategoryName
                   select new { c.CategoryName };
        List<string> categories = new List<string>();
        foreach(var c in cats)
        {
            categories.Add(c.CategoryName);
        }
        return categories;
    }
    public List<string> GetAuthors()
    {
        var auths = from a in db.Authors
                    orderby a.AuthorName
                    select new { a.AuthorName };
        List<string> authors = new List<string>();
        foreach (var a in auths)
        {
            authors.Add(a.AuthorName);
        }
        return authors;
    }
    public List<Book> GetBooks()
    {
        var tls = from b in db.Books
                  orderby b.BookTitle
                  select b;
        List<Book> titles = new List<Book>();
        foreach (var t in tls)
        {
            Book b = new Book();
            b.BookTitle = t.BookTitle;
            b.BookISBN = t.BookISBN;
            b.BookEntryDate = t.BookEntryDate;
            b.BookKey = t.BookKey;
            titles.Add(b);

        }
        return titles;

    }

}

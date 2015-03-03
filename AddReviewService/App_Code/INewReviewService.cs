using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INewReviewService" in both code and config file together.
[ServiceContract]
public interface INewReviewService
{
    [OperationContract]
    bool AddAuthor(Author a);

    [OperationContract]
    bool AddBook(Book b, Author a, string category);

    [OperationContract]
    bool AddReview(Review r);

    [OperationContract]
    List<string> GetCategories();

    [OperationContract]
    List<string> GetAuthors();

    [OperationContract]
    List<Book> GetBooks();

}

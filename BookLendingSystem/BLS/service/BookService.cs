using BLS.model;
using System.Data;

namespace BLS.service {
    interface BookService {
        DataTable getBook();

        DataTable getBookByKeyWord(string keyWord);

        void addBook(Book book);

        void deleteBook(string id);

        Book getBookByBookName(string bookName);

        void updateBook(Book book);

        void updateBookStatusOut(string book_id, string book_out_date, string book_in_date);

        void updateBookStatusIn(string book_id, string date);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalogue
{
    // Book class
    class Book
    {
        // Properties, Fields, Global variables
        String title;
        int pageCount;
        int ISBN;
        bool isCheckedOut; // whether or not the book is checked out
        int dayCheckedOut = -1; // book is not checked out yet so it is -1 to start with       
    }
}

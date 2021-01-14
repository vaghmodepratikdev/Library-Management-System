using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Library
    {
        public static List<LibraryMember> membersList = new List<LibraryMember>() 
        { 
            new LibraryMember("Joe"),
            new LibraryMember("Livia"),
            new LibraryMember("Mandy"),
            new LibraryMember("Ely"),
            new LibraryMember("Erin")
        };

        public static List<Book> booksList = new List<Book>() 
        {
            new Book("Relationships","Book",0,true,""),
            new Book("Half Girlfriend","Book",0,true,""),
            new Book("The Monk Who Sold His Ferrari","Book",0,true,""),
            new Book("1984 A Massacre","Book",0,true,""),
            new Book("Adolf Hitler","Book",0,true,"")
        };

        public static List<Magazine> magazinesList = new List<Magazine>()
        {
            new Magazine("Vogue","Magazine",0,true,""),
            new Magazine("Cosmoplitan","Magazine",0,true,""),
            new Magazine("GQ","Magazine",0,true,""),
            new Magazine("Elle","Magazine",0,true,""),
            new Magazine("Reader's Digest","Magazine",0,true,"")
        };

        public static List<Movie> moviesList = new List<Movie>()
        {
            new Movie("Alice in Wonderland","Movie",0,true,""),
            new Movie("Maleficent","Movie",0,true,""),
            new Movie("The Matrix","Movie",0,true,""),
            new Movie("Avtar","Movie",0,true,""),
            new Movie("Titanic","Movie",0,true,"")
        };

        public static List<Media> mediaList = new List<Media>();


    }
}

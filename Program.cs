using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ConsoleApp4
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//        }
//    }
//}

//concept of class

//class declaration
public class Author
{
    //Data members of class
    public string name;
    public string language;
    public int article_no;
    public int improv_no;

    //Method of class
    public void Details(string name, string language, int article_no, int improv_no)
    {
        this.name = name;
        this.language = language;
        this.article_no = article_no;
        this.improv_no = improv_no;

        Console.WriteLine("The name of the author is: " + name + "\nThe name of the language is: " + language + 
            "\nTotal number of article published: " + article_no + "\nTotal no of improvements done by author is: " + improv_no);
    }


    //Main Method
    public static void Main(string[] args)
    {
        Author a = new Author();        //creating object

        //calling method of class using class object
        a.Details("Ankitha", "C#", 80, 50);

        Console.ReadKey();
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


static void Main()
{
    Console.WriteLine("BookLibrary");
}
public enum Conditions
{
    new_Book,
    good,
    bad,
    writeOff
}

public enum Statuses
{
    on_Shelf,
    at_TheReader,
    lost
}

public class bookLibrary
{
    public static int max_Amount = 35000;
    public string name_Book;
    public string code_Book;
    public Statuses status_Book;
    public Conditions book_Condition;

    public string getBookCode()
    {
        return code_Book;
    }

    public string _getBookName()
    {
        return name_Book;
    }

    public void setStatus(Statuses status)
    {
        status_Book = status;
    }

    public Statuses getStatus()
    {
        return status_Book;
    }

    public void setBookCondition(Conditions condition)
    {
        book_Condition = condition;
    }
    public Conditions getBookCondition()
    {
        return book_Condition;
    }
}

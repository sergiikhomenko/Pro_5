using System.Xml;

namespace task3;
/*З файлу TelephoneBook.xml (файл повинен був бути створений у процесі виконання додаткового завдання)
 виведіть на екран лише номери телефонів.*/
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        string path = "TelephoneBook.xml";
        XDocument xmlDoc;
        try
        {
            xmlDoc = XDocument.Load(path);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        var phonenomer = from contact in xmlDoc.Descendants("Contact")
            select contact.Attribute("TelephoneNumber").Value;
        foreach (var phone in phonenomer)
        {
            Console.WriteLine(phone);
        }

    }
}
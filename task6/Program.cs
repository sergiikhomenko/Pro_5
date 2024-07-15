using System.Xml;

namespace task6;
/*Створіть .xml файл, який би відповідав наступним вимогам:
   • ім'я файлу: TelephoneBook.xml
   • кореневий елемент: “MyContacts”
   • тег “Contact”, і в ньому має бути записано ім'я 
   контакту та атрибут “TelephoneNumber” 
   зі значенням номера телефону.*/

class Program
{
    static void Main(string[] args)
    {
      
        XmlDocument xmlDoc = new XmlDocument();

        XmlElement root = xmlDoc.CreateElement("MyContacts");
        xmlDoc.AppendChild(root);
        XmlElement contact = xmlDoc.CreateElement("Contact");
        contact.InnerText = "Den";
        contact.SetAttribute("TelephoneNumber", "034554322");
        root.AppendChild(contact);
        xmlDoc.Save("TelephoneBook.xml");
        Console.WriteLine("XML файл успішно створений!");
        
    }
}
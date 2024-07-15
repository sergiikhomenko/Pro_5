using System.Xml;

namespace task2;
/*Створіть програму, яка виводить на екран всю інформацію про вказаний .xml файл.*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть шлях");
        string xmlPath = Console.ReadLine();
            XmlDocument xmlDocument = new XmlDocument();
            try
            {
                xmlDocument.Load(xmlPath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            PrintXmlNode( xmlDocument.DocumentElement, 0);
            Console.WriteLine();
    }

    public static void PrintXmlNode(XmlNode node, int indentLevel)
    {
        string ident = new string(' ',indentLevel *2);

        Console.WriteLine($"{ident}Node:{node.Name} Value:{node.InnerText}");
        if (node.Attributes!=null)
        {
            foreach (XmlAttribute atrib in node.Attributes)
            {
                Console.WriteLine($"{indentLevel} Attribute{atrib.Name}  Value:{atrib.Value}");
            }
        }

        foreach (XmlNode childNode in node.ChildNodes)
        {
            PrintXmlNode(childNode,indentLevel+1);
        }
    }
}
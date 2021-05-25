using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace JobAssistant
{
    public class XmlOperations
    {
        private string path = Path.Combine(Environment.CurrentDirectory, @"data\", "EmployeeInformations.xml");
        public XmlOperations()
        {
        }
        public void GenerateBaseEmployeeXML(Employee employee, string school, string english, string position)
        {
            XDocument xdoc = XDocument.Load(path);
            XElement root = xdoc.Root;
            XElement x_employee = new XElement("employee");
            XAttribute username = new XAttribute("username", employee.username);
            XElement x_cv = new XElement("skillList");
            XElement x_school = new XElement("schoolInfo",school);
            XElement x_english = new XElement("englishKnowledge",english);
            XElement x_position = new XElement("positionInfo",position);
            x_cv.Add(x_school, x_english, x_position);
            x_employee.Add(username,x_cv);
            root.Add(x_employee);
            xdoc.Save(path);        
        }
    }
}

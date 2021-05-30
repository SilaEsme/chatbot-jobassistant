using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace JobAssistant
{
    public class XmlOperations
    {
        private string path = Path.Combine(Environment.CurrentDirectory, @"data\", "EmployeeInformations.xml");
        private static int id = 1;

        public XmlOperations()
        {
        }

        public void GenerateBaseEmployeeXML(Employee employee, string school, string english, string position)
        {
            XDocument xdoc = XDocument.Load(path);
            XElement root = xdoc.Root;
            XElement x_employee = new XElement("employee");
            XAttribute username = new XAttribute("username", employee.username);
            XAttribute x_id = new XAttribute("id", id);
            XElement x_cv = new XElement("skillList");
            XElement x_school = new XElement("schoolInfo", school);
            XElement x_english = new XElement("englishKnowledge", english);
            XElement x_position = new XElement("positionInfo", position);
            x_cv.Add(x_school, x_english, x_position);
            x_employee.Add(x_id, username, x_cv);
            root.Add(x_employee);
            xdoc.Save(path);
            id++;
        }

        public void FilterJobs()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlNodeList nodeList;
            XmlNode root = doc.DocumentElement;

            nodeList = root.SelectNodes("descendant::skillList");

            //loop through each node and save it value in NodeStr
            var NodeSchool = "";
            var NodeEnglish = "";
            var NodePosition = "";

            foreach (XmlNode node in nodeList)
            {
                NodeSchool = node.SelectSingleNode("schoolInfo").InnerText;
                NodeEnglish = node.SelectSingleNode("englishKnowledge").InnerText;
                NodePosition = node.SelectSingleNode("positionInfo").InnerText;
            }

            foreach (var job in JobList.CreateSingle().GetList())
            {
                if (job.Okul.ToLower() == NodeSchool.ToLower() && job.Ingilizce.ToLower() == NodeEnglish.ToLower() && job.Pozisyon.ToLower() == NodePosition.ToLower())
                {
                    LoginedUser.Instance().AddProperJob(job);
                }
            }
        }
    }
}
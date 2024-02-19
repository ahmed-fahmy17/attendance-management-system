using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace attendance_management_system.controls
{
    public partial class UserControlReport : UserControl
    {
        public UserControlReport()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            object startDate1 = StartDateComboBox.SelectedItem;
            object endDate1 = EndDateComboBox.SelectedItem;

            //to handle exception if the user not choose either startDate or EndDate
            if (startDate1 == null || endDate1 == null)
            {
                MessageBox.Show("plz choose the start & end date", "Filtered Attendance Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string startDate = startDate1.ToString();
            string endDate = endDate1.ToString();

            // Load XML attendance file
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("C:\\Users\\USER\\Desktop\\cProject2\\attendance-management-system\\xml\\attendance.xml");

            // Create  XSLT transformation object
            XslCompiledTransform transform = new XslCompiledTransform();

            // Load XSLT stylesheet from file
            transform.Load("C:\\Users\\USER\\Desktop\\cProject2\\attendance-management-system\\xml\\FilteringDependingOnStartAndEndDate.xslt");

            // Create arguments for the XSLT to be replaced by start & end at xslt file
            XsltArgumentList xsltArgs = new XsltArgumentList();
            xsltArgs.AddParam("startDate", "", startDate);
            xsltArgs.AddParam("endDate", "", endDate);

            // Perform the XSLT transformation and save the result
            using (StringWriter sw = new StringWriter())
            {
                transform.Transform(xmlDocument, xsltArgs, sw);
                string resultXml = sw.ToString();

                // Display the filtered XML result in a message box
                MessageBox.Show(resultXml, "Filtered Attendance Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControlReport_Load(object sender, EventArgs e)
        {
            string xmlFilePath = "C:\\Users\\USER\\Desktop\\c#proj4\\attendance-management-system\\xml\\attendance.xml";

            if (File.Exists(xmlFilePath))
            {
                // Load XML document
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlFilePath);

                // Get the root element
                XmlElement root = xmlDoc.DocumentElement;

                // Iterate through each child node (assuming each represents an item)
                foreach (XmlNode node in root.ChildNodes)
                {
                    // Extract data from XML (assuming the text is stored in an attribute named "value")
                    XmlNode nameNode = node.SelectSingleNode("date");
                    if (nameNode != null)
                    {
                        string itemName = nameNode.InnerText;

                        // Add the item to the ComboBox
                        StartDateComboBox.Items.Add(itemName);
                        EndDateComboBox.Items.Add(itemName);
                    }
                }
            }
            else
            {
                MessageBox.Show("XML file not found.");
            }
        }

        private void StartDateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


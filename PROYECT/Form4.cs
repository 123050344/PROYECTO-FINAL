using System;
using System.IO;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using OfficeOpenXml;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace PROYECT
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public void SetFinalNoteText(string text)
        {
            txtfinalnote.Text = text;
        }
        public void SetFinalRecipeName(string name)
        {
            lblnamefinal.Text = name;
        }

        private void btnexportword_Click(object sender, EventArgs e)
        {
            try
            {
               
                string labelContent = lblnamefinal.Text;
                string textboxContent = txtfinalnote.Text;

               
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "Recipe.docx");

               
                using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
                {
                   
                    MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                    mainPart.Document = new Document();
                    Body body = mainPart.Document.AppendChild(new Body());

                  
                    Paragraph paraLabel = body.AppendChild(new Paragraph());
                    Run runLabel = paraLabel.AppendChild(new Run());
                    runLabel.AppendChild(new Text("" + labelContent));

                    Paragraph paraListView = body.AppendChild(new Paragraph());
                    Run runListView = paraListView.AppendChild(new Run());
                    runListView.AppendChild(new Text(""));
                    foreach (ListViewItem item in lstrecipefinal.Items)
                    {
                        Paragraph itemPara = body.AppendChild(new Paragraph());
                        Run itemRun = itemPara.AppendChild(new Run());
                        itemRun.AppendChild(new Text(item.Text));
                    }

                   
                    Paragraph paraTextBox = body.AppendChild(new Paragraph());
                    Run runTextBox = paraTextBox.AppendChild(new Run());
                    runTextBox.AppendChild(new Text("" + textboxContent));

                    mainPart.Document.Save();
                }

                MessageBox.Show("Document created successfully at " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnexportexcel_Click(object sender, EventArgs e)
        {
            try
            {
                
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                string labelContent = lblnamefinal.Text;
                string textboxContent = txtfinalnote.Text;

                string thePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(thePath, "Recipe.xlsx");

               
                using (var package = new ExcelPackage())
                {
                   
                    var worksheet = package.Workbook.Worksheets.Add("my recipe");

                
                    worksheet.Cells["A1"].Value = "Name";
                    worksheet.Cells["B1"].Value = labelContent;

                   
                    worksheet.Cells["A2"].Value = "Ingredients";
                    worksheet.Cells["B2"].Value = "Quantity";

                    int row = 3;
                    foreach (ListViewItem item in lstrecipefinal.Items)
                    {
                        if (item.SubItems.Count >= 2)
                        {
                            worksheet.Cells["A" + row].Value = item.SubItems[0].Text; // Ingredient
                            worksheet.Cells["B" + row].Value = item.SubItems[1].Text; // Quantity
                            row++;
                        }
                        else
                        {
                            MessageBox.Show("Each ListViewItem should have at least 2 subitems.");
                        }
                    }

                    
                    worksheet.Cells["A" + row].Value = "Preparation";
                    worksheet.Cells["B" + row].Value = textboxContent;

                
                    FileInfo fileInfo = new FileInfo(filePath);
                    package.SaveAs(fileInfo);
                }

                MessageBox.Show("Excel file created successfully at " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnexporttxt_Click(object sender, EventArgs e)
        {
            try
            {
               
                string labelContent = lblnamefinal.Text;
                string textboxContent = txtfinalnote.Text;

              
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "Recipe.txt");

          
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                   
                    writer.WriteLine("Name:");
                    writer.WriteLine(labelContent);
                    writer.WriteLine();

                  
                    writer.WriteLine("Ingredients\tQuantity");
                    foreach (ListViewItem item in lstrecipefinal.Items)
                    {
                        if (item.SubItems.Count >= 2)
                        {
                            writer.WriteLine($"{item.SubItems[0].Text}\t{item.SubItems[1].Text}");
                        }
                        else
                        {
                            MessageBox.Show("Each ListViewItem should have at least 2 subitems.");
                        }
                    }
                    writer.WriteLine();

                    writer.WriteLine("Preparation:");
                    writer.WriteLine(textboxContent);
                }

                MessageBox.Show("Text file created successfully at " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnexportxml_Click(object sender, EventArgs e)
        {
            try
            {

                string labelContent = lblnamefinal.Text;
                string textboxContent = txtfinalnote.Text;


                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "Recipe.xml");


                using (XmlWriter writer = XmlWriter.Create(filePath, new XmlWriterSettings { Indent = true }))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Recipe");

                    writer.WriteStartElement("Name");
                    writer.WriteString(labelContent);
                    writer.WriteEndElement();


                    writer.WriteStartElement("Ingredients");
                    foreach (ListViewItem item in lstrecipefinal.Items)
                    {
                        if (item.SubItems.Count >= 2)
                        {
                            writer.WriteStartElement("Ingredient");
                            writer.WriteElementString("Name", item.SubItems[0].Text);
                            writer.WriteElementString("Quantity", item.SubItems[1].Text);
                            writer.WriteEndElement();
                        }
                        else
                        {
                            MessageBox.Show("Each ListViewItem should have at least 2 subitems.");
                        }
                    }
                    writer.WriteEndElement();


                    writer.WriteStartElement("Preparation");
                    writer.WriteString(textboxContent);
                    writer.WriteEndElement();

                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }

                MessageBox.Show("XML file created successfully at " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnexportjson_Click(object sender, EventArgs e)
        {
            try
            {
                string labelText = lblnamefinal.Text;

              
                List<string> listViewItems = new List<string>();
                foreach (ListViewItem item in lstrecipefinal.Items)
                {
                    listViewItems.Add(item.Text);
                }

                string textBoxText = txtfinalnote.Text;

               
                var dataToExport = new
                {
                    LabelText = labelText,
                    ListViewItems = listViewItems,
                    TextBoxText = textBoxText
                };

                string json = JsonConvert.SerializeObject(dataToExport, Formatting.Indented);

                
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

               
                string filePath = Path.Combine(desktopPath, "exportedData.json");

             
                File.WriteAllText(filePath, json);

                MessageBox.Show("Data exported to JSON correctly", "Successful Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while exporting the data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Form4_Load(object sender, EventArgs e)
        {

        }

        
    }
}


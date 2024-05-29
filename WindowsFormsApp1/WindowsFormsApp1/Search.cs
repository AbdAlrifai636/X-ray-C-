using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Search : Form
    {
        private string[] imageFiles;
        private List<DataGridViewRow> rows = new List<DataGridViewRow>();
        public Search()
        {
            InitializeComponent();
        }

        private void ChooseFolder(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog();
            DialogResult folderDialogResult = folderDialog.ShowDialog();

            if (folderDialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
            {
                string folderPath = folderDialog.SelectedPath;
                result.Text = "Select Folder is: " + folderPath;

                imageFiles = Directory.GetFiles(folderPath, "*.jpg");

                filesTable.Rows.Clear();


                foreach (string filePath in imageFiles)
                {
                    string fileName = Path.GetFileName(filePath);
                    DateTime lastModified = File.GetLastWriteTime(filePath);
                    long fileSizeBytes = new FileInfo(filePath).Length;
                    double fileSizeMB = fileSizeBytes / (1024.0 * 1024.0);

                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(filesTable, fileName, lastModified, fileSizeMB.ToString("0.##"));
                    rows.Add(row);
                    filesTable.Rows.Add(row);
                }
            }
        }

        private void FilterBySize(object sender, EventArgs e)
        {
            warning.ForeColor = Color.Red;
            var enteredSize = sizeInput.Text;
            if (imageFiles == null)
            {
                warning.Text = "Choose a folder first";
                return;
            }
            if (enteredSize == "")
            {
                warning.Text = "Enter a size first!";
                return;
            }

            if (!float.TryParse(enteredSize, out float inputSize))
            {

                warning.Text = "The size must be a nubmer!";
                return; 
            }

            warning.Text = "";
            filesTable.Rows.Clear();

            // Filtering
            foreach (string filePath in imageFiles)
            {
                string fileName = Path.GetFileName(filePath);
                DateTime lastModified = File.GetLastWriteTime(filePath);
                long fileSizeBytes = new FileInfo(filePath).Length;
                double fileSizeMB = Math.Round(fileSizeBytes / (1024.0 * 1024.0), 2);

                if (fileSizeMB == Double.Parse(enteredSize))
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(filesTable, fileName, lastModified, fileSizeMB);
                    filesTable.Rows.Add(row);
                }
            }

            if(filesTable.Rows.Count == 0)
            {
                warning.Text = "There is no result in this folder";
                warning.ForeColor = Color.Gray;
            }

        }

        private void FilterByDate(object sender, EventArgs e)
        {
            warning.ForeColor = Color.Red;
            var selectedDate = datePicker.Value;
            if (imageFiles == null)
            {
                warning.Text = "Choose a folder first";
                return;
            }

            warning.Text = "";
            filesTable.Rows.Clear();
            // Filtering
            foreach (string filePath in imageFiles)
            {
                string fileName = Path.GetFileName(filePath);
                DateTime lastModified = File.GetLastWriteTime(filePath);
                long fileSizeBytes = new FileInfo(filePath).Length;
                double fileSizeMB = Math.Round(fileSizeBytes / (1024.0 * 1024.0), 2);
                if (lastModified.Date == selectedDate.Date)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(filesTable, fileName, lastModified, fileSizeMB);
                    filesTable.Rows.Add(row);
                }
            }

            if (filesTable.Rows.Count == 0)
            {
                warning.Text = "There is no result in this folder";
                filesTable.Rows.AddRange(rows.ToArray());
                warning.ForeColor = Color.Gray;
            }

        }

        private void ResetTable(object sender, EventArgs e)
        {
            if (sizeInput.Text.Length == 0)
            {
                if (rows.Count != filesTable.Rows.Count)
                {
                    filesTable.Rows.Clear();
                    filesTable.Rows.AddRange(rows.ToArray());
                }
            }
        }

    }
}

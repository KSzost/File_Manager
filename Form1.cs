using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Threading;
using System.Reflection;

namespace FileManager
{

    public partial class Form1 : Form
    {

        //TODO
        //rekurencyjne kasowanie

        //funkcje ogólne
        public Form1()
        {
            InitializeComponent();
            ShowData(dataG1, txtPath1, Directory.GetCurrentDirectory());
            ShowData(dataG2, txtPath2, Directory.GetCurrentDirectory());
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            dataG1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataG2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private Rectangle dragBoxFromMouseDown;
        private object valueFromMouseDown;

        private void ShowData(DataGridView list, TextBox box, string path)
        {
            list.Rows.Clear();
            string[] directories = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);
            box.Text = path;
            foreach (string directory in directories)
            {
                string name = Path.GetFileName(directory);
                Image ic = Image.FromFile(Directory.GetCurrentDirectory() + @"\folder_icon.png");
                list.Rows.Add(ic,name, Directory.GetCreationTime(path + @"\" + name));
            }
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                Icon appIcon = Icon.ExtractAssociatedIcon(path + @"\" + name);
                Image ic = appIcon.ToBitmap();
                list.Rows.Add(ic,name, File.GetCreationTime(path + @"\" + name));
            }
        }

        private void Refresh_list()
        {
            ShowData(dataG1, txtPath1, txtPath1.Text);
            ShowData(dataG2, txtPath2, txtPath2.Text);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7)
            {
                string path = txtPath1.Text;
                DirectoryInfo di1 = Directory.CreateDirectory(path + "/New");
                Refresh_list();
                txtAlert1.Text = di1.ToString();
            }
            if (e.KeyCode == Keys.F5)
            {
                Refresh_list();
            }
            if (e.KeyCode == Keys.F8)
            {
                if (dataG1.CurrentCell.Value != null)
                {
                    if (File.Exists(txtPath1.Text + @"\" + dataG1[1, dataG1.CurrentRow.Index].Value.ToString()))
                    {
                        File.Delete(txtPath1.Text + @"\" + dataG1[1, dataG1.CurrentRow.Index].Value.ToString());
                    }
                    else if (Directory.Exists(txtPath1.Text + @"\" + dataG1[1, dataG1.CurrentRow.Index].Value.ToString()))
                    {
                        Directory.Delete(txtPath1.Text + @"\" + dataG1[1, dataG1.CurrentRow.Index].Value.ToString());
                    }
                }
                Refresh_list();
            }
        }

        private void DeleteBasicallyEverything(string path, string name)
        {
            if (name != null)
            {
                if (File.Exists(path + @"\" + name))
                {
                    File.Delete(path +  @"\" + name);
                }
                else if (Directory.Exists(path + @"\" + name))
                {
                    Directory.Delete(path + @"\" + name, true);
                }
            }
            Refresh_list();
        }

        private void CopyBasicallyEverything(string source, string destiny, string name)
        {
            if (File.Exists(source + @"\" + name))
            {
                try
                {
                    File.Copy(source + @"\" + name, destiny + @"\" + name);
                }
                catch (IOException)
                {
                    MessageBox.Show("Istnieje plik o tej samej nazwie");
                }
            }
            else if (Directory.Exists(source + @"\" + name))
            {
                try
                {
                    DirectoryCopy(source + @"\" + name, destiny + @"\" + name, true);
                }
                catch (IOException)
                {
                    MessageBox.Show("Istnieje folder o tej samej nazwie");
                }

            }
            Refresh_list();
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }


        //Przyciski
        private void BtnOpen1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd1 = new FolderBrowserDialog() { Description = "Otwórz wybraną ściezkę:" };
            if (fbd1.ShowDialog() == DialogResult.OK)
            {
                ShowData(dataG1, txtPath1, fbd1.SelectedPath);
            }
        }

        private void BtnOpen2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd2 = new FolderBrowserDialog() { Description = "Otwórz wybraną ściezkę:" };
                if (fbd2.ShowDialog() == DialogResult.OK)
                {
                    ShowData(dataG2, txtPath2, fbd2.SelectedPath);
            }
        }

        private void BtnCopy1_Click(object sender, EventArgs e)
        {
            string name = dataG1[1, dataG1.CurrentRow.Index].Value.ToString();
            CopyBasicallyEverything(txtPath1.Text, txtPath2.Text, dataG1[1, dataG1.CurrentRow.Index].Value.ToString());
        }

        private void BtnCopy2_Click(object sender, EventArgs e)
        {
            string name = dataG2[1, dataG1.CurrentRow.Index].Value.ToString();
            CopyBasicallyEverything(txtPath2.Text, txtPath1.Text, dataG2[1, dataG1.CurrentRow.Index].Value.ToString());
        }

        private void BtnDel1_Click(object sender, EventArgs e)
        {
            DeleteBasicallyEverything(txtPath1.Text, dataG1[1, dataG1.CurrentRow.Index].Value.ToString());
        }

        private void BtnDel2_Click(object sender, EventArgs e)
        {
            DeleteBasicallyEverything(txtPath2.Text, dataG2[1, dataG1.CurrentRow.Index].Value.ToString());
        }

        private void BtnParentDirectory1_Click(object sender, EventArgs e)
        {
            try
            {
                ShowData(dataG1, txtPath1, Directory.GetParent(txtPath1.Text).ToString());
            }
            catch
            {

                txtAlert1.Text = "Jesteś w katalogu głównym";
            }
        }

        private void BtnParentDirectory2_Click(object sender, EventArgs e)
        {
            try
            {
                ShowData(dataG2, txtPath2, Directory.GetParent(txtPath2.Text).ToString());
            }
            
            catch (NullReferenceException)
            {
                txtAlert2.Text = "Jesteś w katalogu głównym";
            }
        }

        private void BtnNewDir1_Click(object sender, EventArgs e)
        {
            string path = txtPath1.Text;
            try
            {
                DirectoryInfo di1 = Directory.CreateDirectory(path + @"\New");
                txtAlert1.Text = di1.ToString();
                Refresh_list();
            }
            catch (UnauthorizedAccessException w)
            {
                txtAlert1.Text = (w.Message);
            }
        }

        private void BtnNewDir2_Click(object sender, EventArgs e)
        {
            string path = txtPath2.Text;
            try
            {
                DirectoryInfo di2 = Directory.CreateDirectory(path + "/New");
                txtAlert1.Text = di2.ToString();
                Refresh_list();
            }
            catch (UnauthorizedAccessException w)
            {
                txtAlert2.Text = (w.Message);
            }
        }

        private void DataG1_CellDoubleClick(Object sender, DataGridViewCellEventArgs e)
        {
            if (dataG1.CurrentCell.Value != null)
            {
                string item = dataG1.CurrentCell.Value.ToString();
                if (Directory.Exists(txtPath1.Text + @"\" + item))
                {
                    ShowData(dataG1, txtPath1, txtPath1.Text + @"\" + item);
                }
                else if (File.Exists(txtPath1.Text + @"\" + item))
                {
                    try
                    {
                        System.Diagnostics.Process.Start(txtPath1.Text + @"\" + item);
                    }
                    catch (Win32Exception w)
                    {
                        txtAlert1.Text = (w.Message);
                    }
                }
            }
        }

        private void DataG2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataG2.CurrentCell.Value != null)
            {
                string item = dataG2.CurrentCell.Value.ToString();
                if (Directory.Exists(txtPath2.Text + @"\" + item))
                {
                    ShowData(dataG2, txtPath2, txtPath2.Text + @"\" + item);
                }
                else if (File.Exists(txtPath2.Text + @"\" + item))
                {
                    try
                    {
                        System.Diagnostics.Process.Start(txtPath2.Text + @"\" + item);
                    }
                    catch (Win32Exception w)
                    {
                        txtAlert2.Text = (w.Message);
                    }
                }
            }
        }
        

        //kopiowanie z 1 do 2
       
        private void DataG1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                if (dragBoxFromMouseDown != Rectangle.Empty && !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    try
                    {
                        DragDropEffects dropEffect = dataG1.DoDragDrop(valueFromMouseDown, DragDropEffects.Copy);
                    }
                    catch (NullReferenceException){

                    }
                }
            }
        }

        private void DataG1_MouseDown(object sender, MouseEventArgs e)
        {
            var hittestInfo = dataG1.HitTest(e.X, e.Y);
            if (hittestInfo.RowIndex != -1 && hittestInfo.ColumnIndex != -1)
            {

                valueFromMouseDown = dataG1.Rows[hittestInfo.RowIndex].Cells[hittestInfo.ColumnIndex].Value;
                if (valueFromMouseDown != null)
                {               
                    Size dragSize = SystemInformation.DragSize;
                    dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
                }
            }
            else
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void DataG2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void DataG2_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void DataG2_DragDrop(object sender, DragEventArgs e)
        {
            Point clientPoint = dataG2.PointToClient(new Point(e.X, e.Y));

            if (e.Effect == DragDropEffects.Copy)
            {
                string cellvalue = e.Data.GetData(typeof(string)) as string;
                var hittest = dataG2.HitTest(clientPoint.X, clientPoint.Y);
                if (hittest.ColumnIndex != -1 && hittest.RowIndex != -1)
                {
                    CopyBasicallyEverything(txtPath1.Text, txtPath2.Text, cellvalue);
                }
            }
        }


        //kopiowanie z 2 do 1
        private void DataG2_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                if (dragBoxFromMouseDown != Rectangle.Empty && !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    try
                    {
                        DragDropEffects dropEffect = dataG2.DoDragDrop(valueFromMouseDown, DragDropEffects.Copy);
                    }
                    catch (NullReferenceException)
                    {

                    }
                }
            }
        }

        private void DataG2_MouseDown(object sender, MouseEventArgs e)
        {
            var hittestInfo = dataG2.HitTest(e.X, e.Y);
            if (hittestInfo.RowIndex != -1 && hittestInfo.ColumnIndex != -1)
            {

                valueFromMouseDown = dataG2.Rows[hittestInfo.RowIndex].Cells[hittestInfo.ColumnIndex].Value;
                if (valueFromMouseDown != null)
                {
                    Size dragSize = SystemInformation.DragSize;
                    dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
                }
            }
            else
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void DataG1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void DataG1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void DataG1_DragDrop(object sender, DragEventArgs e)
        {
            Point clientPoint = dataG1.PointToClient(new Point(e.X, e.Y));

            if (e.Effect == DragDropEffects.Copy)
            {
                string cellvalue = e.Data.GetData(typeof(string)) as string;
                var hittest = dataG1.HitTest(clientPoint.X, clientPoint.Y);
                if (hittest.ColumnIndex != -1 && hittest.RowIndex != -1)
                {
                    CopyBasicallyEverything(txtPath2.Text, txtPath1.Text, cellvalue);
                }
            }
        }

    }

}

       


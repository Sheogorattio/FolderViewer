using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderViewer
{
    public partial class Form1 : Form
    {
        Thread MaskCheckThread;
        SynchronizationContext synchContext = new SynchronizationContext();
        Regex IsTXT = new Regex(@"(\W|\w){1,}\.txt$");

        void CheckMask()
        {
            while (true)
            {
                if (IsTXT.IsMatch(MaskTextBox.Text))
                {
                    synchContext.Send(d => KeyWordsTextBox.Enabled = true, null);
                }
                else
                {
                    synchContext.Send(d => KeyWordsTextBox.Enabled = false, null);
                }
            }
            
        }
        public Form1()
        {
            InitializeComponent();

            synchContext = SynchronizationContext.Current;

            string[] LosgicalDrives =  Directory.GetLogicalDrives();
            for(int i = 0; i < LosgicalDrives.Length; i++)
            {
                DiskComboBox.Items.Add(LosgicalDrives[i]);
            }

            KeyWordsTextBox.Enabled = false;

            MaskCheckThread = new Thread(new ThreadStart(CheckMask));
            MaskCheckThread.IsBackground = true;
            MaskCheckThread.Start();
        }

        private void ListRadio_CheckedChanged(object sender, EventArgs e)
        {
            listView.View = View.List;
        }

        private void TileRadio_CheckedChanged(object sender, EventArgs e)
        {
            listView.View = View.Tile;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                listView.Items.Clear();
                var SearchOp = SubFoldersCheckBox.Checked? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

                Queue<string> root = new Queue<string>();
                root.Enqueue(DiskComboBox.Text);
                string path = null;
                while(root.Count > 0)
                {
                    path = root.Dequeue();
                    DirectoryInfo di = new DirectoryInfo(path);
                    DirectoryInfo[] dirs = di.GetDirectories();
                    bool isSpecial = false;
                    foreach ( DirectoryInfo dir in dirs )
                    {
                        isSpecial = false;
                        if( dir.Name.Equals("Documents and Settings") || dir.Name.Equals("System Volume Information") || dir.Name.Equals("Default User")) continue;
                        foreach (Environment.SpecialFolder suit in Enum.GetValues(typeof(Environment.SpecialFolder)))//if current dir is a special folder
                        {
                            string[] PathParts = new DirectoryInfo(Environment.GetFolderPath(suit)).Name.Split(' ');
                            string SplittedName = null;
                            for(int i = 0; i < PathParts.Length; i++)
                            {
                                SplittedName += PathParts[i];
                            }
                            if (dir.Name == SplittedName)
                            {
                                isSpecial = true;
                                break;
                            }
                        }
                        if(isSpecial) { continue; }
                        root.Enqueue(dir.FullName);
                    }
                    FileInfo[] fileInfos = di.GetFiles();
                    foreach ( FileInfo fileInfo in fileInfos )
                    {
                        listView.Items.Add(fileInfo.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

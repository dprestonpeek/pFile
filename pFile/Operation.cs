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

namespace pFile
{
    public partial class Operation : Form
    {
        enum OperationType { COPY, MOVE, RENAME }
        OperationType opType;
        string panel1Url = "";
        string panel2Url = "";

        string fromLocation;
        string toLocation;
        string restrictedFiletype;
        string filePrefix = "";
        string folderNamePrefix;


        bool prefixFolderName;
        bool allSubdirectories;
        bool overwriteDuplicates;
        bool suffixDuplicates;
        bool justEnumerate;

        List<string> directoriesToSearch = new List<string>();
        List<string> filesToTransfer = new List<string>();
        List<string> originalFiles = new List<string>();

        public Operation(string panel1, string panel2)
        {
            InitializeComponent();
            OperationTypeDropDown.SelectedIndex = 0;
            FilesOnlyTop.Checked = true;
            SuffixDuplicates.Checked = true;
            DestinationPane.Value = 1;
            panel1Url = panel1;
            panel2Url = panel2;
        }

        private void PerformOperation_Click(object sender, EventArgs e)
        {
            GetPreferences();
            GetDirectoriesToSearch();
            MarkOriginalFiles();

            switch ((int)opType)
            {
                case 0: //Copy
                    CopyFiles();
                    break;
                case 1: //Move
                    CopyFiles();
                    DeleteOriginalFiles();
                    break;
                case 2: //Rename
                    RenameFiles();
                    DeleteOriginalFiles();
                    break;
            }
            Close();
        }

        private void GetPreferences()
        {
            opType = (OperationType)OperationTypeDropDown.SelectedIndex;

            fromLocation = panel1Url;
            toLocation = panel2Url;
            restrictedFiletype = "";
            filePrefix = "";
            folderNamePrefix = "";

            prefixFolderName = FolderPrefix.Checked;
            allSubdirectories = FilesInSubdirectories.Checked;
            overwriteDuplicates = OverwriteDuplicates.Checked;
            suffixDuplicates = SuffixDuplicates.Checked;
            justEnumerate = JustEnumerate.Checked;

            if (DestinationPane.Value == 0)
            {
                fromLocation = panel2Url;
                toLocation = panel1Url;
            }
            if (opType == OperationType.RENAME)
            {
                fromLocation = toLocation;
            }
            if (RestrictFiletype.Checked)
            {
                restrictedFiletype = FileTypeBox.Text;
            }
            if (PrefixFiles.Checked)
            {
                filePrefix = PrefixBox.Text;
            }
        }

        private void RenameFiles()
        {
            fromLocation = toLocation;
            CopyFiles();
        }

        private void CopyFiles()
        {
            foreach (string dir in directoriesToSearch)
            {
                //if RestrictToFiletype is checked, make sure the filetypes match before adding
                if (RestrictFiletype.Checked && !restrictedFiletype.Equals(""))
                {
                    List<string> filesToCheck = new List<string>();
                    filesToCheck.AddRange(Directory.GetFiles(dir));
                    foreach (string file in filesToCheck)
                    {
                        if (file.Substring(file.Length - restrictedFiletype.Length) == restrictedFiletype)
                        {
                            filesToTransfer.Add(file);
                        }
                    }
                }
                else
                {
                    filesToTransfer.AddRange(Directory.GetFiles(dir));
                }
            }

            int fileNumber = 0;
            foreach (string file in filesToTransfer)
            {
                string newFilename = "";
                if (prefixFolderName)
                {
                    folderNamePrefix = Directory.GetParent(file).Name + Separator.Text;
                }

                if (justEnumerate)
                {
                    fileNumber++;
                    newFilename = Path.Combine(toLocation, filePrefix + folderNamePrefix + fileNumber + Path.GetExtension(file));
                }
                else
                {
                    newFilename = Path.Combine(toLocation, filePrefix + folderNamePrefix + Path.GetFileName(file));
                }

                int i = 1;
                while (File.Exists(newFilename))
                {
                    if (overwriteDuplicates)
                    {
                        File.Delete(newFilename);
                    }
                    else if (suffixDuplicates)
                    {
                        string justname = Path.GetFileNameWithoutExtension(newFilename);
                        string ext = Path.GetExtension(newFilename);
                        string enumeration = GetEnumerationString(justname);
                        int num = -1;
                        if (enumeration != "")
                        {
                            num = int.Parse(enumeration.Substring(1, enumeration.Length - 2));
                        }

                        //if filename is enumerated
                        if (enumeration != "")
                        {
                            justname = justname.Replace(enumeration, "(" + i + ")");
                            newFilename = folderNamePrefix + justname + ext;
                        }
                        else
                        {
                            newFilename = folderNamePrefix + justname + "(" + i + ")" + ext;
                        }

                        newFilename = Path.Combine(toLocation, Path.GetFileName(newFilename));
                        i++;
                    }
                }
                File.Copy(file, newFilename);
            }
        }

        private void GetDirectoriesToSearch()
        {
            directoriesToSearch.Add(fromLocation);
            if (allSubdirectories)
            {
                GetAllSubdirectories(fromLocation);
            }
        }

        private void MarkOriginalFiles()
        {
            originalFiles = new List<string>();
            foreach (string directory in directoriesToSearch)
            {
                originalFiles.AddRange(Directory.GetFiles(directory));
            }
        }

        private void DeleteOriginalFiles()
        {
            List<string> filesToDelete = new List<string>();
            foreach (string directory in directoriesToSearch)
            {
                filesToDelete.AddRange(Directory.GetFiles(directory));
            }
        }

        private void GetAllSubdirectories(string location)
        {
            foreach (string dir in Directory.GetDirectories(location))
            {
                directoriesToSearch.AddRange(Directory.GetDirectories(dir));
                if (Directory.GetDirectories(dir).Length > 0)
                {
                    GetAllSubdirectories(dir);
                }
            }
        }

        private string GetEnumerationString(string justFilenameNoExt)
        {
            string enumeration = "";

            int index = justFilenameNoExt.LastIndexOf("(");
            if (index > 0)
            {
                enumeration = justFilenameNoExt.Substring(index);
            }
            return enumeration;
        }

        private void FileTypeBox_TextChanged(object sender, EventArgs e)
        {
            RestrictFiletype.Checked = true;
        }

        private void PrefixBox_TextChanged(object sender, EventArgs e)
        {
            PrefixFiles.Checked = true;
        }

        private void Separator_TextChanged(object sender, EventArgs e)
        {
            FolderPrefix.Checked = true;
        }
    }
}

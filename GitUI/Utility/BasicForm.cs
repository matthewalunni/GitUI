using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utility
{
    class BasicForm
    {

        /// <summary>
        /// this method prompts the user to select a directory
        /// </summary>
        /// <returns>string of selected directory</returns>
        public static string DirectoryUploadPrompt()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    // string[] files = Directory.GetFiles(fbd.SelectedPath);
                    return fbd.SelectedPath;

                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// this method prompts a user to select a directory and returns a string array of files
        /// within the selected directory
        /// </summary>
        /// <returns>string array of file paths</returns>
        public static string[] ReturnAllFilesPrompt()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    return files;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// this method returns true if there is a text box on a form that is 
        /// empty
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        /// <alert>broken</alert>
        public static bool TextBoxesAreEmpty(Form form)
        {
            foreach (Control c in form.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    if (String.IsNullOrEmpty(c.Text))
                    {
                        return false;
                    }
                }
                
            }

            return true;
        }
    }
}

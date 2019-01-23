using BllPalindrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryWord;

namespace WinPalindrome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog myOFD = new OpenFileDialog();
            DialogResult result = myOFD.ShowDialog();
            if (result == DialogResult.OK)
            {
                PalindromeManagement myBLL = new PalindromeManagement();
                List<string> myList = myBLL.GetListPalindromeFromFile(myOFD.FileName);
                LstAll.DataSource = myList;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnFilterPalindrome_Click(object sender, EventArgs e)
        {
            LstNotPalindrome.Items.Clear();
            LstPalindrome.Items.Clear();
            palindrome myPalindrome = new palindrome();
           
            foreach (string word in LstAll.Items)
            {
              bool result =  myPalindrome.isPalindrome(word);

                if (result)
                {
                    LstPalindrome.Items.Add(word);
                }
                else
                {
                    LstNotPalindrome.Items.Add(word);
                }
            }
        }
    }
}

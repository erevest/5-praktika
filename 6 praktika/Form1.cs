using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_praktika
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int index = listBox1.SelectedIndex;
      // Считываем строку в перменную str
      string str = (string)listBox1.Items[index];
      string subString = "сок";
      int indexOfSubstring = str.IndexOf(subString);
      if (indexOfSubstring == 0)
        label1.Text = "сок = да ";
      else
        label1.Text = "сок = нет ";
    



    }
  }
}

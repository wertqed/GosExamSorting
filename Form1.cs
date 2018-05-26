using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GosExamSorting
{
    public partial class Form1 : Form
    {
        private int[] arr = new int[70];
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int [] res = QuickSort.Sort(arr);
            string str = "";
            for(int i=0; i< res.Length; i++)
            {
                str += res[i]+ " ";
            }
            MessageBox.Show(str);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str = "";
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 200);
                str += arr[i] + " ";
            }
            this.textBox1.Text = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] res = MergeSort.Sort(arr);
            string str = "";
            for (int i = 0; i < res.Length; i++)
            {
                str += res[i] + " ";
            }
            MessageBox.Show(str);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] res = RadixSort.Sort(arr);
            string str = "";
            for (int i = 0; i < res.Length; i++)
            {
                str += res[i] + " ";
            }
            MessageBox.Show(str);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] res = CountingSort.Sort(arr);
            string str = "";
            for (int i = 0; i < res.Length; i++)
            {
                str += res[i] + " ";
            }
            MessageBox.Show(str);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] res = GnomeSort.Sort(arr);
            string str = "";
            for (int i = 0; i < res.Length; i++)
            {
                str += res[i] + " ";
            }
            MessageBox.Show(str);
        }
    }
}

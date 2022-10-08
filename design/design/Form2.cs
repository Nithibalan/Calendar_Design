using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace design
{
    public partial class Form2 : Form
    {
        int month;
        public Form2()
        {
            InitializeComponent();
        }
        public static void months()
        {

            int[] ma = new int[35] { 0, 0, 0, 0, 0, 0, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 0, 0, 0, 0 };
           
            
            
        }

        
        

        private void button33_Click(object sender, EventArgs e)
        {
            
            flowLayoutPanel1.Controls.Clear();
            month++;

            for (int i = 1; i <= 35; i++)
            {
                Button button = new Button();
                button.Height = 110;
                button.Width = 140;
                button.Text = i.ToString();
                flowLayoutPanel1.Controls.Add(button);
                string currentMonth = DateTime.Now.ToString("MM");
                string currentYear = DateTime.Now.Year.ToString();
                label8.Text = currentMonth;
                label9.Text = currentYear;
                months();

          
            }
            
           
            
           
            
            
        
        }

        private void Form2_Load(object sender, EventArgs e)
        {
         
            for (int i = 1; i <= 35; i++)
            {
                Button button = new Button();
                button.Height = 110;
                button.Width = 140;
                button.Text = i.ToString();
                flowLayoutPanel1.Controls.Add(button);
                string currentMonth = DateTime.Now.Month.ToString("MM");
                string currentYear = DateTime.Now.Year.ToString();
                label8.Text = currentMonth;
                label9.Text = currentYear;
              
            }
            
           
            
            
            

           
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            month--;
            
            for (int i = 1; i <= 35; i++)
            {
                Button button = new Button();
                button.Height = 110;
                button.Width = 140;
                button.Text = i.ToString();
                flowLayoutPanel1.Controls.Add(button);
                string currentMonth = DateTime.Now.Month.ToString("MM");
                string currentYear = DateTime.Now.Year.ToString();
                label8.Text = currentMonth;
                label9.Text = currentYear;
                
                
            }
            
            
            
           
            
           
            
        }

        
           


    }
}

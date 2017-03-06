using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coursework_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog()==DialogResult.OK)
            {
               
                double result = 0;
                if (double.TryParse(form2.textBox1.Text, out result))
                {
                    MessageBox.Show("Invalid input");
                    button1.PerformClick();
                }
                else
                {
                    if (double.TryParse(form2.textBox2.Text, out result))
                    {
                        MessageBox.Show("Invalid input");
                        button1.PerformClick();
                    }
                    else
                    {
                        if (double.TryParse(form2.textBox3.Text, out result))
                        {
                            string text = form2.textBox1.Text + " " + form2.textBox2.Text + " " + form2.textBox3.Text;

                            listBox1.Items.Add(text);

                            button1.Enabled = false;
                            button2.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Invalid input");
                            button1.PerformClick();
                        }
                    }

                }

                
               
              


               
                
            }
         
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            if (form3.ShowDialog() == DialogResult.OK)
            {
             
                    double result = 0;
                    if (double.TryParse(form3.textBox1.Text, out result))
                    {
                    if (double.TryParse(form3.textBox2.Text, out result))
                    {
                        if (double.TryParse(form3.textBox3.Text, out result))
                        {
                            double dohodi = double.Parse(form3.textBox1.Text) + double.Parse(form3.textBox2.Text) + double.Parse(form3.textBox3.Text);
                            listBox2.Items.Add(dohodi.ToString() + " BGN");
                            button1.Enabled = true;
                            button2.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Invalid input");
                            button2.PerformClick();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid input");
                        button2.PerformClick();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Invalid input");
                    button2.PerformClick();
                }
                 
            }
           
                
            
              


            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }


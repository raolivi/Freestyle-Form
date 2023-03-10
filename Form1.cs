using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Freestyle_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        SoundPlayer notifier = new SoundPlayer(Properties.Resources.arrow);

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Lime;
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            try
            {
                throw new NotImplementedException();
            }
            catch (NotImplementedException notImp)
            {
                DialogResult result = MessageBox.Show("Submit form?", notImp.Message,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);


                if (result == DialogResult.Yes)
                {
                    notifier.Play();

                    toolStripStatusLabel1.Text = "Submitted";

                    listBox1.Items.Add(NameBox.Text);

                    if (radioButton1.Checked)
                    {
                        listBox1.Items.Add(radioButton1.Text);
                    }

                    if (radioButton2.Checked)
                    {
                        listBox1.Items.Add(radioButton2.Text);
                    }

                    listBox1.Items.Add(HomeBox.Text);

                    if (checkBox1.Checked)
                    {
                        listBox1.Items.Add(checkBox1.Text);
                    }

                    if (checkBox2.Checked)
                    {
                        listBox1.Items.Add(checkBox2.Text);
                    }

                    if (checkBox3.Checked)
                    {
                        listBox1.Items.Add(checkBox3.Text);
                    }

                    if (checkBox4.Checked)
                    {
                        listBox1.Items.Add(checkBox4.Text);
                    }

                    if (checkBox5.Checked)
                    {
                        listBox1.Items.Add(checkBox5.Text);
                    }

                    if (checkBox6.Checked)
                    {
                        listBox1.Items.Add(checkBox6.Text);
                    }

                    if (checkBox7.Checked)
                    {
                        listBox1.Items.Add(checkBox7.Text);
                    }

                    radioButton2.Checked = false;
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    checkBox5.Checked = false;
                    checkBox6.Checked = false;
                    checkBox7.Checked = false;

                    NameBox.Clear();
                    HomeBox.Clear();
                }

                if (result == DialogResult.No)
                {
                    toolStripStatusLabel1.Text = "Fill out form";
                }

            }
        }
    }
}

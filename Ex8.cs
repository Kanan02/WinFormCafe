using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1
{
    public partial class BestOil : Form
    {
        List<Benzin> benzins;
        List<Meal> meals;
        double allSum = 0;
        Timer timer = new Timer();
        double allSumOfClient = 0;

        double cafeSum = 0;
       
        public BestOil()
        {
            InitializeComponent();
            FullInitialize();
     
        }

        void FullInitialize()
        {
            
            benzins = new List<Benzin>
            {
                new Benzin("A-76",6.40),
                new Benzin("A-78",7.40),
                new Benzin("A-90",9.00),
                new Benzin("A-91",10.50),
                new Benzin("A-92",11.50)
            };
            allSumOfClient = 0;
            cafeSum = 0;
            comboBox1.Items.Clear();
            foreach (var item in benzins)
            {
                comboBox1.Items.Add(item);

            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox1.Text = "";
            textBoxKolichestvo.Text = "";
            textBoxSumma.Text = "";
            comboBox1.Text = "";

            meals = new List<Meal>
            {
                new Meal("Хот-Дог",4),
                new Meal("Гамбургер",5.10),
                new Meal("Картофель-Фри",7.20)
            };
            checkBox1.Text = meals[0].Name;
            checkBox2.Text = meals[1].Name;
            checkBox3.Text = meals[2].Name;
            textBox2.Text = $"{meals[0].Price}.00";
            textBox4.Text = $"{meals[1].Price}0";
            textBox6.Text = $"{meals[2].Price}0";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            label6.Text = "0";
            SumOrLit.Text = "0";
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }


        #region Zapravka
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                textBox1.Text = $" {benzins.Where(x => x.Name == comboBox1.Text).ElementAt(0).Sum}";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");

            }
            textBox1.ReadOnly = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxKolichestvo.ReadOnly = false;
            textBoxSumma.ReadOnly = true;
            textBoxSumma.Text="";
            SumOrLit.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxKolichestvo.ReadOnly = true;
            textBoxSumma.ReadOnly = false;
            textBoxKolichestvo.Text = "";
            SumOrLit.Text = "";
            
            
        }


        private void textBoxKolichestvo_TextChanged(object sender, EventArgs e)
        {
            
            if (textBoxKolichestvo.Text=="")
            {
                return;
            }
            groupBox4.Text = "К оплате";
            SumOrLit.Text = $"{(double.Parse(textBoxKolichestvo.Text) * double.Parse(textBox1.Text))}";
            grivnesOrLitres.Text = "грн.";
            
        }

        private void textBoxSumma_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSumma.Text == "")
            {
                return;
            }
            groupBox4.Text = "К выдаче";
            SumOrLit.Text = $"{Math.Round(double.Parse(textBoxSumma.Text) / double.Parse(textBox1.Text),1)}";
            grivnesOrLitres.Text = "л.";
        }
        #endregion


        #region Kafe


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (textBox3.Text != "")
            {
                if (checkBox1.Checked==true)
                {
                    textBox3.ReadOnly = true;
                    cafeSum += double.Parse(textBox2.Text) * double.Parse(textBox3.Text);
                   
                }
                else
                {
                    textBox3.ReadOnly = false;
                    cafeSum -= double.Parse(textBox2.Text) * double.Parse(textBox3.Text);
                }
            }
            label6.Text = $"{cafeSum}";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                if (checkBox2.Checked == true)
                {
                    textBox5.ReadOnly = true;
                    cafeSum += double.Parse(textBox4.Text) * double.Parse(textBox5.Text);

                }
                else
                {
                    textBox3.ReadOnly = false;
                    cafeSum -= double.Parse(textBox4.Text) * double.Parse(textBox5.Text);
                }
            }
            label6.Text = $"{cafeSum}";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                if (checkBox3.Checked == true)
                {
                    textBox7.ReadOnly = true;
                    cafeSum += double.Parse(textBox6.Text) * double.Parse(textBox7.Text);

                }
                else
                {
                    textBox3.ReadOnly = false;
                    cafeSum -= double.Parse(textBox6.Text) * double.Parse(textBox7.Text);
                }
            }
            label6.Text = $"{cafeSum}";
            sum.Text = "";
        }

       
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text!="")
            {
                checkBox1.Enabled = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                checkBox2.Enabled = true;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                checkBox3.Enabled = true;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                allSumOfClient += double.Parse(SumOrLit.Text)+double.Parse(label6.Text);
                
            }
            else
            {
                allSumOfClient += double.Parse(textBoxSumma.Text) + double.Parse(label6.Text);
            }
            sum.Text = $"{allSumOfClient} грн.";
            allSum += allSumOfClient;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FullInitialize();
        }

        private void BestOil_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show($"Ваша выручка за день: {allSum} грн.","Ежедневная выручка");

        }
    }
}

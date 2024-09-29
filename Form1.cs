using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project25
{
    
    public partial class Form1 : Form
    {
        double total_Value = 0;
        double n = 1;
        double bal = 0;
        

        public Form1()
        {
            InitializeComponent();
            textBox_Total.Text = textBox_Total.Text + total_Value;

            richBoxTitle.AppendText("FINE NINE RESTAURANT\n");
            richBoxTitle.AppendText("-----------------------------------------------------------\n");

        }

        private void Chicken_Nuggets(object sender, EventArgs e)
        {
            double Chicken_Nuggets = 600;
            total_Value = total_Value + Chicken_Nuggets;
            textBox_Total.Clear();
            textBox_Total.Text = textBox_Total.Text + total_Value;
            richBoxlist.AppendText(n + "\tChicken Nuggets\t\t" + Chicken_Nuggets + "\n");
            n = n + 1;
        }

        private void Chicken_BBQ(object sender, EventArgs e)
        {
            double Chicken_BBQ = 1200;
            total_Value = total_Value + Chicken_BBQ;
            textBox_Total.Clear();
            textBox_Total.Text = textBox_Total.Text + total_Value;
            richBoxlist.AppendText(n + "\tChicken BBQ\t\t" + Chicken_BBQ + "\n");
            n = n + 1;

        }

        private void Chicken_Puff(object sender, EventArgs e)
        {
            double Chicken_Puff = 500;
            total_Value = total_Value + Chicken_Puff;
            textBox_Total.Clear();
            textBox_Total.Text = textBox_Total.Text + total_Value;
            richBoxlist.AppendText(n + "\tChicken Puff\t\t" + Chicken_Puff + "\n");
            n = n + 1;
        }

        private void Sawarma(object sender, EventArgs e)
        {
            double Sawarma = 350;
            total_Value = total_Value + Sawarma;    
            textBox_Total.Clear();
            textBox_Total.Text = textBox_Total.Text + total_Value;
            richBoxlist.AppendText(n + "\tSawarma   \t\t" +  Sawarma + "\n");
            n = n + 1;
        }

        private void Chrispy_Chicken(object sender, EventArgs e)
        {
            double Chrispy_Chicken = 450;
            total_Value = total_Value + Chrispy_Chicken;
            textBox_Total.Clear();
            textBox_Total.Text = textBox_Total.Text + total_Value;
            richBoxlist.AppendText(n + "\tCrispy Chicken\t\t" + Chrispy_Chicken + "\n");
            n = n + 1;
        }

        private void Egg_Roll(object sender, EventArgs e)
        {
            double Egg_Roll = 150;
            total_Value = total_Value + Egg_Roll;
            textBox_Total.Clear();
            textBox_Total.Text = textBox_Total.Text + total_Value;
            richBoxlist.AppendText(n + "\tEgg Roll\t\t\t" +  Egg_Roll + "\n");
            n = n + 1;
        }

        private void Spicy_Bun(object sender, EventArgs e)
        {
            double Spicy_Bun = 100;
            total_Value = total_Value + Spicy_Bun;
            textBox_Total.Clear();
            textBox_Total.Text = textBox_Total.Text + total_Value;
            richBoxlist.AppendText(n + "\tSpicy Bun\t\t" + Spicy_Bun + "\n");
            n = n + 1;
        }

        private void Omlet(object sender, EventArgs e)
        {
            double Omlet = 90;
            total_Value = total_Value + Omlet;
            textBox_Total.Clear();
            textBox_Total.Text = textBox_Total.Text + total_Value;
            richBoxlist.AppendText(n + "\tOmlet\t\t\t" +  Omlet + "\n");
            n = n + 1;
        }

        private void Burger(object sender, EventArgs e)
        {
            double Burger = 600;
            total_Value = total_Value + Burger;
            textBox_Total.Clear();
            textBox_Total.Text = textBox_Total.Text + total_Value;
            richBoxlist.AppendText(n + "\tBurger\t\t\t" +  Burger + "\n");
            n = n + 1;
        }

        private void Pizza(object sender, EventArgs e)
        {
            double Pizza = 1100;
            total_Value = total_Value + Pizza;
            textBox_Total.Clear();
            textBox_Total.Text = textBox_Total.Text + total_Value;
            richBoxlist.AppendText(n + "\tPizza\t\t\t" +  Pizza + "\n");
            n = n + 1;
        }

        private void Cake(object sender, EventArgs e)
        {
            double cake = 400;
            total_Value = total_Value + cake;
            textBox_Total.Clear();
            textBox_Total.Text = textBox_Total.Text + total_Value;
            richBoxlist.AppendText(n + "\tCake\t\t\t" +  cake + "\n");
            n = n + 1;
        }

        private void Brownie(object sender, EventArgs e)
        {
            double Brownie = 600;
            total_Value = total_Value + Brownie;
            textBox_Total.Clear();
            textBox_Total.Text = textBox_Total.Text + total_Value;
            richBoxlist.AppendText(n + "\tBrownie\t\t\t" +  Brownie + "\n");
            n = n + 1;
        }

        private void Espresso(object sender, EventArgs e)
        {
            double Espresso = 350;
            total_Value = total_Value + Espresso;
            textBox_Total.Clear();
            textBox_Total.Text = textBox_Total.Text + total_Value;
            richBoxlist.AppendText(n + "\tEspresso\t\t\t" +  Espresso + "\n");
            n = n + 1;
        }

        private void Americano(object sender, EventArgs e)
        {
            double Americano = 400;
            total_Value = total_Value + Americano;
            textBox_Total.Clear();
            textBox_Total.Text = textBox_Total.Text + total_Value;
            richBoxlist.AppendText(n + "\tAmericano\t\t" +  Americano + "\n");
            n = n + 1;
        }

        private void Cafe_Latte(object sender, EventArgs e)
        {
            double Cafe_Latte = 300;
            total_Value = total_Value + Cafe_Latte;
            textBox_Total.Clear();
            textBox_Total.Text = textBox_Total.Text + total_Value;
            richBoxlist.AppendText(n + "\tCafe Latte\t\t" +  Cafe_Latte + "\n");
            n = n + 1;
        }

        private void Cafe_Mocha(object sender, EventArgs e)
        {
            double Cafe_Mocha = 400;
            total_Value = total_Value + Cafe_Mocha;
            textBox_Total.Clear();
            textBox_Total.Text = textBox_Total.Text + total_Value;
            richBoxlist.AppendText(n + "\tCafe Mocha\t\t" +  Cafe_Mocha + "\n");
            n = n + 1;
        }

        private void Cappucino(object sender, EventArgs e)
        {
            double Cappucino = 300;
            total_Value = total_Value + Cappucino;
            textBox_Total.Clear();
            textBox_Total.Text = textBox_Total.Text + total_Value;
            richBoxlist.AppendText(n + "\tCappucino\t\t" + Cappucino + "\n");
            n = n + 1;
        }

        private void Caramel_Mocha(object sender, EventArgs e)
        {
            double Caramel_Mocha = 400;
            total_Value = total_Value + Caramel_Mocha;
            textBox_Total.Clear();
            textBox_Total.Text = textBox_Total.Text + total_Value;
            richBoxlist.AppendText(n + "\tCaramel Mocha\t\t" +  Caramel_Mocha + "\n");
            n = n + 1;
        }

        private void Macha_Tea(object sender, EventArgs e)
        {
            double Macha_Tea = 200;
            total_Value = total_Value + Macha_Tea;
            textBox_Total.Clear();
            textBox_Total.Text = textBox_Total.Text + total_Value;
            richBoxlist.AppendText(n + "\tMacha Tea\t\t" +  Macha_Tea + "\n");
            n = n + 1;
        }

        private void Citrus_Tea(object sender, EventArgs e)
        {
            double Citrus_Tea = 230;
            total_Value = total_Value + Citrus_Tea;
            textBox_Total.Clear();
            textBox_Total.Text = textBox_Total.Text + total_Value;
            richBoxlist.AppendText(n + "\tCitrus Tea\t\t" +  Citrus_Tea + "\n");
            n = n + 1;
        }

        private void EarlGrey_Tea(object sender, EventArgs e)
        {
            double EarlGrey_Tea = 250;
            total_Value = total_Value + EarlGrey_Tea;
            textBox_Total.Clear();
            textBox_Total.Text = textBox_Total.Text + total_Value;
            richBoxlist.AppendText(n + "\tEarlGrey Tea\t\t" + EarlGrey_Tea + "\n");
            n = n + 1;
        }

        private void PepperMint_Tea(object sender, EventArgs e)
        {
            double PepperMint_Tea = 200;
            total_Value = total_Value + PepperMint_Tea;
            textBox_Total.Clear();
            textBox_Total.Text = textBox_Total.Text + total_Value;
            richBoxlist.AppendText(n + "\tPepperMint Tea\t\t" + PepperMint_Tea + "\n");
            n = n + 1;
        }

        private void Black_Coffee(object sender, EventArgs e)
        {
            double Black_Coffee = 100;
            total_Value = total_Value + Black_Coffee;
            textBox_Total.Clear();
            textBox_Total.Text = textBox_Total.Text + total_Value;
            richBoxlist.AppendText(n + "\tBlack Coffee\t\t" +  Black_Coffee + "\n");
            n = n + 1;
        }

        private void Black_Tea(object sender, EventArgs e)
        {
            double Black_tea = 70;
            total_Value = total_Value + Black_tea;
            textBox_Total.Clear();
            textBox_Total.Text = textBox_Total.Text + total_Value;
            richBoxlist.AppendText(n + "\tBlack Tea\t\t" + Black_tea + "\n");
            n = n + 1;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTimer.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToShortDateString();
          
        }

        private void printPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string total = "\n\nTotal Amount\t\t\t" + textBox_Total.Text;
            string paid = "\nAmount Paid\t\t\t" + textBox_Paid.Text;
            string bala = "\nBalance\t\t\t\t" + textBox_Bal.Text;
            string time = "\n" + DateTime.Now.ToLongTimeString() + "\t\t" + DateTime.Now.ToShortDateString();  


            e.Graphics.DrawString(richBoxTitle.Text+ richBoxlist.Text + total + paid + bala + time , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printDoc(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void paid(object sender, EventArgs e)
        {
            textBox_Bal.Clear();
            double amount_paid = 0;
            amount_paid = double.Parse(textBox_Paid.Text);
            bal = amount_paid - total_Value;
            textBox_Bal.AppendText(bal.ToString());

        }

        private void clear(object sender, EventArgs e)
        {
            textBox_Total.Clear();
            total_Value = 0;
            textBox_Total.Text = textBox_Total.Text + total_Value;
            richBoxlist.Clear();
            textBox_Bal.Clear();
            textBox_Paid.Clear();
            textBox_Paid.Text = "0";
        }
    }
}

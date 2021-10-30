using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;

namespace MinexBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          

            while (true)
            {
                string kullaniciAdi, sifre;

                kullaniciAdi = textBox1.Text;
                sifre = textBox1.Text;


                IWebDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://minex.world/login");
                Thread.Sleep(8000);


                IWebElement userName = driver.FindElement(By.Name("login"));
                IWebElement password = driver.FindElement(By.Name("password"));
                IWebElement loginBtn = driver.FindElement(By.CssSelector(".btn.btn-base.mt-4"));

                userName.SendKeys(kullaniciAdi);
                password.SendKeys(sifre);
                loginBtn.Click();
                Thread.Sleep(3000);



                driver.Navigate().GoToUrl("https://minex.world/cabinet/bonuses");
                Thread.Sleep(3000);

                IWebElement bonussesBtn = driver.FindElement(By.XPath("//*[@id=\"get-bonus\"]"));
                bonussesBtn.Click();
                Thread.Sleep(5000);



                driver.Close();
                driver.Quit();
                Thread.Sleep(3600000);
            }
            
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}

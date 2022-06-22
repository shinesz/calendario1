using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caledario
{
    public partial class Form1 : Form
    {
        int month;
        int year;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Sab_Click(object sender, EventArgs e)
        {

        }

        private void Sex_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displaDays();
        }

        private void BotaoPro_Click(object sender, EventArgs e)
        {
            
            //recipiente claro
            RecipienteDoDia.Controls.Clear();

            //incrementar mês para ir para o próximo mês
            month++;
            if ((month >= 1) && (month <= 12))
            {
                string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
                LDdate.Text = monthname + "  " + year;
                
            }
            else
            {
                month = 1;
                year++;
                string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
                LDdate.Text = monthname + "  " + year;
                
            }

          
            
            DateTime now = DateTime.Now;

            //Para que não pegue o primeiro dia do mês.

            DateTime startofthemonth = new DateTime(year, month, 1);

            //obter a contagem de dias do mês 

            int days = DateTime.DaysInMonth(year, month);

            //converter o strartofthemont para0 inteiro

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            //primeiro para que não crie um controle de usuário em branco
            for (int i = 1; i < dayoftheweek; i++)
            {
                Usercontrol1 ucblank = new Usercontrol1();
                RecipienteDoDia.Controls.Add(ucblank);

            }
            //agora vamos criar usercontrol por dias
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                RecipienteDoDia.Controls.Add(ucdays);
            }
        }// Botão de Proximo

        private void qui_Click(object sender, EventArgs e)
        {

        }

        private void RecipienteDoDia_Paint(object sender, PaintEventArgs e)
        {

        }

        private void displaDays()
        {
            
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            //Para que não pegue o primeiro dia do mês.
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);   
            LDdate.Text = monthname + "  " + year;           
            DateTime startofthemonth = new DateTime(now.Year,now.Month,1);

            //obter a contagem de dias do mês 

            int days = DateTime.DaysInMonth(year, month);

            //converter o strartofthemont para0 inteiro

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"))+1;
            //primeiro para que não crie um controle de usuário em branco
            for(int i = 1; i < dayoftheweek; i++)
            {
                Usercontrol1 ucblank = new Usercontrol1();
                RecipienteDoDia.Controls.Add(ucblank);

            }
            //agora vamos criar usercontrol por dias
            for(int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                RecipienteDoDia.Controls.Add(ucdays);
            }
        }

        private void BotaoAn_Click(object sender, EventArgs e)
        {
            //recipiente claro
            RecipienteDoDia.Controls.Clear();

            //incrementar mês para ir para o próximo mês
           month--;
          
            if ((month >= 1) && (month <= 12))
            {
                string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
                LDdate.Text = monthname + "  " + year;

            }
            else
            {
                month = 12;
                year--;
                string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
                LDdate.Text = monthname + "  " + year;

            }

            


            DateTime now = DateTime.Now;

            //Para que não pegue o primeiro dia do mês.

            DateTime startofthemonth = new DateTime(year, month, 1);

            //obter a contagem de dias do mês 

            int days = DateTime.DaysInMonth(year, month);

            //converter o strartofthemont para0 inteiro

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            //primeiro para que não crie um controle de usuário em branco
            for (int i = 1; i < dayoftheweek; i++)
            {
                Usercontrol1 ucblank = new Usercontrol1();
                RecipienteDoDia.Controls.Add(ucblank);

            }
            //agora vamos criar usercontrol por dias
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                RecipienteDoDia.Controls.Add(ucdays);
            }
        }//botao voltar

        private void LDdate_Click(object sender, EventArgs e)
        {

        }
    }
}

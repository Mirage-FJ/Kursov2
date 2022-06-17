using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Word = Microsoft.Office.Interop.Word;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string number1, nam;
        public int err = 1, nam1 = 1;
        public Form1()
        {
            InitializeComponent();
            
            List<string> subject = new List<string>
        {
            "Технології програмування", "Операційні системи", "Комп. Логіка"
        };
            // добавляем список элементов
            domainUpDown1.Items.AddRange(subject);
            List<string> year = new List<string>
        {
            "2018-2019","2019-2020","2020-2021", "2021-2022", "2022-2023", "2023-2024", "2024-2025", "2025-2026", "2026-2027", "2027-2028", "2028-2029", "2029-2030"
        };
            // добавляем список элементов
            domainUpDown2.Items.AddRange(year);
            List<string> speciality = new List<string>
        {
            "121 - Інженерія програмного забезпечення", "123 - Компьютерна інженерія", "125 - Кібер безпека"
        };
            // добавляем список элементов
            domainUpDown3.Items.AddRange(speciality);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // обработка изменения текста в элементе
        private void button1_Click(object sender, EventArgs e)
        {
            for (; ; )
            {
                //Создание объекта для генерации чисел
                Random rnd = new Random();
                //Получить случайное число (в диапазоне от 0 до 50)
                int nam1 = rnd.Next(0, 50);
                int nam2;
                string text1= "";
                string text2= "";
                //Цикл по созданию 25 билетов
                for (; ; )
                {
                    nam2 = rnd.Next(0, 50);
                    if (nam2 != nam1) break;
                }
                //Условия по предмету
                if (domainUpDown1.Text == "Технології програмування")
                {
                     text1 = Convert.ToString(domainUpDown7.Items[nam1]);
                     text2 = Convert.ToString(domainUpDown7.Items[nam2]);
                }
                //Условия по предмету
                else if (domainUpDown1.Text == "Операційні системи")
                {
                     text1 = Convert.ToString(domainUpDown6.Items[nam1]);
                     text2 = Convert.ToString(domainUpDown6.Items[nam2]);
                }
                //Условия по предмету
                else if (domainUpDown1.Text == "Комп. Логіка")
                {
                     text1 = Convert.ToString(domainUpDown8.Items[nam1]);
                     text2 = Convert.ToString(domainUpDown8.Items[nam2]);
                }
                
               
                string numb = numericUpDown4.Text;
                int numb1 = Convert.ToInt32(numericUpDown3.Text);

                numericUpDown3.Text = Convert.ToString(Class1.cl_number(numb, numb1));

                number1 = Class1.cl_yaer(domainUpDown2.Text, number1);

                nam = domainUpDown1.Text;
                var helper = new Class1("1.doc");
                //Директория ключевих слов и их замены
                var item = new Dictionary<string, string>
             {
                { "<QW1>", text1 },
                { "<QW2>", text2 },
                { "<RRRR>", domainUpDown2.Text },
                { "<PTN>", numericUpDown2.Text },
                { "<PTD>", numericUpDown3.Text },
                { "<PTM>", numericUpDown4.Text },
                { "<FIO>", domainUpDown5.Text },
                { "<N>", Convert.ToString(err) },
                { "<SPB>", domainUpDown3.Text },
                { "<PRD>", domainUpDown1.Text },
                { "<KFD>", domainUpDown4.Text },
                { "<RRRN>", number1 }
            };

                if (helper.Process(item, number1, nam, err)) err++;
                progressBar1.PerformStep();
                //Конец цыкла
                if (err > 25) break;
            }
            //Уведомление
            MessageBox.Show("Файли створено!", "Повідомлення");
            err = 1;
            /*else MessageBox.Show("Error!", "Повідомлення");*/
        }
        //Ввод с клавиатуры
        private void domainUpDown2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        //Кнопка информации о авторе
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();

        }
        //Ввод с клавиатуры только цыфр
        private void numericUpDown5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}

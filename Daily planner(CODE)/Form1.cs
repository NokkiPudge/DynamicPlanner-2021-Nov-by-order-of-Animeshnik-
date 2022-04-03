using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
namespace Daily_planner
{
    public partial class Form1 : Form
    {
        string name="";
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            if (!Directory.Exists(@"C:\Plans"))
            {
                Directory.CreateDirectory(@"C:\Plans");
            }
            DirectoryInfo dir = new DirectoryInfo("C:\\Plans");
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo fi in files)
            {
                PlanList.Items.Add(fi.ToString());
            }

            PlanBox.ScrollBars = ScrollBars.Vertical;
            PlanBox.Enabled = false;
            PlanBox.Hide();
            monthCalendar1.Hide();
            CloseB.Hide();
            AcceptB.Hide();
            CreateNewButton.Hide();
            ClearButton.Hide();
            NoteBox.Hide();
            NoteLabel.Hide();
            NoteBox.MaxLength = 16;
            WatchBox.Hide();
            WatchClose.Hide();
            DataLabel.Hide();
            DataBox.Hide();
            timer1.Interval = 450;
            notifyIcon1.Icon = SystemIcons.Exclamation;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Заметка";
           
            notifyIcon1.Visible = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void CreateB_Click(object sender, EventArgs e)
        {
            PlanBox.Show();//показывает поле ввода текста заметки
            AcceptB.Show();//показывает поле принятия введенной информации
            CloseB.Show();//показывает кнопку закрытия меню
            ClearButton.Show();//показывает кнопку очистки всех поле
            CreateNewButton.Show();//показывает кнопку создания новой заметки
            PlanBox.Enabled = true;//активирует поле
            CreateNewButton.Enabled = false;//активирует кнопку
            planlabel.Hide();//скрывание надписи
            PlanList.Hide();//скрывание выпадающего списка заметок
            CreateB.Hide();//скрывание кнопки для перехода в меню создания
            DeleteB.Hide();//скрывание кнопку удаления заметки
            monthCalendar1.Show();//показывает календарь
            NoteBox.Show();//показывает поле для ввода названия заметки
            NoteLabel.Show();//показывает надпись
            WatchB.Hide();//скрывает кнопку просмотра
            DataLabel.Show();//показывает надпись
            DataBox.Show();//показывает поле для ввода даты напоминания
        }

        private void CloseB_Click(object sender, EventArgs e)
        {
            PlanBox.Hide();//скрывание поля ввода 
            ClearButton.Hide();//скрывание кнопку очистки всех поле
            AcceptB.Hide();//скрывание поле принятия введенной информации
            CloseB.Hide();//скрывание кнопку закрытия меню
            CreateNewButton.Hide();//скрывание кнопку создания новой заметки
            PlanBox.Enabled = false;//дизактивирует поле ввода
            CreateNewButton.Enabled = false;//дизактивирует кнопку создания
            planlabel.Show();//показывает надпись
            PlanList.Show();//показывает выпадающий список
            CreateB.Show();//показывает кнопку перехода в меню создания
            DeleteB.Show();//показывает кнопку удаления заметки
            monthCalendar1.Hide();//скрывание календаря
            NoteBox.Hide();//скрывание поля имени заметки
            NoteLabel.Hide();//скрывание надписи
            NoteBox.Enabled = true;//активирует  меню для записи имени
            PlanBox.Enabled = true;//активирует поле ввода заметки
            DataBox.Enabled = true;//активирует поле ввода даты
            WatchB.Show();//показывает кнопку просмотра
            PlanList.Items.Clear();//очищает выпадающий список
            DirectoryInfo dir = new DirectoryInfo("C:\\Plans");//
            FileInfo[] files = dir.GetFiles();///////////
            foreach (FileInfo fi in files)////////////// КОНСТРУКТОР ОБНОВЛЕНИЯ ВЫПАД.СПИСКА 
            {
                PlanList.Items.Add(fi.ToString());/////
            }
            DataLabel.Hide();//скрывание надписи
            DataBox.Hide();//скрывание поля для воода времени
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            PlanBox.Clear();//очистка поля ввода текста
            NoteBox.Clear();//очистка поля наименования
            DataBox.Clear();//очистка поля времени
            NoteBox.Enabled = true;//активация поля наименования
            PlanBox.Enabled = true;//активация поля ввода текста
            CreateNewButton.Enabled = false;//дизактивация кнопки создания новой заметки
        }

        private void AcceptB_Click(object sender, EventArgs e)
        {
            if (PlanBox.Text != "" && NoteBox.Text!="")//Срабатывает при условии, что заполнены поля ввода и наименования
            {
                CreateNewButton.Enabled = true;//активация кнопки создания заметки
                NoteBox.Enabled = false;//дизактивация поля наименования
                PlanBox.Enabled = false;//дизактивация поля ввода текста
                DataBox.Enabled = false;//дизактивация поля времени срабатывания
            }
            else//срабатывает, если не выполнено первое условие
            {
                MessageBox.Show("Поле для записи пустое или отсутствует имя заметки!");//вывод на экран ошибки
            }

        }

        private void CreateNewButton_Click(object sender, EventArgs e)
        {
            char[] who = NoteBox.Text.ToCharArray();//Создание массива имени
            if (who[0] == ' ')//проверка на пробелы 
            {
                MessageBox.Show("название не может начинаться с пробела");//вывод ошибки
                NoteBox.Enabled = true;//активация поля имени
                PlanBox.Enabled = true;//активация поля записей
                NoteBox.Clear();//очищение поля имени
            }
            else//если поле не пустое
            {
                if (PlanBox.Text != "" && NoteBox.Text != "")//проверка на пустоту в остальных полях
                {
                    using (StreamWriter sw = new StreamWriter(@"C:\\Plans\\" + NoteBox.Text))//класс записи
                    {
                        if (DataBox.Text != "")//проверка даты
                        {
                            sw.WriteLine(DataBox.Text);//запись даты в 1 строку
                        }
                        else//если даты нет
                        {
                            MessageBox.Show("Заметка создана без напоминания");//вывод ошибки
                            sw.WriteLine("1");//запись 1
                        }
                        sw.WriteLine(PlanBox.Text);//запись текста
                        sw.Close();//закрытие потока
                    }
                }
                else//если поля пустые
                {
                    MessageBox.Show("Поле для записи пустое или отсутствует имя заметки!");//вывод ошибки
                    CreateNewButton.Enabled = false;//дизактивация кнопки создания 
                }
            }
        }

        private void NoteBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void WatchB_Click(object sender, EventArgs e)
        {
            try {
                WatchBox.ReadOnly = true;//установка режима чтения в поле просмтотра
                if (PlanList.SelectedItem != null)//проверка на выбранную заметку
                { 
                    name = @"C:\\Plans\\" + PlanList.SelectedItem.ToString();// установка имени пути
                }
            WatchBox.Show();//показывает поле просмтора
            planlabel.Hide();//скрывание наименования
                PlanList.Hide();//скрывание выпад.список
                CreateB.Hide();//скрывание кнопки создания
                DeleteB.Hide();//скрывание кнопки удаления
                WatchB.Hide();//скрывание кнопки просмтора
                WatchClose.Show();//показывает кнопку закрыть
            using (StreamReader sr=new StreamReader(name))//поток для чтения
            {
                WatchBox.Text = sr.ReadToEnd();//считывание текста
                sr.Close();//закрытие потока
            }
            }
            catch (Exception error)//вылавливание ошибки
            {
                MessageBox.Show("Заметка не выбрана");//вывод ошибки
                WatchBox.Hide();//скрывание поля просмотра
                planlabel.Show();//показывает наименование
                PlanList.Show();//показывает выпад.список
                CreateB.Show();//показывает кнопку создания
                DeleteB.Show();//показывает кнопку удаления
                WatchB.Show();//показывает кнопку просмтора
                WatchClose.Hide();//скрывание кнопки закрывания
            }
        }

        private void WatchClose_Click(object sender, EventArgs e)
        {
            WatchBox.Hide();//скрывание поля просмтора
            planlabel.Show();//показывает наименования
            PlanList.Show();//показывает выпад.списка
            CreateB.Show();//показывает кнопку создания
            DeleteB.Show();//показывает кнопку удаления
            WatchB.Show();//показывает кнопку просмотра
            WatchBox.Clear();//очищает поле просмотра
            WatchClose.Hide();//скрывание кнопки закрытия
        }

        private void DeleteB_Click(object sender, EventArgs e)
        {
            
                if (PlanList.SelectedItem != null)//проверка на выбор заметки 
                {
                    name = @"C:\\Plans\\" + PlanList.SelectedItem.ToString();//запись пути
                    File.Delete(name);//удаление заметки
                }
           
            PlanList.Items.Clear();//
            DirectoryInfo dir = new DirectoryInfo("C:\\Plans");//
            FileInfo[] files = dir.GetFiles();///////
            foreach (FileInfo fi in files)/////////
            {
                PlanList.Items.Add(fi.ToString());//КОНСТРУКТОР ОБНОВЛЕНИЯ ВЫПАД.СПИСКА
            }

        }

        private void WatchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = new DateTime();//класс Даты и времени
            int n = PlanList.Items.Count;//запись колчиества заметок
          
            for (int i = 0; i < n; i++)//цикл проверки даты в заметках
            { string namee= "C:\\Plans" + "\\" + PlanList.Items[i].ToString();//запись пути
                using (StreamReader sr = new StreamReader(namee))//включение потока
                {
                    string dateLate = sr.ReadLine();//считывание даты
                    if (Convert.ToString(DateTime.Now) == dateLate)//сравнение с датой на пк
                    {
                        ShowIcon = false;//показывание икноки в скрыт.значках
                        notifyIcon1.Visible = true;//видимость уведомления(видимо)
                        notifyIcon1.BalloonTipText = PlanList.Items[i].ToString();//записывание имени заметки
            notifyIcon1.ShowBalloonTip(5000);//вызывание выплывающего уведомления на 5 сек
                    }
                    
                    sr.Close();//закрытие потока
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;//показ уведомления в менб скрытых значков
            notifyIcon1.Visible = false;//видимость уведомления(не видимо)

        }
    }
}

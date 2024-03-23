using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary
{
    public partial class Form1 : Form
    {
        Counter counter;
        SubjectService subjectService;
        List<Subject> subjectIn = new List<Subject>() {new Host()};
        Subject subjectCurrent = new Country();

        public Form1()
        {
            InitializeComponent();
            counter= new Counter();
            subjectService = new SubjectService(counter);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statisticlabel.Text = ("Количество стран: 0\nКоличество регионов: 0\nКоличество районов: 0\nКоличество городов: 0");
        }

        private void create_button_Click(object sender, EventArgs e) // Создание субъекта классом SubjectService
        {
            Subject subject = subjectIn.Last();
            if (typeof(Host) == subject.GetType())
            {
                subjectService.CreateCountry(nametextbox.Text, Convert.ToInt32(populationtextbox.Text), descriptiontextbox.Text); // Создание страны
                listbox.DataSource = null;
                listbox.DataSource = subjectService.countries;
                listbox.DisplayMember = "Name"; // Вывод страны в listbox
                
            } else if (typeof (Country) == subject.GetType())
            {
                subjectService.CreateRegion((Country)subject, nametextbox.Text, Convert.ToInt32(populationtextbox.Text), descriptiontextbox.Text); // Создание региона
                Country country = (Country)subject;
                listbox.DataSource = null;
                listbox.DataSource = country.subjects;
                listbox.DisplayMember = "Name";
            } else if (typeof(Region) == subject.GetType())
            {
                subjectService.CreateDistrict((Region)subject, nametextbox.Text, Convert.ToInt32(populationtextbox.Text), descriptiontextbox.Text); // Создание района
                Region region = (Region)subject;
                listbox.DataSource = null;
                listbox.DataSource = region.subjects;
                listbox.DisplayMember = "Name";

            } else if (typeof(District) == subject.GetType())
            {
                subjectService.CreateCity((District)subject, nametextbox.Text, Convert.ToInt32(populationtextbox.Text), descriptiontextbox.Text); // СОздание города
                District district = (District)subject;
                listbox.DataSource = null;
                listbox.DataSource = district.subjects;
                listbox.DisplayMember = "Name";
            }
            statisticlabel.Text = String.Format("Количество стран: {0}\nКоличество регионов: {1}\nКоличество районов: {2}\nКоличество городов: {3}", counter.CounterCountry, counter.CounterRegion, counter.CounterDistrict, counter.CounterCity);
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            Subject subject = subjectIn.Last();
            if (typeof(Host) == subject.GetType())
            {
                subjectService.DeleteCountry((Country)listbox.SelectedItem); // Удаление страны из списка
                listbox.DataSource = null;
                listbox.DataSource = subjectService.countries;
                listbox.DisplayMember = "Name";
            }
            else if (typeof(Country) == subject.GetType())
            {
                subjectService.DeleteRegion((Country)subject, (Region)listbox.SelectedItem); // Удаление региона
                Country country = (Country)subject;
                listbox.DataSource = null;
                listbox.DataSource = country.subjects;
                listbox.DisplayMember = "Name";
            }
            else if (typeof(Region) == subject.GetType())
            {
                subjectService.DeleteDistrict((Region)subject, (District)listbox.SelectedItem); // Удаление района
                Region region = (Region)subject;
                listbox.DataSource = null;
                listbox.DataSource = region.subjects;
                listbox.DisplayMember = "Name";

            }
            else if (typeof(District) == subject.GetType())
            {
                subjectService.DeleteCity((District)subject, (City)listbox.SelectedItem); // Удаление города
                District district = (District)subject;
                listbox.DataSource = null;
                listbox.DataSource = district.subjects;
                listbox.DisplayMember = "Name";
            }
            statisticlabel.Text = String.Format("Количество стран: {0}\nКоличество регионов: {1}\nКоличество районов: {2}\nКоличество городов: {3}", counter.CounterCountry, counter.CounterRegion, counter.CounterDistrict, counter.CounterCity);
        }

        private void find_button_Click(object sender, EventArgs e) // Поиск субъекта
        {
            subjectService.Note += DisplayMessage;
            subjectCurrent = subjectService.FindSubject(nametextbox.Text);
            if (subjectCurrent != null)
            { 
                infoRichTextBox.Clear();
                infoRichTextBox.Text = subjectCurrent.ToString();             
            }
        }
        private static void DisplayMessage(Object sender, SubjectEventArgs e) // Сообщение на форме
        {
            if (e.message != "По вашему запросу ничего не найдено ;(")
            {
                MessageBox.Show(String.Format(e.message));
            }
            else
            {
               MessageBox.Show(String.Format(e.message));
            }
        }

        private void clean_button_Click(object sender, EventArgs e) // Очищение полей ввода
        {
            nametextbox.Clear();
            populationtextbox.Clear();
            descriptiontextbox.Clear();
        }

        private void listbox_MouseClick(object sender, MouseEventArgs e) // Вывод информации о выбранном субъекте по клику
        {
            try
            {
                infoRichTextBox.Clear();
                infoRichTextBox.Text = listbox.SelectedItem.ToString();
            } catch (NullReferenceException)
            {
                return;
            }
            
            
        }

        private void listbox_MouseDoubleClick(object sender, MouseEventArgs e) // Переход к вложенному списку в субъекте по двойному клику
        {
            try {
                subjectIn.Add((Subject)listbox.SelectedItem);
                Subject subject = subjectIn.Last();

                if (typeof(Country) == subject.GetType())
                {
                    Country country = (Country)subject;
                    listbox.DataSource = country.subjects;
                    listlabel.Text = "Все регионы:";
                    back_button.Enabled = true;
                }
                else if (typeof(Region) == subject.GetType())
                {
                    Region region = (Region)subject;
                    listbox.DataSource = region.subjects;
                    listlabel.Text = "Все районы:";
                }
                else if (typeof(District) == subject.GetType())
                {
                    District district = (District)subject;
                    listbox.DataSource = district.subjects;
                    listlabel.Text = "Все города:";
                }
            } catch (NullReferenceException) { return; }
           
        }

        private void back_button_Click(object sender, EventArgs e) // Возвращение листбокса к предыдущему списку
        {
            if (subjectIn.Count == 1) {
                return;
            }
            subjectIn.RemoveAt(subjectIn.Count - 1);
            Subject subject = subjectIn.Last();
           
            if (typeof(Country) == subject.GetType())
            {
                Country country = (Country)subject;
                listbox.DataSource = country.subjects;
                listbox.DisplayMember = "Name";
                listlabel.Text = "Все регионы:";
            }
            else if (typeof(Region) == subject.GetType())
            {
                Region region= (Region)subject;
                listbox.DataSource = region.subjects;
                listbox.DisplayMember = "Name";
                listlabel.Text = "Все районы:";
            }
            else if (typeof(District) == subject.GetType())
            {
                District district = (District)subject;
                listbox.DataSource = district.subjects;
                listbox.DisplayMember = "Name";
                listlabel.Text = "Все города:";
            } else if (typeof(Host) == subject.GetType())
            {
                listbox.DataSource = subjectService.countries;
                listbox.DisplayMember = "Name";
                listlabel.Text = "Все страны:";
                back_button.Enabled = false;
            } else if (typeof(City) == subject.GetType())
            {
                return;
            }
        }
    }
}

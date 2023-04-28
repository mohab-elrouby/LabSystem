using Lab.Data;
using LabProject_Task1.Custom_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabProject_Task1
{
    public partial class FormInputs : UserControl
    {
        LabContext context = new LabContext();
        Dictionary<string, List<string>> CitiesEnglish = new Dictionary<string, List<string>>()
        {
            { "Alexandria", new List<string>() { "Alexandria", "Borg El Arab", "King Mariout", "Abu Qir", "Rosetta" } },
            { "Aswan", new List<string>() { "Aswan", "Edfu", "Kom Ombo" } },
            { "Asyut", new List<string>() { "Asyut", "Abnub", "Sahel Selim" } },
            { "Beheira", new List<string>() { "Damanhur", "Rashid", "Kafr El Dawwar", "Edko", "El Delengat", "Kom Hamada" } },
            { "Beni Suef", new List<string>() { "Beni Suef", "Nasser", "New Beni Suef" } },
            { "Cairo", new List<string>() { "Cairo", "Helwan", "6th of October", "Obour", "Badrshein", "El Marg" } },
            { "Dakahlia", new List<string>() { "Mansoura", "Matareya", "Aga", "Dekernes", "Talkha" } },
            { "Damietta", new List<string>() { "Damietta", "Faraskur", "Zarqa" } },
            { "Faiyum", new List<string>() { "Faiyum", "Ihnasiya El-Madinah", "Itsa", "Ibshaway", "Sannwras", "Tamia" } },
            { "Gharbia", new List<string>() { "Tanta", "El Santa", "Kafr El Zayat" } },
            { "Giza", new List<string>() { "Giza", "Badrashein", "El Ayat", "Hawamdia" } },
            { "Ismailia", new List<string>() { "Ismailia", "Fayed", "El Qantara" } },
            { "Kafr El Sheikh", new List<string>() { "Kafr El Sheikh", "Desouk", "Baltim" } },
            { "Luxor", new List<string>() { "Luxor", "Esna", "Armant" } },
            { "Matrouh", new List<string>() { "Marsa Matrouh", "Siwa", "El Hamam" } },
            { "Minya", new List<string>() { "Minya", "Maghagha","Mallawi", "Abu Qurqas" } },
            { "Monufia", new List<string>() { "Shibin El-Kom", "Ashmoun", "Tala" } },
            { "New Valley", new List<string>() { "Kharga", "Dakhla" } },
            { "North Sinai", new List<string>() { "El-Arish", "Rafah", "Bir El-Abed" } },
            { "Port Said", new List<string>() { "Port Said", "Port Fouad" } },
            { "Qalyubia", new List<string>() { "Banha", "Qalyub", "Shibin El-Kom" } },
            { "Qena", new List<string>() { "Qena", "Nag Hammadi", "Qift" } },
            { "Red Sea", new List<string>() { "Hurghada", "Sharm El Sheikh", "Marsa Alam", "Ras Ghareb" } },
            { "Sohag", new List<string>() { "Sohag", "Akhmim", "Girga" } },
            { "South Sinai", new List<string>() { "Sharm El Sheikh", "Dahab", "Nuweiba" } },
            { "Suez", new List<string>() { "Suez", "Ataqah", "Ras Sudr" } }
        };
        Dictionary<string, List<string>> CitiesArabic = new Dictionary<string, List<string>>()
        {
            { "الإسكندرية", new List<string>() { "الإسكندرية", "برج العرب", "المرج", "أبو قير", "رشيد" } },
            { "أسوان", new List<string>() { "أسوان", "إدفو", "كوم أمبو" } },
            { "أسيوط", new List<string>() { "أسيوط", "أبنوب", "ساحل سليم" } },
            { "البحيرة", new List<string>() { "دمنهور", "رشيد", "كفر الدوار", "إدكو", "الدلنجات", "كوم حمادة" } },
            { "بني سويف", new List<string>() { "بني سويف", "ناصر", "الواسطي"} },
            { "القاهرة", new List<string>() { "القاهرة", "حلوان", "السادس من أكتوبر", "العبور", "بدرشين", "المرج" } },
            { "الدقهلية", new List<string>() { "المنصورة", "المطرية", "أجا", "دكرنس", "طلخا" } },
            { "دمياط", new List<string>() { "دمياط", "فارسكور", "الزرقا" } },
            { "الفيوم", new List<string>() { "الفيوم", "إهناسيا المدينة", "تمي الأمديد" } },
            { "الغربية", new List<string>() { "طنطا", "السنطة", "كفر الزيات" } },
            { "الجيزة", new List<string>() { "الجيزة", "بدرشين", "العياط", "هرم" } },
            { "الإسماعيلية", new List<string>() { "الإسماعيلية", "الفيوم", "القنطرة" } },
            { "كفر الشيخ", new List<string>() { "كفر الشيخ", "دسوق", "بلطيم" } },
            { "الأقصر", new List<string>() { "الأقصر", "إسنا", "أرمنت" } },
            { "مطروح", new List<string>() { "مرسى مطروح", "سيوة", "الحمام" } },
            { "المنيا", new List<string>() { "المنيا", "مغاغة", "أبو قرقاص" } },
            { "المنوفية", new List<string>() { "شبين الكوم", "طنطا", "الباجور" } },
            { "الوادي الجديد", new List<string>() { "الخارجة", "الفرافرة", "بلاط" } },
            { "شمال سيناء", new List<string>() { "العريش", "رفح", "بئر العبد" } },
            { "بورسعيد", new List<string>() { "بورسعيد", "العرب" } },
            { "قنا", new List<string>() { "قنا", "نجع حمادي", "قفط" } },
            { "القليوبية", new List<string>() { "بنها", "قليوب", "شبرا الخيمة" } },
            { "السويس", new List<string>() { "السويس", "العريش" } },
            { "الشرقية", new List<string>() { "الزقازيق", "بلبيس", "منيا القمح" } },
            { "سوهاج", new List<string>() { "سوهاج", "أخميم", "الجمالية" } },
            { "جنوب سيناء", new List<string>() { "شرم الشيخ", "دهب", "نويبع" } },
            };

        private bool IsValidName = false, IsValidPhone = false, IsValidAge = false;
        private Regex nameReg = new Regex("^[a-zA-Z]{3,}(?: [a-zA-Z]+){0,2}$");
        private Regex phoneReg = new Regex("^01[0125][0-9]{8}$");


        int selecedGovernate;
        public FormInputs()
        {
            InitializeComponent();
            this.Governorates.DataSource = this.CitiesArabic.Keys.ToList();
            this.Cities.DataSource = this.CitiesArabic[this.CitiesArabic.Keys.ToList().FirstOrDefault()];
            this.testsComboBox.DataSource = context.Tests.Select(t => t.Name).ToList();
        }

        private void txtName__TextChanged(object sender, EventArgs e)
        {
            this.ValidateName(sender, e, this.txtName, this.nameError);
        }
        public void ValidateName(object sender, EventArgs e, CustomTextBox input, Label error)
        {
            if (!nameReg.IsMatch(input.Texts))
            {
                error.ForeColor = Color.Red;
                error.Text = "name is not valid";
                error.Visible= true;
            }
            else
            {
                error.Text = "";
                error.Visible= false;
                this.IsValidName= true;
            }
        }

        private void txtAge__TextChanged(object sender, EventArgs e)
        {
            this.ValidateAge(sender, e, this.txtAge, ageError);
        }

        public void ValidateAge(object sender, EventArgs e, CustomTextBox input, Label error)
        {
            if (!int.TryParse(input.Texts, out int number))
            {
                error.ForeColor = Color.Red;
                error.Text = "enter numbers only";
                error.Visible= true;
            }
            else
            {
                if(number > 100)
                {
                    error.ForeColor = Color.Red;
                    error.Text = "maximum age is 100";
                    error.Visible= true;
                }
                else
                {
                    error.Text = "";
                    error.Visible= false;
                    this.IsValidAge= true;
                }
            }
        }

        private void txtPhone__TextChanged(object sender, EventArgs e)
        {
            this.ValidatePhone(sender, e, this.txtPhone, this.phoneError);
        }

        public void ValidatePhone(object sender, EventArgs e, CustomTextBox input, Label error)
        {
            if (!phoneReg.IsMatch(input.Texts))
            {
                error.ForeColor = Color.Red;
                error.Text = "not a valid phone number";
                error.Visible= true;
            }
            else
            {
                error.Text = "";
                error.Visible= false;
                this.IsValidPhone = true;
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(this.IsValidPhone && this.IsValidName && this.IsValidAge)
            {
                Patient newPatient = new Patient() 
                {
                    Name = this.txtName.Texts,
                    Age = int.Parse(this.txtAge.Texts),
                    Phone = this.txtPhone.Texts,
                    Job= this.txtJob.Texts                     
                };
                context.Patients.Add(newPatient);
                context.SaveChanges();
                this.savedStatus.Text = "Patient saved!";
                this.savedStatus.Visible = true;
            }
            else
            {
                this.ValidateName(sender, e, this.txtName, this.nameError);
                this.ValidateAge(sender, e, this.txtAge, ageError);
                this.ValidatePhone(sender, e, this.txtPhone, this.phoneError);
                this.savedStatus.Text = "One ore more inputs are not valid";
                this.savedStatus.Visible = true;
            }
        }

        private void testsComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtPrice.Texts = context.Tests.Where(t => t.Name == this.testsComboBox.SelectedItem).Select(t => t.Price).FirstOrDefault().ToString();
            //this.txtPrice.PlaceholderText = context.Tests.Where(t => t.Name == this.testsComboBox.SelectedItem).Select(t => t.Price).FirstOrDefault().ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach(var c in this.Controls)
            {
                if (c.GetType() == typeof(CustomTextBox))
                {
                    var x = (CustomTextBox)c as CustomTextBox;
                    x.Texts = "";
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Governorates_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var index = this.Governorates.SelectedItem.ToString();
            this.Cities.DataSource = CitiesArabic[index];
        }
    }
}

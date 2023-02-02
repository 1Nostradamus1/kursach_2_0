using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace kursach_2_0
{
    public partial class mainForm : Form
    {
        private void Data()
        {
            MySqlConnection connection = new MySqlConnection(@"server=localhost;port=3306;username=root;password=root;database=contakti");
            connection.Open();
            MySqlCommand command = new MySqlCommand(@"SELECT * FROM `contakti`", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "contakti");
            dataGridView1.DataSource = ds.Tables[0];

        }
        


        public mainForm()
        {
            InitializeComponent();
            name.Text = "Имя";
            name.ForeColor = Color.Gray;
            surname.Text = "Фамилия";
            surname.ForeColor = Color.Gray;
            otchestvo.Text = "Отчество";
            otchestvo.ForeColor = Color.Gray;
            phonenumber.Text = "Номер телефона";
            phonenumber.ForeColor = Color.Gray;
            yearphone.Text = "Год установки телефона";
            yearphone.ForeColor = Color.Gray;
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void name_Enter(object sender, EventArgs e)
        {
            if (name.Text == "Имя")
            {
                name.Text = "";
                name.ForeColor = Color.Black;
            }
        }

        private void name_Leave(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                name.Text = "Имя";
                name.ForeColor = Color.Gray;
            }
        }

        private void surname_Enter(object sender, EventArgs e)
        {
            if (surname.Text == "Фамилия")
            {
                surname.Text = "";
                surname.ForeColor = Color.Black;
            }
        }

        private void surname_Leave(object sender, EventArgs e)
        {
            if (surname.Text == "")
            {
                surname.Text = "Фамилия";
                surname.ForeColor = Color.Gray;
            }
        }

        private void otchestvo_Enter(object sender, EventArgs e)
        {
            if (otchestvo.Text == "Отчество")
            {
                otchestvo.Text = "";
                otchestvo.ForeColor = Color.Black;
            }
        }

        private void otchestvo_Leave(object sender, EventArgs e)
        {
            if (otchestvo.Text == "")
            {
                otchestvo.Text = "Отчество";
                otchestvo.ForeColor = Color.Gray;
            }
        }

        private void phonenumber_Enter(object sender, EventArgs e)
        {
            if (phonenumber.Text == "Номер телефона")
            {
                phonenumber.Text = "";
                phonenumber.ForeColor = Color.Black;
            }
        }

        private void phonenumber_Leave(object sender, EventArgs e)
        {
            if (phonenumber.Text == "")
            {
                phonenumber.Text = "Номер телефона";
                phonenumber.ForeColor = Color.Gray;
            }
        }

        private void yearphone_Enter(object sender, EventArgs e)
        {
            if (yearphone.Text == "Год установки телефона")
            {
                yearphone.Text = "";
                yearphone.ForeColor = Color.Black;
            }
        }

        private void yearphone_Leave(object sender, EventArgs e)
        {
            if (yearphone.Text == "")
            {
                yearphone.Text = "Год установки телефона";
                yearphone.ForeColor = Color.Gray;
            }
        }
        private bool Checker()
        {
            if (name.Text == "Имя")
            {
                MessageBox.Show("Заполните имя");
                return false;
            }
            if (surname.Text == "Фамилия")
            {
                MessageBox.Show("Заполните фамилию");
                return false;
            }
            if (otchestvo.Text == "Отчество")
            {
                MessageBox.Show("Заполните отчество");
                return false;
            }
            if (phonenumber.Text == "Номер телефона")
            {
                MessageBox.Show("Заполните номер телефона");
                return false;
            }
            if (yearphone.Text == "Год установки")
            {
                MessageBox.Show("Заполните год установки телефона");
                return false;
            }


            if (phonenumber.Text.Length != 11)
            {
                MessageBox.Show("Введите номер коректно");
                return false;
            }

            foreach (char num in phonenumber.Text)
            {
                if (char.IsDigit(num) == false)
                {
                    MessageBox.Show("Номер должен состоять из чисел");
                    return false;
                }
            }
            foreach (char num in yearphone.Text)
            {
                if (char.IsDigit(num) == false)
                {
                    MessageBox.Show("Год должен состоять из чисел");
                    return false;
                }
            }
            foreach (char num in name.Text)
            {
                if (char.IsLetter(num) == false)
                {
                    MessageBox.Show("Используйте буквы для написания имени");
                    return false;
                }
            }
            foreach (char num in surname.Text)
            {
                if (char.IsLetter(num) == false)
                {
                    MessageBox.Show("Используйте буквы для написания фамилии");
                    return false;
                }
            }
            foreach (char num in otchestvo.Text)
            {
                if (char.IsLetter(num) == false)
                {
                    MessageBox.Show("Используйте буквы для написания отчества");
                    return false;
                }
            }


            if (yearphone.Text.Length != 4)
            {
                MessageBox.Show("Введите год коректно");
                return false;
            }
            else return true;
        } 
        

        private void add_button_Click(object sender, EventArgs e)
        {
            bool check = Checker();
            if (check==true)
            {
                Db2 db = new Db2();
                MySqlCommand command = new MySqlCommand("INSERT INTO `contakti` (`name`, `surname`, `otchestvo`, `phonenumber`, `year`) VALUES (@name, @sur, @otchestvo, @phonenumber, @year)", db.getConnection());
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
                command.Parameters.Add("@sur", MySqlDbType.VarChar).Value = surname.Text;
                command.Parameters.Add("@otchestvo", MySqlDbType.VarChar).Value = otchestvo.Text;
                command.Parameters.Add("@phonenumber", MySqlDbType.VarChar).Value = phonenumber.Text;
                command.Parameters.Add("@year", MySqlDbType.VarChar).Value = yearphone.Text;
                
                db.openConnection();
                

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Абонент успешно добавлен");
                else
                    MessageBox.Show("Абонент не добавлен");


                

                db.closeConnection();
                Data();
                name.Clear();

                name.Text = "Имя";
                name.ForeColor = Color.Gray;

                surname.Clear();

                surname.Text = "Фамилия";
                surname.ForeColor = Color.Gray;

                otchestvo.Clear();
                otchestvo.Text = "Отчество";
                otchestvo.ForeColor = Color.Gray;
                phonenumber.Clear();
                phonenumber.Text = "Номер телефона";
                phonenumber.ForeColor = Color.Gray;
                yearphone.Clear();
                yearphone.Text = "Год установки телефона";
                yearphone.ForeColor = Color.Gray;
            }

        }
        
        private void mainForm_Load(object sender, EventArgs e)
        {
           Data();
            
          

        }
        
        private void deleteButton_Click(object sender, EventArgs e)
        {
            string messege = "Вы действительно хотите удалить пользователя?";
            if (MessageBox.Show(messege,"Внимание",MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            else
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    int id;

                    id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                    Db2 db = new Db2();
                    MySqlCommand command = new MySqlCommand("DELETE FROM contakti WHERE `contakti`.`id` =" + id, db.getConnection());
                    db.openConnection();

                    Data();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        Data();
                        MessageBox.Show("Абонент успешно удален");
                    }
                    else
                        MessageBox.Show("Абонент не удален");




                    db.closeConnection();
                }
                else
                {
                    MessageBox.Show("Выделите всю строку");
                }
            }
           
        }

       

        private void button1_Click_1(object sender, EventArgs e)//кнопка изменить
        {
            bool check = Checker();
            if (check == true)
            {

                if (dataGridView1.SelectedRows.Count == 1)
                {

                    Db2 db = new Db2();
                    int id;

                    id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                    MySqlCommand command = new MySqlCommand("UPDATE `contakti` SET `name` = @name, `surname` = @sur, `otchestvo` = @otchestvo, `year` = @year WHERE `contakti`.`id` =" + id, db.getConnection());

                    if (name.Text != "Имя" && surname.Text != "Фамилия" && otchestvo.Text != "Отчество" && phonenumber.Text != "Номер телефона" && yearphone.Text != "Год установки")
                    {
                        command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
                        command.Parameters.Add("@sur", MySqlDbType.VarChar).Value = surname.Text;
                        command.Parameters.Add("@otchestvo", MySqlDbType.VarChar).Value = otchestvo.Text;
                        command.Parameters.Add("@phonenumber", MySqlDbType.VarChar).Value = phonenumber.Text;
                        command.Parameters.Add("@year", MySqlDbType.VarChar).Value = yearphone.Text;
                        db.openConnection();


                        if (command.ExecuteNonQuery() == 1)
                            MessageBox.Show("Абонент успешно изменён");
                        else
                            MessageBox.Show("Абонент не добавлен");




                        db.closeConnection();
                        Data();
                        name.Clear();

                        name.Text = "Имя";
                        name.ForeColor = Color.Gray;

                        surname.Clear();

                        surname.Text = "Фамилия";
                        surname.ForeColor = Color.Gray;

                        otchestvo.Clear();
                        otchestvo.Text = "Отчество";
                        otchestvo.ForeColor = Color.Gray;
                        phonenumber.Clear();
                        phonenumber.Text = "Номер телефона";
                        phonenumber.ForeColor = Color.Gray;
                        yearphone.Clear();
                        yearphone.Text = "Год установки телефона";
                        yearphone.ForeColor = Color.Gray;

                    }
                    else if (name.Text == "Имя")
                    {
                        MessageBox.Show("Заполните имя для изменения!");
                    }
                    else if (surname.Text == "Фамилия")
                    {
                        MessageBox.Show("Заполните фамилию для изменения!");
                    }


                    else if (otchestvo.Text == "Отчество")
                    {
                        MessageBox.Show("Заполните отчество для изменения!");
                    }
                    else if (phonenumber.Text == "Номер телефона")
                    {
                        MessageBox.Show("Заполните номер телефона для изменения!");
                    }
                    else if (yearphone.Text == "Год установки")
                    {
                        MessageBox.Show("Заполните год для изменения!");
                    }




                }
                else
                {
                    MessageBox.Show("Выделите всю строку");
                }
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
       
           }
        void saveTable()
        {
        //    string path = System.IO.Directory.GetCurrentDirectory() + @"\" + "savechanel.xlsx";
        //    Ex.Application exapp = new Ex.Application();
        //    Ex.Workbook workbook = exapp.Workbooks.Add();
        //    Ex.Worksheet worksheet = workbook.get_ActiveSheet();
        }

        private void button_word_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.Unicode);
                try
                {
                    List<int> col_n = new List<int>();
                    foreach (DataGridViewColumn col in dataGridView1.Columns)
                        if (col.Visible)
                        {
                            //sw.Write(col.HeaderText + "\t");
                            col_n.Add(col.Index);
                        }
                    //sw.WriteLine();
                    int x = dataGridView1.RowCount;
                    if (dataGridView1.AllowUserToAddRows) x--;

                    for (int i = 0; i < x; i++)
                    {
                        for (int y = 0; y < col_n.Count; y++)
                            sw.Write(dataGridView1[col_n[y], i].Value + "\t");
                        sw.Write(" \r\n");
                    }
                    sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
                

            }

        }   

            private void panel2_Paint(object sender, PaintEventArgs e)//поиск
        {

           
        }
    }
}







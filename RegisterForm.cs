using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach_2_0
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            Login.Text = "Введите логин";
            Login.ForeColor = Color.Gray;
            Password.Text = "Введите пароль";
            Password.ForeColor = Color.Gray;
            PhoneNumber.Text = "Введите номер";
            PhoneNumber.ForeColor = Color.Gray;
            Username.Text = "Введите имя";
            Username.ForeColor = Color.Gray;
            UserSerName.Text = "Введите фамилию";
            UserSerName.ForeColor = Color.Gray;
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Enter(object sender, EventArgs e)
        {
            if (Login.Text == "Введите логин")
            {
                Login.Text = "";
                Login.ForeColor = Color.Black;
            }
        }

        private void Login_Leave(object sender, EventArgs e)
        {
            if (Login.Text == "")
            {
                Login.Text = "Введите логин";
                Login.ForeColor = Color.Gray;
            }

        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Введите пароль")
            {
                Password.Text = "";
                Password.ForeColor = Color.Black;
            }

        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "Введите пароль";
                Password.ForeColor = Color.Gray;
            }
        }

        private void PhoneNumber_Enter(object sender, EventArgs e)
        {
            if (PhoneNumber.Text == "Введите номер")
            {
                PhoneNumber.Text = "";
                PhoneNumber.ForeColor = Color.Black;
            }

        }

        private void PhoneNumber_Leave(object sender, EventArgs e)
        {
            if (PhoneNumber.Text == "")
            {
                PhoneNumber.Text = "Введите номер";
                PhoneNumber.ForeColor = Color.Gray;
            }

        }

        private void Username_Enter(object sender, EventArgs e)
        {
            if (Username.Text == "Введите имя")
            {
                Username.Text = "";
                Username.ForeColor = Color.Black;
            }

        }

        private void Username_Leave(object sender, EventArgs e)
        {
            if (Username.Text == "")
            {
                Username.Text = "Введите имя";
                Username.ForeColor = Color.Gray;
            }
        }

        private void UserSerName_Enter(object sender, EventArgs e)
        {
            if (UserSerName.Text == "Введите фамилию")
            {
                UserSerName.Text = "";
                UserSerName.ForeColor = Color.Black;
            }
        }

        private void UserSerName_Leave(object sender, EventArgs e)
        {
            if (UserSerName.Text == "")
            {
                UserSerName.Text = "Введите фамилию";
                UserSerName.ForeColor = Color.Gray;
            }
        }
        private bool Check() 
        {

            foreach (char num in Username.Text)
            {
                if (char.IsLetter(num) == false)
                {
                    MessageBox.Show("Имя должно состоять из букв");
                    return false;
                }
            }
            foreach (char num in UserSerName.Text)
            {
                if (char.IsLetter(num) == false)
                {
                    MessageBox.Show("Фамилия должна состоять из букв");
                    return false;
                }
            }
            foreach (char num in PhoneNumber.Text)
            {
                if (char.IsDigit(num) == false)
                {
                    MessageBox.Show("Номер должен состоять из цифр");
                    return false;
                }
            }



            if (PhoneNumber.Text.Length != 11)
            {
                MessageBox.Show("Введите номер корректно ");
                return false;
            }

            else return true;
        }
        private void ButtonRegistration_Click(object sender, EventArgs e)
        {
            bool check = Check();
            if (check == true)
            {
                DataBaza db = new DataBaza();
                MySqlCommand command = new MySqlCommand("INSERT INTO `nostradamus` (`login`, `password`, `number`, `name`, `sername`) VALUES (@login, @pass, @numb, @name, @sername)", db.getConnection());
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = Login.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Password.Text;
                command.Parameters.Add("@numb", MySqlDbType.VarChar).Value = PhoneNumber.Text;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = Username.Text;
                command.Parameters.Add("@sername", MySqlDbType.VarChar).Value = UserSerName.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Аккаунт успешно создан");
                else
                    MessageBox.Show("Не удалось создать аккаунт");



                db.closeConnection();
                Login.Text = "Введите логин";
                Login.ForeColor = Color.Gray;
                Password.Text = "Введите пароль";
                Password.ForeColor = Color.Gray;
                PhoneNumber.Text = "Введите номер";
                PhoneNumber.ForeColor = Color.Gray;
                Username.Text = "Введите имя";
                Username.ForeColor = Color.Gray;
                UserSerName.Text = "Введите фамилию";
                UserSerName.ForeColor = Color.Gray;
                this.Hide();
                Form1 loginForm = new Form1();
                loginForm.Show();
            }
        }
        public Boolean CheckUser()
        {
            DataBaza DB = new DataBaza();

            DataTable table = new DataTable();
            DataTable table1 = new DataTable();
          
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter();
           

            MySqlCommand command = new MySqlCommand("SELECT * FROM `nostradamus` WHERE `login` = @uL ", DB.getConnection());
            MySqlCommand comman = new MySqlCommand("SELECT * FROM `nostradamus` WHERE `number` = @num ", DB.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Login.Text;
            comman.Parameters.Add("@num", MySqlDbType.VarChar).Value = PhoneNumber.Text;
            adapter.SelectCommand = command;
            adapter1.SelectCommand = comman;
            adapter1.Fill(table1);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже есть, введите другой");
                return true;
            }
           
             if (table1.Rows.Count > 0)
            {
                MessageBox.Show("Такой номер уже есть, введите другой");
                return true;
            }
            else
                return false;

        }

        private void Labelfinish_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginForm = new Form1(); 
            loginForm.Show();
        }

        private void LabelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

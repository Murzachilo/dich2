using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace dich
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection conn;
        public MainWindow()
        {
            InitializeComponent();
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=" + System.Environment.MachineName + ";Initial Catalog=CompStrahOfAuto;Integrated Security=True";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Password == "")
            {
                MessageBox.Show("логин или пароль пуст", textBox1.Text);
                return;
            }  // Проверка на заполнение
            else
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                DataTable useresTable = new DataTable();
                SqlCommand comm = new SqlCommand("SELECT * FROM Сотрудники WHERE Login = '" + textBox1.Text + "' AND Password = '" + textBox2.Password + "' AND IdRole = 0", conn);

                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                comm.ExecuteNonQuery();
                adapter.Fill(useresTable);
                if (useresTable.Rows.Count > 0)
                {
                    this.Hide();
                    adminMenu dlg = new adminMenu();
                    dlg.Show();
                    //Вход как админ

                    // Проверка на админа
                }
                else
                {
                    SqlCommand com = new SqlCommand("SELECT * FROM Сотрудники WHERE Login = '" + textBox1.Text + "' AND Password = '" + textBox2.Password + "'", conn);
                    DataTable useresTabl = new DataTable();

                    SqlDataAdapter adapte = new SqlDataAdapter(com);
                    com.ExecuteNonQuery();
                    adapte.Fill(useresTabl);
                    if (useresTabl.Rows.Count > 0)
                    {
                        this.Hide();
                        Menu dlg = new Menu();
                        dlg.Show();
                        // Вход как пользователя
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                        // Уведомление о не входе
                    }

                }
                // Проверка на пользователя
            }
        }
    }
}

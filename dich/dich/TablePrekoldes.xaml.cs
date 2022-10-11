using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace dich
{
    /// <summary>
    /// Логика взаимодействия для TablePrekoldes.xaml
    /// </summary>
    public partial class TablePrekoldes : Window
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataTable phonesTable;
        string AccId;
        bool s = false;
        int typeSql;
        public TablePrekoldes()
        {
            InitializeComponent();
            conn = new SqlConnection();
            //сonn = new SqlConnection();
            //adapter = new SqlDataAdapter(command);
            conn.ConnectionString = "Data Source=localhost;Initial Catalog=CompStrahOfAuto;Integrated Security=True";
            phonesGrid.CanUserAddRows = false;
        }

        private void BtnForm_Click(object sender, RoutedEventArgs e)
        {
            /*TaskWindow taskWindow = new TaskWindow();            // Изменение 
            DataRowView row = (DataRowView)phonesGrid.SelectedItems[0];
            taskWindow.rw = row;
            taskWindow.Show();
            //MessageBox.Show(taskWindow.strQuery);
            this.Close();
            /*if (conn.State == ConnectionState.Closed) conn.Open();
            DataTable phonesTable = new DataTable("Phones");

            SqlCommand comm = new SqlCommand(taskWindow.strQuery, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            comm.ExecuteNonQuery();
            comm.CommandText = "SELECT * FROM Аккаунты";
            comm.ExecuteNonQuery();
            adapter.Fill(phonesTable);
            phonesGrid.ItemsSource = phonesTable.DefaultView;*/
        }

        private void MainWindow1_Loaded(object sender, RoutedEventArgs e)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();

            DataTable phonesTable = new DataTable();
            SqlCommand comm = new SqlCommand("SELECT Серия, Номер, [Дата рождения], [Дата начала стажа] FROM [Водительское удостверение]", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            comm.ExecuteNonQuery();
            adapter.Fill(phonesTable);
            phonesGrid.ItemsSource = phonesTable.DefaultView;
            //phonesGrid.SelectedIndex = 0;
            phonesGrid.Focus();
            phonesGrid.SelectedItem = phonesGrid.Items[0];
            phonesGrid.ScrollIntoView(phonesGrid.Items[0]);
        }

        private void BtnInsert_Click(object sender, RoutedEventArgs e)
        {

            //TaskWindow taskWindow = new TaskWindow();
            //DataRowView row = (DataRowView)phonesGrid.SelectedItems[0];      //Обработчик добавить
            //taskWindow.rw = row;
            //taskWindow.rw = null;
            //taskWindow.Show();
            //this.Close();
            /*MessageBox.Show(taskWindow.strQuery);

            if (conn.State == ConnectionState.Closed) conn.Open();
            DataTable phonesTable = new DataTable("Аккаунт");

            SqlCommand comm = new SqlCommand(taskWindow.strQuery, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            comm.ExecuteNonQuery();
            comm.CommandText = "SELECT * FROM Аккаунт";
            comm.ExecuteNonQuery();
            adapter.Fill(phonesTable);
            phonesGrid.ItemsSource = phonesTable.DefaultView;*/
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            int count_row = phonesGrid.Items.Count;
            MessageBox.Show(Convert.ToString(count_row));
            try
            {

                DataRowView row = (DataRowView)phonesGrid.SelectedItems[0];

                // MessageBox.Show(Convert.ToString(row["Title"]));
                AccId = Convert.ToString(row["Код"]);
                MessageBox.Show("DELETE  FROM Аккаунт WHERE Id = '" + AccId + "'");


                if (conn.State == ConnectionState.Closed) conn.Open();
                DataTable phonesTable = new DataTable("Аккаунт");
                SqlCommand comm = new SqlCommand("DELETE  FROM Аккаунт WHERE Код = '" + AccId + "'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                comm.ExecuteNonQuery();
                comm.CommandText = "SELECT * FROM Аккаунт";
                comm.ExecuteNonQuery();
                adapter.Fill(phonesTable);
                phonesGrid.ItemsSource = phonesTable.DefaultView;

            }
            catch
            {
                MessageBox.Show("нет данных");
                return;
            }



        }


        private void phonesGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

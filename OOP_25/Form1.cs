using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OOP_25
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection;

        public Form1()
        {
            InitializeComponent();
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\koval\\Downloads\\OOP_25-master\\OOP_25-master\\OOP_25\\FictionBD.accdb";
            connection = new OleDbConnection(connectionString);
            Writters();
            States();
            Books();
        }

        private void Video_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fictionBDDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.fictionBDDataSet.Books);

        }

        private void Books()
        {
            string query = "SELECT Books.BooksId, Books.BooksNames, Books.YearOfWriting, Writters.WrittersNames as Writters, States.StatesNames as States " +
                           "FROM ((Books " +
                           "INNER JOIN Writters ON Books.WrittersID = Writters.WrittersID) " +
                           "INNER JOIN States ON Books.StatesID = States.StatesID)";

            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewMovies.DataSource = table;
        }

        private void Writters()
        {
            string query = "SELECT WrittersID, WrittersNames FROM Writters";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBoxWritters.DataSource = table;
            comboBoxWritters.DisplayMember = "WrittersNames";
            comboBoxWritters.ValueMember = "WrittersID";
        }

        private void States()
        {
            string query = "SELECT StatesID, StatesNames FROM States";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBoxState.DataSource = table;
            comboBoxState.DisplayMember = "StatesNames";
            comboBoxState.ValueMember = "StatesID";
        }

        private bool CounterOfBooks(string title)
        {
            string query = "SELECT COUNT(*) FROM Books WHERE BooksNames = @BooksNames";
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@BooksNames", title);

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                int count = (int)command.ExecuteScalar();
                connection.Close();

                return count > 0;
            }
        }

        private void Add(string title, int year, int directorId, int genreId)
        {
            try
            {
                string query = "INSERT INTO Books (BooksNames, YearOfWriting, WrittersID, StatesID) VALUES (@BooksNames, @YearOfWriting, @WrittersID, @StatesID)";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BooksNames", title);
                    command.Parameters.AddWithValue("@YearOfWriting", year);
                    command.Parameters.AddWithValue("@WrittersID", directorId);
                    command.Parameters.AddWithValue("@StatesID", genreId);

                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    command.ExecuteNonQuery();
                    connection.Close();

                    Books();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void FirstReport()
        {
            string query = "SELECT Writters.WrittersNames, COUNT(Books.BooksID) AS MovieCount " +
                           "FROM Books " +
                           "INNER JOIN Writters ON Books.WrittersID = Writters.WrittersID " +
                           "GROUP BY Writters.WrittersNames";

            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewReport.DataSource = table;
        }

        private void SecondReport()
        {
            string query = "SELECT States.StatesNames, COUNT(Books.BooksID) AS MovieCount " +
                           "FROM Books " +
                           "INNER JOIN States ON Books.StatesID = States.StatesID " +
                           "GROUP BY States.StatesNames";

            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewReport.DataSource = table;
        }

        private void Search(string title)
        {
            string query = "SELECT Books.BooksId, Books.BooksNames, Books.YearOfWriting, Writters.WrittersNames as Writters, States.StatesNames as States " +
                           "FROM ((Books " +
                           "INNER JOIN Writters ON Books.WrittersID = Writters.WrittersID) " +
                           "INNER JOIN States ON Books.StatesID = States.StatesID)" +
                                   "WHERE Books.BooksNames LIKE @BooksNames";

            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@BooksNames", "%" + title + "%");

                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewMovies.DataSource = table;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string title = textBoxSearch.Text;
            Search(title);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            Books();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxBooksNames.Text) ||
           string.IsNullOrWhiteSpace(textBoxYear.Text) ||
           comboBoxWritters.SelectedValue == null ||
           comboBoxState.SelectedValue == null)
            {
                MessageBox.Show("Будь ласка, заповніть всі поля перед додаванням фільму.");
                return;
            }

            if (int.TryParse(textBoxYear.Text, out int year) &&
                int.TryParse(comboBoxWritters.SelectedValue.ToString(), out int directorId) &&
                int.TryParse(comboBoxState.SelectedValue.ToString(), out int genreId))
            {
                string title = textBoxBooksNames.Text;

                if (CounterOfBooks(title))
                {
                    MessageBox.Show("Фільм з таким заголовком вже існує.");
                    return;
                }

                Add(title, year, directorId, genreId);
            }
            else
            {
                MessageBox.Show("Перевірте правильність введених даних.");
            }
        }

        private void buttonReportByState_Click(object sender, EventArgs e)
        {
            SecondReport();
        }

        private void buttonReportByWritters_Click(object sender, EventArgs e)
        {
            FirstReport();
        }
    }
}

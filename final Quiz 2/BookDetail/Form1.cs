using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookDetail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Book> GetBookForSearch(string name)
        {
            string sql = "SELECT * FROM Books WHERE Name LIKE '%" + name + "%'";
            DataAccess dataAccess = new DataAccess();
            SqlDataReader sqlDataReader = dataAccess.GetData(sql);
            List<Book> books = new List<Book>();
            while (sqlDataReader.Read())
            {
                Book book = new Book((int)sqlDataReader["id"], sqlDataReader["Name"].ToString(), sqlDataReader["Author"].ToString(), sqlDataReader["Edition"].ToString());
                books.Add(book);
            }
            return books;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetBookForSearch(textBox1.Text);
        }
    }
}

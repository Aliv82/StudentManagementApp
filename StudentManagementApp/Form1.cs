using StudentManagementApp.Data;
using System;
using System.Linq;
using System.Windows.Forms;
using StudentManagementApp.Data;

namespace StudentManagementApp
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext _context;
        public Form1()
        {
            InitializeComponent();
            _context = new AppDbContext();
            LoadStudents();
        }

        private void LoadStudents()
        {
            var data = _context.Students
                .Select(s => new
                {
                    s.Id,
                    FullName = s.FirstName + " " + s.LastName,
                    s.Email,
                    s.BirthDate
                })
                .ToList();

            dataGridView1.DataSource = data;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

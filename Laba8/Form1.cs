using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModels;
using LinqToDB;
using Npgsql;

namespace Laba8
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new Ivt191dyachkovskiyamanDB())
            {
                var q =
                    from c in db.Students
                    where c.Surname.StartsWith("И") || c.Name.StartsWith("И")
                    select c;
                dataGridView1.DataSource = q.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new Ivt191dyachkovskiyamanDB())
            {
                var q =
                    from c in db.Students
                    where c.Kurs == 2
                    orderby c.Surname
                    join p in db.ExamMarks on c.StudentId equals p.StudentId
                    select new { c.Surname, p.Mark };
                dataGridView1.DataSource = q.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var db = new Ivt191dyachkovskiyamanDB())
            {
                var q =
                    from c in db.Lectures
                    join p in db.Subjects on c.UnivId equals p.SubjId
                    select new { c.Surname};
                dataGridView1.DataSource = q.ToList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var db = new Ivt191dyachkovskiyamanDB())
            {
                var max = db.Students.Select(c => c.Stipend).Max();
            var q =
                (from c in db.Students
                 where c.Kurs > 2 && c.Stipend == max
                 select new { c.Name, c.Surname, c.Kurs, c.Stipend });

            dataGridView1.DataSource = q.ToList();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var db = new Ivt191dyachkovskiyamanDB())
            {
                var q = db.ExamMarks.Where(c => c.SubjId == 10).Select(c => c.Mark).Average();

                label1.Text = q.ToString();
            }
        }
    }
}

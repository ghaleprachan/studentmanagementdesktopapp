using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StudentInformationSystem
{
    public partial class StudentForm : Form
    {
        private int count = 0; 
        private BindingList<Student> StudentList;

        public string[] CourseList { get; private set; }

        public StudentForm()
        {
            InitializeComponent();
            InitSettings();
            LoadGrid();
        }

        private void InitSettings()
        {
            this.ComboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            this.CourseList = this.ComboCourse.Items.Cast<Object>().Select(item => item.ToString()).ToArray();
            this.ComboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboSort.DropDownStyle = ComboBoxStyle.DropDownList;
            this.DateReg.Format = DateTimePickerFormat.Custom;
            this.DateReg.CustomFormat = "dd/MM/yyyy";
        }

        private void LoadGrid()
        {
            StudentList = new BindingList<Student>(new List<Student>());
            DGStudent.DataSource = StudentList;
            foreach (DataGridViewColumn item in DGStudent.Columns)
            {
                item.ReadOnly = true;
            }
            for (int i = 0; i < CourseList.Length; i++)
            {
                ChartReport.Series.Add(CourseList[i]);
            }
            updateReport();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (TxtFirstName.TextLength == 0
                || TxtLastName.TextLength == 0
                || TxtAddress.TextLength == 0
                || TxtEmail.TextLength == 0
                || TxtContact.TextLength == 0
                || DateReg.Text.Length == 0
                || ComboStatus.Text.Length == 0
                || ComboCourse.Text.Length == 0)
            {
                MessageBox.Show("Fields should not be empty", "Invalid form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                addStudent();
            }
        }

        /// <summary>Adds students to list.</summary>
        private void addStudent()
        {
            Student std;
            std = new Student
            {
                Id = count++,
                FirstName = TxtFirstName.Text,
                LastName = TxtLastName.Text,
                Address = TxtFirstName.Text,
                Email = TxtFirstName.Text,
                ContactNo = TxtContact.Text,
                EnrolledCourse = ComboCourse.SelectedItem.ToString(),
                Status = ComboStatus.SelectedItem.ToString(),
                RegistrationDate = DateReg.Value
            };
            this.StudentList.Add(std);
            updateReport();
            clearList();
        }

        private void updateReport()
        {
            var columns = from course in this.CourseList
                          select new Course
                          {
                              CourseName = course,
                              Count = getEnrolled(course)
                          };
            DGReport.DataSource = columns.ToList();
            foreach (DataGridViewColumn item in DGReport.Columns)
            {
                item.ReadOnly = true;
            }
            BindChart(columns);
        }

        private void BindChart(IEnumerable<Course> columns)
        {
            //ChartReport.DataSource = columns.ToList();
            for (int i = 0; i < CourseList.Length; i++)
            {
                ChartReport.Series[CourseList[i]].XValueType = ChartValueType.String;
                ChartReport.Series[CourseList[i]].YValueType = ChartValueType.Auto;
                List<string> xvals = new List<string>
                {
                    ""
                };
                List<Int32> yvals = new List<Int32>();
                var count = columns.Where(item => item.CourseName == CourseList[i]).First();
                yvals.Add(count.Count);
                ChartReport.Series[CourseList[i]].Points.DataBindXY(xvals.ToArray(), yvals.ToArray());
            }
        }

        private int getEnrolled(string enrolledCourse)
        {
            var query = from t in StudentList
                        where t.EnrolledCourse == enrolledCourse
                            && t.Status == "Enrolled"
                            && givenWeek(t.RegistrationDate)
                        select t;
            return query.Count();
        }

        private bool givenWeek(DateTime registrationDate)
        {
            return true;
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            bool asc = PanelDataGrid.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked).Text == "Ascending";
            SortList(asc, ComboSort.SelectedItem.ToString());
        }

        private void SortList(bool asc, string sortBy)
        {
            // Selection Sort
            for (int i=0; i < StudentList.Count(); i++)
            {
                for (int j = i; j < StudentList.Count(); j++)
                {
                    int compared;
                    if (sortBy == "First Name")
                    {
                        compared = String.Compare(StudentList[i].FirstName, StudentList[j].FirstName);
                    }
                    else
                    {
                        compared = DateTime.Compare(StudentList[i].RegistrationDate, StudentList[j].RegistrationDate);
                    }
                    if ((asc && compared > 0) || (!asc && compared < 0))
                    {
                        SwapItems(i, j);
                    }
                }
            }
        }

        private void SwapItems(int i, int j)
        {
            var temp = StudentList[i];
            StudentList[i] = StudentList[j];
            StudentList[j] = temp;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clearList();
        }

        private void clearList()
        {
            TxtAddress.ResetText();
            TxtFirstName.ResetText();
            TxtLastName.ResetText();
            TxtEmail.ResetText();
            TxtContact.ResetText();
        }
    }
}

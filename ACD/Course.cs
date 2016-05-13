using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACD
{
    public class Course
    {
        public List<Course> Prerequisites = new List<Course>();
        public List<Course> Postrequisites = new List<Course>(); //todo add to constructor
        private string courseNumber_;
        private string core_; //coursegroup
        private string courseName_;
        private string description_;
        private string format_;
        private float creditHours_;
        public Course(string CourseNumber, string Core, string CourseName, string Description, float CreditHours)
        {
            this.CourseNumber = CourseNumber;
            this.Core = Core;
            this.CourseName = CourseName;
            this.Description = Description;
            this.CreditHours = CreditHours;
        }
        
        public bool HasLab { get; set; }
        
        public string CourseNumber
        {
            get { return courseNumber_; }
            set
            {
                if (value.Length > 10)
                {
                    //System.Windows.Forms.MessageBox.Show("Course number to large");
                    throw new Exception("Course number to large");
                }
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value can not be null or empty");
                }
                courseNumber_ = value;
            }
        }
        public void addPostrequisites()
        {
            foreach (Course VARIABLE in Postrequisites)
            {
                this.Prerequisites.Add(VARIABLE);
            }
        }
        public void addPrerequisites()
        {
            foreach (Course VARIABLE in Prerequisites)
            {
                this.Prerequisites.Add(VARIABLE);
            }
        }
        public string Core
        {
            get { return core_; }
            set
            {
                if (value.Length > 50)
                {
                    //System.Windows.Forms.MessageBox.Show("Course number to large");
                    throw new Exception("Core name to large");
                }
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value can not be null or empty");
                }
                core_ = value;
            }
        }
        public string CourseName
        {
            get { return courseName_; }
            set
            {
                if (value.Length > 50)
                {
                    //System.Windows.Forms.MessageBox.Show("Course number to large");
                    throw new Exception("Course name to large");
                }
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value can not be null or empty");
                }
                courseName_ = value;
            }
        }
        public string Description
        {
            get
            {
                return description_;
            }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value can not be null or empty");
                }
                description_ = value;
            }
        }
        public float CreditHours
        {
            get { return creditHours_; }
            set
            {
                if (value < 1)
                {
                    //System.Windows.Forms.MessageBox.Show("Course number to large");
                    throw new Exception("Can't have 0 hours for a Course");
                }
                creditHours_ = value;
            }
        }
        public string Format
        {
            get { return format_; }
            set
            {
                if (value.Length > 50)
                {
                    //System.Windows.Forms.MessageBox.Show("Course number to large");
                    throw new Exception("Format name to large");
                }
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value can not be null or empty");
                }
                format_ = value;
            }
        }
    }
}

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
        private string _courseNumber;
        private string _core;
        private string _courseName;
        private string _description;
        private string _format;
        private float _creditHours;
        public Course(string CourseNumber, string Core, string CourseName, string Description, float CreditHours, string Format, Course[] Prerequisities, bool HasLab)
        {
            this.CourseNumber = CourseNumber;
            this.Core = Core;
            this.CourseName = CourseName;
            this.Description = Description;
            this.CreditHours = CreditHours;
            this.Format = Format;
            foreach (Course VARIABLE in Prerequisities)
            {
                this.Prerequisites.Add(VARIABLE);
            }
            this.HasLab = HasLab;
        }
        public Course(string CourseNumber, string Core, string CourseName, string Description, float CreditHours, string Format, Course[] Prerequisities)
        {
            this.CourseNumber = CourseNumber;
            this.CourseNumber = CourseNumber;
            this.Core = Core;
            this.CourseName = CourseName;
            this.Description = Description;
            this.CreditHours = CreditHours;
            this.Format = Format;
            foreach (Course VARIABLE in Prerequisities)
            {
                this.Prerequisites.Add(VARIABLE);
            }
        }
        public Course(string CourseNumber, string Core, string CourseName, string Description, float CreditHours, Course[] Prerequisities, bool HasLab)
        {
            this.CourseNumber = CourseNumber;
            this.CourseNumber = CourseNumber;
            this.Core = Core;
            this.CourseName = CourseName;
            this.Description = Description;
            this.CreditHours = CreditHours;
            foreach (Course VARIABLE in Prerequisities)
            {
                this.Prerequisites.Add(VARIABLE);
            }
            this.HasLab = HasLab;
        }
        public Course(string CourseNumber, string Core, string CourseName, string Description, float CreditHours, string Format,  bool HasLab)
        {
            this.CourseNumber = CourseNumber;
            if (CourseNumber == null) throw new ArgumentNullException(nameof(CourseNumber));
            this.CourseNumber = CourseNumber;
            this.Core = Core;
            this.CourseName = CourseName;
            this.Description = Description;
            this.CreditHours = CreditHours;
            this.Format = Format;
            this.HasLab = HasLab;
        }
        public Course(string CourseNumber, string Core, string CourseName, string Description, float CreditHours, string Format)
        {
            this.CourseNumber = CourseNumber;
            this.CourseNumber = CourseNumber;
            this.Core = Core;
            this.CourseName = CourseName;
            this.Description = Description;
            this.CreditHours = CreditHours;
            this.Format = Format;
        }
        public Course(string CourseNumber, string Core, string CourseName, string Description, float CreditHours, Course[] Prerequisities)
        {
            this.CourseNumber = CourseNumber;
            this.Core = Core;
            this.CourseName = CourseName;
            this.Description = Description;
            this.CreditHours = CreditHours;
            foreach (Course VARIABLE in Prerequisities)
            {
                this.Prerequisites.Add(VARIABLE);
            }
        }
        public Course(string CourseNumber, string Core, string CourseName, string Description, float CreditHours, bool HasLab)
        {
            this.CourseNumber = CourseNumber;
            this.Core = Core;
            this.CourseName = CourseName;
            this.Description = Description;
            this.CreditHours = CreditHours;
            this.HasLab = HasLab;
        }
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
            get { return _courseNumber; }
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
                _courseNumber = value;
            }
        }
        
        public string Core
        {
            get { return _core; }
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
                _core = value;
            }
        }
        public string CourseName
        {
            get { return _courseName; }
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
                _courseName = value;
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value can not be null or empty");
                }
                _description = value;
            }
        }
        public float CreditHours
        {
            get { return _creditHours; }
            set
            {
                if (value < 1)
                {
                    //System.Windows.Forms.MessageBox.Show("Course number to large");
                    throw new Exception("Can't have 0 hours for a Course");
                }
                _creditHours = value;
            }
        }
        public string Format
        {
            get { return _format; }
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
                _format = value;
            }
        }
    }
}

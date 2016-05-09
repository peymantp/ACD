using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACD
{
    public class Course
    {

        public Course(string CourseNumber, string Core, string CourseName, string Description, double CreditHours, string Format, Course[] Prerequisities, bool HasLab)
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
        public Course(string CourseNumber, string Core, string CourseName, string Description, double CreditHours, string Format, Course[] Prerequisities)
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
        public Course(string CourseNumber, string Core, string CourseName, string Description, double CreditHours, Course[] Prerequisities, bool HasLab)
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
        public Course(string CourseNumber, string Core, string CourseName, string Description, double CreditHours, string Format,  bool HasLab)
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
        public Course(string CourseNumber, string Core, string CourseName, string Description, double CreditHours, string Format)
        {
            this.CourseNumber = CourseNumber;
            this.CourseNumber = CourseNumber;
            this.Core = Core;
            this.CourseName = CourseName;
            this.Description = Description;
            this.CreditHours = CreditHours;
            this.Format = Format;
        }
        public Course(string CourseNumber, string Core, string CourseName, string Description, double CreditHours, Course[] Prerequisities)
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
        public Course(string CourseNumber, string Core, string CourseName, string Description, double CreditHours, bool HasLab)
        {
            this.CourseNumber = CourseNumber;
            this.Core = Core;
            this.CourseName = CourseName;
            this.Description = Description;
            this.CreditHours = CreditHours;
            this.HasLab = HasLab;
        }
        public Course(string CourseNumber, string Core, string CourseName, string Description, double CreditHours)
        {
            this.CourseNumber = CourseNumber;
            this.CourseNumber = CourseNumber;
            this.Core = Core;
            this.CourseName = CourseName;
            this.Description = Description;
            this.CreditHours = CreditHours;
        }
        public List<Course> Prerequisites = new List<Course>();
        public bool HasLab { get; set; }
        public string CourseNumber
        {
            get { return CourseNumber; }
            set
            {
                if (value.Length > 10)
                {
                    //System.Windows.Forms.MessageBox.Show("Course number to large");
                    throw new Exception("Course number to large");
                }
                if (!String.IsNullOrEmpty(value) || !String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value can not be null or empty");
                }
                CourseNumber = value;
            }
        }
        public string Core
        {
            get { return Core; }
            set
            {
                if (value.Length > 50)
                {
                    //System.Windows.Forms.MessageBox.Show("Course number to large");
                    throw new Exception("Core name to large");
                }
                if (!String.IsNullOrEmpty(value) || !String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value can not be null or empty");
                }
                Core = value;
            }
        }
        public string CourseName
        {
            get { return CourseName; }
            set
            {
                if (value.Length > 50)
                {
                    //System.Windows.Forms.MessageBox.Show("Course number to large");
                    throw new Exception("Course name to large");
                }
                if (!String.IsNullOrEmpty(value) || !String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value can not be null or empty");
                }
                CourseName = value;
            }
        }
        public string Description
        {
            get
            {
                return Description;
            }
            set
            {
                if (!String.IsNullOrEmpty(value) || !String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value can not be null or empty");
                }
                Description = value;
            }
        }
        public double CreditHours
        {
            get { return CreditHours; }
            set
            {
                if (value < 1)
                {
                    //System.Windows.Forms.MessageBox.Show("Course number to large");
                    throw new Exception("Can't have 0 hours for a Course");
                }
                CreditHours = value;
            }
        }
        public string Format
        {
            get { return Format; }
            set
            {
                if (value.Length > 50)
                {
                    //System.Windows.Forms.MessageBox.Show("Course number to large");
                    throw new Exception("Format name to large");
                }
                if (!String.IsNullOrEmpty(value) || !String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value can not be null or empty");
                }
                Format = value;
            }
        }
    }
}

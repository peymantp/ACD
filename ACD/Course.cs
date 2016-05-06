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
            if (string.IsNullOrWhiteSpace(CourseNumber))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(CourseNumber));
            if (string.IsNullOrWhiteSpace(Core))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(Core));
            if (string.IsNullOrWhiteSpace(CourseName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(CourseName));
            if (string.IsNullOrWhiteSpace(Description))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(Description));
            this.CourseNumber = CourseNumber;
            this.Core = Core;
            this.CourseName = CourseName;
            this.Description = Description;
            this.CreditHours = CreditHours;
            this.Format = Format;
            foreach (Course VARIABLE in Prerequisities)
            {
                this.Prerequisities.Add(VARIABLE);
            }
            this.HasLab = HasLab;
        }
        public Course(string CourseNumber, string Core, string CourseName, string Description, double CreditHours, string Format, Course[] Prerequisities)
        {
            if (string.IsNullOrWhiteSpace(CourseNumber))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(CourseNumber));
            if (string.IsNullOrWhiteSpace(Core))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(Core));
            if (string.IsNullOrWhiteSpace(CourseName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(CourseName));
            if (string.IsNullOrWhiteSpace(Description))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(Description));
            this.CourseNumber = CourseNumber;
            this.CourseNumber = CourseNumber;
            this.Core = Core;
            this.CourseName = CourseName;
            this.Description = Description;
            this.CreditHours = CreditHours;
            this.Format = Format;
            foreach (Course VARIABLE in Prerequisities)
            {
                this.Prerequisities.Add(VARIABLE);
            }
        }
        public Course(string CourseNumber, string Core, string CourseName, string Description, double CreditHours, Course[] Prerequisities, bool HasLab)
        {
            if (string.IsNullOrWhiteSpace(CourseNumber))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(CourseNumber));
            if (string.IsNullOrWhiteSpace(Core))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(Core));
            if (string.IsNullOrWhiteSpace(CourseName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(CourseName));
            if (string.IsNullOrWhiteSpace(Description))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(Description));
            this.CourseNumber = CourseNumber;
            this.CourseNumber = CourseNumber;
            this.Core = Core;
            this.CourseName = CourseName;
            this.Description = Description;
            this.CreditHours = CreditHours;
            foreach (Course VARIABLE in Prerequisities)
            {
                this.Prerequisities.Add(VARIABLE);
            }
            this.HasLab = HasLab;
        }
        public Course(string CourseNumber, string Core, string CourseName, string Description, double CreditHours, string Format,  bool HasLab)
        {
            if (string.IsNullOrWhiteSpace(CourseNumber))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(CourseNumber));
            if (string.IsNullOrWhiteSpace(Core))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(Core));
            if (string.IsNullOrWhiteSpace(CourseName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(CourseName));
            if (string.IsNullOrWhiteSpace(Description))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(Description));
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
            if (string.IsNullOrWhiteSpace(CourseNumber))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(CourseNumber));
            if (string.IsNullOrWhiteSpace(Core))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(Core));
            if (string.IsNullOrWhiteSpace(CourseName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(CourseName));
            if (string.IsNullOrWhiteSpace(Description))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(Description));
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
            if (string.IsNullOrWhiteSpace(CourseNumber))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(CourseNumber));
            if (string.IsNullOrWhiteSpace(Core))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(Core));
            if (string.IsNullOrWhiteSpace(CourseName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(CourseName));
            if (string.IsNullOrWhiteSpace(Description))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(Description));
            this.CourseNumber = CourseNumber;
            this.Core = Core;
            this.CourseName = CourseName;
            this.Description = Description;
            this.CreditHours = CreditHours;
            foreach (Course VARIABLE in Prerequisities)
            {
                this.Prerequisities.Add(VARIABLE);
            }
        }
        public Course(string CourseNumber, string Core, string CourseName, string Description, double CreditHours, bool HasLab)
        {
            if (string.IsNullOrWhiteSpace(CourseNumber))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(CourseNumber));
            if (string.IsNullOrWhiteSpace(Core))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(Core));
            if (string.IsNullOrWhiteSpace(CourseName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(CourseName));
            if (string.IsNullOrWhiteSpace(Description))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(Description));
            this.CourseNumber = CourseNumber;
            this.Core = Core;
            this.CourseName = CourseName;
            this.Description = Description;
            this.CreditHours = CreditHours;
            this.HasLab = HasLab;
        }
        public Course(string CourseNumber, string Core, string CourseName, string Description, double CreditHours)
        {
            if (string.IsNullOrWhiteSpace(CourseNumber))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(CourseNumber));
            if (string.IsNullOrWhiteSpace(Core))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(Core));
            if (string.IsNullOrWhiteSpace(CourseName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(CourseName));
            if (string.IsNullOrWhiteSpace(Description))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(Description));
            this.CourseNumber = CourseNumber;
            this.CourseNumber = CourseNumber;
            this.Core = Core;
            this.CourseName = CourseName;
            this.Description = Description;
            this.CreditHours = CreditHours;
        }
        public List<Course> Prerequisities = new List<Course>();

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
                CourseName = value;
            }
        }

        public string Description { get; set; }

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
                Format = value;
            }
        }
    }
}

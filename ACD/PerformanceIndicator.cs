using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACD
{
    class PerformanceIndicator
    {

        public PerformanceIndicator(string Indicator, string LearningLevel, string Name, string CourseNumber, string Core)
        {
            this.Indicator = Indicator;
            this.LearningLevel = LearningLevel;
            this.Name = Name;
            this.CourseNumber = CourseNumber;
            this.Core = Core;
        }
        public string Indicator
        {
            get
            {
                return Indicator;
            }

            set
            {
                if (value.Length > 250 )
                {
                    //System.Windows.Forms.MessageBox.Show("Course number to large");
                    throw new Exception("Indicator name to large");
                }
                if(!String.IsNullOrEmpty(value) || !String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value can not be null or empty");
                }

                Indicator = value;
            }
        }

        public string LearningLevel
        {
            get
            {
                return LearningLevel;
            }

            set
            {
                if (value.Length > 10)
                {
                    //System.Windows.Forms.MessageBox.Show("Course number to large");
                    throw new Exception("Learning level to large");
                }
                if (!String.IsNullOrEmpty(value) || !String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value can not be null or empty");
                }
                LearningLevel = value;
            }
        }

        public string Name
        {
            get
            {
                return Name;
            }

            set
            {
                if (value.Length > 50)
                {
                    //System.Windows.Forms.MessageBox.Show("Course number to large");
                    throw new Exception("Name to large");
                }
                if (!String.IsNullOrEmpty(value) || !String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value can not be null or empty");
                }
                Name = value;
            }
        }

        public string CourseNumber
        {
            get
            {
                return CourseNumber;
            }

            set
            {
                if (value.Length > 10)
                {
                    //System.Windows.Forms.MessageBox.Show("Course number to large");
                    throw new Exception("Course number value to large");
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
            get
            {
                return Core;
            }

            set
            {
                if (value.Length > 50)
                {
                    //System.Windows.Forms.MessageBox.Show("Course number to large");
                    throw new Exception("Core value to large");
                }
                if (!String.IsNullOrEmpty(value) || !String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value can not be null or empty");
                }
                Core = value;
            }
        }
    }
}

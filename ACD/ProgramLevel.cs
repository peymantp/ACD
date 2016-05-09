using System;
/// <summary>
/// Author: Manish Mallavarapu 
/// Date: 2016-05-09
/// </summary>
namespace ACD
{
    /// <summary>
    /// This class creates a program level 
    /// for each course 
    /// </summary>
    class ProgramLevel
    {
        public string name_;
        private string desc_;
        private string courseNo_;
        private string core_;
        /// <summary>
        /// Constructor that creates a ProgramLevel object 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="desc"></param>
        /// <param name="courseNo"></param>
        /// <param name="core"></param> 
        public ProgramLevel(string name, string desc, string courseNo, string core)
        {
            name_ = name;
            desc_ = desc;
            courseNo_ = courseNo;
            core_ = core;        
        }
        
        public string name
        {
            get { return name_; }
            set
            {
                if (!isEmptyInput(ref value)) {
                    throw new ArgumentNullException("value can not be null or empty");
                }
                name_ = value;
            }
        }
        public string desc
        {
            get { return desc_; }
            set
            {
                if (!isEmptyInput(ref value))
                {
                    throw new ArgumentNullException("value can not be null or empty");
                }
                desc_ = value;
            }
        }
        public string courseNo
        {
            get { return courseNo_; }
            set
            {
                if (!isEmptyInput(ref value))
                {
                    throw new ArgumentNullException("value can not be null or empty");
                }
                courseNo_ = value;
            }
        }
        public string core
        {
            get { return core_; }
            set
            {
                if (!isEmptyInput(ref value))
                {
                    throw new ArgumentNullException("value can not be null or empty");
                }
                core_ = value;
            }
        }
        private bool isEmptyInput(ref string value)
        {
            if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
            {
                return false; 
            }
            return true; 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Problem2
{
    // GradeBook class with a constructor to initialize the course name.
    public class GradeBook
    {
        private string courseName; // course name for this GradeBook
        private string instructorName; //instructor name for this GradeBook

        // constructor initializes courseName and courseInstructor with strings supplied as arguments
        public GradeBook(string name, string instructor)
        {
            CourseName = name; // initialize courseName using property

        } // end constructor

        // property to get and set the course name
        public string CourseName
        {
            get
            {
                return courseName;
            } // end get
            set
            {
                courseName = value;
            } // end set
        } // end property CourseName

        // property to get and set the instructor name
        public string InstructorName
        {
            get
            {
                return instructorName;
            } // end get
            set
            {
                this.instructorName = value;
            } // end set
        } // end property InstrucorName

        // display a welcome message to the GradeBook user
        public void DisplayMessage()
        {
            // use property CourseName to get the 
            // name of the course that this GradeBook represents
            Console.WriteLine("Welcome to the grade book for\n{0}!",
               CourseName);
            //use property InstructorName to get the
            //name of the instructor who represents this GradeBook    
            Console.WriteLine("This course is presented by {0}",
                InstructorName);
        } // end method DisplayMessage
    } // end class GradeBook



}

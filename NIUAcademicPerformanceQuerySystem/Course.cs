/*******************************************************************************************************************
 *                                                                                                                 *
 *  CSCI 473/504							Assignment 3								 Fall 2018                 *                                           
 *																										           *
 *  Programmer's: Sandeep Alla (z1821331) *  
 *																										           *
 *  Date Due  : October 11th, 2018			File :	Course.cs					     				           *                          
 *																										           *
 *  Purpose   : To write a program that allows user to Enroll into available Courses. This file contains           *
 *            	a class for Course.															                       *
 ******************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIUAcademicPerformanceQuerySystem
{

	public class Course : IComparable //Here Course class implements IComparable interface
	{
		private string deptCode, sectionNum; // Declaring variables of string type and is public
		private uint courseNum; //Declaring variable of integer type and is public
		private ushort creditHours, numOfStudentsCurrentlyEnrolled, maxCapacityOfEnrollment;//Declaring variables of ushort type and is public
		private List<uint> zID = new List<uint>();

		public String DeptCode // Name method
		{
			get { return deptCode; } //Get property
			set { deptCode = value; } // Set property
		}

		public String SectionNum // Name method
		{
			get { return sectionNum; } //Get property
			set { sectionNum = value; } // Set property
		}

		public uint CourseNum // Name method
		{
			get { return courseNum; } //Get property
			set { courseNum = value; } // Set property
		}

		public ushort CreditHours // Name method
		{
			get { return creditHours; } //Get property
			set { creditHours = value; } // Set property
		}

		public ushort NumOfStudentsCurrentlyEnrolled // Name method
		{
			get { return numOfStudentsCurrentlyEnrolled; } //Get property
			set { numOfStudentsCurrentlyEnrolled = value; } // Set property
		}

		public ushort MaxCapacityOfEnrollment // Name method
		{
			get { return maxCapacityOfEnrollment; } //Get property
			set { maxCapacityOfEnrollment = value; } // Set property
		}

		public List<uint> ZID // Name method
		{
			get { return zID; } //Get property
			set { zID = value; } // Set property
		}


		public Course() // Default Constructor for Course class
		{
			this.deptCode = null;
			this.sectionNum = null;
			this.courseNum = 0;
			this.creditHours = 0;
			this.maxCapacityOfEnrollment = 0;
			this.numOfStudentsCurrentlyEnrolled = 0;
			this.zID = new List<uint>();
		}

		//Alternate Constructor for Course class
		public Course(string deptCode, string sectionNum, uint courseNum, ushort creditHours, ushort maxCapacityOfEnrollment)
		{
			this.deptCode = deptCode;
			this.sectionNum = sectionNum;
			this.courseNum = courseNum;
			this.creditHours = creditHours;
			this.maxCapacityOfEnrollment = maxCapacityOfEnrollment;
			this.zID = new List<uint>();
		}

		//Comparable method for Sorting
		public int CompareTo(object alpha)
		{
			Course course = (Course)alpha;
			if (course == null)
				throw new ArgumentException("Object is not a Course");
			else
			{
				int compare = this.DeptCode.ToLower().CompareTo(course.DeptCode.ToLower());
				if (compare == 0)
				{
					compare = this.CourseNum.CompareTo(course.CourseNum);//compares coursenumber
				}
				return compare;
			}
		}

		//Print Roster method prints the currently enrolled student details for a particular course
		public List<String> PrintRoster()
		{
			List<String> courseRoster = new List<string>();

			if (ZID.Count == 0) // When there are no students in a course prints message
			{
				courseRoster.Add("Course : " + DeptCode + " " + CourseNum + "-" + SectionNum + "<" + NumOfStudentsCurrentlyEnrolled + "/" + MaxCapacityOfEnrollment + ">");
				courseRoster.Add("----------------------------------------------------------------------------");
				courseRoster.Add("There are currently no Students Enrolled in " + DeptCode + " " + CourseNum + "-" + SectionNum + ".");


			}
			else
			{
				courseRoster.Add("Course : " + DeptCode + " " + CourseNum + "-" + SectionNum + "<" + NumOfStudentsCurrentlyEnrolled + "/" + MaxCapacityOfEnrollment + ">");
				courseRoster.Add("----------------------------------------------------------------------------");
				foreach (var zid in ZID)//Looping through the ZIDS
				{
					foreach (var sPool in Program.studentPool) // Looping through studentPool list
					{
						if (sPool.ZID.Equals(zid))
						{
							String firstname = sPool.FirstName;
							String lastname = sPool.LastName;
							String major = sPool.Major;
							//Displaying the Student details who are currently enrolled in this instance of course
							courseRoster.Add(Convert.ToString(zid) + firstname.PadLeft(25) + "," + lastname.PadRight(25) + major);
							break;
						}
					}

				}
			}

			return courseRoster;
		}


		//Overrides the string
		public override string ToString()
		{
			return base.ToString();
		}


	}
}

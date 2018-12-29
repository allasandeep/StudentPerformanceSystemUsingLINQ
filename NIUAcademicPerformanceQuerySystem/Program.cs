/*******************************************************************************************************************
 *                                                                                                                 *
 *  CSCI 473/504							Assignment 1								 Fall 2018                 *                                           
 *																										           *
 *  Programmer's: Sandeep Alla (z1821331)   *  
 *																										           *
 *  Date Due  : October 11th, 2018			File :	Program.cs					     				           *                          
 *																										           *
 *  Purpose   : To write a program that allows user to Enroll into available Courses. This file contains           *
 *            	a class for Course.															                       *
 ******************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIUAcademicPerformanceQuerySystem
{
	static class Program
	{

		//Global Variables
		public static List<Student> studentPool; // Initializing a list of type Student 
		public static List<Course> coursePool; // Initializing a list of type Course
		public static List<String> availableMajors;//Initializing a list of type string
		public static List<String> availableDeptCode;//Initializing a list of type string
		public static List<StudentCourse> studentData;//Initializing a list of type studentcourse
		public static List<String> availableGrades;//Initializing a list of type string

		public static void read() // read method to get data from a file
		{
			//Variables to store the contents read from the input files			
			uint newZID;
			string newFirstName;
			string newLastName;
			string newMajor;
			float newGPA;
			string newAcademicYear;
			string newDeptCode, newSectionNum;
			uint newCourseNum;
			ushort newCreditHours, newMaxCapacityOfEnrollment;
			string newGrade;
			
			studentPool = new List<Student>();
			coursePool = new List<Course>();
			availableMajors = new List<string>();
			studentData = new List<StudentCourse>();

			try
			{
				//Reading the file
				using (StreamReader inFile = new StreamReader(Directory.GetCurrentDirectory() + "\\2188_a3_input01.txt")) // StreamReader is used to read data from a text file
				{

					string data = inFile.ReadLine(); // Reading the firstline and storing it in string variable data
					while (data != null) // Loop until there is nothing to read from the file
					{
						string[] result = data.Split(','); //Splitting the data seperated by ','
						newZID = Convert.ToUInt32(result[0]);
						newFirstName = result[1];
						newLastName = result[2];
						newMajor = result[3];
						newAcademicYear = result[4];
						newGPA = float.Parse(result[5]);
						Student student = new Student(newZID, newFirstName, newLastName, newMajor, newAcademicYear, newGPA); // Creating an object of the class Student
						studentPool.Add(student); // Adding objects into a list
						data = inFile.ReadLine();
					}


					inFile.Close(); // Closing the file
				}
			}
			catch (Exception e) // Catchs any exceptions that are raised during the file read
			{
				Console.WriteLine("The file could not be read:"); // Error Message
				Console.WriteLine(e.Message);
			}

			try
			{
				using (StreamReader inFile = new StreamReader(Directory.GetCurrentDirectory() + "\\2188_a3_input02.txt")) // StreamReader is used to read data from a text file
				{
					string data = inFile.ReadLine(); // Reading the firstline and storing it in string variable data
					while (data != null) // Loop until there is nothing to read from the file
					{
						string[] result = data.Split(','); //Splitting the data seperated by ','
						newDeptCode = result[0];
						newCourseNum = Convert.ToUInt32(result[1]);
						newSectionNum = result[2];
						newCreditHours = ushort.Parse(result[3]);
						newMaxCapacityOfEnrollment = ushort.Parse(result[4]);
						Course course = new Course(newDeptCode, newSectionNum, newCourseNum, newCreditHours, newMaxCapacityOfEnrollment); // Creating an object of the class Student
						coursePool.Add(course); // Adding objects into a list
						data = inFile.ReadLine();
					}
					inFile.Close();
				}
			}
			catch (Exception e) // Catchs any exceptions that are raised during the file read
			{
				Console.WriteLine("The file could not be read:"); // Error Message
				Console.WriteLine(e.Message);
			}

			try
			{
				using (StreamReader inFile = new StreamReader(Directory.GetCurrentDirectory() + "\\2188_a3_input03.txt")) // StreamReader is used to read data from a text file
				{
					string data = inFile.ReadLine(); // Reading the firstline and storing it in string variable data
					while (data != null) // Loop until there is nothing to read from the file
					{
						availableMajors.Add(data);
						data = inFile.ReadLine();
					}
					inFile.Close();
				}
			}
			catch (Exception e) // Catchs any exceptions that are raised during the file read
			{
				Console.WriteLine("The file could not be read:"); // Error Message
				Console.WriteLine(e.Message);
			}

			try
			{
				using (StreamReader inFile = new StreamReader(Directory.GetCurrentDirectory() + "\\2188_a3_input04.txt")) // StreamReader is used to read data from a text file
				{
					string data = inFile.ReadLine(); // Reading the firstline and storing it in string variable data
					while (data != null) // Loop until there is nothing to read from the file
					{
						string[] result = data.Split(','); //Splitting the data seperated by ','
						newZID = Convert.ToUInt32(result[0]);
						newDeptCode = result[1];
						newCourseNum = Convert.ToUInt32(result[2]);
						newGrade = result[3];
						StudentCourse studentCourse = new StudentCourse(newZID, newDeptCode, newCourseNum, newGrade); // Creating an object of the class Student
						studentData.Add(studentCourse); // Adding objects into a list
						data = inFile.ReadLine();
					}
					inFile.Close();
				}
			}
			catch (Exception e) // Catchs any exceptions that are raised during the file read
			{
				Console.WriteLine("The file could not be read:"); // Error Message
				Console.WriteLine(e.Message);
			}



		}

		//adding department codes to the addDeptcode list
		public static void addDeptCode()
		{
			availableDeptCode = new List<string>();
			availableDeptCode.Add("CSCI");
			availableDeptCode.Add("MATH");
			availableDeptCode.Add("STAT");
			availableDeptCode.Add("THEA");
			availableDeptCode.Add("ART");
			availableDeptCode.Add("ANTH");
			availableDeptCode.Add("PSYC");
			availableDeptCode.Add("MKT");
			availableDeptCode.Add("PHYS");
			availableDeptCode.Add("FIN");
			availableDeptCode.Add("EMICS");
			availableDeptCode.Add("BIO");
			availableDeptCode.Add("CHM");
			availableDeptCode.Add("MISC");
		}

		//adding grades data to the addGrade list
		public static void addGrade()
		{
			availableGrades = new List<string>();
			availableGrades.Add("A+");
			availableGrades.Add("A");
			availableGrades.Add("A-");
			availableGrades.Add("B+");
			availableGrades.Add("B");
			availableGrades.Add("B-");
			availableGrades.Add("C++");
			availableGrades.Add("C");
			availableGrades.Add("C-");
			availableGrades.Add("D");			;
			availableGrades.Add("F");
		}


		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			addGrade();
			addDeptCode();
			read(); // Calling the read method from the Program class
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}

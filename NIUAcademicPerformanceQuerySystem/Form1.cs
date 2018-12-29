/*******************************************************************************************************************
 *                                                                                                                 *
 *  CSCI 473/504							Assignment 3								 Fall 2018                 *                                           
 *																										           *
 *  Programmer's: Sandeep Alla (z1821331)   *  
 *																										           *
 *  Date Due  : October 11th, 2018			File :	Form1.cs					     				               *                          
 *																										           *
 *  Purpose   : To write a program that allows user to Enroll into available Courses. This file contains           *
 *            	a class for Course.															                       *
 ******************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIUAcademicPerformanceQuerySystem
{
	//class Form1
	public partial class Form1 : Form
	{
		//initializing variables
		public int FRPercentage = 0;
		public int ZID = 0, courseNum = 0 , failCourseNum = 0 , gTCourseNum = 0 , gradeIndex = -1;
		public String deptCode = "" , failDeptCode = "", failMajor = "", gTDeptCode = "" , grade = "", passReportGrade = "";
		public bool GradeThresholdRb1 = false, GradeThresholdRb2 = false , FailReportRb1 = false , FailReportRb2 = false, PassReportRb1 = false, PassReportRb2 = false;

		public Form1()
		{
			InitializeComponent();

			foreach (var majors in Program.availableMajors) //to iterate through lists
			{
				StudentMajorCB.Items.Add(majors);//populating values to studentMajor combo box
			}

			foreach ( var grades in Program.availableGrades)//to iterate through lists
			{
				gradeThresholdCB.Items.Add(grades);//populating values to gradeThreshold combo box
				passReportGradeCB.Items.Add(grades);//populating values to passReportGrade combo box
			}
		}

		//method to show resultsreport for one student
		private void showGradeReportForOneStudent_Click(object sender, EventArgs e)
		{
			if (ZID != 0)
			{
				outputDisplay.Clear();

				//using linq query to select a student objects whose zid is given
				StudentCourse[] studentCourse = (Program.studentData.Where(s => s.ZID == ZID).ToArray());

				//uisng linq query to arrange deptcode and course number in ascending order
				var orderByResult = from s in studentCourse
									orderby s.DeptCode, s.CourseNum ascending
									select s;

				if (studentCourse.Length > 0)
				{
					outputDisplay.Text += "Single Student Grade Report (" + ZID + ")" + Environment.NewLine;
					outputDisplay.Text += "-------------------------------------------------------------" + Environment.NewLine;
					foreach (StudentCourse s in orderByResult)//iterating through orderby result and displaying the student data one by one
					{
						outputDisplay.Text += "z" + Convert.ToString(s.ZID).PadRight(10) + " | " + "  " + (s.DeptCode + "-" + s.CourseNum).PadRight(10) + " | " + "  " + s.Grade + Environment.NewLine;
					}

					outputDisplay.Text += Environment.NewLine + "###   END RESULTS   ###";
				}

				
			}
			else
				outputDisplay.Text = "Please Enter a ZID to Show Results";
		}

		//this method returns a fixed value for the given parameter
		private int getValueforGrade(String grade)
		{
			
			if (grade == "A+")
				return 10;
			else if (grade == "A")
				return 9;
			else if (grade == "A-")
				return 8;
			else if (grade == "B+")
				return 7;
			else if (grade == "B")
				return 6;
			else if (grade == "B-")
				return 5;
			else if (grade == "C++")
				return 4;
			else if (grade == "C")
				return 3;
			else if (grade == "C-")
				return 2;
			else if (grade == "D")
				return 1;
			else if (grade == "F")
				return 0;

			return 11;
		}


		private void outputDisplay_TextChanged(object sender, EventArgs e)
		{

		}

		//this method gets the zid entered by the user in student zid text box
		private void studentZidTB_TextChanged_1(object sender, EventArgs e)
		{
			try
			{
				String input = "";
				if (studentZidTB.Text.Length > 8)//if zid text length is greater than 8
					outputDisplay.Text = "The Z-ID cannot be more than 8 characters";//display the output
				else if (studentZidTB.Text.Length == 8)//if zid length is equal to 8
				{
					outputDisplay.Text = "";
					input = studentZidTB.Text;
					if (input[0] == 'Z' || input[0] == 'z')//if input is capital or small z
					{
						try
						{
							ZID = Convert.ToInt32(input.Substring(1, input.Length - 1));//convert from string to integer
							outputDisplay.Text = "";
						}
						catch (Exception)
						{
							outputDisplay.Text = "You Entered an incorrect Z-ID";//display the output
						}
					}
					else
						outputDisplay.Text += "You Entered an incorrect Z-ID";
				}
				else if (studentZidTB.Text.Length == 7)//if zid text length is equal to 7
				{
					input = studentZidTB.Text;
					if (input[0] == 'Z' || input[0] == 'z')//if input is capital or small z
						outputDisplay.Text = "You Entered an incorrect Z-ID";//display this text
					else
					{
						try
						{
							ZID = Convert.ToInt32(input);
							outputDisplay.Text = "";
						}
						catch (Exception)
						{
							outputDisplay.Text = "You Entered an incorrect Z-ID";
						}
					}
				}
				else
				{
					outputDisplay.Text = "Enter a valid Z-ID";
				}

				if(studentZidTB.Text == "")
				{
					ZID = 0;
				}
			}
			catch (Exception)
			{

			}
		}

		//this method shows results of major students who failed the course
		private void showMajorStudentsWhoFailedACourse_Click(object sender, EventArgs e)
		{
			outputDisplay.Clear();
			if (failMajor != "" && failDeptCode != "" && failCourseNum != 0)
			{
				//linq query to select student objects from student pool whose major matches the selected major
				Student[] selectMajorStudents = (Program.studentPool.Where(s => s.Major == failMajor).ToArray());

				//linq query to select studentcourse objects whose department code and coursenum equals to dept code and course number 
				StudentCourse[] studentCourse = (Program.studentData.Where(s => s.DeptCode == failDeptCode && s.CourseNum == failCourseNum).ToArray());

				//linq query to join selectmajorstudents and studentcourse array of objects and to get all the records of who got a grade F
				var orderByResult = from q in selectMajorStudents
									join a in studentCourse
									on q.ZID equals a.ZID 
									where a.Grade == "F"
									orderby a.ZID ascending
									select a;


				if ( orderByResult != null )
				{
					outputDisplay.Text += "Fail Report of Majors (" + failMajor + ") in " + failDeptCode + " " + failCourseNum + Environment.NewLine;
					outputDisplay.Text += "-------------------------------------------------------------" + Environment.NewLine;
					foreach ( StudentCourse s in orderByResult)//iterating through orderby result and displaying the student data one by one
					{
						outputDisplay.Text += "z" + Convert.ToString(s.ZID).PadRight(10) + " | " + "  " + (s.DeptCode + "-" + s.CourseNum).PadRight(10) + " | " + "  " + s.Grade + Environment.NewLine;
					}

					outputDisplay.Text += Environment.NewLine + "###   END RESULTS   ###";
				}


			}
			else
				outputDisplay.Text += "Please Select a Major / Enter a Course";


		}

		
		//method to get the value of radiobutton
		private void FRrb1_CheckedChanged(object sender, EventArgs e)
		{
			if (FRrb1.Checked == true)
			{
				FailReportRb1 = true;
			}
			else
				FailReportRb1 = false;
		}

		//method to showfailreport for all courses
		private void showFailReportforAllCourses_Click(object sender, EventArgs e)
		{
			outputDisplay.Clear();
			float percentage = 0;
			List<String> data = new List<string>();
			List<String> arrayOfResults = new List<string>();

			if (FRPercentage != 0 && (FailReportRb1 != false || FailReportRb2 != false))
			{
				//linq query to select all students whose grade = f and group them by their dept code and course num and orderby dept code and course num in ascending order
				var countOfFailed = Program.studentData.Where(p => p.Grade == "F")
										 .GroupBy(info => new { info.DeptCode, info.CourseNum })
										 .Select(group => new
										 {
											 Metric = group.Key,
											 Count = group.Count()
										 })
										 .OrderBy(group => group.Metric.DeptCode)
										 .ThenBy(group => group.Metric.CourseNum);

				//linq query to select all students and group them by their dept code and course num and orderby dept code and course num in ascending order
				var countOfEnrolled = Program.studentData.GroupBy(info => new { info.DeptCode, info.CourseNum })
										  .Select(group => new
										  {
											  Metric = group.Key,
											  Count = group.Count()
										  })
										  .OrderBy(group => group.Metric.DeptCode)
										  .ThenBy(group => group.Metric.CourseNum);

				

				// Looping through the countOfEnrolled and then through countOfFailed
				foreach (var s in countOfEnrolled)
				{
					foreach (var p in countOfFailed)
					{
						//if the deptCode and coursenum equals to the given deptcode and coursenum
						if (s.Metric.DeptCode == p.Metric.DeptCode && s.Metric.CourseNum == p.Metric.CourseNum)
						{
							//Calculate the percentage of that course
							percentage = ((float)p.Count / (float)s.Count) * 100;
							//Added all the associated data seperated by a comma
							String temp = s.Metric.DeptCode +","+ s.Metric.CourseNum +"," +s.Count + "," + p.Count + "," + Math.Round(percentage,2);
							data.Add(temp);
						}
					}
				}
			
				
				//If the condition is Less than or equal to then							
				if (FailReportRb1 == true)
				{
					outputDisplay.Text += "Fail Percentage (<= " + FRPercentage + "%) Report for Classes." + Environment.NewLine;
					outputDisplay.Text += "-------------------------------------------------------------" + Environment.NewLine;
					foreach (var s in data) // loop through the list and add those rows to the list
					{
						String[] result = s.Split(','); // Seperate the data
						if (Convert.ToDouble(result[4]) <= FRPercentage)
							  arrayOfResults.Add("Out of  " + result[2] + "  enrolled in  " + result[0] + "-" + result[1] + ",  " + result[3] + "  failed ( " + result[4] + "%)");
					}				

				}
				else if(FailReportRb2 == true) 
				{
					outputDisplay.Text += "Fail Percentage (>= " + FRPercentage + "%) Report for Classes." + Environment.NewLine;
					outputDisplay.Text += "-------------------------------------------------------------" + Environment.NewLine;
					foreach (var s in data) // loop through the list and add those rows to the list
					{
						String[] result = s.Split(','); // seperate the data
						if (Convert.ToDouble(result[4]) >= FRPercentage)
							arrayOfResults.Add("Out of  " + result[2] + "  enrolled in  " + result[0] + "-" + result[1] + ",  " + result[3] + "  failed ( " + result[4] + "%)");
					}
					
				}

				//If the arrayOfResults count is greater than 0 then there are some rows
				if (arrayOfResults.Count > 0) 
				{
					//Iterate through the arrayOfResults
					foreach(var result in arrayOfResults)
					{
						outputDisplay.Text += result + "\n\n";
					}
					outputDisplay.Text += Environment.NewLine + "###   END RESULTS   ###";
				}
				else
					outputDisplay.Text += "No Courses matched the query criteria";

			}
			else
				outputDisplay.Text = "Please input all the required data to show results";
		}

		//Method to get if the radio button is checked or not
		private void PRrb1_CheckedChanged(object sender, EventArgs e)
		{
			if (PRrb1.Checked == true)
			{
				PassReportRb1 = true;
			}
			else
				PassReportRb1 = false;
		}

		//Method to get if the radio button is checked or not
		private void PRrb2_CheckedChanged(object sender, EventArgs e)
		{
			if (PRrb2.Checked == true)
			{
				PassReportRb2 = true;
			}
			else
				PassReportRb2 = false;
		}

		//Method to get the grade selected
		private void passReportGradeCB_SelectedIndexChanged(object sender, EventArgs e)
		{
			String selectedTextInput = passReportGradeCB.SelectedItem.ToString();
			passReportGrade = selectedTextInput;
		}

		//Method to showpass report for all courses
		private void showPassReportForAllCourses_Click(object sender, EventArgs e)
		{
			outputDisplay.Clear();
			float percentage = 0;
			List<String> data = new List<string>();
			List<String> arrayOfResults = new List<string>();

			if (passReportGrade != "" && (PassReportRb1 != false || PassReportRb2 != false))
			{			
				
				if (PassReportRb1 == true)
				{
					//linq query to select all students whose grade = f and p.grade is <= passReportGrade and group them by their dept code and course num and orderby dept code and course num in ascending order
					var countOfPassed = Program.studentData.Where(p => p.Grade != "F" && getValueforGrade(p.Grade) <= getValueforGrade(passReportGrade))
											 .GroupBy(info => new { info.DeptCode, info.CourseNum })
											 .Select(group => new
											 {
												 Metric = group.Key,
												 Count = group.Count()
											 })
											 .OrderBy(group => group.Metric.DeptCode)
											 .ThenBy(group => group.Metric.CourseNum);

					//linq query to select all students p.grade is <= passReportGrade and group them by their dept code and course num and orderby dept code and course num in ascending order
					var countOfEnrolled = Program.studentData.GroupBy(info => new { info.DeptCode, info.CourseNum })
											  .Select(group => new
											  {
												  Metric = group.Key,
												  Count = group.Count()
											  })
											  .OrderBy(group => group.Metric.DeptCode)
											  .ThenBy(group => group.Metric.CourseNum);

					// Looping through the countOfEnrolled and then through countOfFailed
					foreach (var s in countOfEnrolled)
					{
						foreach (var p in countOfPassed)
						{
							//if the deptCode and coursenum equals to the given deptcode and coursenum
							if (s.Metric.DeptCode == p.Metric.DeptCode && s.Metric.CourseNum == p.Metric.CourseNum)
							{
								//Calculate the percentage of that course
								percentage = ((float)p.Count / (float)s.Count) * 100;
								//Added all the associated data seperated by a comma
								String temp = s.Metric.DeptCode + "," + s.Metric.CourseNum + "," + s.Count + "," + p.Count + "," + Math.Round(percentage, 2);
								data.Add(temp);
							}
						}
					}
				}
				else if(PassReportRb2 == true)
				{
					//linq query to select all students whose grade = f and p.grade is >= passReportGrade and group them by their dept code and course num and orderby dept code and course num in ascending order
					var countOfPassed = Program.studentData.Where(p => p.Grade != "F" && getValueforGrade(p.Grade) >= getValueforGrade(passReportGrade))
											 .GroupBy(info => new { info.DeptCode, info.CourseNum })
											 .Select(group => new
											 {
												 Metric = group.Key,
												 Count = group.Count()
											 })
											 .OrderBy(group => group.Metric.DeptCode)
											 .ThenBy(group => group.Metric.CourseNum);

					//linq query to select all students p.grade is <= passReportGrade and group them by their dept code and course num and orderby dept code and course num in ascending order
					var countOfEnrolled = Program.studentData.GroupBy(info => new { info.DeptCode, info.CourseNum })
											  .Select(group => new
											  {
												  Metric = group.Key,
												  Count = group.Count()
											  })
											  .OrderBy(group => group.Metric.DeptCode)
											  .ThenBy(group => group.Metric.CourseNum);

					// Looping through the countOfEnrolled and then through countOfFailed
					foreach (var s in countOfEnrolled)
					{
						foreach (var p in countOfPassed)
						{
							if (s.Metric.DeptCode == p.Metric.DeptCode && s.Metric.CourseNum == p.Metric.CourseNum)
							{
								percentage = ((float)p.Count / (float)s.Count) * 100;
								String temp = s.Metric.DeptCode + "," + s.Metric.CourseNum + "," + s.Count + "," + p.Count + "," + Math.Round(percentage, 2);
								data.Add(temp);
							}
						}
					}
				}

				//If the condition is Less than or equal to then	
				if (PassReportRb1 == true)
				{
					outputDisplay.Text += "Pass Percentage (<= " + passReportGrade + "%) Report for Classes." + Environment.NewLine;
					outputDisplay.Text += "-------------------------------------------------------------" + Environment.NewLine;
					// loop through the list and add those rows to the list
					foreach (var s in data)
					{
						String[] result = s.Split(',');// seperate the data
						arrayOfResults.Add("Out of  " + result[2] + "  enrolled in  " + result[0] + "-" + result[1] + ",  " + result[3] + "  passed at or below this threshold ( " + result[4] + "%)");
					}

				}
				else if(PassReportRb2 == true)
				{
					outputDisplay.Text += "Pass Percentage (>= " + passReportGrade + "%) Report for Classes." + Environment.NewLine;
					outputDisplay.Text += "-------------------------------------------------------------" + Environment.NewLine;
					// loop through the list and add those rows to the list
					foreach (var s in data)
					{
						String[] result = s.Split(',');// seperate the data
						arrayOfResults.Add("Out of  " + result[2] + "  enrolled in  " + result[0] + "-" + result[1] + ",  " + result[3] + "  passed at or below this threshold ( " + result[4] + "%)");
					}

				}

				//If the arrayOfResults count is greater than 0 then there are some rows
				if (arrayOfResults.Count > 0)
				{
					//Iterate through the arrayOfResults
					foreach (var result in arrayOfResults)
					{
						outputDisplay.Text += result + "\n\n";
					}
					outputDisplay.Text += Environment.NewLine + "###   END RESULTS   ###";
				}
				else
					outputDisplay.Text += "No Courses matched the query criteria";

			}
			else
				outputDisplay.Text = "Please input all the required data to show results";
		}

		//Method to get if the radio button is checked or not
		private void FRrb2_CheckedChanged(object sender, EventArgs e)
		{
			if (FRrb2.Checked == true)
			{
				FailReportRb2 = true;
			}
			else
				FailReportRb2 = false;
		}

		//Method to get fail percentage
		private void FailReportPercentage_ValueChanged(object sender, EventArgs e)
		{
			int selectInput = Convert.ToInt32(FailReportPercentage.Value);
			FRPercentage = selectInput;
		}

		//Method to get if the radio button is checked or not
		private void GTrb2_CheckedChanged(object sender, EventArgs e)
		{
			if (GTrb2.Checked == true)
			{
				GradeThresholdRb2 = true;
			}
			else
				GradeThresholdRb2 = false;
		}

		//Method to showgradethreshold for one course
		private void showGradeThresholdForOneCourse_Click(object sender, EventArgs e)
		{
			outputDisplay.Clear();
			if(grade != "" &&  (GradeThresholdRb1 == true || GradeThresholdRb2 == true) && gTCourseNum != 0 && gTDeptCode != "")
			{
				IEnumerable<StudentCourse> orderByResult = null;

				if (GradeThresholdRb1 == true)
				{
					//Linq query to select the all the students from the studentData whose grade is less than or equal to the given grade and deptcode and coursenum equals to the given deptcode and coursenum
					orderByResult = from s in Program.studentData
										where getValueforGrade(s.Grade) <= getValueforGrade(grade) && s.DeptCode == gTDeptCode && s.CourseNum == gTCourseNum
										orderby s.ZID ascending
										select s;
				}
				else if (GradeThresholdRb2 == true)
				{
					//Linq query to select the all the students from the studentData whose grade is greater than or equal to the given grade and deptcode and coursenum equals to the given deptcode and coursenum
					orderByResult = from s in Program.studentData
										where getValueforGrade(s.Grade) >= getValueforGrade(grade) && s.DeptCode == gTDeptCode && s.CourseNum == gTCourseNum
									orderby s.ZID ascending
										select s;
				}

				if (orderByResult != null)
				{
					outputDisplay.Text += "Grade Threshold Report for (" + gTDeptCode + " " + gTDeptCode + ")" + Environment.NewLine;
					outputDisplay.Text += "-------------------------------------------------------------" + Environment.NewLine;
					foreach (StudentCourse s in orderByResult) // Iterate through the orderByResult and display the student data
					{
						outputDisplay.Text += "z" + Convert.ToString(s.ZID).PadRight(10) + " | " + "  " + (s.DeptCode + "-" + s.CourseNum).PadRight(10) + " | " + "  " + s.Grade + Environment.NewLine;
					}

					outputDisplay.Text += Environment.NewLine + "###   END RESULTS   ###";
				}
			}
			else
			{
				outputDisplay.Text = "Please input all the required data to show results";
			}
		}

		//Method to get the selected grade 
		private void gradeThresholdCB_SelectedIndexChanged(object sender, EventArgs e)
		{
			String selectedTextIndex = gradeThresholdCB.SelectedItem.ToString();
			grade = selectedTextIndex;
		}

		//Method to get the course input
		private void gradeThresholdCourse_TextChanged(object sender, EventArgs e)
		{
			String courseTbInput = gradeThresholdCourse.Text;
			//Splitting the given course into deptcode and coursenum
			String[] inputSplit = courseTbInput.Split(' ');			

			try
			{
				gTDeptCode = inputSplit[0];
				gTCourseNum = Convert.ToInt32(inputSplit[1]);
			}
			catch
			{

			}
		}

		//Method to know whether the radio button is checked or not
		private void GTrb1_CheckedChanged(object sender, EventArgs e)
		{
			if (GTrb1.Checked == true)
			{
				GradeThresholdRb1 = true;
			}
			else
				GradeThresholdRb1 = false;
		}

		//method to get the selected major from the combo box		
		private void StudentMajorCB_SelectedIndexChanged(object sender, EventArgs e)
		{
			String selectedTextInput = StudentMajorCB.SelectedItem.ToString();
			failMajor = selectedTextInput;
		}

		//Method to display grade report for one course
		private void showGradeReportForOneCourse_Click(object sender, EventArgs e)
		{
			if (deptCode != "" && courseNum != 0)
			{
				outputDisplay.Clear();

				//Linq quert to select all the studentdata whose deptcode and coursenum matchs the given deptcode and coursenum
				StudentCourse[] studentCourse = (Program.studentData.Where(s => s.DeptCode == deptCode && s.CourseNum == courseNum).ToArray());

				//Arranging the studentCourse objects in ascending order of there ZID
				var orderByResult = from s in studentCourse
									orderby s.ZID ascending
									select s;

				if (studentCourse.Length > 0)
				{
					outputDisplay.Text += "Grade Report for (" + deptCode + " " + courseNum + ")" + Environment.NewLine;
					outputDisplay.Text += "-------------------------------------------------------------" + Environment.NewLine;
					foreach (StudentCourse s in orderByResult)//Looping through the orderByResult and displaying all the student details
					{
						outputDisplay.Text += "z" + Convert.ToString(s.ZID).PadRight(10) + " | " + "  " + (s.DeptCode + "-" + s.CourseNum).PadRight(10) + " | " + "  " + s.Grade + Environment.NewLine;
					}

					outputDisplay.Text += Environment.NewLine + "###   END RESULTS   ###";
				}			
				
			}
			else
				outputDisplay.Text = "Please Enter a Course to Show Results";
		}

		//Method to get the course from the failCourseTb
		private void FailCourseTb_TextChanged(object sender, EventArgs e)
		{
			String courseTbInput = FailCourseTb.Text;
			//Splitting the given course into deptcode and coursenum
			String[] inputSplit = courseTbInput.Split(' ');

			try
			{
				failDeptCode = inputSplit[0];
				failCourseNum = Convert.ToInt32(inputSplit[1]);
			}
			catch
			{

			}
		}

		//Method to get the course from the courseTB
		private void courseTb_TextChanged(object sender, EventArgs e)
		{
			String courseTbInput = courseTb.Text;
			//Splitting the given course into deptcode and coursenum
			String[] inputSplit = courseTbInput.Split(' ');

			try
			{
				deptCode = inputSplit[0];
				courseNum = Convert.ToInt32(inputSplit[1]);
			}
			catch
			{

			}
		}
	}
}

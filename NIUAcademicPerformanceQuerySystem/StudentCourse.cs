/*******************************************************************************************************************
 *                                                                                                                 *
 *  CSCI 473/504							Assignment 3								 Fall 2018                 *                                           
 *																										           *
 *  Programmer's: Sandeep Alla (z1821331) Gayathri Sanikommu (z1822939) Venkata SuryaVamsi Maddukuri (z1855404)    *  
 *																										           *
 *  Date Due  : October 11th, 2018			File :	StudentCourse.cs					     				       *                          
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
	class StudentCourse
	{
		private readonly uint zID;
		private readonly string deptCode; // Declaring variables of string type and is public
		private readonly uint courseNum;
		private readonly string grade;

		//constructor 
		public StudentCourse(uint zID, string deptCode, uint courseNum, string grade)
		{
			this.zID = zID;
			this.deptCode = deptCode;
			this.courseNum = courseNum;
			this.grade = grade;
		}

		public String DeptCode // Name method
		{
			get { return deptCode; } //Get property
		}

		public uint CourseNum // Name method
		{
			get { return courseNum; } //Get property
		}

		public uint ZID // Name method
		{
			get { return zID; } //Get property
		}

		public String Grade // Name method
		{
			get { return grade; } //Get property
		}
	}
}

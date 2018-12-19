/*******************************************************************************************************************
 *                                                                                                                 *
 *  CSCI 473/504							Assignment 1								 Fall 2018                 *                                           
 *																										           *
 *  Programmer's: Sandeep Alla (z1821331) Gayathri Sanikommu (z1822939) Venkata SuryaVamsi Maddukuri (z1855404)    *  
 *																										           *
 *  Date Due  : September 13th, 2018			File :	Course.cs					     				           *                          
 *																										           *
 *  Purpose   : To write a program that allows user to Enroll into available Courses. This file contains           *
 *            	a class for Course.															                       *
 ******************************************************************************************************************/
namespace NIUAcademicPerformanceQuerySystem
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.studentZidTB = new System.Windows.Forms.TextBox();
			this.showGradeReportForOneStudent = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.outputDisplay = new System.Windows.Forms.RichTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.GTrb1 = new System.Windows.Forms.RadioButton();
			this.groupBoxForGradeThreshold = new System.Windows.Forms.GroupBox();
			this.GTrb2 = new System.Windows.Forms.RadioButton();
			this.gradeThresholdCB = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.gradeThresholdCourse = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.showGradeThresholdForOneCourse = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.StudentMajorCB = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.FailCourseTb = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.showMajorStudentsWhoFailedACourse = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.courseTb = new System.Windows.Forms.TextBox();
			this.showGradeReportForOneCourse = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.FRrb2 = new System.Windows.Forms.RadioButton();
			this.FRrb1 = new System.Windows.Forms.RadioButton();
			this.FailReportPercentage = new System.Windows.Forms.NumericUpDown();
			this.label13 = new System.Windows.Forms.Label();
			this.showFailReportforAllCourses = new System.Windows.Forms.Button();
			this.label14 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.PRrb2 = new System.Windows.Forms.RadioButton();
			this.PRrb1 = new System.Windows.Forms.RadioButton();
			this.label15 = new System.Windows.Forms.Label();
			this.showPassReportForAllCourses = new System.Windows.Forms.Button();
			this.passReportGradeCB = new System.Windows.Forms.ComboBox();
			this.groupBoxForGradeThreshold.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.FailReportPercentage)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(197, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Grade Report for One Student";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Z-ID";
			// 
			// studentZidTB
			// 
			this.studentZidTB.Location = new System.Drawing.Point(47, 36);
			this.studentZidTB.Name = "studentZidTB";
			this.studentZidTB.Size = new System.Drawing.Size(100, 20);
			this.studentZidTB.TabIndex = 2;
			this.studentZidTB.TextChanged += new System.EventHandler(this.studentZidTB_TextChanged_1);
			// 
			// showGradeReportForOneStudent
			// 
			this.showGradeReportForOneStudent.Location = new System.Drawing.Point(357, 37);
			this.showGradeReportForOneStudent.Name = "showGradeReportForOneStudent";
			this.showGradeReportForOneStudent.Size = new System.Drawing.Size(88, 23);
			this.showGradeReportForOneStudent.TabIndex = 3;
			this.showGradeReportForOneStudent.Text = "Show Results";
			this.showGradeReportForOneStudent.UseVisualStyleBackColor = true;
			this.showGradeReportForOneStudent.Click += new System.EventHandler(this.showGradeReportForOneStudent_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(448, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "Query Results";
			// 
			// outputDisplay
			// 
			this.outputDisplay.Location = new System.Drawing.Point(451, 37);
			this.outputDisplay.Name = "outputDisplay";
			this.outputDisplay.Size = new System.Drawing.Size(485, 517);
			this.outputDisplay.TabIndex = 5;
			this.outputDisplay.Text = "";
			this.outputDisplay.TextChanged += new System.EventHandler(this.outputDisplay_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 68);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(214, 15);
			this.label4.TabIndex = 6;
			this.label4.Text = "Grade Threshold for One Course";
			// 
			// GTrb1
			// 
			this.GTrb1.AutoSize = true;
			this.GTrb1.Location = new System.Drawing.Point(6, 19);
			this.GTrb1.Name = "GTrb1";
			this.GTrb1.Size = new System.Drawing.Size(133, 17);
			this.GTrb1.TabIndex = 7;
			this.GTrb1.TabStop = true;
			this.GTrb1.Text = "Less Than or Equal To";
			this.GTrb1.UseVisualStyleBackColor = true;
			this.GTrb1.CheckedChanged += new System.EventHandler(this.GTrb1_CheckedChanged);
			// 
			// groupBoxForGradeThreshold
			// 
			this.groupBoxForGradeThreshold.Controls.Add(this.GTrb2);
			this.groupBoxForGradeThreshold.Controls.Add(this.GTrb1);
			this.groupBoxForGradeThreshold.Location = new System.Drawing.Point(16, 96);
			this.groupBoxForGradeThreshold.Name = "groupBoxForGradeThreshold";
			this.groupBoxForGradeThreshold.Size = new System.Drawing.Size(157, 72);
			this.groupBoxForGradeThreshold.TabIndex = 8;
			this.groupBoxForGradeThreshold.TabStop = false;
			// 
			// GTrb2
			// 
			this.GTrb2.AutoSize = true;
			this.GTrb2.Location = new System.Drawing.Point(6, 43);
			this.GTrb2.Name = "GTrb2";
			this.GTrb2.Size = new System.Drawing.Size(146, 17);
			this.GTrb2.TabIndex = 8;
			this.GTrb2.TabStop = true;
			this.GTrb2.Text = "Greater Than or Equal To";
			this.GTrb2.UseVisualStyleBackColor = true;
			this.GTrb2.CheckedChanged += new System.EventHandler(this.GTrb2_CheckedChanged);
			// 
			// gradeThresholdCB
			// 
			this.gradeThresholdCB.FormattingEnabled = true;
			this.gradeThresholdCB.Location = new System.Drawing.Point(180, 146);
			this.gradeThresholdCB.Name = "gradeThresholdCB";
			this.gradeThresholdCB.Size = new System.Drawing.Size(47, 21);
			this.gradeThresholdCB.TabIndex = 9;
			this.gradeThresholdCB.SelectedIndexChanged += new System.EventHandler(this.gradeThresholdCB_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(180, 127);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(36, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Grade";
			// 
			// gradeThresholdCourse
			// 
			this.gradeThresholdCourse.Location = new System.Drawing.Point(233, 147);
			this.gradeThresholdCourse.Name = "gradeThresholdCourse";
			this.gradeThresholdCourse.Size = new System.Drawing.Size(100, 20);
			this.gradeThresholdCourse.TabIndex = 11;
			this.gradeThresholdCourse.TextChanged += new System.EventHandler(this.gradeThresholdCourse_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(231, 127);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Course";
			// 
			// showGradeThresholdForOneCourse
			// 
			this.showGradeThresholdForOneCourse.Location = new System.Drawing.Point(357, 145);
			this.showGradeThresholdForOneCourse.Name = "showGradeThresholdForOneCourse";
			this.showGradeThresholdForOneCourse.Size = new System.Drawing.Size(88, 23);
			this.showGradeThresholdForOneCourse.TabIndex = 13;
			this.showGradeThresholdForOneCourse.Text = "Show Results";
			this.showGradeThresholdForOneCourse.UseVisualStyleBackColor = true;
			this.showGradeThresholdForOneCourse.Click += new System.EventHandler(this.showGradeThresholdForOneCourse_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(13, 191);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(241, 15);
			this.label7.TabIndex = 14;
			this.label7.Text = "Major Students Who Failed A Course";
			// 
			// StudentMajorCB
			// 
			this.StudentMajorCB.FormattingEnabled = true;
			this.StudentMajorCB.Location = new System.Drawing.Point(16, 230);
			this.StudentMajorCB.Name = "StudentMajorCB";
			this.StudentMajorCB.Size = new System.Drawing.Size(121, 21);
			this.StudentMajorCB.TabIndex = 15;
			this.StudentMajorCB.SelectedIndexChanged += new System.EventHandler(this.StudentMajorCB_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(16, 214);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(33, 13);
			this.label8.TabIndex = 16;
			this.label8.Text = "Major";
			// 
			// FailCourseTb
			// 
			this.FailCourseTb.Location = new System.Drawing.Point(234, 230);
			this.FailCourseTb.Name = "FailCourseTb";
			this.FailCourseTb.Size = new System.Drawing.Size(100, 20);
			this.FailCourseTb.TabIndex = 17;
			this.FailCourseTb.TextChanged += new System.EventHandler(this.FailCourseTb_TextChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(231, 214);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 13);
			this.label9.TabIndex = 18;
			this.label9.Text = "Course";
			// 
			// showMajorStudentsWhoFailedACourse
			// 
			this.showMajorStudentsWhoFailedACourse.Location = new System.Drawing.Point(357, 227);
			this.showMajorStudentsWhoFailedACourse.Name = "showMajorStudentsWhoFailedACourse";
			this.showMajorStudentsWhoFailedACourse.Size = new System.Drawing.Size(88, 23);
			this.showMajorStudentsWhoFailedACourse.TabIndex = 19;
			this.showMajorStudentsWhoFailedACourse.Text = "Show Results";
			this.showMajorStudentsWhoFailedACourse.UseVisualStyleBackColor = true;
			this.showMajorStudentsWhoFailedACourse.Click += new System.EventHandler(this.showMajorStudentsWhoFailedACourse_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(13, 279);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(193, 15);
			this.label10.TabIndex = 20;
			this.label10.Text = "Grade Report for One Course";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(16, 305);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(40, 13);
			this.label11.TabIndex = 21;
			this.label11.Text = "Course";
			// 
			// courseTb
			// 
			this.courseTb.Location = new System.Drawing.Point(62, 302);
			this.courseTb.Name = "courseTb";
			this.courseTb.Size = new System.Drawing.Size(100, 20);
			this.courseTb.TabIndex = 22;
			this.courseTb.TextChanged += new System.EventHandler(this.courseTb_TextChanged);
			// 
			// showGradeReportForOneCourse
			// 
			this.showGradeReportForOneCourse.Location = new System.Drawing.Point(357, 299);
			this.showGradeReportForOneCourse.Name = "showGradeReportForOneCourse";
			this.showGradeReportForOneCourse.Size = new System.Drawing.Size(88, 23);
			this.showGradeReportForOneCourse.TabIndex = 23;
			this.showGradeReportForOneCourse.Text = "Show Results";
			this.showGradeReportForOneCourse.UseVisualStyleBackColor = true;
			this.showGradeReportForOneCourse.Click += new System.EventHandler(this.showGradeReportForOneCourse_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(12, 325);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(179, 15);
			this.label12.TabIndex = 24;
			this.label12.Text = "Fail Report For All Courses";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.FRrb2);
			this.groupBox2.Controls.Add(this.FRrb1);
			this.groupBox2.Location = new System.Drawing.Point(16, 353);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(157, 72);
			this.groupBox2.TabIndex = 25;
			this.groupBox2.TabStop = false;
			// 
			// FRrb2
			// 
			this.FRrb2.AutoSize = true;
			this.FRrb2.Location = new System.Drawing.Point(6, 43);
			this.FRrb2.Name = "FRrb2";
			this.FRrb2.Size = new System.Drawing.Size(146, 17);
			this.FRrb2.TabIndex = 8;
			this.FRrb2.TabStop = true;
			this.FRrb2.Text = "Greater Than or Equal To";
			this.FRrb2.UseVisualStyleBackColor = true;
			this.FRrb2.CheckedChanged += new System.EventHandler(this.FRrb2_CheckedChanged);
			// 
			// FRrb1
			// 
			this.FRrb1.AutoSize = true;
			this.FRrb1.Location = new System.Drawing.Point(6, 19);
			this.FRrb1.Name = "FRrb1";
			this.FRrb1.Size = new System.Drawing.Size(133, 17);
			this.FRrb1.TabIndex = 7;
			this.FRrb1.TabStop = true;
			this.FRrb1.Text = "Less Than or Equal To";
			this.FRrb1.UseVisualStyleBackColor = true;
			this.FRrb1.CheckedChanged += new System.EventHandler(this.FRrb1_CheckedChanged);
			// 
			// FailReportPercentage
			// 
			this.FailReportPercentage.Location = new System.Drawing.Point(180, 404);
			this.FailReportPercentage.Name = "FailReportPercentage";
			this.FailReportPercentage.Size = new System.Drawing.Size(47, 20);
			this.FailReportPercentage.TabIndex = 26;
			this.FailReportPercentage.ValueChanged += new System.EventHandler(this.FailReportPercentage_ValueChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(177, 388);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(62, 13);
			this.label13.TabIndex = 27;
			this.label13.Text = "Percentage";
			// 
			// showFailReportforAllCourses
			// 
			this.showFailReportforAllCourses.Location = new System.Drawing.Point(357, 402);
			this.showFailReportforAllCourses.Name = "showFailReportforAllCourses";
			this.showFailReportforAllCourses.Size = new System.Drawing.Size(88, 23);
			this.showFailReportforAllCourses.TabIndex = 28;
			this.showFailReportforAllCourses.Text = "Show Results";
			this.showFailReportforAllCourses.UseVisualStyleBackColor = true;
			this.showFailReportforAllCourses.Click += new System.EventHandler(this.showFailReportforAllCourses_Click);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(12, 448);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(186, 15);
			this.label14.TabIndex = 29;
			this.label14.Text = "Pass Report For All Courses";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.PRrb2);
			this.groupBox3.Controls.Add(this.PRrb1);
			this.groupBox3.Location = new System.Drawing.Point(16, 482);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(157, 72);
			this.groupBox3.TabIndex = 30;
			this.groupBox3.TabStop = false;
			// 
			// PRrb2
			// 
			this.PRrb2.AutoSize = true;
			this.PRrb2.Location = new System.Drawing.Point(6, 43);
			this.PRrb2.Name = "PRrb2";
			this.PRrb2.Size = new System.Drawing.Size(146, 17);
			this.PRrb2.TabIndex = 8;
			this.PRrb2.TabStop = true;
			this.PRrb2.Text = "Greater Than or Equal To";
			this.PRrb2.UseVisualStyleBackColor = true;
			this.PRrb2.CheckedChanged += new System.EventHandler(this.PRrb2_CheckedChanged);
			// 
			// PRrb1
			// 
			this.PRrb1.AutoSize = true;
			this.PRrb1.Location = new System.Drawing.Point(6, 19);
			this.PRrb1.Name = "PRrb1";
			this.PRrb1.Size = new System.Drawing.Size(133, 17);
			this.PRrb1.TabIndex = 7;
			this.PRrb1.TabStop = true;
			this.PRrb1.Text = "Less Than or Equal To";
			this.PRrb1.UseVisualStyleBackColor = true;
			this.PRrb1.CheckedChanged += new System.EventHandler(this.PRrb1_CheckedChanged);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(177, 518);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(36, 13);
			this.label15.TabIndex = 32;
			this.label15.Text = "Grade";
			// 
			// showPassReportForAllCourses
			// 
			this.showPassReportForAllCourses.Location = new System.Drawing.Point(357, 531);
			this.showPassReportForAllCourses.Name = "showPassReportForAllCourses";
			this.showPassReportForAllCourses.Size = new System.Drawing.Size(88, 23);
			this.showPassReportForAllCourses.TabIndex = 33;
			this.showPassReportForAllCourses.Text = "Show Results";
			this.showPassReportForAllCourses.UseVisualStyleBackColor = true;
			this.showPassReportForAllCourses.Click += new System.EventHandler(this.showPassReportForAllCourses_Click);
			// 
			// passReportGradeCB
			// 
			this.passReportGradeCB.FormattingEnabled = true;
			this.passReportGradeCB.Location = new System.Drawing.Point(180, 532);
			this.passReportGradeCB.Name = "passReportGradeCB";
			this.passReportGradeCB.Size = new System.Drawing.Size(47, 21);
			this.passReportGradeCB.TabIndex = 34;
			this.passReportGradeCB.SelectedIndexChanged += new System.EventHandler(this.passReportGradeCB_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(948, 566);
			this.Controls.Add(this.passReportGradeCB);
			this.Controls.Add(this.showPassReportForAllCourses);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.showFailReportforAllCourses);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.FailReportPercentage);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.showGradeReportForOneCourse);
			this.Controls.Add(this.courseTb);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.showMajorStudentsWhoFailedACourse);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.FailCourseTb);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.StudentMajorCB);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.showGradeThresholdForOneCourse);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.gradeThresholdCourse);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.gradeThresholdCB);
			this.Controls.Add(this.groupBoxForGradeThreshold);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.outputDisplay);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.showGradeReportForOneStudent);
			this.Controls.Add(this.studentZidTB);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBoxForGradeThreshold.ResumeLayout(false);
			this.groupBoxForGradeThreshold.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.FailReportPercentage)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox studentZidTB;
		private System.Windows.Forms.Button showGradeReportForOneStudent;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox outputDisplay;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton GTrb1;
		private System.Windows.Forms.GroupBox groupBoxForGradeThreshold;
		private System.Windows.Forms.RadioButton GTrb2;
		private System.Windows.Forms.ComboBox gradeThresholdCB;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox gradeThresholdCourse;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button showGradeThresholdForOneCourse;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox StudentMajorCB;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox FailCourseTb;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button showMajorStudentsWhoFailedACourse;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox courseTb;
		private System.Windows.Forms.Button showGradeReportForOneCourse;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton FRrb2;
		private System.Windows.Forms.RadioButton FRrb1;
		private System.Windows.Forms.NumericUpDown FailReportPercentage;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button showFailReportforAllCourses;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton PRrb2;
		private System.Windows.Forms.RadioButton PRrb1;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button showPassReportForAllCourses;
		private System.Windows.Forms.ComboBox passReportGradeCB;
	}
}


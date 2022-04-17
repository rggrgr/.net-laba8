//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/linq2db).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------

#pragma warning disable 1572, 1591

using System;

using LinqToDB;
using LinqToDB.Configuration;
using LinqToDB.Mapping;

namespace DataModels
{
	/// <summary>
	/// Database       : ivt191dyachkovskiyaman
	/// Data Source    : tcp://localhost:5432
	/// Server Version : 12.6
	/// </summary>
	public partial class Ivt191dyachkovskiyamanDB : LinqToDB.Data.DataConnection
	{
		public ITable<ExamMark>   ExamMarks    { get { return this.GetTable<ExamMark>(); } }
		public ITable<Lecture>    Lectures     { get { return this.GetTable<Lecture>(); } }
		public ITable<Progress>   Progresses   { get { return this.GetTable<Progress>(); } }
		public ITable<Student>    Students     { get { return this.GetTable<Student>(); } }
		public ITable<Subject>    Subjects     { get { return this.GetTable<Subject>(); } }
		public ITable<SubjLect>   SubjLects    { get { return this.GetTable<SubjLect>(); } }
		public ITable<University> Universities { get { return this.GetTable<University>(); } }

		partial void InitMappingSchema()
		{
		}

		public Ivt191dyachkovskiyamanDB()
		{
			InitDataContext();
			InitMappingSchema();
		}

		public Ivt191dyachkovskiyamanDB(string configuration)
			: base(configuration)
		{
			InitDataContext();
			InitMappingSchema();
		}

		public Ivt191dyachkovskiyamanDB(LinqToDbConnectionOptions options)
			: base(options)
		{
			InitDataContext();
			InitMappingSchema();
		}

		public Ivt191dyachkovskiyamanDB(LinqToDbConnectionOptions<Ivt191dyachkovskiyamanDB> options)
			: base(options)
		{
			InitDataContext();
			InitMappingSchema();
		}

		partial void InitDataContext  ();
		partial void InitMappingSchema();
	}

	[Table(Schema="public", Name="exam_marks")]
	public partial class ExamMark
	{
		[Column("exam_id"),    Nullable] public int?      ExamId    { get; set; } // integer
		[Column("student_id"), Nullable] public int?      StudentId { get; set; } // integer
		[Column("subj_id"),    Nullable] public int?      SubjId    { get; set; } // integer
		[Column("mark"),       Nullable] public int?      Mark      { get; set; } // integer
		[Column("exam_date"),  Nullable] public DateTime? ExamDate  { get; set; } // date
	}

	[Table(Schema="public", Name="lectures")]
	public partial class Lecture
	{
		[Column("lecturer_id"), Nullable] public int?   LecturerId { get; set; } // integer
		[Column("surname"),     Nullable] public string Surname    { get; set; } // text
		[Column("name"),        Nullable] public string Name       { get; set; } // text
		[Column("city"),        Nullable] public string City       { get; set; } // text
		[Column("univ_id"),     Nullable] public int?   UnivId     { get; set; } // integer
	}

	[Table(Schema="public", Name="progress")]
	public partial class Progress
	{
		[Column("subj_id"),    Nullable] public int? SubjId         { get; set; } // integer
		[Column("student_id"), Nullable] public int? StudentId      { get; set; } // integer
		[Column("progress"),   Nullable] public int? ProgressColumn { get; set; } // integer
		[Column("semester"),   Nullable] public int? Semester       { get; set; } // integer
	}

	[Table(Schema="public", Name="student")]
	public partial class Student
	{
		[Column("student_id"), NotNull    ] public int       StudentId { get; set; } // integer
		[Column("surname"),       Nullable] public string    Surname   { get; set; } // text
		[Column("name"),          Nullable] public string    Name      { get; set; } // text
		[Column("stipend"),       Nullable] public double?   Stipend   { get; set; } // double precision
		[Column("kurs"),          Nullable] public int?      Kurs      { get; set; } // integer
		[Column("city"),          Nullable] public string    City      { get; set; } // character(50)
		[Column("birthday"),      Nullable] public DateTime? Birthday  { get; set; } // date
		[Column("univ_id"),       Nullable] public int?      UnivId    { get; set; } // integer
	}

	[Table(Schema="public", Name="subject")]
	public partial class Subject
	{
		[Column("subj_id"),   Nullable] public int?   SubjId   { get; set; } // integer
		[Column("subj_name"), Nullable] public string SubjName { get; set; } // text
		[Column("hour"),      Nullable] public int?   Hour     { get; set; } // integer
		[Column("semester"),  Nullable] public int?   Semester { get; set; } // integer
	}

	[Table(Schema="public", Name="subj_lect")]
	public partial class SubjLect
	{
		[Column("lecturer_id"), Nullable] public int? LecturerId { get; set; } // integer
		[Column("subj_id"),     Nullable] public int? SubjId     { get; set; } // integer
	}

	[Table(Schema="public", Name="university")]
	public partial class University
	{
		[Column("univ_id"),   Nullable] public int?   UnivId   { get; set; } // integer
		[Column("univ_name"), Nullable] public string UnivName { get; set; } // text
		[Column("rating"),    Nullable] public int?   Rating   { get; set; } // integer
		[Column("city"),      Nullable] public string City     { get; set; } // text
	}
}

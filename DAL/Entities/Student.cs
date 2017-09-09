using Common.Modules.Enums;
using System.Collections.Generic;

namespace DAL.Entities
{
	public class Student : Person
	{
		public DegreeOfEducation DegreeOfEducation { get; set; }

		public string FieldOfStudy { get; set; }
		public int Grade { get; set; }
		#region NavigationProperty
		public ICollection<StudentCourse> StudentCourses { get; set; }
		#endregion
	}
}

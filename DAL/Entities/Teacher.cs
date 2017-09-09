using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	public class Teacher : Person
	{
		public string DegreeOfEducation { get; set; }
		public DateTime HiredYear { get; set; }
		public string FieldOfStudy { get; set; }
		#region Navigation Property
		public User User { get; set; }
		public ICollection<TeacherCourse> TeacherCourses { get; set; }
		#endregion
	}
}

using DAL.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	public class Course : EntityBase
	{
		public string CourseName { get; set; }
		public string Source { get; set; }
		#region NavigationProperties
		public ICollection<TeacherCourse> TeacherCourses { get; set; }
		public ICollection<StudentCourse> StudentCourses { get; set; }

		#endregion
	}
}

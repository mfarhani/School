using DAL.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	public class StudentCourse : EntityBase
	{
		public int StudentID { get; set; }
		public int CourseID { get; set; }
		#region NavigationProperty
		public Student Student { get; set; }
		public Course Course { get; set; }
		#endregion
	}
}

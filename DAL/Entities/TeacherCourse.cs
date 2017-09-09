using DAL.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	public class TeacherCourse:EntityBase
	{
		public int TeacherID { get; set; }
		public int CourseID { get; set; }
		public DateTime Date { get; set; }
		#region NavigationProperty
		public Teacher Teacher { get; set; }
		public Course Course { get; set; }
		#endregion
	}
}

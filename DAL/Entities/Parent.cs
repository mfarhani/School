using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	public abstract class Parent : Person
	{
		public string DegreeOfEducation { get; set; }
		public int NumberOfChildren { get; set; }
		#region NavigationProperty
		public User User { get; set; }
		#endregion

	}
}

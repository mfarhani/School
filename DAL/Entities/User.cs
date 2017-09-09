using DAL.Common;
using DAL.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	public class User : EntityBase
	{
		public string UserName { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public bool IsActive { get; set; }
		public int AccessLevel { get; set; }
		#region Navigation Property
		public Teacher Teacher { get; set; }
		public Parent Parent { get; set; }

		#endregion
	}
}

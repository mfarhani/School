using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAL.Common
{
	[System.ComponentModel.DataAnnotations.Schema.ComplexType]
	public class Name
	{
		public Name()
		{
		}
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
		public string FullName
		{
			get
			{
				if (string.IsNullOrEmpty(FirstName))
					return LastName;
				return string.Format("{0} {1}", FirstName, LastName);
			}
		}
	}
}

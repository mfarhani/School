using DAL.Common;
using DAL.Modules;
using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
	public class Person : EntityBase
	{
		public Person()
		{

		}
		[Required]
		public Name Name { get; set; }
		[Required]
		public string Address { get; set; }
		public string Phone { get; set; }
		public string Mobile { get; set; }
		[Required]
		public DateTime BirthDay { get; set; }
		public Boolean Gender { get; set; }
	}
}

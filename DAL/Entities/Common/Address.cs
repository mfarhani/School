using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAL.Common
{
	[System.ComponentModel.DataAnnotations.Schema.ComplexType]
	public class Address
	{
		public Address()
		{

		}
		public string Street { get; set; }
		public string Alley { get; set; }

	}
}

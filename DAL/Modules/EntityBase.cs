using DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Modules
{
	public class EntityBase : IEntityBase
	{
		public Guid ID { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StanZoBank.Domain.IdentityEntity;
namespace StanZoBank.Domain.Entities
{
	public class Customer
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		[EmailAddress]
		public string Email { get; set; }

		[Phone]
		public string PhooneNumber { get; set; }

		public string Address { get; set; }

		public string State { get; set; }
	
		public string UserId { get; set; }
		
		public ApplicationUser ApplicationUser { get; set; }
		
		public DateTime CreatedAt { get; set; } = DateTime.Now;

	}
}

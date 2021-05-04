using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StanZoBank.Domain.Entities.Enums;
using StanZoBank.Domain.IdentityEntity;

namespace StanZoBank.Domain.Entities
{
	public class Transaction
	{

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public string TransactionReference { get; set; }

		public string TransactionDetails { get; set; }

		public TransactionStatus TransactionSatus { get; set; }
		
		public TransactionType TransactionType { get; set; }
		
		public string UserId { get; set; }
		
		public ApplicationUser ApplicationUser { get; set; }
		
		public DateTime CreatedAt { get; set; } = DateTime.Now;
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NormuraRuleDBModels.Entities
{
	public class Sessionuser
	{
		public int ID {get; set;}


		[StringLength(50)]
		public string SessionID {get; set;}


		[StringLength(50)]
		public string UserID {get; set;}


		public DateTime CreateDate {get; set;}


	}

}

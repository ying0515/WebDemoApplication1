using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NormuraRuleDBModels.Entities
{
	public class Systemrole
	{
		public int ID {get; set;}


		[StringLength(50)]
		public string RoleKey {get; set;}


		[StringLength(50)]
		public string RoleSysName {get; set;}


		[StringLength(50)]
		public string Desc {get; set;}


		public DateTime CreateDate {get; set;}


	public bool IsEnabled {get; set;}


	}

}

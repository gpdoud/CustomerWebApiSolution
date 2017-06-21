using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerWebApiProject.Models {
	public class Customer {
		public int ID { get; set; }
		public int DB { get; set; }
		public string Name { get; set; }
		public bool Active { get; set; }
		public DateTime DateCreated { get; set; }
		public decimal CreditLimit { get; set; }
	}
}
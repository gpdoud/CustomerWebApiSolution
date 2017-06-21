using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerWebApiProject.Models {
	public class Order {
		public int ID { get; set; }
		public DateTime Date { get; set; }
		public string Description { get; set; }
		public decimal Total { get; set; }
	}
}
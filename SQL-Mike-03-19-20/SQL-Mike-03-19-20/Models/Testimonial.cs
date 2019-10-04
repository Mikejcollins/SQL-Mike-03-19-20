using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SQL_Mike_03_19_20.Models
{
	public class testimonial
	{

		public int ID { get; set; }
		public string Author { get; set; }
		public string Content { get; set; }
		public DateTime Added { get; set; }
	}
}
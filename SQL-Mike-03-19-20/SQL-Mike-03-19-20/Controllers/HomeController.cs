using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Security.Provider;
using SQL_Mike_03_19_20.Migrations;
using SQL_Mike_03_19_20.Models;

namespace SQL_Mike_03_19_20.Controllers
{
	public class HomeController : Controller
	{

		public ActionResult Index()
		{
			return View();
		}



	}


}
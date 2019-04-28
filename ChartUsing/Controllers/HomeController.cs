using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace ChartUsing.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ChartColumn(string tip = "Line")  //Chart tipini parametreye bagladık böylece dışarıdan tipe ne verirsek  ona göre grafik olusacak!
        {

            Chart chart = new Chart(500, 500);
            chart.AddTitle("MyComputer Salesman Graphic");
            chart.AddLegend("Products");
            chart.AddSeries(name: "Computer A", chartType: tip, xValue: new[] { 20, 40, 60 }, yValues: new[] { 800, 1200, 2300 });
            chart.AddSeries(name: "Computer B", chartType: tip, xValue: new[] { 20, 40, 60 }, yValues: new[] { 900, 1600, 3300 });

            return View(chart);
        }
    }
}
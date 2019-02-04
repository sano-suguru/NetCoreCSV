using System;
using NetCoreCSV.Services;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreCSV.Controllers {
  public class MembersController: Controller {
    private IMemberService Service { get; }

    public MembersController(IMemberService service) {
      Service = service;
    }

    public IActionResult Index() {
      var members = Service.GetMembers();
      return View(members);
    }

    public IActionResult DownloadCsv() {
      var filename = $"{DateTime.Now:yyyyMMddhhmmssfff}.csv";
      return File(Service.GetCsvData(), "text/csv", filename);
    }
  }
}
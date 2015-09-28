using DataAccess.Repository;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleMvcApplication.Models;
using System.Web.Configuration;

namespace SampleMvcApplication.Controllers
{
    public class EmployeeDetailsController : Controller
    {
        //
        // GET: /EmployeeDetails/

        public ActionResult Index()
        {
            GetXmlFilePath();
            List<EmployeeDetailsModel> employeeDetailsModels = new List<EmployeeDetailsModel>();
            List<EmployeeViewModel> employeeDetailsViewModels = new List<EmployeeViewModel>();
            //string xmlPath = WebConfigurationManager.AppSettings["XmlFilePath"];
               string   xmlPath = Server.MapPath("~/XMLFile/SampleXML.xml");
      
         int id = 0;

            //Add New comment

         employeeDetailsModels = GetDetails(id, xmlPath);
            foreach (var v in employeeDetailsModels)
            {
                EmployeeViewModel employeeDetailsModel = new EmployeeViewModel();
                employeeDetailsModel.EmployeeId = v.EmployeeId;
                employeeDetailsModel.EmployeeName = v.EmployeeName;
                employeeDetailsModel.EmployeeDesignation = v.EmployeeDesignation;
                employeeDetailsModel.EmployeeAddress = v.EmployeeAddress;
                employeeDetailsViewModels.Add(employeeDetailsModel);
            }


            return View(employeeDetailsViewModels);
        }

        public List<EmployeeDetailsModel> GetDetails(int id,string xmlPath)
        {
            EmployeeDetailsRepository employeeRepo = new EmployeeDetailsRepository();
            //string xmlPath = Server.MapPath("~/XMLFile/SampleXML.xml");
            return employeeRepo.GetEmpolyeeDetails( xmlPath,id);
        }


        public List<EmployeeDetailsModel> GetDetailsByXmlString(String xmlString,int Id)
        {
            EmployeeDetailsRepository employeeRepo = new EmployeeDetailsRepository();

            return employeeRepo.GetEmpolyeeDetailsByXmlString(xmlString, Id);

        }


        public string GetXmlFilePath()
        {

            string xmlFilePath = "";
            xmlFilePath = WebConfigurationManager.AppSettings["XmlFilePath"];
            ViewData["val1"] = xmlFilePath;
            return xmlFilePath;
        }

    }
}

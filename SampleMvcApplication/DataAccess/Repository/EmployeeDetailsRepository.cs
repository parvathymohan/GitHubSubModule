using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess.Repository
{
   public class EmployeeDetailsRepository
    {

       public List<EmployeeDetailsModel> GetEmpolyeeDetails(string xmlPath,int Id)
        {

            List<EmployeeDetailsModel> employeeDetailsModel = new List<EmployeeDetailsModel>();


            System.Xml.Linq.XDocument xmlDoc = XDocument.Load(xmlPath);
            employeeDetailsModel = (from x in xmlDoc.Root.Elements("Employee") 
                                      select
                                      new EmployeeDetailsModel
                                      {
                                          EmployeeId = Convert.ToInt32(x.Element("Id").Value),
                                          EmployeeName = (string)x.Element("Name").Value,
                                          EmployeeDesignation = (string)x.Element("Designation").Value,
                                          EmployeeAddress = (string)x.Element("Address").Value 
                                          


                                      }).ToList();

           if(Id!=0)
           {

               List<EmployeeDetailsModel> agencyDetailsModelResult = employeeDetailsModel.Where(s => s.EmployeeId == Id).ToList<EmployeeDetailsModel>();
               return agencyDetailsModelResult;

           }
           else
           {
               return employeeDetailsModel;
           }






            //return agencyDetailsModel;
           
        }



       public List<EmployeeDetailsModel> GetEmpolyeeDetailsByXmlString(string xmlString, int Id)
       {

           List<EmployeeDetailsModel> employeeDetailsModel = new List<EmployeeDetailsModel>();


           System.Xml.Linq.XDocument xmlDoc = XDocument.Parse(xmlString);

           
           employeeDetailsModel = (from x in xmlDoc.Root.Elements("Employee")
                                 select
                                 new EmployeeDetailsModel
                                 {
                                     EmployeeId = Convert.ToInt32(x.Element("Id").Value),
                                     EmployeeName = (string)x.Element("Name").Value,
                                     EmployeeDesignation = (string)x.Element("Designation").Value,
                                     EmployeeAddress = (string)x.Element("Address").Value



                                 }).ToList();

           if (Id != 0)
           {

               List<EmployeeDetailsModel> agencyDetailsModelResult = employeeDetailsModel.Where(s => s.EmployeeId == Id).ToList<EmployeeDetailsModel>();
               return agencyDetailsModelResult;

           }
           else
           {
               return employeeDetailsModel;
           }






           //return agencyDetailsModel;

       }
    }
}

    


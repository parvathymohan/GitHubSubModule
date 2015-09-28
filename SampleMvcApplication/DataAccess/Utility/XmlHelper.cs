using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Utility
{
   public class XmlHelper
    {


        public string GetXml()
        {
            string xmlString = @"<?xml version=""1.0""?><Employees> <Employee><Id>1</Id><Name>John</Name><Designation>SSE</Designation><Address>Address1</Address></Employee><Employee><Id>2</Id><Name>Sanoj</Name><Designation>SSE</Designation><Address>Address1</Address></Employee></Employees>";
            return xmlString;
        }
    }
}

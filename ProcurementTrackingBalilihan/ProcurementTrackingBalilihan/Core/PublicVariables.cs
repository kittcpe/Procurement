using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ProcurementTrackingBalilihan.Core
{
    class PublicVariables
    {
        public static string ProjectName = "Procurement Tracking v.1.0";
        public static double ProjectVersion = 2.0;

        #region Server Details
        public static string ServerConnectionString =  File.ReadLines("constring.txt").First();
        #endregion

        public static string UserPrivilege { get; set; }
    }

}

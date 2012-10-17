using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientManager.Database
{
    public partial class doctor
    {
        public string docFullName
        {
            get
            {
                return docFirstName + " " + docLastName; 
            }
        }
    }
}

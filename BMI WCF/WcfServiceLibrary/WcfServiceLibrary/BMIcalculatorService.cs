using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class BMIcalculatorService : IBMIcalculatorService
    {
        public double Calculatebmi(Person p)
        {
            double bmi = p.weight / Math.Pow(p.height,2);
            return bmi;
        }
        
            
    }


            
    
}


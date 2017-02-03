using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SummatorService" in both code and config file together.
    public class SummatorService : ISummatorService
    {
        public int GetSum(int a, int b)
        {
            return a + b;
        }
    }
}

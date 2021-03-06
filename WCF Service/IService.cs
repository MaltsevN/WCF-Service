﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISummatorService" in both code and config file together.
    [ServiceContract]
    public interface ISummatorService
    {
        [OperationContract]
        int GetSum(int a, int b);
    }

    [ServiceContract]
    public interface IMultiplicatorService
    {
        [OperationContract]
        int GetMult(int a, int b);
    }
}

﻿using System.ServiceModel;

namespace wcfConsoleApp.Services
{
    [ServiceContract]
    public interface IMyContract
    {
        [OperationContract]
        string MyMethod(string data);
    }

    [ServiceContract]
    public interface IMyOtherContract
    {
        [OperationContract]
        int AnotherMethod(int number);
    }
}

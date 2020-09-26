using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using EntitiesLayer; //for entities


namespace WCFEmpServiceLib
{
    [ServiceContract]
    public interface IEmpService
    {         
        [OperationContract]
        List<Employee> GetAllEmps();

        [OperationContract]
        void AddEmployee(Employee emp);

        [OperationContract]
        void DeleteEmpById(int ecode);
        
        [OperationContract]
        void UpdateEmpById(Employee emp);
       
        [OperationContract]
        Employee GetEmpById(int ecode);

    }
}

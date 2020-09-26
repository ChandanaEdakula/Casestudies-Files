using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ADOEmpLib; //for DAL classes

namespace WCFEmpServiceLib
{
    public class EmpService : IEmpService,IMathService
    {
        public void AddEmployee(Employee emp)
        {
            AdoDisconnected dal = new AdoDisconnected();
            dal.AddEmployee(emp);
        }

        public void DeleteEmpById(int ecode)
        {
            AdoDisconnected dal = new AdoDisconnected();
            dal.DeleteEmpById(ecode);
        }

        public void DivideNumber()
        {
            try
            {
                int x = 100, y = 0;
                int result = x / y;
            }
            catch (DivideByZeroException ex)
            {
                //log the main exception and throw user-defined error
                //create a FaultException<T> of ur custom exception type and
                //then throw this FaultException object
                MyException ex2 = new MyException("some error has occurred, try later");
                FaultException<MyException> fex = new FaultException<MyException>(ex2, ex2.ErrMsg);
                throw fex;
            }

        }

        public List<Employee> GetAllEmps()
        {
            AdoDisconnected dal = new AdoDisconnected();
            var empLst = dal.GetAllEmps();
            return empLst;
        }

        public Employee GetEmpById(int ecode)
        {
            AdoDisconnected dal = new AdoDisconnected();
            var emp = dal.GetEmpById(ecode);
            return emp;
        }

        public void UpdateEmpById(Employee emp)
        {
            AdoDisconnected dal = new AdoDisconnected();
            dal.UpdateEmpById(emp);
        }
    }


    [DataContract]
    public class MyException 
    {
        public string ErrMsg { get;  }
        public MyException(string errMsg) 
        {
            ErrMsg = errMsg;
        }
    }
}
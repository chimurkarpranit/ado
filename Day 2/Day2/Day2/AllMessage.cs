///Day2 : Class for Commmon Message
///Created By: Pranit Chimurkar
///Date: 2019/08/12

namespace Day2
{
    public class AllMessage
    {
        public const string strEmp1 = "select CONCAT(e.FirstName,' ',e.LastName) AS Name, e.* from employees e";
        public const string strEmp = "select * from employees";
        public const string strTerr = "select * from territories";
        public const string strEmpTerr = "select * from employeeterritories et where et.EmployeeID = ";
    }
}
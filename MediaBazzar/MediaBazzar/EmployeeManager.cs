using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazzar
{
    public class EmployeeManager : IManager
    {
        private List<Employee> Emps;
        private EmployeeData data;
        public EmployeeManager()
        {
            data = new EmployeeData();
            loadDataFromDatabase();
        }
        private void loadDataFromDatabase()
        {
            try
            {
                Emps = (List<Employee>)data.ReadAll();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }       
        }
        public bool Add(object obj)
        {
            if (obj != null)
            {
                try
                {
                    data.Insert((Employee)obj);
                    loadDataFromDatabase();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }
        public Employee GetEmployee(int id)
        {
            foreach (Employee emp in Emps)
            {
                if (emp.EmployeeID == id)
                {
                    return emp;
                }
            }
            return null;
        }
        public List<object> GetAllPerType()
        {
            List<object> temp = new List<object>();
            foreach (Employee item in Emps)
            {
                temp.Add(item);
            }
            return temp;
        }
        public bool FireEmployee(Employee emp, string reason)
        {
            if (emp.Active)
            {
                emp.fireEmployee(reason);
                try
                {
                    data.FireEmployee(emp);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }
        public bool Remove(object obj)
        {
            throw new NotImplementedException();
        }
    }
}

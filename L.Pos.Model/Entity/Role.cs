using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Pos.Model.Entity
{
    public class Role : BaseEntity<string>
    {
        public virtual string Description { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual Role RootRole { get; set; }
        public virtual ICollection<RoleMenu> RoleMenus { get; set; }

        public virtual void AddEmployee(Employee newEmployee)
        {
            if (Employees == null)
            {
                Employees = new List<Employee>();
            }

            if (Employees.FirstOrDefault(x => x.Id == newEmployee.Id) == null)
            {
                Employees.Add(newEmployee);
            }
        }

        public virtual void RemoveEmployee(Employee Employee)
        {
            if (Employees == null)
            {
                Employees = new List<Employee>();
            }

            if (Employees.FirstOrDefault(x => x.Id == Employee.Id) != null)
            {
                Employees.Remove(Employee);
            }
        }

        public virtual void AddRoleMenu(RoleMenu RoleMenu)
        {
            if (RoleMenus == null)
            {
                RoleMenus = new List<RoleMenu>();
            }

            if (RoleMenus.FirstOrDefault(x => x.Role.Id == RoleMenu.Role.Id && x.Menu.Id == RoleMenu.Menu.Id) == null)
            {
                RoleMenus.Add(RoleMenu);
            }
        }

        public virtual void RemoveRoleMenu(RoleMenu RoleMenu)
        {
            if (RoleMenus == null)
            {
                RoleMenus = new List<RoleMenu>();
            }

            if (RoleMenus.FirstOrDefault(x => x.Role.Id == RoleMenu.Role.Id && x.Menu.Id == RoleMenu.Menu.Id) != null)
            {
                RoleMenus.Remove(RoleMenu);
            }
        }
    }
}

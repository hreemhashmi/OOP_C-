using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_project.Admin
{
    internal class AdminService
    {
        private AdminRepo repo = new AdminRepo();
        public bool Login(string name, string password)
        {
            AdminModel admin = repo.GetAdmin();
            if (admin.GetName() == name && admin.GetPassword() == password)
            {
                return true;
            }
            return false;
        }
    }
}

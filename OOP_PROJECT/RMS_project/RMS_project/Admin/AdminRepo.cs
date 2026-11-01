using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_project.Admin
{
    internal class AdminRepo
    {
        private AdminModel admin = new AdminModel("admin", "789");
        public AdminModel GetAdmin()
        {
            return this.admin;
        }
    }
}

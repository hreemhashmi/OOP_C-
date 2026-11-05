using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent_Management_system.Admin
{
    internal class AdminModel
    {
        private string name;
        private string password;
    
    public AdminModel()
        {

        }
    public AdminModel(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetPassword(string password)
        {
            this.password=password;
        }
        public string GetPassword()
        {
            return this.password;
        }
    }
 } 

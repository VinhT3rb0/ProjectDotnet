using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Model
{
    public class UserAccountModel
    {
        public string Username { get; set; }    
        public string DisplayName { get; set; }
        public byte[] ProfilePicture { get; set; }
    }
}

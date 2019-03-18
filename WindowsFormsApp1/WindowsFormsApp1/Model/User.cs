using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class User
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string pwd;

        public string Pwd
        {
            get { return pwd; }
            set { pwd = value; }
        }

        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_006
{
    internal class UserClass
    {
        private string id;
        private string name;
        private string address;

        

        
        public string getName()
        {
            return name;
        }
        public string getAdd()
        {
            return address;
        }
        public UserClass(string id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }

        public bool CheckIfUserExists(string ID)
        {
            if(ID == id)
                return true;
            else return false;
        }

    }
}

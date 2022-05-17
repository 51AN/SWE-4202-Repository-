using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_007
{
    internal class ProfessionalClass : Participant
    {
        static public List<ProfessionalClass> ProList = new List<ProfessionalClass>();
        public ProfessionalClass(string name, string reg, string cont, string email, string levell)
        {
            this.name = name;
            this.regNo = reg;
            this.contact = cont;
            this.email = email;
            this.level = levell;

        }
        public override double getFee(double feees)
        {
            return (feees + (0.1 * feees));
        }

        
    }
}

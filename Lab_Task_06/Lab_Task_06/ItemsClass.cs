using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_06
{
    internal class ItemsClass
    {
        private string shirtAm;
        private string pantAm;
        private string SuitAm;
        private string BedSheetAm;
        
        
        private string shirtTodo;
        private string pantTodo;
        private string SuitTodo;
        private string BedSheetTodo;


        public void setItems(string sam, string pam, string suam, string bam, string shtd, string ptd, string sutd,string bstd)
        {
            this.shirtAm = sam;
            this.pantAm = pam;
            this.SuitAm = suam;
            this.BedSheetAm = bam;

            this.shirtTodo = shtd;
            this.pantTodo = ptd;
            this.SuitTodo = sutd;
            this.BedSheetTodo= bstd;
        }

        public string getItems()
        {
            string set = "Shirt" + "\t" + shirtAm + "\t" + shirtTodo + "\n"
                        + "Pants" + "\t" + shirtAm + "\t" + shirtTodo + "\n"
                        + "Suits" + "\t" + shirtAm + "\t" + shirtTodo + "\n"
                        + "Bed-Sheets" + "\t" + shirtAm + "\t" + shirtTodo + "\n";
            return set;
        }




    }
}

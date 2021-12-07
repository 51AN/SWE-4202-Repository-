using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_04
{
    internal class ResearchArticleClass:ParentBookClass
    {
        private string publishDate;
        private string ConORJournal;
        private double DOI;


        public void settterReArticle(double id, string title, string author, string publisher, double quanitity, double doi, string pubDate, string ConorJour)
        {
            this.ID = id;
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.quantity = quanitity;
            this.DOI = doi;
            this.publishDate = pubDate;
            this.ConORJournal = ConorJour;


        }
        public bool checkReArticle(double ReArID)
        {
            if (ReArID == ID)
                return true;
            else return false;

        }


        public string getReArticle()
        {
            string setbook = ID.ToString() + "\t" + Title + "\t" + Author + "\t" + DOI.ToString() + "\t" + quantity.ToString() + "\t" + ConORJournal;
            return setbook;
        }
        public void ReArquantityDecrease()
        {
            quantity = quantity - 1;
        }

        public bool ReArquantityCheck()
        {
            if (quantity == 0)
                return false;
            else return true;
        }


    }
}

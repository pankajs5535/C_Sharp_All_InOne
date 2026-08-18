using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shap_All.Oops.Abstraction.Person_Date_Emp
{
    public class Date
    {
        private int dd;
        private int mm;
        private int yy;

        public static int count = 0;

        public Date()
        {
            // Default constructor
        }

        public Date(int dd, int mm, int yy)
        {
            this.dd = dd;
            this.mm = mm;
            this.yy = yy;
        }

        public void ShowDate()
        {
            System.Console.WriteLine($"Date: {dd}/{mm}/{yy}");
        }

        public void ShowDate(char ch)
        {
            System.Console.WriteLine($"Date: {dd}{ch}{mm}{ch}{yy}");
        }
    }

}

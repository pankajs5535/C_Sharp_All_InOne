using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shap_All.Oops.Abstraction.Mobile_Demo
{

    // Abstract Mobile Class
    public abstract class Mobile
    {
        private string model;
        private string company;
        private string color;
        private string camera;

        // Constructor
        public Mobile()
        {
            // Initialization if needed
        }

        // Setter method
        public void SetMobile(string model, string company, string color, string camera)
        {
            this.model = model;
            this.company = company;
            this.color = color;
            this.camera = camera;
        }

        // Getter method
        public void GetMobile()
        {
            System.Console.WriteLine("Mobile Model: " + model);
            System.Console.WriteLine("Mobile Company: " + company);
            System.Console.WriteLine("Mobile Color: " + color);
            System.Console.WriteLine("Mobile Camera: " + camera);
        }
    }


}

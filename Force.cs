using System;
using System.Collections.Generic;
using System.Text;

namespace MendozaQ1
{


   
    class Force
    {
        private const double gravityConst = 0.0000000000667408;

        private double force;
        private double objectMass1;
        private double objectMass2;
        private double distanceApart;
        public string objectName1;
        public string objectName2;

        public double ObjectMass1
        {
            get { return objectMass1; }
            set { objectMass1 = value; calc(); }
        }

      
        public string ObjectName1
        {
            get { return objectName1; }
            set { objectName1 = value; }
        }

        

        public string ObjectName2
        {
            get { return objectName2; }
            set { objectName2 = value; }
        }

        public double ObjectMass2
        {
            get { return objectMass2; }
            set { objectMass2 = value; calc(); }

        }

        public double Radius
        {
            get { return distanceApart; }

            set { distanceApart = value; calc(); }
        }
        public double GravityForce { get; private set; }

        private void calc()
        {
            force = gravityConst * ((objectMass1 * objectMass2) / distanceApart);

        }

        public override string ToString()
        {
            return "The force between " + objectName1 + " and " + objectName2 + " is: " + force + " in Newtons.";
        }







    }
}

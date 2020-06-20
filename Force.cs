using System;
using System.Collections.Generic;
using System.Text;

namespace MendozaQ1
{

//TODO:  score 89/100
   
    class Force
    {
        private const double gravityConst = 0.0000000000667408;

       // private double force;
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

    //TODO:  The names should be auto properties  -2
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
        //TODO:  This is not a good practice.  Make the private field and the
        //property have the same name
            get { return distanceApart; }

            set { distanceApart = value; calc(); }
        }
        public double GravityForce { get; private set; }

//TODO:  This works because you only return the summary.  However, there is nothing to return
//TODO:  from the GravityForce property

            //TODO:  calc should be Calc  -2
        private void calc()
        {
            //TODO:  So change this  so you are setting a value into the GravityForce Property  -2
            GravityForce   /*force*/ = gravityConst * ((objectMass1 * objectMass2) / distanceApart);
//TODO:  The formula has division by distance squared  -5
        }

        public override string ToString()
        {
            return "The force between " + objectName1 + " and " + objectName2 + " is: " + /*force*/GravityForce + " in Newtons.";
        }







    }
}

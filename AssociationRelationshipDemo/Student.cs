using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationRelationshipDemo
{
    class Student
    {
        public string RegNO { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public double PhysicsScore { set; get; }
        public double MathScore { set; get; }
        public Address StudentAddress { set; get; } // One To One Association Relationship

        public string GetResult()
        {
            Calculator calc = new Calculator(); // Uses Relationship
            double totalScore = calc.Add(PhysicsScore, MathScore);
            double avgScore = calc.Divide(totalScore, 2);
            if (avgScore >= 50)
            {
                return "Passed";
            }
            else
            {
                return "Failed";
            }
        }
    }
}

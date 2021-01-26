using System;

namespace Polymorphism
{
    public class PolymorphismTest
    {
        public static void Main(string[] args)
        {
            CommissionEmployee commissionEmployee = new CommissionEmployee("Sue", "Jones", "222-22-2222", 10000.00M, .06M);
            BasePlusCommissionEmployee basePlusCommissionEmployee = new BasePlusCommissionEmployee("Bob", "Lewis", "333-33-3333", 5000.00M, .04M, 300.00M);

            
            Console.WriteLine("{0} {1}:\n\n{2}\n{3}: {4:C}\n",
                "Call CommissionEmployee's ToString and Earnings methods ", "with base-class reference to base class object",
                commissionEmployee.ToString(), "earnings", commissionEmployee.Earnings());

            
            Console.WriteLine("{0} {1}:\n\n{2}\n{3}: {4:C}\n",
                "Call BasePlusCommissionEmployee's ToString and Earnings ", "methods with derived class reference to derived-class object",
                basePlusCommissionEmployee.ToString(), "earnings", basePlusCommissionEmployee.Earnings());


            // invoke ToString and Earnings on derived-class object
            // using base-class variable
            CommissionEmployee commissionEmployee2 = basePlusCommissionEmployee;

            Console.WriteLine("{0} {1}:\n\n{2}\n{3}: {4:C}", "Call BasePlusCommissionEmployee's ToString and Earnings ", "with base class reference to derived-class object",
                commissionEmployee2.ToString(), "earnings", commissionEmployee2.Earnings());

        }
    }
}

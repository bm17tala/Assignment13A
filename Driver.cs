using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_13A_DLLs;

namespace Assignment_13A {
    internal class Driver {

        //test base class, basketball and baseball classes
        static void Main(string[] args) {
            //base class - name/sport/coach are undefined so they don't appear in this printout
            Console.WriteLine("Instantiating the base class...");
            Team baseTeam = new Team();
            Console.WriteLine(baseTeam);

            //basketball subclass - the information entered into the basketball class will appear here, with the overridden
            //methods inside the basketball class being called instead of the base class
            Console.WriteLine("Instantiating the Basketball child class...");
            Basketball basketballTeam = new Basketball();
            Console.WriteLine(basketballTeam);

            //baseball subclass - the information entered into the baseball class will appear here, with the overridden
            //methods inside the baseball class being called instead of the base class
            Console.WriteLine("Instantiating the Baseball child class...");
            Baseball baseballTeam = new Baseball();
            Console.WriteLine(baseballTeam);

            //call playerlist functions in baseclass, basketball and baseball subclasses also.
            //subclasses will call their overridden versions of the function.
            Console.WriteLine("Testing PlayerList virtual functions...\n");

            Console.WriteLine("Base class:");
            baseTeam.PlayerList();

            Console.WriteLine("Basketball subclass:");
            basketballTeam.PlayerList();

            Console.WriteLine("Baseball subclass:");
            baseballTeam.PlayerList();

            //IBasketball implementation test
            Console.WriteLine("Testing IBasketball interface:");
            Console.WriteLine("Increasing payroll...");
            basketballTeam.IncreasePayroll(1479.33F);
            Console.WriteLine("Payroll is now {0:C}", basketballTeam.TotalPayroll);
            Console.WriteLine("Decreasing payroll...");
            basketballTeam.DecreasePayroll(512.16F);
            Console.WriteLine("Payroll is now {0:C}\n", basketballTeam.TotalPayroll);

            //IBaseball implementation test
            Console.WriteLine("Testing IBaseball interface:");
            Console.WriteLine("Starting the first inning...");
            baseballTeam.NextInning();
            Console.WriteLine("Current inning: {0}", baseballTeam.CurrentInning);
            Console.WriteLine("The team got a home run!");
            baseballTeam.HomeRun();
            Console.WriteLine("Current score: {0}\n", baseballTeam.Score);

            //ICap implementation test; testing on basketball
            Console.WriteLine("Testing ICap interface:");
            Console.WriteLine("Setting variables accordingly...");
            basketballTeam.SalaryCap = 10000000F;
            basketballTeam.TotalPayroll = 8000000F;
            basketballTeam.RemainingCapSpace = basketballTeam.SalaryCap - basketballTeam.TotalPayroll;
            Console.WriteLine("Increasing payroll by $1,000,000...");
            basketballTeam.IncreasePayroll(1000000F);
            Console.WriteLine("Payroll increased! It is now {0:C}", basketballTeam.TotalPayroll);
            Console.WriteLine("Decreasing payroll by $500,000...");
            basketballTeam.DecreasePayroll(500000F);
            Console.WriteLine("Payroll decreased! It is now {0:C}", basketballTeam.TotalPayroll);

            Console.ReadKey();
        }
    }

}

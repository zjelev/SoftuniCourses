﻿namespace P02_VehiclesExtension.Commands.VehicleCommands
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DriveCommand : Command
    {
        //--------------- Constructors -----------------
        public DriveCommand() : base("Drive")
        {

        }

        //----------------- Methods --------------------
        public override void Run(string[] args)
        {
            Console.WriteLine("For testing purposes");
            //throw new NotImplementedException(); -> Liskov Substitution Violation if thrown...
        }

        public override void Run(string[] args, ICollection<Vehicle> vehicles)
        {
            foreach (Vehicle vehicle in vehicles.Where(v => v.GetType().Name == args[1]))
            {
                vehicle.Drive(double.Parse(args[2]));
            }
        }
    }
}

﻿
using System;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Utilities.Messages;

namespace EasterRaces.Models.Drivers.Entities
{
    public class Driver : IDriver
    {
        
        private string name;
        
        private bool canParticipate;
       

        public Driver(string name)
        {
            this.Name = name;
            this.canParticipate = false;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidName,value, 5));
                }

                this.name = value;
            }
        }

        public ICar Car { get; private set; }


        public int NumberOfWins { get; private set; }

        public bool CanParticipate
        {
            get
            {
                return this.canParticipate;
            }
            private set
            {
                if (this.Car == null)
                {
                    canParticipate = false;
                }
                else
                {
                    canParticipate = true;
                }
                
            }
        }
        public void WinRace()
        {
            this.NumberOfWins++;
        }

        public void AddCar(ICar car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(ExceptionMessages.CarInvalid);
            }

            this.Car = car;
            this.canParticipate = true;
        }
    }
}

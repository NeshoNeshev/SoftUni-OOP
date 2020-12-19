﻿
using System;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Commands
{
    public class ExitCommand:ICommand
    {
        public string Execute(string[] args)
        {
            Environment.Exit(0);//spira programata
            return null;
        }
    }
}
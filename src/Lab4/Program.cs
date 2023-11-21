using System;
using Itmo.ObjectOrientedProgramming.Lab4.Controllers;

namespace Itmo.ObjectOrientedProgramming.Lab4;
public static class Program
{
    public static void Main()
    {
        while (true)
        {
            string? command = Console.ReadLine();
            var invoker = new Invoker();
            invoker.ExecuteCommand(command);
        }
    }
}

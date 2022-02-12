// 2022/02/12
// LocalClsConfig.Test

using System;
using static LocalClsConfig;

class Program {
    static void Main(string[] args) {

        SetEnvironment();

        Console.WriteLine("Hello World!");

        ResizeConsoleToFit();

        if (ConsoleEnvironmet == ConsoleEnvironmets.WIN)
            Console.ReadKey(true);
    }
}
﻿namespace ServiceBusDepot.ConsoleHost.Features
{
    public static class ConsoleColorManager
    {
        public static ConsoleColorRegion Title { get { return new ConsoleColorRegion(System.ConsoleColor.Yellow); } }

        public static ConsoleColorRegion Header { get { return new ConsoleColorRegion(System.ConsoleColor.Yellow); } }

        public static ConsoleColorRegion InputOption { get { return new ConsoleColorRegion(System.ConsoleColor.Green); } }

        public static ConsoleColorRegion ErrorMessage{ get { return new ConsoleColorRegion(System.ConsoleColor.Red); } }

    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueryMaster;
using QueryMaster.GameServer;
using System;

namespace UnitTest
{
    [TestClass]
    public class GameServerTest
    {
        [TestMethod]
        public void GetInfoTest()
        {
            var server = ServerQuery.GetServerInstance(EngineType.Source, @"121.46.225.75", 27015);
            var info = server.GetInfo();
            Console.WriteLine(info.IsObsolete);
            Console.WriteLine(info.Address);
            Console.WriteLine(info.Protocol);
            Console.WriteLine(info.Name);
            Console.WriteLine(info.Map);
            Console.WriteLine(info.Directory);
            Console.WriteLine(info.Description);
            Console.WriteLine(info.Id);
            Console.WriteLine(info.Players);
            Console.WriteLine(info.MaxPlayers);
            Console.WriteLine(info.Bots);
            Console.WriteLine(info.ServerType);
            Console.WriteLine(info.Environment);
            Console.WriteLine(info.IsPrivate);
            Console.WriteLine(info.IsSecure);
            Console.WriteLine(info.GameVersion);
            Console.WriteLine(info.Ping);
            Console.WriteLine(info.ExtraInfo);
            Console.WriteLine(info.ShipInfo);
            Console.WriteLine(info.IsModded);
            Console.WriteLine(info.ModInfo);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueryMaster;
using QueryMaster.MasterServer;
using QueryMaster.MasterServer.DataObjects;
using System;
using System.Threading.Tasks;
using Region = QueryMaster.MasterServer.Region;

namespace UnitTest
{
    [TestClass]
    public class MasterServerTest
    {
        [TestMethod]
        public async Task GetListTest()
        {
            var server = MasterQuery.GetServerInstance(MasterQuery.SourceServerEndPoint);
            var method = new BatchReceivedCallback(info =>
            {
                Console.WriteLine(info.Source);
                Console.WriteLine(info.IsLastBatch);
                Console.WriteLine(info.Region);
                Console.WriteLine(info.ReceivedEndpoints.Count);
                foreach (var endPoint in info.ReceivedEndpoints)
                {
                    Console.WriteLine($@"{endPoint.Address}:{endPoint.Port}");
                }
            });
            var filter = new IpFilter
            {
                AppId = Game.Left_4_Dead_2
            };

            server.GetAddresses(Region.Asia, method, filter);
            await Task.Delay(5000);
        }

        [TestMethod]
        public async Task GetListNewApiTest()
        {
            
            await Task.Delay(5000);
        }
    }
}

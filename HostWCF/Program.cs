using ObjectWCF;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace HostWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lansare server WCF...");

            ServiceHost host = new ServiceHost(
                typeof(PostComment),
                new Uri("http://localhost:8000/PC")
            );

            foreach (ServiceEndpoint se in host.Description.Endpoints)
                Console.WriteLine("A (address): {0} \nB (binding): {1}\nC(Contract): {2}\n", se.Address, se.Binding.Name, se.Contract.Name);

            host.Open();

            Console.ReadLine();
            
            host.Close();
        }
    }
}

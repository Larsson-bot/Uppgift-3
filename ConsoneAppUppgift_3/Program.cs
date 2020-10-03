using Microsoft.Azure.Devices.Client;
using SharedLibaries.Services;
using System;

namespace ConsoleAppUppgift_3
{
    class Program
    {
        private static readonly string _conn = "HostName=Uppgift3.azure-devices.net;DeviceId=consoleapp;SharedAccessKey=Bu5rwQng/XT05sJRIGk27t7EYQGaM1nFds8/H+B90nU=";
        private static readonly DeviceClient deviceClient = DeviceClient.CreateFromConnectionString(_conn, TransportType.Mqtt);

        static void Main(string[] args)
        {
            DeviceService.SendMessageAsync(deviceClient).GetAwaiter();
            DeviceService.ReceiveMessageAsync(deviceClient).GetAwaiter();
            Console.ReadKey();
        }
    }
}

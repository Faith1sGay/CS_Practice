using Hypixel.NET;
using System;
using System.IO;
using System.Text.Json;

namespace HypixelCLI
{
    internal class ApiCreds
    {
        public string ApiKey
        {
            get; set;
        }
    }

    class Program
    {
        public static ApiCreds creds = null;

        static void Main()
        {
            creds = JsonSerializer.Deserialize<ApiCreds>(File.ReadAllText("../../../ApiCreds.json"));
            HypixelApi api = new HypixelApi(creds.ApiKey, 300);
            int opts;
            Console.WriteLine("Please Enter MineCraft Username : ");
            string user = Console.ReadLine();
            Console.WriteLine("== HYPIXEL STAT CLI ==");
            Console.WriteLine("Please enter the option for Hypixel Stats that you want: \n1.QuakeCraft\n2.Walls\n3.Paintball\n4.Survival Games\n5.TNT Games\n6.VampireZ");
            opts = int.Parse(Console.ReadLine());
            switch (opts)
            {
                case 1:
                    var qc = api.GetUserByPlayerName(user);
                    Console.WriteLine("User : {0}\nFirst time logged into QuakeCraft : {1}\nLast time logged into QuakeCraft : {2}\nTotal QuakeCraft Kills : {3}\nTo", user, qc.Player.FirstLogin, qc.Player.LastLogin, qc.Player.Stats.Quake.Kills);
                    break;
                case 2:
                    var walls = api.GetUserByPlayerName(user);
                    Console.WriteLine("User : {0}\nFirst time logged into Walls : {1}\nLast time logged into Walls : {2}\nTotal Walls Kills : {3}", user, walls.Player.FirstLogin, walls.Player.LastLogin, walls.Player.Stats.Walls.Kills);
                    break;
            }
        }
    }
}
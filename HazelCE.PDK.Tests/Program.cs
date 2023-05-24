using System;
using HazelCE.PDK;
using Newtonsoft.Json;

namespace HazelCE.PDK.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            plugin MyPlugin = new plugin();
            //MyPlugin.name[0] = "SiestaPlugin";
            //MyPlugin.id[0] = "sisplug";
            //MyPlugin.root[0] = MyPlugin.id[0];
            MyPlugin.id_complete[0, 0] = "SiestaPlugin";
            MyPlugin.id_complete[0, 1] = "sisplug";
            MyPlugin.id_complete[0, 2] = MyPlugin.id_complete[0, 1];
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;
            using (StreamWriter sw = new StreamWriter(@"plugins.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, MyPlugin);
            }

            Console.ReadLine();
        }
    }
}
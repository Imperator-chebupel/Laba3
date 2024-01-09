using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Resources.ResXFileRef;

namespace Текстовый_квест_с_интерфейсом
{
    public class FileWorker
    {
        ItemConverter IC = new ItemConverter();

        public void Write_to_JSON_player(Player player) 
        {
            Player player_to_write = new Player();
            player_to_write.Time_ = player.Time_;
            player_to_write.X_ = player.X_;
            player_to_write.Y_ = player.Y_;
            string FilePath_Main = @"C:\\Users\\azza1\\OneDrive\\Рабочий стол\\Мощное хранилище данных\\Player_P.txt";
            string FilePath_Inv = @"C:\\Users\\azza1\\OneDrive\\Рабочий стол\\Мощное хранилище данных\\Player_Inv.txt";
            string JsonPlayer = JsonConvert.SerializeObject(player_to_write);
            string JsonInv = JsonConvert.SerializeObject(player.Inventory);
            File.WriteAllText(FilePath_Main, JsonPlayer);
            File.WriteAllText(FilePath_Inv, JsonInv);
        }

        public Player Read_the_JSON_player()
        {
            string FilePath_Main = @"C:\\Users\\azza1\\OneDrive\\Рабочий стол\\Мощное хранилище данных\\Player_P.txt";
            string FilePath_Inv = @"C:\\Users\\azza1\\OneDrive\\Рабочий стол\\Мощное хранилище данных\\Player_Inv.txt";
            TextReader reader = new StreamReader(FilePath_Main);
            var fileContents = reader.ReadToEnd();
            Player p = JsonConvert.DeserializeObject<Player>(fileContents);
            TextReader reader_inv = new StreamReader(FilePath_Inv);
            var fileContents_ = reader_inv.ReadToEnd();

            JsonConverter[] converters = { new ItemConverter() };
            var inv = JsonConvert.DeserializeObject<List<Item>>(fileContents_, new JsonSerializerSettings() { Converters = converters });

            p.Inventory = inv;
            return p;
        }

        public void Write_to_JSON_world(Stuff stuff)
        {
            string FilePath_NPC = @"C:\\Users\\azza1\\OneDrive\\Рабочий стол\\Мощное хранилище данных\\World_NPCs.txt";
            string FilePath_IT = @"C:\\Users\\azza1\\OneDrive\\Рабочий стол\\Мощное хранилище данных\\World_Items.txt";
            string JsonWorld_NPC = JsonConvert.SerializeObject(stuff.NPCs);
            string JsonWorld_Items = JsonConvert.SerializeObject(stuff.Items);
            File.WriteAllText(FilePath_NPC, JsonWorld_NPC);
            File.WriteAllText(FilePath_IT, JsonWorld_Items);
        }

        public Stuff Read_from_Json_world()
        {
            Stuff S = new Stuff();
            string FilePath_NPC = @"C:\\Users\\azza1\\OneDrive\\Рабочий стол\\Мощное хранилище данных\\World_NPCs.txt";
            string FilePath_It = @"C:\\Users\\azza1\\OneDrive\\Рабочий стол\\Мощное хранилище данных\\World_Items.txt";
            TextReader reader = new StreamReader(FilePath_It);
            var fileContents = reader.ReadToEnd();
            JsonConverter[] converters = { new ItemConverter() };
            var items = JsonConvert.DeserializeObject<List<Item>>(fileContents, new JsonSerializerSettings() { Converters = converters });
            S.Items = items;
            
            TextReader reader_ = new StreamReader(FilePath_NPC);
            var fileContents_ = reader_.ReadToEnd();
            JsonConverter[] converters_ = { new ItemConverter() };
            var npcs = JsonConvert.DeserializeObject<List<NPC>>(fileContents_, new JsonSerializerSettings() { Converters = converters_ });
            S.NPCs = npcs;
            return S;
        }




        public class ItemConverter : JsonConverter
        {
            public override bool CanConvert(Type objectType)
            {
                return (objectType == typeof(Item));
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                throw new NotImplementedException();
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                JObject jo = JObject.Load(reader);
                if (jo["Index"].Value<string>() == "1")
                    return jo.ToObject<Item_usefull>(serializer);

                if (jo["Index"].Value<string>() == "2")
                    return jo.ToObject<Item_useless>(serializer);

                if (jo["Index"].Value<string>() == "3")
                    return jo.ToObject<Item_timer>(serializer);
                
                if (jo["Index"].Value<string>() == "4") 
                    return jo.ToObject<NPC>(serializer);



                return null;
            }
        }
    }
}

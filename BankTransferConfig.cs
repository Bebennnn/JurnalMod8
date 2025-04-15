using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Modul8_103022330122
{
    public class BankTransferConfig
    {
        private const string ConfigPath = "bank_transfer_config.json";

        public string lang { get; set; } 
       public Transfer trasnfer { get; set; }

        public List<string> methods { get; set; }
        public Confirmation confirmation { get; set; }



        public BankTransferConfig()
        {
            LoadConfig();
        }

       
        public class Transfer {
            public int threshold { get; set; }
            public int low_fee { get; set; }
            public int high_fee { get; set; }
        }
        public class Confirmation { 
            public string en { get; set; }
            public string id { get; set; }

        }

        public void SetDefault()
        {
            BankTransferConfig config = new BankTransferConfig();
            config.lang = "en";
            config.trasnfer.threshold = 25000000;
            config.trasnfer.low_fee = 6500;
            config.trasnfer.high_fee = 15000;
            config.methods = "[ “RTO (real-time)”, “SKN”, “RTGS”, “BI FAST” ]";
            config.confirmation.en = "yes";
            config.confirmation.id = "ya";


        }

        public void LoadConfig()
        {
            if (File.Exists(ConfigPath))
            {
                string json = File.ReadAllText(ConfigPath);
                var data = JsonSerializer.Deserialize<BankTransferConfig>(json);
                if (data != null)
                {
                    lang = data.lang;
                    threshold = data.Transfer.threshold;
                    low_fee = data.low_fee;
                    high_fee = data.high_fee;
                    methods = data.methods;
                    en = data.en;
                    id = data.id;
                }
            }
            else
            {
                SaveConfig();
            }
        }
        public void SaveConfig()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(this, options);
            File.WriteAllText(ConfigPath, json);
        }
    }
}

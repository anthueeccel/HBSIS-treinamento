using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ForeachNaLista
{
   
    public class CotacaoApi
    {
        public double varBid { get; set; }
        public string code { get; set; }
        public string codein { get; set; }
        public string name { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public double pctChange { get; set; }
        public double bid { get; set; }
        public double ask { get; set; }

        [JsonIgnore]
        public TimeSpan timestamp { get; set; }
        [JsonIgnore]
        public DateTime create_date { get; set; }

        // CotacaoApi cotacaoApi = new CotacaoApi();
        //string json = JsonConvert.SerializeObject(cotacaoApi);
        //CotacaoApi deserializedCotacaoApi = JsonConvert.DeserializeObject<CotacaoApi>(json);
        //Install package Newtonsoft.js
    }
}

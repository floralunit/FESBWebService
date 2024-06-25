using System;
using System.Collections.Generic;

namespace FESBWebService.Model
{

    /*   {
     "info": {
       "ID": "",
       "Model": "",
       "ChangeAuthor": "",
       "ChangeDate": "",
       "Producer": "",
       "GUIDRequestConsumer": "",
       "GUIDRequestID": ""
     },
     "object": { },
     "additionalInfo": [
       {
         "infoset": {
           "Key": "",
           "Value": ""
         }
       }
     ]
   } */
    public class Info
    {
        public long? ID { get; set; }
        public string Model { get; set; }
        public string ChangeAuthor { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string Producer { get; set; }
        public Guid? GUIDRequestConsumer { get; set; }
        public Guid? GUIDRequestID { get; set; }
    }

    public class Infoset
    {
        public long? Key { get; set; }
        public string Value { get; set; }
    }

    public class AdditionalInfo
    {
        public Infoset Infoset { get; set; }
    }

    public class RootObject
    {
        public Info Info { get; set; }
        public object Object { get; set; }
        public List<AdditionalInfo> AdditionalInfo { get; set; }
    }

}
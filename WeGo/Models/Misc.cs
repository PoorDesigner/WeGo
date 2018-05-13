using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeGo.Models
{
    [Serializable]
    public class POSAccountStatus
    {

        public int Id { get; set; }

        public string Name { get; set; }
    }

    [Serializable]
    public class Agent
    {

        public int Id { get; set; }

        public string Name { get; set; }
    }

    [Serializable]
    public class EmailTemplate
    {

        public int Subject { get; set; }

        public string Body { get; set; }
    }

    

}
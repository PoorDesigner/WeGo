using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeGo.Models
{
    [Serializable]
    public class AccountViewModel : IStepViewModel
    {
        public AccountViewModel()
        {
            Status = new List<POSAccountStatus>();
            Agent = new List<Agent>();
            Status.Add(new POSAccountStatus() { Id = 1, Name = "New" });
            Status.Add(new POSAccountStatus() { Id = 2, Name = "Complte" });

            Agent.Add(new Agent() { Id = 1, Name = "Vivek" });
            Agent.Add(new Agent() { Id = 2, Name = "Mani" });

        }
        public string Name = "Create Account";

        public int SelectedStatusId { get; set; }

        [DisplayName("Pos Account Status")]
        public List<POSAccountStatus> Status { get; set; }

        public int SelectedAgentId { get; set; }

        [DisplayName("Agent")]
        public List<Agent> Agent { get; set; }

        public string ShopName { get; set; }
        public string ShopAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public string ShopEmail { get; set; }
        public string ShopWeb { get; set; }
        public string StoreMatch { get; set; }
        public string ProductMatch { get; set; }

        public string SecurityToken { get; set; }

        public string ShopDefaultFlag { get; set; }


    }

    [Serializable]
    public class QuestionsViewModel : IStepViewModel
    {
        public string Name = "Questions";
    }

    [Serializable]
    public class DeliverySettingsViewModel : IStepViewModel
    {
        public string Name = "Delivery Settings";
    }
}
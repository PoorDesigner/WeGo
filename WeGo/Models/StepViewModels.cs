using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WeGo.Models
{
    [Serializable]
    public class Step1ViewModel : IStepViewModel
    {
        public string Foo { get; set; }
    }

    [Serializable]
    public class Step2ViewModel : IStepViewModel
    {
        public string Bar { get; set; }
    }

    [Serializable]
    public class Step3ViewModel : IStepViewModel
    {
        public string Baz { get; set; }
    }
}
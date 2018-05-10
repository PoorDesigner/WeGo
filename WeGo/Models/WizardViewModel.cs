using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeGo.Models
{
    [Serializable]
    public class WizardViewModel
    {
        public int CurrentStepIndex { get; set; }
        public IList<IStepViewModel> Steps { get; set; }

        public void Initialize()
        {
            Steps = typeof(IStepViewModel)
                .Assembly
                .GetTypes()
                .Where(t => !t.IsAbstract && typeof(IStepViewModel).IsAssignableFrom(t))
                .Select(t => (IStepViewModel)Activator.CreateInstance(t))
                .ToList();
        }
    }
}
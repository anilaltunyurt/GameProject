using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Entities
{
    public class Campaign : IEntity
    {
        public string CampaignName { get; set; }
        public double CampaignRate { get; set; }

    }
}

﻿using IMSLogicLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSLogicLayer.Models
{
    public class Intervention : IMSDBLayer.DataModels.Intervention
    {
        private string clientName;
        private string districtName;
        
        public string ClientName
        {
            get { return clientName; }
            set { this.clientName = value; }
        }

        public string DistrictName
        {
            get { return districtName; }
            set { this.districtName = value; }
        }

        public new InterventionState State
        {
            get { return (InterventionState)base.State; }
            set { base.State = (int)value; }
        }
    }
}
﻿using IMSLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSLogicLayer.ServiceInterfaces
{
    public interface IDistrictService
    {
        District GetDistrictById(Guid Id);

        District GetDistrictByName(string name);

    }
}

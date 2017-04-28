﻿using IMSLogicLayer.Enums;
using IMSLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSLogicLayer.ServiceInterfaces
{
    public interface IInterventionService
    {
        //  InterventionType getInterventionType();
        Intervention getInterventionsById(Guid interventionId);

        IEnumerable<Intervention> getListofProposedInterventions();

        IEnumerable<Intervention> getInterventionsByCreatorId(Guid creatorId);

        IEnumerable<Intervention> getInterventionsByClientId(Guid clientId);

        IEnumerable<Intervention> getInterventionByApprovedUser(Guid userId);

        bool updateInterventionState(Guid interventionId, InterventionState state);

        bool updateInterventionDetail(Guid interventionId, string comments, int remainLife);

        bool updateInterventionLastVisitDate(Guid interventionId, DateTime lastVisitDate);
        bool updateIntervetionApprovedBy(Guid interventionId, User user);
        bool updateInterventionState(Guid interventionId, InterventionState state, Guid identityId);
    }
}

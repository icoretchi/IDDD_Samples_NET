﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaaSOvation.IdentityAccess.Domain.Model.Identity
{
    public class TenantDeactivated : SaaSOvation.Common.Domain.Model.IDomainEvent
    {
        public TenantDeactivated(TenantId tenantId)
        {
            this.EventVersion = 1;
            this.OccurredOn = DateTime.Now;
            this.TenantId = tenantId.Id;
        }

        public int EventVersion { get; set; }

        public DateTime OccurredOn { get; set; }

        public string TenantId { get; private set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MAVN.Service.PayrexxIntegration.Domain.Services
{
    public interface IPartnerIntegrationPropertiesService
    {
        List<IntegrationProperty> GetIntegrationProperties();

        Task<PayrexxIntegrationProperties> FetchPropertiesAsync(Guid partnerId);

        PayrexxIntegrationProperties DeserializePayrexxIntegrationProperties(string paymentIntegrationProperties);

        Task<List<string>> GetIntegrationCurrency();
    }
}

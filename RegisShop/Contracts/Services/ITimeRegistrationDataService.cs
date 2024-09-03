﻿using BethanysPieShopHRM.Shared.Domain;

namespace RegisShop.Contracts.Services
{
        public interface ITimeRegistrationDataService
        {
            Task<List<TimeRegistration>> GetTimeRegistrationsForEmployee(int employeeId);
            Task<int> GetTimeRegistrationCountForEmployeeId(int employeeId);
            Task<List<TimeRegistration>> GetPagedTimeRegistrationsForEmployee(int employeeId, int pageSize, int start);

    }
}

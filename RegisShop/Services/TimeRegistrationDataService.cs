using BethanysPieShopHRM.Shared.Domain;
using RegisShop.Contracts.Repositories;
using RegisShop.Contracts.Services;


namespace RegisShop.Services
{
    public class TimeRegistrationDataService: ITimeRegistrationDataService
    {
            private readonly ITimeRegistrationRepository _timeRegistrationRepository;

            public TimeRegistrationDataService(ITimeRegistrationRepository timeRegistrationRepository)
            {
                _timeRegistrationRepository = timeRegistrationRepository;
            }

            public async Task<List<TimeRegistration>> GetTimeRegistrationsForEmployee(int employeeId)
            {
                return await _timeRegistrationRepository.GetTimeRegistrationsForEmployee(employeeId);
            }

            public async Task<List<TimeRegistration>> GetPagedTimeRegistrationsForEmployee(int employeeId, int pageSize, int start)
            {
                return await _timeRegistrationRepository.GetPagedTimeRegistrationsForEmployee(employeeId, pageSize, start);
            }

            public async Task<int> GetTimeRegistrationCountForEmployeeId(int employeeId)
            {
                return await _timeRegistrationRepository.GetTimeRegistrationCountForEmployeeId(employeeId);
            }


    }
}

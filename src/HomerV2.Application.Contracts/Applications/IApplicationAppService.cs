using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Homer.Applications.Dtos;
using HomerV2.Enums;
using Volo.Abp.Application.Services;

namespace HomerV2.Applications
{
    public interface IApplicationAppService : IApplicationService
    {
        Task<List<ApplicationDto>> GetListAsync();
        Task<ApplicationDto> GetAsync(Guid id);
        Task CreateAsync(ApplicationDto input);
        Task DeleteAsync(Guid id);
        Task ChangeNameAsync(Guid id, ChangeApplicationNameDto input);
        Task ChangeLogoAsync(Guid id, ChangeApplicationLogoDto input);
        Task<List<ChangeApplicationLogoDecodedDto>> GetApplicationsWithDecodedLogosAsync(MenuTypes menuType);
        Task ChangeUrlAsync(Guid id, ChangeApplicationUrlDto input);
        Task ChangeTargetAsync(Guid id, ChangeApplicationTargetDto input);
        Task UpdateMenuTypesAsync(Guid id, UpdateApplicationMenuTypesDto input);
        Task<List<ApplicationDto>> GetListByMenuTypeAsync(MenuTypes menuType);
    }
}
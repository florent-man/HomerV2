using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homer.Applications.Dtos;
using HomerV2.Enums;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HomerV2.Applications
{
    public class ApplicationAppService : ApplicationService, IApplicationAppService
    {
        private readonly IRepository<Application, Guid> _applicationRepository;

        public ApplicationAppService(IRepository<Application, Guid> applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }

        public async Task<List<ApplicationDto>> GetListAsync()
        {
            var applications = await _applicationRepository.GetListAsync();
            return ObjectMapper.Map<List<Application>, List<ApplicationDto>>(applications);
        }

        public async Task<ApplicationDto> GetAsync(Guid id)
        {
            var application = await _applicationRepository.GetAsync(id);
            return ObjectMapper.Map<Application, ApplicationDto>(application);
        }

        public async Task CreateAsync(ApplicationDto input)
        {
            var application = new Application(
                Guid.NewGuid(),
                input.Name,
                input.Logo,
                input.Url,
                input.Target,
                input.MenuTypes
            );

            await _applicationRepository.InsertAsync(application);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _applicationRepository.DeleteAsync(id);
        }

        public async Task ChangeNameAsync(Guid id, ChangeApplicationNameDto input)
        {
            var application = await _applicationRepository.GetAsync(id);
            application.ChangeName(input.Name);
            await _applicationRepository.UpdateAsync(application);
        }

        public async Task ChangeLogoAsync(Guid id, ChangeApplicationLogoDto input)
        {
            var application = await _applicationRepository.GetAsync(id);
            
            if (input.Logo != null && input.Logo.Length > 0)
            {
                application.ChangeLogoFromFile(input.Logo);
                await _applicationRepository.UpdateAsync(application);
            }
            else
            {
                throw new ArgumentException("Le logo fourni est invalide.");
            }
        }
        
        public async Task<List<ChangeApplicationLogoDecodedDto>> GetApplicationsWithDecodedLogosAsync(MenuTypes menuType)
        {
            var applications = await _applicationRepository.GetListAsync(app => app.MenuTypes == menuType);

            foreach (var application in applications)
            {
                application.GetLogoAsByteArray()
            }
            // Mapper les entités vers des DTOs avec le décodage du logo
            return applications.Select(app => new ChangeApplicationLogoDecodedDto
            {
                DecodedLogo = $"data:image/png;base64,{app.Logo}", 
            }).ToList();
        }


        public async Task ChangeUrlAsync(Guid id, ChangeApplicationUrlDto input)
        {
            var application = await _applicationRepository.GetAsync(id);
            application.ChangeUrl(input.Url);
            await _applicationRepository.UpdateAsync(application);
        }

        public async Task ChangeTargetAsync(Guid id, ChangeApplicationTargetDto input)
        {
            var application = await _applicationRepository.GetAsync(id);
            application.ChangeTarget(input.Target);
            await _applicationRepository.UpdateAsync(application);
        }

        public async Task UpdateMenuTypesAsync(Guid id, UpdateApplicationMenuTypesDto input)
        {
            var application = await _applicationRepository.GetAsync(id);
            application.UpdateMenuTypes(input.MenuTypes);
            await _applicationRepository.UpdateAsync(application);
        }

        public async Task<List<ApplicationDto>> GetListByMenuTypeAsync(MenuTypes menuType)
        {
            var applications = await _applicationRepository.GetListAsync(app => app.MenuTypes == menuType);

            // Mapper les entités vers des DTOs
            return ObjectMapper.Map<List<Application>, List<ApplicationDto>>(applications);
        }
    }
}

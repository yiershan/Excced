using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Exceed.Roles.Dto;
using Exceed.Users.Dto;

namespace Exceed.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}

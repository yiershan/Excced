﻿using Abp.Application.Services.Dto;

namespace Exceed.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}


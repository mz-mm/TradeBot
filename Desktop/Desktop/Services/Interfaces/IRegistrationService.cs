﻿using Desktop.Models;
using Desktop.Responses;
using Desktop.Services.Network.Responses;

namespace Desktop.Services.Interfaces;

public interface IRegistrationService
{
    public Task<DataResponse<RegistrationResponse>> RegistrationAsync(User user)
;

}

﻿using ClaramontanaOnlineShop.Data.Entities;
using System;
using System.Threading.Tasks;

namespace ClaramontanaOnlineShop.Service.RefreshTokenService
{
    public interface IRefreshTokenService
    {
        Task CreateAsync(RefreshTokenDto refreshTokenDto);
        Task<RefreshToken> GetByTokenAsync(string token);
        Task DeleteAsync(Guid tokenId);
        Task DeleteAllAsync(Guid userId);
    }
}
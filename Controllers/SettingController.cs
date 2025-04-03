using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebLab.Data;
using WebLab.DTO;
using WebLab.Interfaces;
using WebLab.Models;
using WebLab.Services;

namespace WebLab.Controllers;

public class SettingController(ApplicationDbContext context, ISettingService settingService) : BaseController
{
    public readonly ApplicationDbContext _context = context;
    private readonly ISettingService _settingsService = settingService;

    [HttpPost("new")]
    public async Task<ActionResult<UserSetting>> SaveSetting(UserSettingDTO userSettingDto)
    {
        var user = await context.Users.FirstOrDefaultAsync(user => user.Id == userSettingDto.UserID);
        if (user == null)
        {
            return NotFound("User was not found");
        }

        var userSetting = new UserSetting()
        {
            ProgressiveVisualizationExperiment = userSettingDto.ProgressiveVisualizationExperiment,
            ProgressiveVisualizationExperimentTest = userSettingDto.ProgressiveVisualizationExperimentTest,
            AutoStartNextExperiment = userSettingDto.AutoStartNextExperiment,
            Created = DateTime.UtcNow,
            User = user,
        };

        context.UserSettings.Add(userSetting);
        await context.SaveChangesAsync();
        return userSetting;
    }

    [HttpGet]
    public async Task<ActionResult<UserSettingDTO>> GetLastSetting(int userId)
    {
        var user = await context.Users.FindAsync(userId);
        if (user == null)
        {
            return NotFound("User was not found");
        }

        var latestUserSetting = await context.UserSettings
            .Where(setting => setting.User.Equals(user))
            .OrderByDescending(setting => setting.Created)
            .FirstOrDefaultAsync();
        
        if (latestUserSetting == null)
        {
            var defaultUserSettingDto = settingService.CreateDefaultSetting(user);
            return defaultUserSettingDto;
        }

        var userSettingDto = new UserSettingDTO()
        {
            ProgressiveVisualizationExperiment = latestUserSetting.ProgressiveVisualizationExperiment,
            ProgressiveVisualizationExperimentTest = latestUserSetting.ProgressiveVisualizationExperimentTest,
            AutoStartNextExperiment = latestUserSetting.AutoStartNextExperiment,
            UserID = user.Id,
            Id = latestUserSetting.Id,
            
        };
        return userSettingDto;
    }


    [HttpPost("navigation/new")]
    public async Task<ActionResult<NavigationSelection> >SaveNavigationSetting(NavigationSelection navigationSelection)
    {
        var result = await context.NavigationSelections.AddAsync(navigationSelection);
        await context.SaveChangesAsync();
        return result.Entity;

    }
    
    [HttpGet("navigation/find")]
    public async Task<ActionResult<NavigationSelection>> GetNavigationSetting(int userId)
    {
        var result = await context.NavigationSelections.Where(setting => setting.UserId == userId).FirstOrDefaultAsync();
        return result;

    }
    
    
    [HttpPost("mental-model/shop/user-navigation/new")]
    public async Task<ActionResult<MentalModelNavigationConfig> >SaveUserShopNavigationConfig(MentalModelNavigationConfig navigationConfig)
    {
        var result = await context.MentalModelNavigationConfigs.AddAsync(navigationConfig);
        await context.SaveChangesAsync();
        return result.Entity;

    }

    [HttpGet("mental-model/shop/user-navigation/find")]
    public async Task<ActionResult<MentalModelNavigationConfig>> GetUserShopNavigationConfig(int userId)
    {
        var result = await context.MentalModelNavigationConfigs.Where(config => config.UserId == userId).FirstOrDefaultAsync();
        if (result != null)
        {
            return result;
        }
        return NotFound("User was not found");

    }
    
}
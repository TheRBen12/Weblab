using WebLab.DTO;
using WebLab.Models;

namespace WebLab.Interfaces;

public interface ISettingService
{
    UserSettingDTO CreateDefaultSetting(User user);
}
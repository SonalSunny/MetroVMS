using MetroVMS.Entity;
using MetroVMS.Entity.ProjectConfiguration.ViewModel;

namespace MetroVMS.Services.Interface
{
    public interface IProjectConfigurationRepository
    {
        ResponseEntity<List<ConfigurationViewModel>> GetAllConfigs();
        ResponseEntity<ConfigurationViewModel> GetConfiqbyId(long ConfigId);
        Task<ResponseEntity<ConfigurationViewModel>> EditConfiq(ConfigurationViewModel model);
    }
}

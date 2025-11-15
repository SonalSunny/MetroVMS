using MetroVMS.Entity.Localization.ViewModel;
using MetroVMS.Entity;

namespace MetroVMS.Localization.Services
{
    public interface ILocalizationService
    {
        ResponseEntity<bool> SyncLanguageResources();
        LanguageResourceModel GetStringResource(string resourceKey, string culture);
        ResponseEntity<List<LocalizationResourceModel>> GetLanguageResources(string module);
        ResponseEntity<bool> UpdateLocalizationResource(List<LocalizationResourceModel> localizationResourceModels);
        ResponseEntity<string> ExportLocalizationDatatoExcel(string search);
    }
}

using MetroVMS.Entity.Localization.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace MetroVMS.Entities.Localization.ViewModel
{
    public class TranslationFormViewModel
    {
        [BindProperty]
        public string Culture { get; set; }
        public string CultureName { get; set; }

        [BindProperty]
        public string ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public List<LocalizationResourceModel> LocalizationResources { get; set; }
    }
}

using MetroVMS.Entity.MenuManagement.DTO;

namespace MetroVMS.Services.ApplicationMenu.CoreModuleMenus
{
    public static class ConfiguarationMenus
    {
        public static List<AppMenu> GetConfiguarationMenu()
        {
            return new List<AppMenu>()
            {
                new AppMenu()
                {
                    MenuId = MenuMasterStructs.Configuaration,
                    ParentMenuId = null,
                    MenuIcon = "sidebar-item-icon fa fa-th-large",
                    MenuTitle = "Setup & Configuration",
                    MenuDescription = "Configuaration",
                    Path = "#",
                    PageCode = "Configuaration",
                    DisplayOrder = 1,
                    GroupBy="Settings",
                    MenuClaims= new List<MenuClaim>() {
                        new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

                    }
                },
                new AppMenu()
                {
                    MenuId = MenuMasterStructs.Translation,
                    ParentMenuId = MenuMasterStructs.Configuaration,
                    MenuIcon = "sidebar-item-icon fa fa-th-large",
                    MenuTitle = "Transalation",
                    MenuDescription = "Translation",
                    Path = "Configurations/Localization",
                    PageCode = "Translation",
                    DisplayOrder = 1,
                    MenuClaims= new List<MenuClaim>() {
                    new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription },
                        new MenuClaim() { ClaimType = ClaimStructs.AddCode, ClaimName = ClaimStructs.AddDescription },
                        new MenuClaim() { ClaimType = ClaimStructs.EditCode, ClaimName = ClaimStructs.EditDescription },
                        new MenuClaim() { ClaimType = ClaimStructs.DeleteCode, ClaimName = ClaimStructs.DeleteDescription }
                    }
                },

                new AppMenu()
                {
                    MenuId = MenuMasterStructs.ProjectConfiguration,
                    ParentMenuId = MenuMasterStructs.Configuaration,
                    MenuIcon = "sidebar-item-icon fa fa-th-large",
                    MenuTitle = "Project Configuration",
                    MenuDescription = "ProjectConfiguration",
                    Path = "ProjectConfiguration/Index",
                    PageCode = "Configuaration_ProjectConfiguration",
                    DisplayOrder = 1,
                    MenuClaims= new List<MenuClaim>() {
                    new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription },
                        new MenuClaim() { ClaimType = ClaimStructs.AddCode, ClaimName = ClaimStructs.AddDescription },
                        new MenuClaim() { ClaimType = ClaimStructs.EditCode, ClaimName = ClaimStructs.EditDescription },
                        new MenuClaim() { ClaimType = ClaimStructs.DeleteCode, ClaimName = ClaimStructs.DeleteDescription }
                    }
                },
                new AppMenu()
                {
                    MenuId = MenuMasterStructs.ModulesAccess,
                    ParentMenuId = MenuMasterStructs.Configuaration,
                    MenuIcon = "sidebar-item-icon fa fa-th-large",
                    MenuTitle = "User Roles - Modules Access",
                    MenuDescription = "ModulesAccess",
                    Path = "Role/RoleModuleAccess",
                    PageCode = "Configuaration_ModulesAccess",
                    DisplayOrder = 1,
                    MenuClaims= new List<MenuClaim>() {
                    new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription },
                        new MenuClaim() { ClaimType = ClaimStructs.AddCode, ClaimName = ClaimStructs.AddDescription },
                        new MenuClaim() { ClaimType = ClaimStructs.EditCode, ClaimName = ClaimStructs.EditDescription },
                        new MenuClaim() { ClaimType = ClaimStructs.DeleteCode, ClaimName = ClaimStructs.DeleteDescription }
                    }
                }
            };
        }
    }
}

using MetroVMS.Entity.MenuManagement.DTO;

namespace MetroVMS.Services.ApplicationMenu.CoreModuleMenus
{
    public static class ReportAndAnalysisMenus
    {
        public static List<AppMenu> GetReportAndAnalysisMenu()
        {
            return new List<AppMenu>()
            {
                new AppMenu()
                {
                    MenuId = MenuMasterStructs.ReportAndAnalysis,
                    ParentMenuId = null,
                    MenuIcon = "sidebar-item-icon fa fa-cogs",
                    MenuTitle = "Report and Analysis",
                    MenuDescription = "Report and Analysis",
                    Path = "#",
                    PageCode = "Report and Analysis",
                    DisplayOrder = 1,
                    GroupBy="Settings",
                    MenuClaims= new List<MenuClaim>() {
                        new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

                    }
                }, new AppMenu()
                {
                    MenuId = MenuMasterStructs.UserLoginLog,
                    ParentMenuId = MenuMasterStructs.ReportAndAnalysis,
                    MenuIcon = "sidebar-item-icon fa fa-cogs",
                    MenuTitle = "User Login Log",
                    MenuDescription = "User Login Log",
                    Path = "UserLoginLog/Index",
                    PageCode = "User Login Log",
                    DisplayOrder = 1,
                    GroupBy="Settings",
                    MenuClaims= new List<MenuClaim>() {
                        new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

                    }
                },
            };
        }
    }
}


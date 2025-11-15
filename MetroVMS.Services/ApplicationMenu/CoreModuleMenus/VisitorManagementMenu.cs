using MetroVMS.Entity.MenuManagement.DTO;

namespace MetroVMS.Services.ApplicationMenu.CoreModuleMenus
{
    public static class VisitorManagementMenu
    {
        public static List<AppMenu> GetVisitorManagementMenu()
        {
            return new List<AppMenu>()
            {
                new AppMenu()
                {
                    MenuId = MenuMasterStructs.VisitorManagement,
                    ParentMenuId = null,
                    MenuIcon = "fa fa-users",
                    MenuTitle = "Visitor Management",
                    MenuDescription = "Visitor Management",
                    Path = "",
                    PageCode = "Visitor Management",
                    DisplayOrder = 1,
                    GroupBy="Settings",
                    MenuClaims= new List<MenuClaim>() {
                        new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

                    }
                },  new AppMenu()
                {
                    MenuId = MenuMasterStructs.VisitorRegister,
                    ParentMenuId = MenuMasterStructs.VisitorManagement,
                    MenuIcon = "",
                    MenuTitle = "Visitor Register",
                    MenuDescription = "Visitor Register" ,
                    Path = "VisitorIn/Manage",
                    PageCode = "",
                    DisplayOrder = 1,
                    GroupBy="Settings",
                    MenuClaims= new List<MenuClaim>() {
                        new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

                    }
                },
                new AppMenu()
                {
                    MenuId = MenuMasterStructs.VisitorLog,
                    ParentMenuId = MenuMasterStructs.VisitorManagement,
                    MenuIcon = "sidebar-item-icon fa fa-cogs",
                    MenuTitle = "Visitor Log",
                    MenuDescription = "Visitor Log",
                    Path = "VisitorIn/Index",
                    PageCode = "",
                    DisplayOrder = 1,
                    GroupBy="Settings",
                    MenuClaims= new List<MenuClaim>() {
                        new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

                    }
                }
                  




            };
        }
    }
}

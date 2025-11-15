using MetroVMS.Entity.MenuManagement.DTO;

namespace MetroVMS.Services.ApplicationMenu.CoreModuleMenus
{
    public static class HomeMenu
    {
        public static List<AppMenu> GetHomeMenu()
        {
            return new List<AppMenu>()
            {
                new AppMenu()
                {
                    MenuId = MenuMasterStructs.Home,
                    ParentMenuId = null,
                    MenuIcon = "sidebar-item-icon fa fa-home",
                    MenuTitle = "Home",
                    MenuDescription = "Home",
                    Path = "Blank",
                    PageCode = "Home",
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

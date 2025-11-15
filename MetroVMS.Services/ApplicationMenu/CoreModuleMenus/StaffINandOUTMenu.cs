using MetroVMS.Entity.MenuManagement.DTO;

namespace MetroVMS.Services.ApplicationMenu.CoreModuleMenus
{
    public static class StaffINandOUTMenu
    {
        public static List<AppMenu> GetStaffINandOUTMenu()
        {
            return new List<AppMenu>()
            {
                new AppMenu()
                {
                    MenuId = MenuMasterStructs.StaffINandOut,
                    ParentMenuId = null,
                    MenuIcon = "fa fa-sign-in",
                    MenuTitle = "Staff IN & Out",
                    MenuDescription = "StaffINandOut",
                    Path = "",
                    PageCode = "StaffINandOut",
                    DisplayOrder = 1,
                    GroupBy="Settings",
                    MenuClaims= new List<MenuClaim>() {
                        new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

                    }
                },  new AppMenu()
                {
                    MenuId = MenuMasterStructs.MyMovements,
                    ParentMenuId = MenuMasterStructs.StaffINandOut,
                    MenuIcon = "",
                    MenuTitle = "My Movements",
                    MenuDescription = "My Movements" ,
                    Path = "MyMovements/Index",
                    PageCode = "",
                    DisplayOrder = 1,
                    GroupBy="Settings",
                    MenuClaims= new List<MenuClaim>() {
                        new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

                    }
                },  new AppMenu()
                {
                    MenuId = MenuMasterStructs.AllStaffMovements,
                    ParentMenuId = MenuMasterStructs.StaffINandOut,
                    MenuIcon = "",
                    MenuTitle = "All Staff Movement",
                    MenuDescription = "All Staff Movement" ,
                    Path = "AllStaffMovement/Index",
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

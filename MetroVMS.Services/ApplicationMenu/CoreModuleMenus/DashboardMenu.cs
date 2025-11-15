using MetroVMS.Entity.MenuManagement.DTO;

namespace MetroVMS.Services.ApplicationMenu.CoreModuleMenus
{
    public static class DashboardMenu
    {
        public static List<AppMenu> GetDashBoardMenu()
        {
            return new List<AppMenu>()
            {
                new AppMenu()
                {
                    MenuId = MenuMasterStructs.Dashboard,
                    ParentMenuId = null,
                    MenuIcon = "fa fa-dashboard",
                    MenuTitle = "Dashboard",
                    MenuDescription = "Dashboard",
                    Path = "",
                    PageCode = "Dashboard",
                    DisplayOrder = 1,
                    GroupBy="Settings",
                    MenuClaims= new List<MenuClaim>() {
                        new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

                    }
                },  new AppMenu()
                {
                    MenuId = MenuMasterStructs.AllAppointments,
                    ParentMenuId = MenuMasterStructs.Dashboard,
                    MenuIcon = "",
                    MenuTitle = "All Appointments",
                    MenuDescription = "All Appointments" ,
                    Path = "",
                    PageCode = "",
                    DisplayOrder = 1,
                    GroupBy="Settings",
                    MenuClaims= new List<MenuClaim>() {
                        new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

                    }
                },
                new AppMenu()
                {
                    MenuId = MenuMasterStructs.AllMeetings,
                    ParentMenuId = MenuMasterStructs.Dashboard,
                    MenuIcon = "sidebar-item-icon fa fa-cogs",
                    MenuTitle = "All Meetings",
                    MenuDescription = "All Meetings",
                    Path = "",
                    PageCode = "",
                    DisplayOrder = 1,
                    GroupBy="Settings",
                    MenuClaims= new List<MenuClaim>() {
                        new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

                    }
                },
                    new AppMenu()
                {
                    MenuId = MenuMasterStructs.AllStaffMovement,
                    ParentMenuId = MenuMasterStructs.Dashboard,
                    MenuIcon = "sidebar-item-icon fa fa-cogs",
                    MenuTitle = "All Staff Movement",
                    MenuDescription = "All Staff Movement",
                    Path = "",
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

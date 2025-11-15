using MetroVMS.Entity.MenuManagement.DTO;

namespace MetroVMS.Services.ApplicationMenu.CoreModuleMenus
{
    public static class ReportMenu
    {
        public static List<AppMenu> GetReportMenu()
        {
            return new List<AppMenu>()
            {
                new AppMenu()
                {
                    MenuId = MenuMasterStructs.Reports,
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
                    MenuId = MenuMasterStructs.VisitorReports,
                    ParentMenuId = MenuMasterStructs.Reports,
                    MenuIcon = "sidebar-item-icon fa fa-cogs",
                    MenuTitle = "Visitor Reports",
                    MenuDescription = "Visitor Reports",
                    Path = "",
                    PageCode = "Visitor Reports",
                    DisplayOrder = 1,
                    GroupBy="Settings",
                    MenuClaims= new List<MenuClaim>() {
                        new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

                    }
                },

                new AppMenu()
                {
                    MenuId = MenuMasterStructs.VisitReport,
                    ParentMenuId = MenuMasterStructs.Reports,
                    MenuIcon = "sidebar-item-icon fa fa-cogs",
                    MenuTitle = "Visit Report",
                    MenuDescription = "Visit Report",
                    Path = "",
                    PageCode = "Visit Report",
                    DisplayOrder = 1,
                    GroupBy="Settings",
                    MenuClaims= new List<MenuClaim>() {
                        new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

                    }
                },
                new AppMenu()
                {
                    MenuId = MenuMasterStructs.StaffMovementsReport,
                    ParentMenuId = MenuMasterStructs.Reports,
                    MenuIcon = "sidebar-item-icon fa fa-cogs",
                    MenuTitle = "Staff Movements Report",
                    MenuDescription = "Staff Movements Report",
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
                    MenuId = MenuMasterStructs.MeetingRoomBookingReport,
                    ParentMenuId = MenuMasterStructs.Reports,
                    MenuIcon = "sidebar-item-icon fa fa-cogs",
                    MenuTitle = "Meeting Room Booking Report",
                    MenuDescription = "Meeting Room Booking Report",
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
                    MenuId = MenuMasterStructs.AppointmentsReport,
                    ParentMenuId = MenuMasterStructs.Reports,
                    MenuIcon = "sidebar-item-icon fa fa-cogs",
                    MenuTitle = "Appointments Report",
                    MenuDescription = "Appointments Report",
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


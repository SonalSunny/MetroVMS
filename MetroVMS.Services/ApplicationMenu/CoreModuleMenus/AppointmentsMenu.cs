using MetroVMS.Entity.MenuManagement.DTO;

namespace MetroVMS.Services.ApplicationMenu.CoreModuleMenus
{
    public static class AppointmentsMenu
    {
        public static List<AppMenu> GetAppointmentsMenu()
        {
            return new List<AppMenu>()
            {
                new AppMenu()
                {
                    MenuId = MenuMasterStructs.Appointments,
                    ParentMenuId = null,
                    MenuIcon = "fa fa-calendar",
                    MenuTitle = "Appointments",
                    MenuDescription = "Appointments",
                    Path = "",
                    PageCode = "Appointments",
                    DisplayOrder = 1,
                    GroupBy="Settings",
                    MenuClaims= new List<MenuClaim>() {
                        new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

                    }
                },  new AppMenu()
                {
                    MenuId = MenuMasterStructs.NewAppointmentRequest,
                    ParentMenuId = MenuMasterStructs.Appointments,
                    MenuIcon = "",
                    MenuTitle = "New Appointment Request",
                    MenuDescription = "New Appointment Request" ,
                    Path = "NewAppointmentRequest/Index",
                    PageCode = "",
                    DisplayOrder = 1,
                    GroupBy="Settings",
                    MenuClaims= new List<MenuClaim>() {
                        new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

                    }
                },
                new AppMenu()
                {
                    MenuId = MenuMasterStructs.ApproveRequest,
                    ParentMenuId = MenuMasterStructs.Appointments,
                    MenuIcon = "sidebar-item-icon fa fa-cogs",
                    MenuTitle = "Approve Request",
                    MenuDescription = "Approve Request",
                    Path = "ApproveRequest/Index",
                    PageCode = "",
                    DisplayOrder = 1,
                    GroupBy="Settings",
                    MenuClaims= new List<MenuClaim>() {
                        new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

                    }
                }
                //,
                //    new AppMenu()
                //{
                //    MenuId = MenuMasterStructs.MyAppointments,
                //    ParentMenuId = MenuMasterStructs.Appointments,
                //    MenuIcon = "sidebar-item-icon fa fa-cogs",
                //    MenuTitle = "My Appointments",
                //    MenuDescription = "My Appointments",
                //    Path = "",
                //    PageCode = "",
                //    DisplayOrder = 1,
                //    GroupBy="Settings",
                //    MenuClaims= new List<MenuClaim>() {
                //        new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

                //    }
                //}




            };
        }
    }
}

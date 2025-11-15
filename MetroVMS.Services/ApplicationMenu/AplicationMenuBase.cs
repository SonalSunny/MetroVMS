using MetroVMS.Services.ApplicationMenu.CoreModuleMenus;
using MetroVMS.Entity.MenuManagement.DTO;
using MetroVMS.Services.ApplicationMenu.CoreModuleMenus;

namespace MetroVMS.Services.ApplicationMenu
{
    public static class AplicationMenuBase
    {

        public static List<MenuRole> GetApplicationMenus()
        {
            var objBaseList = new List<MenuRole>();
            objBaseList.Add(new MenuRole() { RoleCode = "MetroVMS", DisplayOrder = 1, MenuTitle = "ERP", MenuIcon = "<i class=\"fas fa-user-cog\"></i>", MenuGroups = GetMetroVMSMenus() });
            return objBaseList;
        }
        public static List<MenuGroup> GetMetroVMSMenus()
        {
            var objBaseList = new List<MenuGroup>();

            var objMMenu1 = new MenuGroup();
            objMMenu1.DisplayOrder = 1;
            objMMenu1.GroupTitle = "";
            objMMenu1.Menus = new List<AppMenu>();
            objMMenu1.Menus.AddRange(HomeMenu.GetHomeMenu());
            objMMenu1.Menus.AddRange(DashboardMenu.GetDashBoardMenu());
            objMMenu1.Menus.AddRange(VisitorManagementMenu.GetVisitorManagementMenu());
            objMMenu1.Menus.AddRange(AppointmentsMenu.GetAppointmentsMenu());
            objMMenu1.Menus.AddRange(MeetingRoomMenu.GetMeetingRoomMenu());
            objMMenu1.Menus.AddRange(StaffINandOUTMenu.GetStaffINandOUTMenu());

            objMMenu1.Menus.AddRange(MasterMenus.GetMasterMenu());
            objMMenu1.Menus.AddRange(ReportMenu.GetReportMenu());


            //objMMenu1.Menus.Add(new AppMenu()
            //{
            //    MenuId = MenuMasterStructs.ConfigurationABC,
            //    ParentMenuId = null,
            //    MenuIcon = "sidebar-item-icon fa fa-wrench",
            //    MenuTitle = "Configurations",
            //    MenuDescription = "Configurations",
            //    Path = "Configurations",
            //    PageCode = "Configurations",
            //    DisplayOrder = 1,
            //    GroupBy = "Settings",
            //    MenuClaims = new List<MenuClaim>() {
            //            new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

            //        }
            //});


            //objMMenu1.Menus.AddRange(EmployeeMenuMaster.GetEmployeeMenu());
            //objMMenu1.Menus.AddRange(UserMenuMaster.GetUserMenu());
            //objMMenu1.Menus.AddRange(CoreConfigurationMenuMaster.GetConfigurationMenu());

            //objMMenu1.Menus.AddRange(CoreAuditMenuMaster.GetAuditMenu());

            //objMMenu1.Menus.Add(new AppMenu()
            //{
            //    MenuId = MenuMasterStructs.ConfigurationABC,
            //    ParentMenuId = null,
            //    MenuIcon = "sidebar-item-icon fa fa-th-large",
            //    MenuTitle = "Configurations",
            //    MenuDescription = "Configurations",
            //    Path = "CoreModule/Configurations",
            //    PageCode = "COREMENU_CONFIGURATIONS",
            //    DisplayOrder = 1,
            //    GroupBy = "Settings",
            //    MenuClaims = new List<MenuClaim>() {
            //            new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

            //        }
            //});
            /* Commented for Demo purpose because there is not Show different categories for Menus */

            /*  var objMMenu2 = new MenuGroup();
              objMMenu2.DisplayOrder = 2;
              objMMenu2.GroupTitle = "Settings";
              objMMenu2.Menus = new List<AppMenu>();*/
            // objMMenu2.Menus.AddRange(CoreUserAccountsMenuMaster.GetUserAccountsMenu());
            //  objMMenu2.Menus.AddRange(SampleMenuMaster.GetSampleMenus());


            objBaseList.Add(objMMenu1);
            // objBaseList.Add(objMMenu2);
            return objBaseList;

        }
    }
}

using MetroVMS.Entity.MenuManagement.DTO;

namespace MetroVMS.Services.ApplicationMenu.CoreModuleMenus
{
    public static class MasterMenus
    {
        public static List<AppMenu> GetMasterMenu()
        {
            return new List<AppMenu>()
            {
                new AppMenu()
                {
                    MenuId = MenuMasterStructs.DataEntryMaster,
                    ParentMenuId = null,
                    MenuIcon = "sidebar-item-icon fa fa-database",
                    MenuTitle = "Master Data Entry",
                    MenuDescription = "DataEntryMaster",
                    Path = "#",
                    PageCode = "DataEntryMaster",
                    DisplayOrder = 1,
                    GroupBy="Settings",
                    MenuClaims= new List<MenuClaim>() {
                        new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

                    }
                },
                new AppMenu()
                {
                    MenuId = MenuMasterStructs.UserMaster,
                    ParentMenuId = MenuMasterStructs.DataEntryMaster,
                    MenuIcon = "sidebar-item-icon fa fa-th-large",
                    MenuTitle = "User Master",
                    MenuDescription = "UserMaster",
                    Path = "User/Index",
                    PageCode = "DataEntryMaster_UserMaster",
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
                    MenuId = MenuMasterStructs.UserRolesMaster,
                    ParentMenuId = MenuMasterStructs.DataEntryMaster,
                    MenuIcon = "sidebar-item-icon fa fa-th-large",
                    MenuTitle = "Roles",
                    MenuDescription = "UserRolesMaster",
                    Path = "Role/Index",
                    PageCode = "DataEntryMaster_UserRolesMaster",
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
                    MenuId = MenuMasterStructs.DepartmentMaster,
                    ParentMenuId = MenuMasterStructs.DataEntryMaster,
                    MenuIcon = "sidebar-item-icon fa fa-th-large",
                    MenuTitle = "DepartmentMaster",
                    MenuDescription = "DepartmentMaster",
                    Path = "Role/Index",
                    PageCode = "",
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
                    MenuId = MenuMasterStructs.Staff,
                    ParentMenuId = MenuMasterStructs.DataEntryMaster,
                    MenuIcon = "sidebar-item-icon fa fa-th-large",
                    MenuTitle = "Staff Master",
                    MenuDescription = "Staff Master",
                    Path = "",
                    PageCode = "",
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
                    MenuId = MenuMasterStructs.MeetingRoomMaster,
                    ParentMenuId = MenuMasterStructs.DataEntryMaster,
                    MenuIcon = "sidebar-item-icon fa fa-th-large",
                    MenuTitle = "Meeting Room Master",
                    MenuDescription = "MeetingRoomMaster",
                    Path = "",
                    PageCode = "",
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
                    MenuId = MenuMasterStructs.PurposeofVisit,
                    ParentMenuId = MenuMasterStructs.DataEntryMaster,
                    MenuIcon = "sidebar-item-icon fa fa-th-large",
                    MenuTitle = "Purpose of Visit",
                    MenuDescription = "Purpose of Visit",
                    Path = "",
                    PageCode = "",
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

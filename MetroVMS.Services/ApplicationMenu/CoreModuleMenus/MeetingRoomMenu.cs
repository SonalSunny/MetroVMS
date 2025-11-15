using MetroVMS.Entity.MenuManagement.DTO;

namespace MetroVMS.Services.ApplicationMenu.CoreModuleMenus
{
    public static class MeetingRoomMenu
    {
        public static List<AppMenu> GetMeetingRoomMenu()
        {
            return new List<AppMenu>()
            {
                new AppMenu()
                {
                    MenuId = MenuMasterStructs.MeetingRoom,
                    ParentMenuId = null,
                    MenuIcon = "fa fa-door-open",
                    MenuTitle = "Meeting Room",
                    MenuDescription = "Meeting Room",
                    Path = "",
                    PageCode = "",
                    DisplayOrder = 1,
                    GroupBy="Settings",
                    MenuClaims= new List<MenuClaim>() {
                        new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

                    }
                },  new AppMenu()
                {
                    MenuId = MenuMasterStructs.BookMeetingRoom,
                    ParentMenuId = MenuMasterStructs.MeetingRoom,
                    MenuIcon = "",
                    MenuTitle = "Book Meeting Room",
                    MenuDescription = "Book Meeting Room" ,
                    Path = "BookMeetingRoom/Index",
                    PageCode = "",
                    DisplayOrder = 1,
                    GroupBy="Settings",
                    MenuClaims= new List<MenuClaim>() {
                        new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

                    }
                },
                new AppMenu()
                {
                    MenuId = MenuMasterStructs.MyMeetings,
                    ParentMenuId = MenuMasterStructs.MeetingRoom,
                    MenuIcon = "sidebar-item-icon fa fa-cogs",
                    MenuTitle = "My Meetings",
                    MenuDescription = "My Meetings",
                    Path = "MyMeetings/Index",
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

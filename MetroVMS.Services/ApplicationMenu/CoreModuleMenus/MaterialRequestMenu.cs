using MetroVMS.Entity.MenuManagement.DTO;

namespace MetroVMS.Services.ApplicationMenu.CoreModuleMenus
{
    public static class MaterialRequestMenu
    {
        public static List<AppMenu> GetMaterialRequestMenu()
        {
            return new List<AppMenu>()
            {
                new AppMenu()   
                {
                    MenuId = MenuMasterStructs.MaterialRequest,
                    ParentMenuId = null,
                    MenuIcon = "fa fa-users",
                    MenuTitle = "Material Request",
                    MenuDescription = "Material Request",
                    Path = "",
                    PageCode = "MaterialRequest",
                    DisplayOrder = 1,
                    GroupBy = "Settings",
                    MenuClaims = new List<MenuClaim>() {
                        new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

                    }
                },
                new AppMenu()
                {
                    MenuId = MenuMasterStructs.NewRequest,
                    ParentMenuId = MenuMasterStructs.MaterialRequest,
                    MenuIcon = "",
                    MenuTitle = "New Request",
                    MenuDescription = "New Request",
                    Path = "",
                    PageCode = "",
                    DisplayOrder = 1,
                    GroupBy = "Settings",
                    MenuClaims = new List<MenuClaim>() {
                        new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

                    }
                },
                new AppMenu()
                {
                    MenuId = MenuMasterStructs.BranchApproval,
                    ParentMenuId = MenuMasterStructs.MaterialRequest,
                    MenuIcon = "sidebar-item-icon fa fa-cogs",
                    MenuTitle = "Branch Approval",
                    MenuDescription = "Branch Approval",
                    Path = "",
                    PageCode = "",
                    DisplayOrder = 1,
                    GroupBy = "Settings",
                    MenuClaims = new List<MenuClaim>() {
                        new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

                    }
                },
                new AppMenu()
                {
                    MenuId = MenuMasterStructs.HOApproval,
                    ParentMenuId = MenuMasterStructs.MaterialRequest,
                    MenuIcon = "sidebar-item-icon fa fa-cogs",
                    MenuTitle = "HO Approval",
                    MenuDescription = "HO Approval",
                    Path = "",
                    PageCode = "",
                    DisplayOrder = 1,
                    GroupBy = "Settings",
                    MenuClaims = new List<MenuClaim>() {
                        new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

                    }
                },
                new AppMenu()
                {
                    MenuId = MenuMasterStructs.Store,
                    ParentMenuId = MenuMasterStructs.MaterialRequest,
                    MenuIcon = "sidebar-item-icon fa fa-cogs",
                    MenuTitle = "Store",
                    MenuDescription = "Store",
                    Path = "",
                    PageCode = "",
                    DisplayOrder = 1,
                    GroupBy = "Settings",
                    MenuClaims = new List<MenuClaim>() {
                        new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

                    }
                },
                new AppMenu()
                {
                    MenuId = MenuMasterStructs.UnderPurchase,
                    ParentMenuId = MenuMasterStructs.MaterialRequest,
                    MenuIcon = "sidebar-item-icon fa fa-cogs",
                    MenuTitle = "Under Purchase",
                    MenuDescription = "Under Purchase",
                    Path = "",
                    PageCode = "",
                    DisplayOrder = 1,
                    GroupBy = "Settings",
                    MenuClaims = new List<MenuClaim>() {
                        new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

                    }
                },
                new AppMenu()
                {
                    MenuId = MenuMasterStructs.Store,
                    ParentMenuId = MenuMasterStructs.FullyDelivered,
                    MenuIcon = "sidebar-item-icon fa fa-cogs",
                    MenuTitle = "Fully Delivered",
                    MenuDescription = "Fully Delivered",
                    Path = "",
                    PageCode = "",
                    DisplayOrder = 1,
                    GroupBy = "Settings",
                    MenuClaims = new List<MenuClaim>() {
                        new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }
                    }
                }
            };
        }
    }
}

using MetroVMS.Entity.MenuManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroVMS.Services.ApplicationMenu.CoreModuleMenus
{
    internal class PurchaseMenu
    {
        public static List<AppMenu> GetPurchaseMenu()
        {
            return new List<AppMenu>()
            {
                new AppMenu()
                {
                    MenuId = MenuMasterStructs.Purchase,
                    ParentMenuId = null,
                    MenuIcon = "fa fa-users",
                    MenuTitle = "Purchase",
                    MenuDescription = "Purchase",
                    Path = "",
                    PageCode = "Purchase",
                    DisplayOrder = 1,
                    GroupBy = "Settings",
                    MenuClaims = new List<MenuClaim>() {
                        new MenuClaim() { ClaimType = ClaimStructs.ViewCode, ClaimName = ClaimStructs.ViewDescription }

                    }
                },
                new AppMenu()
                {
                    MenuId = MenuMasterStructs.NewRequest_Purchase,
                    ParentMenuId = MenuMasterStructs.Purchase,
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
                    MenuId = MenuMasterStructs.HOApproval_Purchase,
                    ParentMenuId = MenuMasterStructs.Purchase,
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
                    MenuId = MenuMasterStructs.PurchaseDepartment,
                    ParentMenuId = MenuMasterStructs.Purchase,
                    MenuIcon = "sidebar-item-icon fa fa-cogs",
                    MenuTitle = "Purchase Department",
                    MenuDescription = "Purchase Department",
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
                    MenuId = MenuMasterStructs.Delivery,
                    ParentMenuId = MenuMasterStructs.Purchase,
                    MenuIcon = "sidebar-item-icon fa fa-cogs",
                    MenuTitle = "Delivery",
                    MenuDescription = "Delivery",
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

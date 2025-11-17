using MetroVMS.Entity;
using Microsoft.AspNetCore.Mvc;
using MetroVMS.Entity.Common;
using MetroVMS.Entity.ItemRequestMasterData.ViewModel;
using MetroVMS.Localization;
using MetroVMS.Models.PageModels;
using MetroVMS.Services.Interface;
using X.PagedList;

namespace MetroVMS.Pages.MaterialRequest
{
    public class IndexModel : PagedListBasePageModel
    {
        public IPagedList<ItemRequestViewModel> pagedListData { get; private set; }
        #region FilterDeclaration

        [BindProperty]
        public string DepartmentNo { get; set; }
        [BindProperty]
        public string DepartmentName { get; set; }
        [BindProperty]
        public long? Description { get; set; }
        [BindProperty]
        public long? CreatedEmployee { get; set; }
        [BindProperty]
        public long? Statusid { get; set; }
        public List<DropDownViewModel> DepartmentRefNoList { get; set; }
        public List<DropDownViewModel> DepartmentNameList { get; set; }

        private readonly IDropDownRepository _dropDownRepository;
        private readonly ISharedLocalizer _sharedLocalizer;
        private readonly IItemRequestRepository _itemReqRepo;

        #endregion
        public IndexModel(IDropDownRepository dropDownRepository, ISharedLocalizer sharedLocalizer, IItemRequestRepository itemReqRepo)
        {
            _dropDownRepository = dropDownRepository;
            _sharedLocalizer = sharedLocalizer;
            _itemReqRepo = itemReqRepo;
        }

        public void OnGet(string isGoBack)
        {
            setPagedListColumns();
            BindDropdowns();
            if (isGoBack?.ToLower() != "y")
            {
                TempData["PRO_FILTER_DEP_REF_NO"] = "";
                TempData["PRO_FILTER_DEP_NAME"] = "";
                TempData["PRO_FILTER_STATUS"] = null;
            }
            sortColumn = "DepartmentName";
        }

        public IActionResult OnGetPagedList(int? pn, int? ps, string so, string sc, string gs, string gsc,string nm, string showProject)
        {
            setPagedListColumns();
            pageNo = pn;
            pageSize = ps;
            sortOrder = so;
            sortColumn = sc;
            globalSearch = gs;
            searchField = gsc;
            var DepartmentNo = TempData.Peek("PRO_FILTER_DEP_REF_NO");
            var DepartmentName = TempData.Peek("PRO_FILTER_DEP_NAME");
            var Status = TempData.Peek("PRO_FILTER_STATUS");


            Statusid = GenericUtilities.Convert<long?>(Status);
            if (Statusid == null)
            {
                Statusid = 1;
            }

            var RefNumberId = !string.IsNullOrEmpty(DepartmentNo?.ToString()) ? Convert.ToInt64(DepartmentNo) : 0;
            var DepNameId = !string.IsNullOrEmpty(DepartmentName?.ToString()) ? Convert.ToInt64(DepartmentName) : 0;


            var objResponce = _itemReqRepo.GetAllItemRequests(Statusid, RefNumberId, DepNameId);
            if (objResponce.transactionStatus == System.Net.HttpStatusCode.OK)
            {

                pagedListData = PagedList(objResponce.returnData);
            }

            return new PartialViewResult
            {
                ViewName = "_IndexPartial",
                ViewData = ViewData
            };
        }

        //public JsonResult OnPostDeleteDepartment(int? keyid, int? Id)
        //{
        //    var retData = new ResponseEntity<bool>();
        //    var objModel = new DepartmentViewModel();
        //    objModel.DepartmentId = Convert.ToInt32(keyid);
        //    objModel.DiffId = Convert.ToInt32(Id);
        //    retData = _itemReqRepo.DeleteDepartment(objModel);
        //    return new JsonResult(retData);
        //}

        public JsonResult OnPostApplyFilter()
        {
            // Store filter values in TempData
            TempData["PRO_FILTER_STATUS"] = Statusid.ToString();
            TempData["PRO_FILTER_DEP_REF_NO"] = DepartmentNo;
            TempData["PRO_FILTER_DEP_NAME"] = DepartmentName;
            return new JsonResult(true);
        }

        public void setPagedListColumns()
        {
            pageListFilterColumns = new List<PageListFilterColumns>();
            var objList = new List<PageListFilterColumns>();
            objList.Add(new PageListFilterColumns { ColumName = "All", ColumnDescription = _sharedLocalizer.Localize("DD_ALL_TABLE_SEARCH").Value });
            objList.Add(new PageListFilterColumns { ColumName = "RequestNo", ColumnDescription = _sharedLocalizer.Localize("Department Ref No").Value });
            pageListFilterColumns = objList;
        }

        private void BindDropdowns()
        {
            //DepartmentRefNoList = _dropDownRepository.GetDepartmentRefNoList();
            //DepartmentNameList = _dropDownRepository.GetDepartmentNameList();
        }

        //public IActionResult OnPostExportData()
        //{
        //    var DepartmentNo = TempData.Peek("PRO_FILTER_DEP_REF_NO");
        //    var DepartmentName = TempData.Peek("PRO_FILTER_DEP_NAME");
        //    var Status = TempData.Peek("PRO_FILTER_STATUS");


        //    Statusid = GenericUtilities.Convert<long?>(Status);
        //    if (Statusid == null)
        //    {
        //        Statusid = 1;
        //    }

        //    var RefNumberId = !string.IsNullOrEmpty(DepartmentNo?.ToString()) ? Convert.ToInt64(DepartmentNo) : 0;
        //    var DepNameId = !string.IsNullOrEmpty(DepartmentName?.ToString()) ? Convert.ToInt64(DepartmentName) : 0;

        //    var empData = _itemReqRepo.ExportUserDatatoExcel("", RefNumberId, DepNameId, Statusid);
        //    var tempFileName = empData.returnData;
        //    return new JsonResult(new { tFileName = tempFileName, fileName = "DepartmentMaster.xlsx" });
        //}
    }
}


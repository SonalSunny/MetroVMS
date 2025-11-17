using MetroVMS.Entity;
using MetroVMS.Entity.DepartmentMaster.ViewModel;
using MetroVMS.Entity.ItemRequestMasterData.ViewModel;
using MetroVMS.Models.PageModels;
using MetroVMS.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MetroVMS.Pages.MaterialRequest
{
    public class ManageModel : BasePageModel
    {
        [BindProperty]
        public ItemRequestViewModel inputModel { get; set; }

        private readonly IItemRequestRepository _itemReqRepo;
        public ManageModel(IItemRequestRepository itemReqRepo)
        {
            _itemReqRepo = itemReqRepo;
        }

        public void OnGet(long? id, string mode)
        {
            _formMode = mode;
            isValidRequest = true;
            inputModel = new ItemRequestViewModel();
            if (id > 0)
            {
                var retData = _itemReqRepo.GetItemRequestById(Convert.ToInt64(id));
                if (retData.transactionStatus == HttpStatusCode.OK)
                {
                    isValidRequest = true;
                    inputModel = retData.returnData;
                }
                else
                {
                    isValidRequest = false;
                    pageErrorMessage = retData.returnMessage;
                }
            }
        }
        public async Task<IActionResult> OnPost()
        {
            var DepartmentName = "";// inputModel.DepartmentName;
            if (DepartmentName == null)
            {
                pageErrorMessage = "Fill all the required fields";
            }
            else
            {
                var retData = new ResponseEntity<DepartmentViewModel>();
                if (btnSubmit == "btnSave" /*&& ModelState.IsValid*/)
                {
                    if (formMode.Equals(FormModeEnum.add))
                    {
                        retData = await _itemReqRepo.CreateItemRequest(inputModel);
                        if (retData.transactionStatus != HttpStatusCode.OK)
                        {
                            pageErrorMessage = retData.returnMessage;

                            IsSuccessReturn = false;
                        }
                        else
                        {
                            ModelState.Clear();
                            IsSuccessReturn = true;
                            sucessMessage = retData.returnMessage;
                            inputModel = new ItemRequestViewModel();
                            return Page();
                        }
                    }
                    else
                    {
                        //retData = await _itemReqRepo.UpdateDepartment(inputModel);
                        //if (retData.transactionStatus != HttpStatusCode.OK)
                        //{
                        //    pageErrorMessage = retData.returnMessage;
                        //    IsSuccessReturn = false;
                        //}
                        //else
                        //{
                        //    ModelState.Clear();
                        //    IsSuccessReturn = true;
                        //    sucessMessage = retData.returnMessage;
                        //}
                    }
                }
                else
                {
                    if (btnSubmit == "btnSave")
                    {
                        retData.transactionStatus = HttpStatusCode.BadRequest;
                        pageErrorMessage = "Use 8 or more characters with a mix of letters,numbers,symbols.";
                        IsSuccessReturn = false;
                    }
                    else
                    {
                        ModelState.Clear();
                    }
                }
            }
            return Page();
        }
    }
}
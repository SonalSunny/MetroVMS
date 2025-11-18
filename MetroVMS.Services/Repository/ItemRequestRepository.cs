using MetroVMS.DataAccess;
using MetroVMS.Entity;
using MetroVMS.Entity.ItemRequestMasterData.DTO;
using MetroVMS.Entity.ItemRequestMasterData.ViewModel;
using MetroVMS.Services.Interface;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace MetroVMS.Services.Repository
{
    public class ItemRequestRepository : IItemRequestRepository
    {
        private readonly MetroVMSDBContext _dbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;
        ClaimsPrincipal claimsPrincipal = null;
        long? loggedInUser = null;



        public ItemRequestRepository(MetroVMSDBContext metroVMSDBContext, IHttpContextAccessor httpContextAccessor)
        {
            this._dbContext = metroVMSDBContext;
            _httpContextAccessor = httpContextAccessor;

            try
            {
                claimsPrincipal = _httpContextAccessor?.HttpContext?.User;
                var isAuthenticated = claimsPrincipal?.Identity?.IsAuthenticated ?? false;
                if (isAuthenticated)
                {
                    var userIdentity = claimsPrincipal?.Identity?.Name;
                    if (userIdentity != null)
                    {
                        long userid = 0;
                        Int64.TryParse(userIdentity, out userid);
                        if (userid > 0)
                        {
                            loggedInUser = userid;
                        }
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        public async Task<ResponseEntity<ItemRequestViewModel>> CreateItemRequest(ItemRequestViewModel model)
        {

            var Returndata = new ResponseEntity<ItemRequestViewModel>();
            try
            {
                var Existingata = _dbContext.ItemRequestMasters.Any(i => i.RequestId == model.RequestId);

                if (!model.RequestDate.HasValue || !model.DeliveryDate.HasValue)
                {
                    Returndata.transactionStatus = System.Net.HttpStatusCode.InternalServerError;
                    Returndata.returnMessage = "Please Enter The Required Fields";
                    return Returndata;
                }
                else if(model.RequestDate > model.DeliveryDate)
                {
                    Returndata.transactionStatus = System.Net.HttpStatusCode.InternalServerError;
                    Returndata.returnMessage = "Delivery Date Must be Greater Then Request Date";
                    return Returndata;
                }
                else
                {
                    var Request = new ItemRequestMaster
                    {
                        RequestDate = model.RequestDate,
                        RequestNo = GenerateItemRequestId(),
                        RequestedBy = loggedInUser,
                        DeliveryDate = model.DeliveryDate,
                        DepartmentId = model.DepartmentId,
                        Active = true,
                        CreatedBy = loggedInUser,//loginned user employee is
                        CreatedDate = DateTime.Now,
                    };
                    await _dbContext.ItemRequestMasters.AddAsync(Request);
                    await _dbContext.SaveChangesAsync();
                    Returndata.transactionStatus = System.Net.HttpStatusCode.OK;
                    Returndata.returnMessage = "Request Added Successfully";
                }
            }
            catch (Exception)
            {
                Returndata.transactionStatus = System.Net.HttpStatusCode.InternalServerError;
                Returndata.returnMessage = "Server Error";
            }
            return Returndata;
        }

        public string GenerateItemRequestId()
        {
            var lastRequestNo = _dbContext.ItemRequestMasters.OrderByDescending(i => i.DepartmentId).FirstOrDefault();
            if (lastRequestNo != null)
            {
                var lastNumber = lastRequestNo != null ? int.Parse(lastRequestNo.RequestNo.Substring(3)) : 0;
                lastNumber++;
                return $"ITM{lastNumber:000}";
            }
            else
            {
                return $"ITM001";
            }
        }


        //public async Task<ResponseEntity<DepartmentViewModel>> UpdateDepartment(DepartmentViewModel model)
        //{
        //    var Returndata = new ResponseEntity<DepartmentViewModel>();
        //    try
        //    {
        //        var Existingata = _dbContext.Departments.Any(i => i.DepartmentId != model.DepartmentId && i.Active && i.DepartmentName.Trim().ToLower() == model.DepartmentName.Trim().ToLower());
        //        if (Existingata)
        //        {
        //            Returndata.transactionStatus = System.Net.HttpStatusCode.InternalServerError;
        //            Returndata.returnMessage = "Department Already Exist";
        //        }

        //        var DepartmentData = _dbContext.Departments.FirstOrDefault(i => i.DepartmentId == model.DepartmentId && i.Active);

        //        if (DepartmentData != null)
        //        {

        //            DepartmentData.DepartmentName = model.DepartmentName;
        //            DepartmentData.Description = model.Description;
        //            DepartmentData.UpdatedBy = model.loggedinUserId;
        //            DepartmentData.UpdatedDate = DateTime.Now;
        //            await _dbContext.SaveChangesAsync();
        //            Returndata.transactionStatus = System.Net.HttpStatusCode.OK;
        //            Returndata.returnMessage = "Department Updated Successfully";
        //        }
        //        else
        //        {
        //            Returndata.transactionStatus = System.Net.HttpStatusCode.BadRequest;
        //            Returndata.returnMessage = "Invalid User";
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        Returndata.transactionStatus = System.Net.HttpStatusCode.InternalServerError;
        //        Returndata.returnMessage = "Server Error";
        //    }
        //    return Returndata;
        //}


        //public ResponseEntity<bool> DeleteDepartment(DepartmentViewModel model)
        //{
        //    var retModel = new ResponseEntity<bool>();
        //    try
        //    {
        //        var existingData = _dbContext.Departments.FirstOrDefault(i => i.DepartmentId == model.DepartmentId);
        //        if (existingData != null)
        //        {
        //            existingData.Active = false;
        //            _dbContext.Entry(existingData).State = EntityState.Modified;
        //            _dbContext.SaveChanges();
        //            retModel.returnMessage = "Deactivated";
        //            retModel.transactionStatus = System.Net.HttpStatusCode.OK;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        retModel.transactionStatus = System.Net.HttpStatusCode.InternalServerError;
        //    }
        //    return retModel;
        //}


        public ResponseEntity<ItemRequestViewModel> GetItemRequestById(long ReqId)
        {
            var retModel = new ResponseEntity<ItemRequestViewModel>();
            try
            {
                var objData = _dbContext.ItemRequestMasters.SingleOrDefault(u => u.RequestId == ReqId);
                var objModel = new ItemRequestViewModel();
                objModel.RequestId = objData.RequestId;
                objModel.RequestNo = objData.RequestNo;
                objModel.RequestedBy = objData.RequestedBy;
                objModel.RequestDate = objData.RequestDate;
                objModel.DeliveryDate = objData.DeliveryDate;
                objModel.DepartmentId = objData.DepartmentId;
                objModel.Active = objData.Active;
                retModel.transactionStatus = System.Net.HttpStatusCode.OK;
                retModel.returnData = objModel;

            }
            catch (Exception)
            {
                retModel.transactionStatus = System.Net.HttpStatusCode.InternalServerError;
            }
            return retModel;
        }


        public ResponseEntity<List<ItemRequestViewModel>> GetAllItemRequests(long? Status, long RefNumberId, long DepNameId)
        {
            var retModel = new ResponseEntity<List<ItemRequestViewModel>>();
            try
            {
                var objModel = new List<ItemRequestViewModel>();

                // Base query: Active users
                var retData = _dbContext.ItemRequestMasters.Where(c => c.Active == true);

                // Filter by Status
                if (Status.HasValue)
                {
                    if (Status == 2)
                    {
                        // Include both Active = true and Active = false
                        retData = retData.Where(c => c.Active == true || c.Active == false);
                    }
                    else if (Status == 1)
                    {
                        // Status = 1 maps to Active = true
                        retData = retData.Where(c => c.Active == true);
                    }
                    else if (Status == 0)
                    {
                        // Status = 0 maps to Active = false
                        retData = retData.Where(c => c.Active == false);
                    }
                }

                if (RefNumberId > 0)
                    retData = retData.Where(c => c.DepartmentId == RefNumberId);

                if (DepNameId > 0)
                    retData = retData.Where(c => c.DepartmentId == DepNameId);

                // Map to ViewModel
                objModel = retData.Select(c => new ItemRequestViewModel()
                {
                    DepartmentId = c.DepartmentId,
                    RequestId = c.RequestId,
                    RequestNo = c.RequestNo,
                    RequestDate = c.RequestDate,
                    DeliveryDate = c.DeliveryDate,
                    RequestedBy = c.RequestedBy,
                    RequestedByString = c.RequestedBy != null ? _dbContext.Users.FirstOrDefault(e => e.UserId == c.RequestedBy).UserName : "N/A",
                    IsBranchApproved = c.IsBranchApproved,
                    IsHeadOfficeApproved = c.IsHeadOfficeApproved,
                    Active = c.Active,
                    CreatedDate = c.CreatedDate,
                    CreatedBy = c.CreatedBy,
                    CreatedUsername = _dbContext.Users.FirstOrDefault(e => e.UserId == c.CreatedBy).UserName
                }).ToList();

                objModel = objModel.OrderByDescending(i => i.RequestId).ToList();
                // Set response
                retModel.transactionStatus = System.Net.HttpStatusCode.OK;
                retModel.returnData = objModel;
            }
            catch (Exception ex)
            {
                retModel.transactionStatus = System.Net.HttpStatusCode.InternalServerError;
                retModel.returnMessage = ex.Message; // Include error message for debugging
            }

            return retModel;
        }


        //public ResponseEntity<string> ExportUserDatatoExcel(string search, long DepRefId, long DepNameId, long? Status)
        //{
        //    var retModel = new ResponseEntity<string>();
        //    try
        //    {
        //        var objData = GetAllDepartment(Status, DepRefId, DepNameId);

        //        if (objData.transactionStatus == HttpStatusCode.OK)
        //        {
        //            using (var workbook = new XLWorkbook())
        //            {
        //                // Set header row
        //                var worksheet = workbook.Worksheets.Add("Department Master");
        //                worksheet.Cell(1, 1).Value = "Sl No";
        //                worksheet.Cell(1, 2).Value = "Department Ref Name";
        //                worksheet.Cell(1, 3).Value = "Department Name";
        //                worksheet.Cell(1, 4).Value = "Description";
        //                worksheet.Cell(1, 5).Value = "Createdby";
        //                worksheet.Cell(1, 6).Value = "Created Date";
        //                worksheet.Cell(1, 7).Value = "Status";
        //                // ... Add more headers if needed

        //                // Format header row
        //                var headerRow = worksheet.Row(1);
        //                headerRow.Style.Font.Bold = true;
        //                headerRow.Style.Fill.BackgroundColor = XLColor.LightGray;
        //                // ... Apply additional formatting as needed

        //                for (int i = 0; i < objData.returnData.Count; i++)
        //                {
        //                    worksheet.Cell(i + 2, 1).Value = i + 1; // Serial Number
        //                    worksheet.Cell(i + 2, 2).Value = objData.returnData[i].DepartmentRefNo;
        //                    worksheet.Cell(i + 2, 3).Value = objData.returnData[i].DepartmentName;
        //                    worksheet.Cell(i + 2, 4).Value = objData.returnData[i].Description;
        //                    worksheet.Cell(i + 2, 5).Value = objData.returnData[i].CreatedUsername;
        //                    worksheet.Cell(i + 2, 6).Value = objData.returnData[i].CreatedDate;
        //                    if (objData.returnData[i].Active)
        //                    {
        //                        worksheet.Cell(i + 2, 7).Value = "Active";
        //                    }
        //                    else
        //                    {
        //                        worksheet.Cell(i + 2, 8).Value = "InActive";
        //                    }



        //                    // ... Add more data cells if needed
        //                }

        //                using (var stream = new MemoryStream())
        //                {
        //                    workbook.SaveAs(stream);
        //                    stream.Position = 0;
        //                    byte[] fileBytes = stream.ToArray();
        //                    retModel.returnData = GenericUtilities.SetReportData(fileBytes, ".xlsx");
        //                    retModel.transactionStatus = HttpStatusCode.OK;
        //                }

        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        retModel.transactionStatus = HttpStatusCode.InternalServerError;
        //    }
        //    return retModel;
        //}
    }
}

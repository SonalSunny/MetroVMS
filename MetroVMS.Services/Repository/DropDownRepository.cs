using MetroVMS.DataAccess;
using MetroVMS.Entity.Common;
using MetroVMS.Services.Interface;

namespace MetroVMS.Services.Repository
{
    public class DropDownRepository : IDropDownRepository
    {
        private readonly MetroVMSDBContext? _dbContext;
        public DropDownRepository(MetroVMSDBContext context)
        {
            _dbContext = context;
        }
        //public List<DropDownViewModel> GetDesignations()
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.Designations.Where(c => c.Active == true);
        //        objModel = retData.Select(c => new DropDownViewModel()
        //        {
        //            keyID = c.DesignationId,
        //            name = c.DesignationName,
        //            description = c.Description
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}
        //public List<DropDownViewModel> GetDepartments()
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.Departments.Where(c => c.Active == true);
        //        objModel = retData.Select(c => new DropDownViewModel()
        //        {
        //            keyID = c.DepartmentId,
        //            name = c.DepartmentName,
        //            description = c.Description
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}
        //public List<DropDownViewModel> GetEmployee()
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.Employees.Where(c => c.Active == true);
        //        objModel = retData.Select(c => new DropDownViewModel()
        //        {
        //            keyID = c.EmployeeId,
        //            name = c.EmployeeName
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}
        public List<DropDownViewModel> GetRole()
        {
            var retModel = new List<DropDownViewModel>();
            try
            {
                var objModel = new List<DropDownViewModel>();
                var retData = _dbContext.Roles.Where(c => c.Active == true);
                objModel = retData.Select(static c => new DropDownViewModel()
                {
                    keyID = (long)c.RoleId,
                    name = c.RoleName
                }).ToList();
                retModel = objModel;
            }
            catch (Exception ex)
            {

            }
            return retModel;
        }
        //public List<DropDownViewModel> GetDepartmentRefNoList()
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.Departments.Where(c => c.Active == true);
        //        objModel = retData.Select(static c => new DropDownViewModel()
        //        {
        //            keyID = (long)c.DepartmentId,
        //            name = c.DepartmentRefNo
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}
        //public List<DropDownViewModel> GetDepartmentNameList()
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.Departments.Where(c => c.Active == true);
        //        objModel = retData.Select(static c => new DropDownViewModel()
        //        {
        //            keyID = (long)c.DepartmentId,
        //            name = c.DepartmentName
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}
        //public List<DropDownViewModel> GetDesignationRefNoList()
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.Designations.Where(c => c.Active == true);
        //        objModel = retData.Select(static c => new DropDownViewModel()
        //        {
        //            keyID = (long)c.DesignationId,
        //            name = c.DesignationRefNumber
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}
        //public List<DropDownViewModel> GetDesignationNameList()
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.Designations.Where(c => c.Active == true);
        //        objModel = retData.Select(static c => new DropDownViewModel()
        //        {
        //            keyID = (long)c.DesignationId,
        //            name = c.DesignationName
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}
        //public List<DropDownViewModel> GetLookupTypeList()
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.lookUpTypeMasters.Where(c => c.Active == true);
        //        objModel = retData.Select(static c => new DropDownViewModel()
        //        {
        //            keyID = (long)c.LookUpTypeId,
        //            name = c.LookUpTypeName
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}
        //public List<DropDownViewModel> GetPayrollData()
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.PayrollAdjustments.Where(c => c.Active == true);
        //        objModel = retData.Select(c => new DropDownViewModel()
        //        {
        //            keyID = c.PayrollId,
        //            name = c.AdjustmentName
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}
        //public List<DropDownViewModel> GetLookupMasterList()
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.LookupMasters
        //        .Join(_dbContext.lookUpTypeMasters,
        //              l => l.LookUpTypeId,
        //              ly => ly.LookUpTypeId,
        //              (l, ly) => new { l, ly })
        //        .Where(x => x.ly.LookUpTypeId == 2)
        //        .Select(x => x.l)
        //        .ToList();
        //        objModel = retData.Select(static c => new DropDownViewModel()
        //        {
        //            keyID = (long)c.LookUpId,
        //            name = c.LookUpName
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}

        //public List<DropDownViewModel> GetClient()
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.Clients.Where(c => c.Active == true);
        //        objModel = retData.Select(static c => new DropDownViewModel()
        //        {
        //            keyID = (long)c.ClientId,
        //            name = c.ClientName
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}
        //public List<DropDownViewModel> GetTaskCategoryList()
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.TaskCategories.Where(c => c.Active == true);
        //        objModel = retData.Select(static c => new DropDownViewModel()
        //        {
        //            keyID = (long)c.TaskCategoryId,
        //            name = c.TaskCategoryName
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}
        //public List<DropDownViewModel> GetTaskTypeList()
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.TaskTypes.Where(c => c.Active == true);
        //        objModel = retData.Select(static c => new DropDownViewModel()
        //        {
        //            keyID = (long)c.TaskTypeId,
        //            name = c.TaskTypeName
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}
        //public List<DropDownViewModel> GetTeamList()
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.Teams.Where(c => c.Active == true);
        //        objModel = retData.Select(static c => new DropDownViewModel()
        //        {
        //            keyID = (long)c.TeamId,
        //            name = c.TeamName
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}
        //public List<DropDownViewModel> GetProjectList()
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.Projects.Where(c => c.Active == true);
        //        objModel = retData.Select(static c => new DropDownViewModel()
        //        {
        //            keyID = (long)c.ProjectId,
        //            name = c.ProjectName
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}
        //public List<DropDownViewModel> GetUsersList()
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.Users.Where(c => c.Active == true);
        //        objModel = retData.Select(static c => new DropDownViewModel()
        //        {
        //            keyID = (long)c.UserId,
        //            name = c.UserName
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}
        //public List<DropDownViewModel> GetEnvironmentRefNoList()
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.ProjEnvironment.Where(c => c.Active == true);
        //        objModel = retData.Select(static c => new DropDownViewModel()
        //        {
        //            keyID = (long)c.Id,
        //            name = c.EnvironmentRefNo
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}
        //public List<DropDownViewModel> GetEnvironmentNameList()
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.ProjEnvironment.Where(c => c.Active == true);
        //        objModel = retData.Select(static c => new DropDownViewModel()
        //        {
        //            keyID = (long)c.Id,
        //            name = c.EnvironmentName
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}
        //public List<DropDownViewModel> GetProjectListforClient(long? ClientId)
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.Projects.Where(c => c.Active == true && c.ClientId == ClientId);
        //        objModel = retData.Select(static c => new DropDownViewModel()
        //        {
        //            keyID = (long)c.ProjectId,
        //            name = c.ProjectName
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}

        //public List<DropDownViewModel> GetTaskDurationList()
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.TaskDurations.Where(c => c.Active == true);
        //        objModel = retData.Select(static c => new DropDownViewModel()
        //        {
        //            keyID = (long)c.TaskDurationId,
        //            name = c.TaskDurationText
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}

        //public List<DropDownViewModel> GetTaskTypeListByDepId(long? EmployeeId)
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var DepId = _dbContext.Employees.FirstOrDefault(i => i.EmployeeId == EmployeeId)?.DepartmentId;
        //        if (DepId != null)
        //        {
        //            var objModel = new List<DropDownViewModel>();
        //            var retData = _dbContext.TaskTypes.Where(c => c.Active == true && c.DepartmentId == DepId);
        //            objModel = retData.Select(static c => new DropDownViewModel()
        //            {
        //                keyID = (long)c.TaskTypeId,
        //                name = c.TaskTypeName
        //            }).ToList();
        //            retModel = objModel;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}

        //public List<DropDownViewModel> GetRequirementList()
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.Requirements.Where(c => c.Active == true);
        //        objModel = retData.Select(static c => new DropDownViewModel()
        //        {
        //            keyID = (long)c.RequirementId,
        //            name = c.RequirementName
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}

        //public List<DropDownViewModel> GetProjectsByClient(long Id)
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.Projects.Where(c => c.Active == true && c.ClientId == Id);
        //        objModel = retData.Select(static c => new DropDownViewModel()
        //        {
        //            keyID = (long)c.ProjectId,
        //            name = c.ProjectName
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}
        //public List<DropDownViewModel> GetEnviornmentByProject(long Id)
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.ProjEnvironment.Where(c => c.Active == true && c.ProjectId == Id);
        //        objModel = retData.Select(static c => new DropDownViewModel()
        //        {
        //            keyID = (long)c.Id,
        //            name = c.EnvironmentName
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}

        //public List<DropDownViewModel> GetClientNameList()
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var retData = _dbContext.Clients.Where(c => c.Active == true);
        //        retModel = retData.Select(c => new DropDownViewModel()
        //        {
        //            keyID = (long)c.ClientId,
        //            name = c.ClientName
        //        }).ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        // Log the error for debugging
        //        Console.WriteLine("Error in GetClientNameList: " + ex.Message);
        //    }
        //    return retModel ?? new List<DropDownViewModel>(); // Ensure a non-null return
        //}

        //public List<DropDownViewModel> GetProjectNameList()
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var retData = _dbContext.Projects.Where(c => c.Active == true);
        //        retModel = retData.Select(c => new DropDownViewModel()
        //        {
        //            keyID = (long)c.ProjectId,
        //            name = c.ProjectName
        //        }).ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        // Log the error for debugging
        //        Console.WriteLine("Error in GetProjectNameList: " + ex.Message);
        //    }
        //    return retModel ?? new List<DropDownViewModel>(); // Ensure a non-null return
        //}
        //public List<DropDownViewModel> GetFolderByMdule(long? Id)
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.FolderMasters.Where(c => c.Active == true && c.ModuleId == Id);
        //        objModel = retData.Select(static c => new DropDownViewModel()
        //        {
        //            keyID = (long)c.FolderId,
        //            name = c.FolderName
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}
        //public List<DropDownViewModel> GetModules()
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.LookupMasters
        //        .Join(_dbContext.lookUpTypeMasters,
        //              l => l.LookUpTypeId,
        //              ly => ly.LookUpTypeId,
        //              (l, ly) => new { l, ly })
        //        .Where(x => x.ly.LookUpTypeId == 7)
        //        .Select(x => x.l)
        //        .ToList();
        //        objModel = retData.Select(static c => new DropDownViewModel()
        //        {
        //            keyID = (long)c.LookUpId,
        //            name = c.LookUpName
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}

        //public List<DropDownViewModel> GetWorkLocations()
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.LookupMasters
        //        .Where(x => x.LookUpTypeMaster.LookUpTypeName == "WorkLocationMaster")
        //        .ToList();
        //        objModel = retData.Select(static c => new DropDownViewModel()
        //        {
        //            keyID = (long)c.LookUpId,
        //            name = c.LookUpName
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}

        //public List<DropDownViewModel> GetSourceOfContactList()
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.LookupMasters
        //        .Where(x => x.LookUpTypeMaster.LookUpTypeName == "SourceOfContacts")
        //        .ToList();
        //        objModel = retData.Select(static c => new DropDownViewModel()
        //        {
        //            keyID = (long)c.LookUpId,
        //            name = c.LookUpName
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}

        //public List<DropDownViewModel> GetSalesLeadStatus()
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.LookupMasters
        //        .Where(x => x.LookUpTypeMaster.LookUpTypeName == "SalesLeadStatus")
        //        .ToList();
        //        objModel = retData.Select(static c => new DropDownViewModel()
        //        {
        //            keyID = (long)c.LookUpId,
        //            name = c.LookUpName
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}

        //public List<DropDownViewModel> GetBussinessTypeList()
        //{
        //    var retModel = new List<DropDownViewModel>();
        //    try
        //    {
        //        var objModel = new List<DropDownViewModel>();
        //        var retData = _dbContext.LookupMasters
        //        .Where(x => x.LookUpTypeMaster.LookUpTypeName == "BussinessTypeList")
        //        .ToList();
        //        objModel = retData.Select(static c => new DropDownViewModel()
        //        {
        //            keyID = (long)c.LookUpId,
        //            name = c.LookUpName
        //        }).ToList();
        //        retModel = objModel;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return retModel;
        //}
    }
}

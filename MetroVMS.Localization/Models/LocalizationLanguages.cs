namespace MetroVMS.Localization.Models
{
    public class LocalizationLanguages
    {
        public List<Language> Languages { get; }
        public LocalizationLanguages()
        {
            Languages = new List<Language>();
            Languages.Add(new Language { Name = "English", Culture = "en-US", Direction = "rtl" });
            Languages.Add(new Language { Name = "Arabic", Culture = "ar-AE", Direction = "ltl" });
        }
    }
    public class ResourceModules
    {
        public List<ResourceModule> Modules { get; }

        public ResourceModules()
        {
            Modules = new List<ResourceModule>();
            Modules.Add(new ResourceModule { ModuleCode = "Menu", ModuleName = "Menu", ResourceFile = "EmployeeResources" });
            Modules.Add(new ResourceModule { ModuleCode = "Configuration", ModuleName = "Configuration", ResourceFile = "ConfigurationResource" });
            Modules.Add(new ResourceModule { ModuleCode = "Welcome", ModuleName = "Welcome", ResourceFile = "WelcomeResource" });
            Modules.Add(new ResourceModule { ModuleCode = "Shared", ModuleName = "Shared", ResourceFile = "SharedResource" });
            Modules.Add(new ResourceModule { ModuleCode = "UserMaster", ModuleName = "User Master", ResourceFile = "UserResource" });
            Modules.Add(new ResourceModule { ModuleCode = "Team", ModuleName = "Team Master", ResourceFile = "TeamsResource" });
            Modules.Add(new ResourceModule { ModuleCode = "RoleMaster", ModuleName = "User Roles Master", ResourceFile = "RoleResource" });
            Modules.Add(new ResourceModule { ModuleCode = "LookUpMaster", ModuleName = "LookUp Master", ResourceFile = "LookupResource" });
            Modules.Add(new ResourceModule { ModuleCode = "ProjectConfiguration", ModuleName = "Project Configuration", ResourceFile = "ProjectConfigurationResources" });
            Modules.Add(new ResourceModule { ModuleCode = "ContractTypeMaster", ModuleName = "Contract Type Master", ResourceFile = "ContractTypeResource" });
            Modules.Add(new ResourceModule { ModuleCode = "PayrollAdjustments", ModuleName = "Payroll Adjustments", ResourceFile = "PayrollAdjustmentResources" });
            Modules.Add(new ResourceModule { ModuleCode = "Client", ModuleName = "Client", ResourceFile = "ClientResources" });
            Modules.Add(new ResourceModule { ModuleCode = "Project", ModuleName = "Project", ResourceFile = "ProjectResources" });
            Modules.Add(new ResourceModule { ModuleCode = "TaskCategoryMaster", ModuleName = "Task Category Master", ResourceFile = "TaskCategoryResource" });
            Modules.Add(new ResourceModule { ModuleCode = "TaskTypeMaster", ModuleName = "Task Type Master", ResourceFile = "TaskTypeResource" });
            Modules.Add(new ResourceModule { ModuleCode = "TaskDurationMaster", ModuleName = "Task Duration Master", ResourceFile = "TaskDurationResource" });
            Modules.Add(new ResourceModule { ModuleCode = "QuizOptions", ModuleName = "Quiz Options", ResourceFile = "QuizResources" });
            Modules.Add(new ResourceModule { ModuleCode = "TaskManagement", ModuleName = "Task Management", ResourceFile = "TaskManagementResoursces" });
            Modules.Add(new ResourceModule { ModuleCode = "CircularMaster", ModuleName = "Circular Master", ResourceFile = "CircularResource" });
            Modules.Add(new ResourceModule { ModuleCode = "Requirment", ModuleName = "Circular Master", ResourceFile = "RequirementResources" });
            Modules.Add(new ResourceModule { ModuleCode = "WorkLocationMaster", ModuleName = "Work Location Master", ResourceFile = "WorkLocationResource" });
            Modules.Add(new ResourceModule { ModuleCode = "FileMaster", ModuleName = "File Master", ResourceFile = "FolderFileResources" });
            Modules.Add(new ResourceModule { ModuleCode = "FolderManager", ModuleName = "Folder Manager", ResourceFile = "FolderFileResources" });
            Modules.Add(new ResourceModule { ModuleCode = "NewsAndEventsMaster", ModuleName = "News And Events Master", ResourceFile = "NewsAndEventsResource" });
            Modules.Add(new ResourceModule { ModuleCode = "LeaveRequest", ModuleName = "Leave Request", ResourceFile = "LeaveRequestResource" });
            Modules.Add(new ResourceModule { ModuleCode = "LeaveRequestApproval", ModuleName = "Leave Request Approval", ResourceFile = "LeaveRequestApprovalResource" });
            Modules.Add(new ResourceModule { ModuleCode = "Library", ModuleName = "Library", ResourceFile = "FolderFileResources" });
            Modules.Add(new ResourceModule { ModuleCode = "TaskStatus", ModuleName = "TaskStatus", ResourceFile = "TaskStatusResource" });
            Modules.Add(new ResourceModule { ModuleCode = "QuizMonthlySummary", ModuleName = "QuizMonthlySummary", ResourceFile = "QuizMonthlySummaryResources" });
        }
    }
}
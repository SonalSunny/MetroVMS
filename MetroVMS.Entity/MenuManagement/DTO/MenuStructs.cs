using System.Diagnostics.Metrics;
using System.Reflection;
using System.Xml.Linq;

namespace MetroVMS.Entity.MenuManagement.DTO
{
    public struct ClaimStructs
    {
        public const string ViewCode = "View";
        public const string ViewDescription = "View";

        public const string AddCode = "Add";
        public const string AddDescription = "Add";

        public const string EditCode = "Edit";
        public const string EditDescription = "Edit";

        public const string DeleteCode = "Delete";
        public const string DeleteDescription = "Delete";
    }
    public struct MenuMasterStructs
    {
        #region EmployeeMaster
        public const int EmployeeManagement = 1;
        public const int EmployeeMaster = 101;
        public const int Department = 102;
        public const int Designation = 103;
        #endregion EmployeeMaster

        public const int ConfigurationABC = 100;

        #region UserManagement
        public const int UserManagement = 2;
        public const int UserMastertest = 201;
        public const int RoleGroup = 202;
        public const int RolePrivillage = 203;
        #endregion UserManagement

        # region TaskManagement
        public const int TaskManagement = 1;
        public const int Tasks = 101;
        public const int Requirements = 102;
        public const int ActivitySheetTask = 103;
        public const int CompletedTasks = 104;
        public const int KnowledgeBase = 105;
        public const int ClosedTask = 106;


        #endregion TaskManagement

        #region AttendanceManagement
        public const int AttendanceManagement = 2;
        public const int DailyAttendance = 201;
        public const int LeaveRequest = 202;
        public const int HolidayCalendar = 203;
        public const int ShiftSchedule = 204;
        public const int LeaveRequestApp = 205;
        public const int AttendanceSheetData = 206;
        #endregion AttendanceManagement

        #region Management
        public const int Management = 3;
        public const int ActivitySheetManagement = 301;
        public const int CheckList = 302;
        public const int FileManager = 303;
        public const int LeaveRequestApproval = 304;
        public const int TaskAnalysis = 305;
        public const int ActivitySheetsManagement = 306;
        public const int CheckListManagement = 307;
        public const int FolderManager = 308;
        #endregion Management

        #region HRManagement
        public const int HRManagement = 4;
        public const int ActivitySheet = 401;
        public const int CheckListHR = 402;
        public const int FileManagerHR = 403;
        public const int AttendanceSheet = 404;
        public const int LeaveRequestApprovalHR = 405;
        public const int KnoweldgeBase = 406;
        public const int PoliciesAndTemplates = 407;
        #endregion HRManagement

        #region ProjectManagement
        public const int ProjectManagement = 5;
        public const int ActivitySheetProject = 501;
        public const int ChecklistProject = 502;
        public const int FileManagerProject = 502;
        public const int KnoweldgeBaseProject = 503;
        public const int ProjectEnvironment = 504;
        public const int ClientLogins = 505;
        public const int StatusConfiguration = 506;
        #endregion ProjectManagement

        #region SalesManagement
        public const int SalesManagement = 6;
        public const int ActivitySheetsSales = 601;
        public const int CheckListSales = 602;
        public const int FileManagerSales = 603;
        public const int Clients = 604;
        public const int Projects = 605;
        public const int KnowledgeBaseSales = 606;
        public const int SalesLead = 607;
        #endregion SalesManagement

        #region DataEntryMaster
        public const int DataEntryMaster = 7;
       
    public const int Employees = 701;
        public const int UserMaster = 702;
        public const int DepartmentMaster = 703;
        public const int MeetingRoomMaster = 720;
        public const int PurposeofVisit = 721;
        public const int Staff = 722;
        public const int DesignationMaster = 704;
        public const int UserRolesMaster = 705;
        public const int LookupMaster = 706;
        public const int Team = 707;
        public const int LookUp = 707;
        public const int ContractTypeMaster = 708;
        public const int QuizOptions = 709;
        public const int PayrollOptions = 710;
        public const int TaskCategoryMaster = 711;
        public const int TaskTypes = 712;
        public const int TaskDurationMaster = 713;
        public const int CircularMaster = 714;
        public const int JobVacancies = 715;
        public const int NewsAndEventsMaster = 716;
        public const int WorkLocationMaster = 717;
        public const int TaskStatus = 718;
        public const int QuizMonthlySummary = 719;

        #endregion DataEntryMaster

        #region Configuaration
        public const int Configuaration = 8;
        public const int ProjectConfiguration = 801;
        public const int ModulesAccess = 802;
        public const int Translation = 803;
        public const int ImportData = 804;
        public const int ExportData = 805;
        #endregion Configuaration

        #region Configuration
        public const int Configuration = 9;
        public const int ProjectSetting = 901;
        public const int PageCaptionsEdit = 902;
        #endregion Configuration


        #region Company
        public const int Company = 9;
        public const int Circulars = 901;
        public const int Newsandevents = 902;
        public const int Library = 903;
        #endregion Company

        #region ReportAndAnalysis
        public const int ReportAndAnalysis = 10;
        public const int UserLoginLog = 1001;
        // public const int UserActivityLog = 101;

        #endregion ReportAndAnalysis

        #region EmailandSMS
        public const int EmailandSMS = 11;
        public const int AddressBook = 1101;
        public const int Templates = 1102;
        public const int ComposeEmail = 1103;
        public const int SendItems = 1104;
        #endregion EmailandSMS

        #region Home
        public const int Home = 12;
        #endregion Home
        #region DashBoard
        public const int Dashboard = 27;
        public const int AllAppointments = 2701;
        public const int AllMeetings = 2702;
        public const int AllStaffMovement = 2703;
        #endregion

        #region VisitorManagement
        public const int VisitorManagement = 28;
        public const int VisitorRegister = 2801;
        public const int VisitorLog= 2802;
      
        #endregion
        #region Appointments
        public const int Appointments = 29;
        public const int NewAppointmentRequest = 2901;
        public const int  ApproveRequest= 2902;
        public const int  MyAppointments = 2903;
        #endregion

        #region MeetingRoom
        public const int MeetingRoom = 30;
        public const int BookMeetingRoom = 3001;
        public const int MyMeetings = 3002;
      
        #endregion
        #region StaffINandOut
        public const int StaffINandOut = 31;
        public const int MyMovements = 3101;
        public const int AllStaffMovements = 3101;
        #endregion
        #region Reports
        public const int Reports = 32;
        public const int VisitorReports = 3201;
        public const int VisitReport = 3202;
        public const int StaffMovementsReport = 3203;
        public const int MeetingRoomBookingReport = 3204;
        public const int AppointmentsReport = 3205;

        #endregion

    }








}

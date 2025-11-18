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

        public List<DropDownViewModel> GetLookupTypeList()
        {
            var retModel = new List<DropDownViewModel>();
            try
            {
                var objModel = new List<DropDownViewModel>();
                var retData = _dbContext.LookupTypeMasters.Where(c => c.Active == true);
                objModel = retData.Select(static c => new DropDownViewModel()
                {
                    keyID = (long)c.LookUpTypeId,
                    name = c.LookUpTypeName
                }).ToList();
                retModel = objModel;
            }
            catch (Exception ex)
            {

            }
            return retModel;
        }
    }
}

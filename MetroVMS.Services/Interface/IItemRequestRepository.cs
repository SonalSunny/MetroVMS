using MetroVMS.Entity;
using MetroVMS.Entity.DepartmentMaster.ViewModel;
using MetroVMS.Entity.ItemRequestMasterData.ViewModel;

namespace MetroVMS.Services.Interface
{
    public interface IItemRequestRepository
    {
        Task<ResponseEntity<ItemRequestViewModel>> CreateItemRequest(ItemRequestViewModel model);
        ResponseEntity<List<ItemRequestViewModel>> GetAllItemRequests(long? Status, long RefNumberId, long DepNameId);
        ResponseEntity<ItemRequestViewModel> GetItemRequestById(long ReqId);

    }
}

using OnlineShop.BL.Core;
using OnlineShop.BL.Dtos.Suppliers;

namespace OnlineShop.BL.Contract
{
    public interface ISupplierService : IBaseService
    {
        ServiceResult SaveSupplier(SuppliersSaveDto saveDto);
        ServiceResult UpdateSupplier(SuppliersUpdateDto updateDto);
        ServiceResult DeleteSuppliers(SuppliersRemoveDto removeDto);
    }
}

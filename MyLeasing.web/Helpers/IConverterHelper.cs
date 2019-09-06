using System.Threading.Tasks;
using MyLeasing.web.Data.Entities;
using MyLeasing.web.Models;

namespace MyLeasing.web.Helpers
{
    public interface IConverterHelper
    {
        Task<Property> ToPropertyAsync(PropertyViewModel model, bool isNew);
        PropertyViewModel ToPropertyViewModel(Property property);
        Task<Contract> ToContractAsync(ContractVIewModel model, bool isNew);
    }
}
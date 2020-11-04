using swagger_openapi_netcore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace swagger_openapi_netcore.Services
{
    public interface IColorService
    {
        Task<ColorResponseModel> GetColorResponse(int id);
        Task<List<ColorResponseModel>> GetAllColorResponse();
        Task<ColorResponseModel> Create(ColorRequestModel model);
        Task Update(ColorRequestModel model);
        Task Delete(int id);
    }
}

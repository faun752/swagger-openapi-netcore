using swagger_openapi_netcore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace swagger_openapi_netcore.Services.Implementations
{
    public class ColorService : IColorService
    {
        public async Task<ColorResponseModel> GetColorResponse(int id)
        {
            // ダミーデータを返却;
            return await Task.FromResult(
                new ColorResponseModel()
                {
                    ColorID = 1,
                    BackgroundColor = "",
                    BorderColor = "",
                    FontColor = ""
                });
        }

        public async Task<List<ColorResponseModel>> GetAllColorResponse()
        {
            // ダミーデータを返却;
            return await Task.FromResult(new List<ColorResponseModel>()
            {
                new ColorResponseModel()
                {
                    ColorID = 1,
                    BackgroundColor = "",
                    BorderColor = "",
                    FontColor = ""
                },
                new ColorResponseModel()
                {
                    ColorID = 2,
                    BackgroundColor = "",
                    BorderColor = "",
                    FontColor = ""
                }
            });
        }

        public async Task<ColorResponseModel> Create(ColorRequestModel model)
        {
            // 登録処理
            return await Task.FromResult(new ColorResponseModel()
            {
                ColorID = 1,
                BackgroundColor = "",
                BorderColor = "",
                FontColor = ""
            });
        }

        public Task Update(ColorRequestModel model)
        {
            // 更新処理
            return Task.CompletedTask;
        }

        public Task Delete(int id)
        {
            // 削除処理
            return Task.CompletedTask;
        }
    }
}

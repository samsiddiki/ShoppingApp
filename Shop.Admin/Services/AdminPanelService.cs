using DataModels.CustomModels;
using System.Net.Http.Json;

namespace Shop.Admin.Services
{
    public class AdminPanelService : IAdminPanelService
    {
        private readonly HttpClient httpClient;
        public AdminPanelService(HttpClient _httpClient)
        {
            this.httpClient = _httpClient;
        }
        public async Task<ResponseModel> AdminLogin(LoginModel loginModel)
        {
            HttpResponseMessage response = await httpClient.PostAsJsonAsync("api/admin/AdminLogin/", loginModel);

            // Check if the response was successful
            response.EnsureSuccessStatusCode();

            // Read the response content as a ResponseModel
            ResponseModel responseModel = await response.Content.ReadFromJsonAsync<ResponseModel>();

            return responseModel;
        }

        public async Task<CategoryModel> SaveCategory(CategoryModel newCategory)
        {
            HttpResponseMessage res = await httpClient.PostAsJsonAsync("api/admin/SaveCategory/", newCategory);
            res.EnsureSuccessStatusCode();
            CategoryModel? resModel = await res.Content.ReadFromJsonAsync<CategoryModel>();
            return resModel;
        }
        public async Task<List<CategoryModel>> GetCategories()
        {
            HttpResponseMessage res = await httpClient.GetAsync("api/admin/GetCategories/");
            res.EnsureSuccessStatusCode();
            List<CategoryModel>? resModel = await res.Content.ReadFromJsonAsync<List<CategoryModel>>();
            return resModel;
        }
        public async Task<List<ProductModel>> GetProducts()
        {
            HttpResponseMessage res = await httpClient.GetAsync("api/admin/GetProducts/");
            res.EnsureSuccessStatusCode();
            List<ProductModel>? resModel = await res.Content.ReadFromJsonAsync<List<ProductModel>>();
            return resModel;
        }
        public async Task<bool> UpdateCategory(CategoryModel categoryToUpdate)
        {
            HttpResponseMessage response = await httpClient.PutAsJsonAsync("api/admin/UpdateCategory/", categoryToUpdate);
            response.EnsureSuccessStatusCode();

            bool updateResult = await response.Content.ReadFromJsonAsync<bool>();
            return updateResult;
        }

        public async Task<bool> DeleteCategory(CategoryModel categoryToDelete)
        {
            HttpResponseMessage response = await httpClient.PostAsJsonAsync("api/admin/DeleteCategory/", categoryToDelete);
            response.EnsureSuccessStatusCode();

            bool updateResult = await response.Content.ReadFromJsonAsync<bool>();
            return updateResult;
        }
        public async Task<bool> DeleteProduct(ProductModel productToDelete)
        {
            HttpResponseMessage response = await httpClient.PostAsJsonAsync("api/admin/DeleteProduct/", productToDelete);
            response.EnsureSuccessStatusCode();

            bool updateResult = await response.Content.ReadFromJsonAsync<bool>();
            return updateResult;
        }
        public async Task<ProductModel> SaveProduct(ProductModel newProduct)
        {
            HttpResponseMessage res = await httpClient.PostAsJsonAsync("api/admin/SaveProduct/", newProduct);
            res.EnsureSuccessStatusCode();
            ProductModel resModel = await res.Content.ReadFromJsonAsync<ProductModel>();
            return resModel;
        }
        public async Task<List<StockModel>> GetProductStock()
        {
            HttpResponseMessage res = await httpClient.GetAsync("api/admin/GetProductStock/");
            res.EnsureSuccessStatusCode();
            List<StockModel> resModel = await res.Content.ReadFromJsonAsync<List<StockModel>>();
            return resModel;
        }



        public async Task<bool> UpdateProductStock(StockModel stockToUpdate)
        {
            HttpResponseMessage response = await httpClient.PutAsJsonAsync("api/admin/UpdateProductStock/", stockToUpdate);
            response.EnsureSuccessStatusCode();

            bool updateResult = await response.Content.ReadFromJsonAsync<bool>();
            return updateResult;
        }
    }
}

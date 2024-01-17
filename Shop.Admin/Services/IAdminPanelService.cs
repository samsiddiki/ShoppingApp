﻿using DataModels.CustomModels;

namespace Shop.Admin.Services
{
    public interface IAdminPanelService
    {
        Task<ResponseModel> AdminLogin(LoginModel loginModel);
        Task<CategoryModel> SaveCategory(CategoryModel newCategory);
        Task<List<CategoryModel>> GetCategories();
        Task<List<ProductModel>> GetProducts();
        Task<bool> DeleteProduct(ProductModel productToDelete);
        Task<bool> UpdateCategory(CategoryModel categoryToUpdate);
        Task<bool> DeleteCategory(CategoryModel categoryToDelete);
        Task<ProductModel> SaveProduct(ProductModel newProduct);
        Task<bool> UpdateProductStock(StockModel stockToUpdate);
        Task<List<StockModel>> GetProductStock();
    }
}

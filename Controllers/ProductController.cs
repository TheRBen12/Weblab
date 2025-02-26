using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebLab.Data;
using WebLab.DTO;
using WebLab.Interfaces;
using WebLab.Models;

namespace WebLab.Controllers;

public class ProductController(ApplicationDbContext context, IProductService productService) : BaseController
{
    private readonly IProductService _productService = productService;

    [HttpGet]
    public async Task<IEnumerable<ProductDTO>> GetProductsByCategory(string category)
    {
        List<string> types = new List<string>();
        List<ProductType> stack = new List<ProductType>();

        var parentType = await context.ProductTypes
            .FirstOrDefaultAsync(type => type.Name == category);

        var allTypes = await context.ProductTypes.Where(type =>  type.ParentType != null)
            .Include(type => type.ParentType).ToListAsync();
        

        for (int i = 0; i < allTypes.Count; i++)
        {
            var currentType = allTypes[i];
            if (currentType.ParentType.Id == parentType.Id || currentType.Name == category)
            {
                types.Add(currentType.Name);
                stack.Add(currentType);
            }
        }

        while (stack.Any())
        {
            var subParentType = stack.Last();
            for (int i = 0; i < allTypes.Count; i++)
            {
                var currentType = allTypes[i];
                if (currentType.ParentType.Id == subParentType.Id)
                {
                    types.Add(currentType.Name);
                }
            }

            stack.Remove(subParentType);
        }
       
        
        var products = context.Products.Where(product => types.Contains(product.Type.Name)).Include(product => product.Specifications).
                ThenInclude(spec => spec.ProductProperty).Include(product => product.Type);
        if (products.Count() > 0)
        {
             var productDtos = productService.TransformProductListToDtoList(products);
             return productDtos;
        }
        
       
        return [];
    }


    [HttpGet("daily-offer")]
    public async Task<ProductDTO> GetDailyOffer()
    {
        Random random = new Random();
        var numberOfProducts = context.Products.ToList().Count;
        var id = random.Next(1, numberOfProducts);
        var dailyOfferProduct = await context.Products.Include(product => product.Type)
            .Include(product => product.Specifications).ThenInclude(spec => spec.ProductProperty)
            .FirstOrDefaultAsync(product => product.Id == id);

        var productDto = new ProductDTO()
        {
            Id = dailyOfferProduct.Id,
            Name = dailyOfferProduct.Name,
            Type = dailyOfferProduct.Type.Name,
            Trademark = dailyOfferProduct.Trademark,
            Price = dailyOfferProduct.Price,
            Specifications = dailyOfferProduct.Specifications.Select(s => new ProductSpecificationDTO()
            {
                PropertyName = s.ProductProperty.Name,
                Value = s.Value
            }).ToList()
        };

        return productDto;
    }

    [HttpGet("categories")]
    public async Task<IEnumerable<string>> GetSubCategoriesAsStrings(string category)
    {
        List<string> types = new List<string>();
        
        if (category == "Home")
        {
            var homeTypes = await context.ProductTypes.Where(type => type.ParentType == null).ToListAsync();
            foreach (var type in homeTypes)
            {
                types.Add(type.Name);
            }

            return types;
        }
        
        List<ProductType> stack = new List<ProductType>();

        var parentType = await context.ProductTypes
            .FirstOrDefaultAsync(type => type.Name == category);

        var allTypes = await context.ProductTypes.Where(type => type.Name != category && type.ParentType != null)
            .Include(type => type.ParentType).ToListAsync();

        for (int i = 0; i < allTypes.Count; i++)
        {
            var currentType = allTypes[i];
            if (currentType.ParentType.Id == parentType.Id)
            {
                types.Add(currentType.Name);
                stack.Add(currentType);
            }
        }

        return types;
    }
    
    [HttpGet("category")]
    public async Task<IEnumerable<ProductType>> GetSubCategories(string category)
    {
        List<string> types = new List<string>();
        
        if (category == "Home")
        {
            var homeTypes = await context.ProductTypes.Where(type => type.ParentType == null).ToListAsync();

            return homeTypes;
        }
        
        List<ProductType> stack = new List<ProductType>();

        var parentType = await context.ProductTypes
            .FirstOrDefaultAsync(type => type.Name == category);

        var allTypes = await context.ProductTypes.Where(type => type.Name != category && type.ParentType != null)
            .Include(type => type.ParentType).ToListAsync();

        for (int i = 0; i < allTypes.Count; i++)
        {
            var currentType = allTypes[i];
            if (currentType.ParentType.Id == parentType.Id)
            {
                types.Add(currentType.Name);
                stack.Add(currentType);
            }
        }
        var productTypes = context.ProductTypes.Where(type => types.Contains(type.Name)).Include(type => type.ParentType);
        return productTypes;
    }

    [HttpGet("top-sales")]
    public async Task<IEnumerable<ProductDTO>> GetTopSales()
    {
        var randomProducts = await context.Products.Include(product => product.Specifications).
            ThenInclude(spec => spec.ProductProperty).
            Include(product => product.Type)
            .OrderBy(p => Guid.NewGuid())
            .Take(3)
            .ToListAsync();
        var productDTos = productService.TransformProductListToDtoList(randomProducts);
        
        return productDTos;
    }
}
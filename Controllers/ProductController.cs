using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebLab.Data;
using WebLab.DTO;
using WebLab.Models;

namespace WebLab.Controllers;

public class ProductController(ApplicationDbContext context) : BaseController
{
    [HttpGet]
    public async Task<IEnumerable<Product>> GetProductsByCategory(string category)
    {
        return null;
    }

    [HttpGet("daily-offer")]
    public async Task<ProductDTO> GetDailyOffer()
    {
        Random random = new Random();
        var numberOfProducts = context.Products.ToList().Count;
        var id = random.Next(1, numberOfProducts);
        var dailyOfferProduct = await context.Products.Include(product => product.Type).Include(product => product.Specifications).ThenInclude(spec => spec.ProductProperty )
            .FirstOrDefaultAsync(product => product.Id == id);

        var productDto = new ProductDTO()
        {
            Id = dailyOfferProduct.Id,
            Name = dailyOfferProduct.Name,
            Type = dailyOfferProduct.Type.Name,
            Trademark = dailyOfferProduct.Trademark,
            Specifications = dailyOfferProduct.Specifications.Select(s => new ProductSpecificationDTO()
            {
                PropertyName = s.ProductProperty.Name,
                Value = s.Value
            }).ToList()
        };
        
        return productDto;
    }
}
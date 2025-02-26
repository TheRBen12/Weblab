using WebLab.DTO;
using WebLab.Interfaces;
using WebLab.Models;

namespace WebLab.Services;

public class ProductService: IProductService
{
    public IEnumerable<ProductDTO> TransformProductListToDtoList(IEnumerable<Product> products)
    {
        
        if (products == null)
        {
            throw new Exception("Die Produktliste ist null! Bitte überprüfen, ob die Datenbankabfrage korrekt ist.");
        }
        var productDtoList = products
            .Select(product => new ProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                Type = product.Type.Name, // Nur den Namen der Type-Entity übernehmen
                Price = product.Price,
                Trademark = product.Trademark,
                Specifications = product.Specifications
                    .Select(spec => new ProductSpecificationDTO
                    {
                        PropertyName = spec.ProductProperty.Name,
                        Value = spec.Value
                    }).ToList()
            }).ToList();
        
        return productDtoList;
    }
}
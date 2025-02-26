using WebLab.DTO;
using WebLab.Models;

namespace WebLab.Interfaces;

public interface IProductService
{
    IEnumerable<ProductDTO> TransformProductListToDtoList(IEnumerable<Product> products);
}
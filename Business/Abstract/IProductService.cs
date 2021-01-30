using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //iş katmanındaki servis metotları
    public interface IProductService
    {
        List<Product> GetAll();
    }
}

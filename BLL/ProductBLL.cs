using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    [System.ComponentModel.DataObject]
    internal class ProductBLL
    {

        private ProductDTO _productsAdapter = null;
        protected ProductDTO Adapter {
            get {
                if (_productsAdapter == null)
                {
                    _productsAdapter = new ProductDTO();
                }
                return _productsAdapter;
            }
        }
        /*
        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]*/
        //Baza danych
    }

}

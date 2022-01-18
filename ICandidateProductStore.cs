using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateProductStore.Template
{
    /// <summary>
    /// Suggestion of a interface for the implementation of the candidate product store candidate test
    /// </summary>
    interface ICandidateProductStore
    {
        /// <summary>
        /// Get all products
        /// </summary>
        public IList<Product> GetAllProducts();


        /// <summary>
        /// Get all products above given price
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public IList<Product> GetAllProductsAbovePrice(decimal price);


        /// <summary>
        /// Gets the smallest box  to fit two products, can handle different sizes and returns the smallest one available, boxes can be rotated 90 degrees
        /// </summary>
        /// <param name="product1"></param>
        /// <param name="product2"></param>
        /// <returns></returns>
        public Box CalculateSmallestBoxForTwoProducts(Product product1, Product product2);

        /// <summary>
        /// Checkout the smallest box and the two boxes containing them
        /// </summary>
        /// <param name="box"></param>
        /// <param name="product1"></param>
        /// <param name="product2"></param>
        /// <returns></returns>
        public CheckoutSummary Checkout(Box box, Product product1, Product product2);

    }
}

using System;
using System.Collections.Generic;

namespace CandidateProductStore.Template
{
    public record Product();
    public record ProductDimensions();
    public record Box();
    public record CheckoutSummary();


    /// <summary>
    /// Suggested interface for the REST Api connection
    /// </summary>
    public interface ICandidateProductStoreApi
    {
        /// <summary>
        /// Retrieve all products from the REST Api
        /// </summary>
        public IList<Product> GetProducts();

        /// <summary>
        /// Retrieve the dimensions of a product from the REST Api
        /// </summary>
        /// <param name="productId">Product id</param>
        public ProductDimensions GetProductDimensions(int productId);

        /// <summary>
        /// Retrieve all the boxes and their dimensions from the REST Api
        /// </summary>
        public IList<Box> GetBoxes();

        /// <summary>
        /// Validates and performs the order if correct
        /// </summary>
        /// <param name="boxId"></param>
        /// <param name="productIds"></param>
        /// <returns>A summary of the order and if it was valid</returns>
        public CheckoutSummary Checkout(int boxId, int[] productIds);



    }
}

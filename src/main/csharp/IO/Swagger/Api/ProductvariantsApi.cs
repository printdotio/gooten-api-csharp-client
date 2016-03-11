using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProductvariantsApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Get a list of available product variations. Includes pricing information
        /// </summary>
        /// <remarks>
        /// Get a list of all available product variations, or if one passes in a specific product type id (productId), gets a list of available variations of a recipe product.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryCode">The country code the order would be shipped to. For example, &#39;US&#39; or &#39;FR&#39;</param>
        /// <param name="productId">Recipe product ID, such as those returned from the /products service</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api, widget</param>
        /// <param name="all">Whether or not to return all available printio products, or just ones in your recipe. Pass &#39;true&#39; or &#39;false&#39;.</param>
        /// <param name="languageCode">Two-character language code, defaults to \&quot;en\&quot; (english)</param>
        /// <param name="currencyCode">Three character currency code, defaults to \&quot;USD\&quot; (united states dollar)</param>
        /// <returns>ProductVariantResponse</returns>
        ProductVariantResponse GetProductvariants (string countryCode, string productId, int? version, string source, string all = null, string languageCode = null, string currencyCode = null);
  
        /// <summary>
        /// Get a list of available product variations. Includes pricing information
        /// </summary>
        /// <remarks>
        /// Get a list of all available product variations, or if one passes in a specific product type id (productId), gets a list of available variations of a recipe product.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryCode">The country code the order would be shipped to. For example, &#39;US&#39; or &#39;FR&#39;</param>
        /// <param name="productId">Recipe product ID, such as those returned from the /products service</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api, widget</param>
        /// <param name="all">Whether or not to return all available printio products, or just ones in your recipe. Pass &#39;true&#39; or &#39;false&#39;.</param>
        /// <param name="languageCode">Two-character language code, defaults to \&quot;en\&quot; (english)</param>
        /// <param name="currencyCode">Three character currency code, defaults to \&quot;USD\&quot; (united states dollar)</param>
        /// <returns>ApiResponse of ProductVariantResponse</returns>
        ApiResponse<ProductVariantResponse> GetProductvariantsWithHttpInfo (string countryCode, string productId, int? version, string source, string all = null, string languageCode = null, string currencyCode = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Get a list of available product variations. Includes pricing information
        /// </summary>
        /// <remarks>
        /// Get a list of all available product variations, or if one passes in a specific product type id (productId), gets a list of available variations of a recipe product.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryCode">The country code the order would be shipped to. For example, &#39;US&#39; or &#39;FR&#39;</param>
        /// <param name="productId">Recipe product ID, such as those returned from the /products service</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api, widget</param>
        /// <param name="all">Whether or not to return all available printio products, or just ones in your recipe. Pass &#39;true&#39; or &#39;false&#39;.</param>
        /// <param name="languageCode">Two-character language code, defaults to \&quot;en\&quot; (english)</param>
        /// <param name="currencyCode">Three character currency code, defaults to \&quot;USD\&quot; (united states dollar)</param>
        /// <returns>Task of ProductVariantResponse</returns>
        System.Threading.Tasks.Task<ProductVariantResponse> GetProductvariantsAsync (string countryCode, string productId, int? version, string source, string all = null, string languageCode = null, string currencyCode = null);

        /// <summary>
        /// Get a list of available product variations. Includes pricing information
        /// </summary>
        /// <remarks>
        /// Get a list of all available product variations, or if one passes in a specific product type id (productId), gets a list of available variations of a recipe product.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryCode">The country code the order would be shipped to. For example, &#39;US&#39; or &#39;FR&#39;</param>
        /// <param name="productId">Recipe product ID, such as those returned from the /products service</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api, widget</param>
        /// <param name="all">Whether or not to return all available printio products, or just ones in your recipe. Pass &#39;true&#39; or &#39;false&#39;.</param>
        /// <param name="languageCode">Two-character language code, defaults to \&quot;en\&quot; (english)</param>
        /// <param name="currencyCode">Three character currency code, defaults to \&quot;USD\&quot; (united states dollar)</param>
        /// <returns>Task of ApiResponse (ProductVariantResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductVariantResponse>> GetProductvariantsAsyncWithHttpInfo (string countryCode, string productId, int? version, string source, string all = null, string languageCode = null, string currencyCode = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ProductvariantsApi : IProductvariantsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductvariantsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductvariantsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductvariantsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProductvariantsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        /// Get a list of available product variations. Includes pricing information Get a list of all available product variations, or if one passes in a specific product type id (productId), gets a list of available variations of a recipe product.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryCode">The country code the order would be shipped to. For example, &#39;US&#39; or &#39;FR&#39;</param> 
        /// <param name="productId">Recipe product ID, such as those returned from the /products service</param> 
        /// <param name="version">Version of the api being used</param> 
        /// <param name="source">Description of the source-- ios, android, api, widget</param> 
        /// <param name="all">Whether or not to return all available printio products, or just ones in your recipe. Pass &#39;true&#39; or &#39;false&#39;.</param> 
        /// <param name="languageCode">Two-character language code, defaults to \&quot;en\&quot; (english)</param> 
        /// <param name="currencyCode">Three character currency code, defaults to \&quot;USD\&quot; (united states dollar)</param> 
        /// <returns>ProductVariantResponse</returns>
        public ProductVariantResponse GetProductvariants (string countryCode, string productId, int? version, string source, string all = null, string languageCode = null, string currencyCode = null)
        {
             ApiResponse<ProductVariantResponse> localVarResponse = GetProductvariantsWithHttpInfo(countryCode, productId, version, source, all, languageCode, currencyCode);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of available product variations. Includes pricing information Get a list of all available product variations, or if one passes in a specific product type id (productId), gets a list of available variations of a recipe product.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryCode">The country code the order would be shipped to. For example, &#39;US&#39; or &#39;FR&#39;</param> 
        /// <param name="productId">Recipe product ID, such as those returned from the /products service</param> 
        /// <param name="version">Version of the api being used</param> 
        /// <param name="source">Description of the source-- ios, android, api, widget</param> 
        /// <param name="all">Whether or not to return all available printio products, or just ones in your recipe. Pass &#39;true&#39; or &#39;false&#39;.</param> 
        /// <param name="languageCode">Two-character language code, defaults to \&quot;en\&quot; (english)</param> 
        /// <param name="currencyCode">Three character currency code, defaults to \&quot;USD\&quot; (united states dollar)</param> 
        /// <returns>ApiResponse of ProductVariantResponse</returns>
        public ApiResponse< ProductVariantResponse > GetProductvariantsWithHttpInfo (string countryCode, string productId, int? version, string source, string all = null, string languageCode = null, string currencyCode = null)
        {
            
            // verify the required parameter 'countryCode' is set
            if (countryCode == null)
                throw new ApiException(400, "Missing required parameter 'countryCode' when calling ProductvariantsApi->GetProductvariants");
            
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductvariantsApi->GetProductvariants");
            
            // verify the required parameter 'version' is set
            if (version == null)
                throw new ApiException(400, "Missing required parameter 'version' when calling ProductvariantsApi->GetProductvariants");
            
            // verify the required parameter 'source' is set
            if (source == null)
                throw new ApiException(400, "Missing required parameter 'source' when calling ProductvariantsApi->GetProductvariants");
            
    
            var localVarPath = "/productvariants/v/{version}/source/{source}/";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (version != null) localVarPathParams.Add("version", Configuration.ApiClient.ParameterToString(version)); // path parameter
            if (source != null) localVarPathParams.Add("source", Configuration.ApiClient.ParameterToString(source)); // path parameter
            
            if (countryCode != null) localVarQueryParams.Add("countryCode", Configuration.ApiClient.ParameterToString(countryCode)); // query parameter
            if (productId != null) localVarQueryParams.Add("productId", Configuration.ApiClient.ParameterToString(productId)); // query parameter
            if (all != null) localVarQueryParams.Add("all", Configuration.ApiClient.ParameterToString(all)); // query parameter
            if (languageCode != null) localVarQueryParams.Add("languageCode", Configuration.ApiClient.ParameterToString(languageCode)); // query parameter
            if (currencyCode != null) localVarQueryParams.Add("currencyCode", Configuration.ApiClient.ParameterToString(currencyCode)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetProductvariants: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProductvariants: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ProductVariantResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProductVariantResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductVariantResponse)));
            
        }

        
        /// <summary>
        /// Get a list of available product variations. Includes pricing information Get a list of all available product variations, or if one passes in a specific product type id (productId), gets a list of available variations of a recipe product.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryCode">The country code the order would be shipped to. For example, &#39;US&#39; or &#39;FR&#39;</param>
        /// <param name="productId">Recipe product ID, such as those returned from the /products service</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api, widget</param>
        /// <param name="all">Whether or not to return all available printio products, or just ones in your recipe. Pass &#39;true&#39; or &#39;false&#39;.</param>
        /// <param name="languageCode">Two-character language code, defaults to \&quot;en\&quot; (english)</param>
        /// <param name="currencyCode">Three character currency code, defaults to \&quot;USD\&quot; (united states dollar)</param>
        /// <returns>Task of ProductVariantResponse</returns>
        public async System.Threading.Tasks.Task<ProductVariantResponse> GetProductvariantsAsync (string countryCode, string productId, int? version, string source, string all = null, string languageCode = null, string currencyCode = null)
        {
             ApiResponse<ProductVariantResponse> localVarResponse = await GetProductvariantsAsyncWithHttpInfo(countryCode, productId, version, source, all, languageCode, currencyCode);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of available product variations. Includes pricing information Get a list of all available product variations, or if one passes in a specific product type id (productId), gets a list of available variations of a recipe product.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryCode">The country code the order would be shipped to. For example, &#39;US&#39; or &#39;FR&#39;</param>
        /// <param name="productId">Recipe product ID, such as those returned from the /products service</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api, widget</param>
        /// <param name="all">Whether or not to return all available printio products, or just ones in your recipe. Pass &#39;true&#39; or &#39;false&#39;.</param>
        /// <param name="languageCode">Two-character language code, defaults to \&quot;en\&quot; (english)</param>
        /// <param name="currencyCode">Three character currency code, defaults to \&quot;USD\&quot; (united states dollar)</param>
        /// <returns>Task of ApiResponse (ProductVariantResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductVariantResponse>> GetProductvariantsAsyncWithHttpInfo (string countryCode, string productId, int? version, string source, string all = null, string languageCode = null, string currencyCode = null)
        {
            // verify the required parameter 'countryCode' is set
            if (countryCode == null) throw new ApiException(400, "Missing required parameter 'countryCode' when calling GetProductvariants");
            // verify the required parameter 'productId' is set
            if (productId == null) throw new ApiException(400, "Missing required parameter 'productId' when calling GetProductvariants");
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling GetProductvariants");
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling GetProductvariants");
            
    
            var localVarPath = "/productvariants/v/{version}/source/{source}/";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (version != null) localVarPathParams.Add("version", Configuration.ApiClient.ParameterToString(version)); // path parameter
            if (source != null) localVarPathParams.Add("source", Configuration.ApiClient.ParameterToString(source)); // path parameter
            
            if (countryCode != null) localVarQueryParams.Add("countryCode", Configuration.ApiClient.ParameterToString(countryCode)); // query parameter
            if (productId != null) localVarQueryParams.Add("productId", Configuration.ApiClient.ParameterToString(productId)); // query parameter
            if (all != null) localVarQueryParams.Add("all", Configuration.ApiClient.ParameterToString(all)); // query parameter
            if (languageCode != null) localVarQueryParams.Add("languageCode", Configuration.ApiClient.ParameterToString(languageCode)); // query parameter
            if (currencyCode != null) localVarQueryParams.Add("currencyCode", Configuration.ApiClient.ParameterToString(currencyCode)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetProductvariants: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProductvariants: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProductVariantResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProductVariantResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductVariantResponse)));
            
        }
        
    }
    
}

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
    public interface IShippriceestimateApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Get a baseline ship price for an item
        /// </summary>
        /// <remarks>
        /// Price returned is an estimate which may or may not be realistically attainable.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">Product ID</param>
        /// <param name="countryCode">Country Code it will be shipped to</param>
        /// <param name="currencyCode">Currency Code the estimate should be in. Defaults to USD.</param>
        /// <returns>ShipEstimate</returns>
        ShipEstimate GetShippriceestimate (int? productId, string countryCode, string currencyCode = null);
  
        /// <summary>
        /// Get a baseline ship price for an item
        /// </summary>
        /// <remarks>
        /// Price returned is an estimate which may or may not be realistically attainable.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">Product ID</param>
        /// <param name="countryCode">Country Code it will be shipped to</param>
        /// <param name="currencyCode">Currency Code the estimate should be in. Defaults to USD.</param>
        /// <returns>ApiResponse of ShipEstimate</returns>
        ApiResponse<ShipEstimate> GetShippriceestimateWithHttpInfo (int? productId, string countryCode, string currencyCode = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Get a baseline ship price for an item
        /// </summary>
        /// <remarks>
        /// Price returned is an estimate which may or may not be realistically attainable.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">Product ID</param>
        /// <param name="countryCode">Country Code it will be shipped to</param>
        /// <param name="currencyCode">Currency Code the estimate should be in. Defaults to USD.</param>
        /// <returns>Task of ShipEstimate</returns>
        System.Threading.Tasks.Task<ShipEstimate> GetShippriceestimateAsync (int? productId, string countryCode, string currencyCode = null);

        /// <summary>
        /// Get a baseline ship price for an item
        /// </summary>
        /// <remarks>
        /// Price returned is an estimate which may or may not be realistically attainable.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">Product ID</param>
        /// <param name="countryCode">Country Code it will be shipped to</param>
        /// <param name="currencyCode">Currency Code the estimate should be in. Defaults to USD.</param>
        /// <returns>Task of ApiResponse (ShipEstimate)</returns>
        System.Threading.Tasks.Task<ApiResponse<ShipEstimate>> GetShippriceestimateAsyncWithHttpInfo (int? productId, string countryCode, string currencyCode = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ShippriceestimateApi : IShippriceestimateApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippriceestimateApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShippriceestimateApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippriceestimateApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ShippriceestimateApi(Configuration configuration = null)
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
        /// Get a baseline ship price for an item Price returned is an estimate which may or may not be realistically attainable.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">Product ID</param> 
        /// <param name="countryCode">Country Code it will be shipped to</param> 
        /// <param name="currencyCode">Currency Code the estimate should be in. Defaults to USD.</param> 
        /// <returns>ShipEstimate</returns>
        public ShipEstimate GetShippriceestimate (int? productId, string countryCode, string currencyCode = null)
        {
             ApiResponse<ShipEstimate> localVarResponse = GetShippriceestimateWithHttpInfo(productId, countryCode, currencyCode);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a baseline ship price for an item Price returned is an estimate which may or may not be realistically attainable.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">Product ID</param> 
        /// <param name="countryCode">Country Code it will be shipped to</param> 
        /// <param name="currencyCode">Currency Code the estimate should be in. Defaults to USD.</param> 
        /// <returns>ApiResponse of ShipEstimate</returns>
        public ApiResponse< ShipEstimate > GetShippriceestimateWithHttpInfo (int? productId, string countryCode, string currencyCode = null)
        {
            
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ShippriceestimateApi->GetShippriceestimate");
            
            // verify the required parameter 'countryCode' is set
            if (countryCode == null)
                throw new ApiException(400, "Missing required parameter 'countryCode' when calling ShippriceestimateApi->GetShippriceestimate");
            
    
            var localVarPath = "/shippriceestimate/";
    
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
            
            if (productId != null) localVarQueryParams.Add("productId", Configuration.ApiClient.ParameterToString(productId)); // query parameter
            if (countryCode != null) localVarQueryParams.Add("countryCode", Configuration.ApiClient.ParameterToString(countryCode)); // query parameter
            if (currencyCode != null) localVarQueryParams.Add("currencyCode", Configuration.ApiClient.ParameterToString(currencyCode)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetShippriceestimate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetShippriceestimate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ShipEstimate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ShipEstimate) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ShipEstimate)));
            
        }

        
        /// <summary>
        /// Get a baseline ship price for an item Price returned is an estimate which may or may not be realistically attainable.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">Product ID</param>
        /// <param name="countryCode">Country Code it will be shipped to</param>
        /// <param name="currencyCode">Currency Code the estimate should be in. Defaults to USD.</param>
        /// <returns>Task of ShipEstimate</returns>
        public async System.Threading.Tasks.Task<ShipEstimate> GetShippriceestimateAsync (int? productId, string countryCode, string currencyCode = null)
        {
             ApiResponse<ShipEstimate> localVarResponse = await GetShippriceestimateAsyncWithHttpInfo(productId, countryCode, currencyCode);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a baseline ship price for an item Price returned is an estimate which may or may not be realistically attainable.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">Product ID</param>
        /// <param name="countryCode">Country Code it will be shipped to</param>
        /// <param name="currencyCode">Currency Code the estimate should be in. Defaults to USD.</param>
        /// <returns>Task of ApiResponse (ShipEstimate)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ShipEstimate>> GetShippriceestimateAsyncWithHttpInfo (int? productId, string countryCode, string currencyCode = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null) throw new ApiException(400, "Missing required parameter 'productId' when calling GetShippriceestimate");
            // verify the required parameter 'countryCode' is set
            if (countryCode == null) throw new ApiException(400, "Missing required parameter 'countryCode' when calling GetShippriceestimate");
            
    
            var localVarPath = "/shippriceestimate/";
    
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
            
            if (productId != null) localVarQueryParams.Add("productId", Configuration.ApiClient.ParameterToString(productId)); // query parameter
            if (countryCode != null) localVarQueryParams.Add("countryCode", Configuration.ApiClient.ParameterToString(countryCode)); // query parameter
            if (currencyCode != null) localVarQueryParams.Add("currencyCode", Configuration.ApiClient.ParameterToString(currencyCode)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetShippriceestimate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetShippriceestimate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ShipEstimate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ShipEstimate) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ShipEstimate)));
            
        }
        
    }
    
}

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Gooten.ApiClient.Client;
using Gooten.ApiClient.Model;


namespace Gooten.ApiClient.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPriceestimateApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Get an order price
        /// </summary>
        /// <remarks>
        /// Get the price of an order, including discounts from a coupon.
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="order">Order to potentially be submitted</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <returns>OrderPriceResult</returns>
        OrderPriceResult POSTPriceestimate (Order order, int? version, string source);
  
        /// <summary>
        /// Get an order price
        /// </summary>
        /// <remarks>
        /// Get the price of an order, including discounts from a coupon.
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="order">Order to potentially be submitted</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <returns>ApiResponse of OrderPriceResult</returns>
        ApiResponse<OrderPriceResult> POSTPriceestimateWithHttpInfo (Order order, int? version, string source);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Get an order price
        /// </summary>
        /// <remarks>
        /// Get the price of an order, including discounts from a coupon.
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="order">Order to potentially be submitted</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <returns>Task of OrderPriceResult</returns>
        System.Threading.Tasks.Task<OrderPriceResult> POSTPriceestimateAsync (Order order, int? version, string source);

        /// <summary>
        /// Get an order price
        /// </summary>
        /// <remarks>
        /// Get the price of an order, including discounts from a coupon.
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="order">Order to potentially be submitted</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <returns>Task of ApiResponse (OrderPriceResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrderPriceResult>> POSTPriceestimateAsyncWithHttpInfo (Order order, int? version, string source);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PriceestimateApi : IPriceestimateApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceestimateApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PriceestimateApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceestimateApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PriceestimateApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        /// Get an order price Get the price of an order, including discounts from a coupon.
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="order">Order to potentially be submitted</param> 
        /// <param name="version">Version of the api being used</param> 
        /// <param name="source">Description of the source-- ios, android, api</param> 
        /// <returns>OrderPriceResult</returns>
        public OrderPriceResult POSTPriceestimate (Order order, int? version, string source)
        {
             ApiResponse<OrderPriceResult> localVarResponse = POSTPriceestimateWithHttpInfo(order, version, source);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an order price Get the price of an order, including discounts from a coupon.
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="order">Order to potentially be submitted</param> 
        /// <param name="version">Version of the api being used</param> 
        /// <param name="source">Description of the source-- ios, android, api</param> 
        /// <returns>ApiResponse of OrderPriceResult</returns>
        public ApiResponse< OrderPriceResult > POSTPriceestimateWithHttpInfo (Order order, int? version, string source)
        {
            
            // verify the required parameter 'order' is set
            if (order == null)
                throw new ApiException(400, "Missing required parameter 'order' when calling PriceestimateApi->POSTPriceestimate");
            
            // verify the required parameter 'version' is set
            if (version == null)
                throw new ApiException(400, "Missing required parameter 'version' when calling PriceestimateApi->POSTPriceestimate");
            
            // verify the required parameter 'source' is set
            if (source == null)
                throw new ApiException(400, "Missing required parameter 'source' when calling PriceestimateApi->POSTPriceestimate");
            
    
            var localVarPath = "/v/{version}/source/{source}/priceestimate/";
    
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
            
            
            
            
            if (order.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(order); // http body (model) parameter
            }
            else
            {
                localVarPostBody = order; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling POSTPriceestimate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling POSTPriceestimate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OrderPriceResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrderPriceResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderPriceResult)));
            
        }

        
        /// <summary>
        /// Get an order price Get the price of an order, including discounts from a coupon.
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="order">Order to potentially be submitted</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <returns>Task of OrderPriceResult</returns>
        public async System.Threading.Tasks.Task<OrderPriceResult> POSTPriceestimateAsync (Order order, int? version, string source)
        {
             ApiResponse<OrderPriceResult> localVarResponse = await POSTPriceestimateAsyncWithHttpInfo(order, version, source);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an order price Get the price of an order, including discounts from a coupon.
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="order">Order to potentially be submitted</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <returns>Task of ApiResponse (OrderPriceResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrderPriceResult>> POSTPriceestimateAsyncWithHttpInfo (Order order, int? version, string source)
        {
            // verify the required parameter 'order' is set
            if (order == null) throw new ApiException(400, "Missing required parameter 'order' when calling POSTPriceestimate");
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling POSTPriceestimate");
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling POSTPriceestimate");
            
    
            var localVarPath = "/v/{version}/source/{source}/priceestimate/";
    
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
            
            
            
            
            if (order.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(order); // http body (model) parameter
            }
            else
            {
                localVarPostBody = order; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling POSTPriceestimate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling POSTPriceestimate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrderPriceResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrderPriceResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderPriceResult)));
            
        }
        
    }
    
}

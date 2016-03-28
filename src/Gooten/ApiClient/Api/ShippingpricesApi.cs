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
    public interface IShippingpricesApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Get a list of shipping options and prices for items
        /// </summary>
        /// <remarks>
        /// Get a list of shipping options and prices for items.
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shippingPricesRequest">DTO with required information</param>
        /// <param name="partnerBillingKey">Partner billing key</param>
        /// <returns>ShippingPricesResult</returns>
        ShippingPricesResult POSTShippingprices (ShippingPricesRequest shippingPricesRequest, string partnerBillingKey = null);
  
        /// <summary>
        /// Get a list of shipping options and prices for items
        /// </summary>
        /// <remarks>
        /// Get a list of shipping options and prices for items.
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shippingPricesRequest">DTO with required information</param>
        /// <param name="partnerBillingKey">Partner billing key</param>
        /// <returns>ApiResponse of ShippingPricesResult</returns>
        ApiResponse<ShippingPricesResult> POSTShippingpricesWithHttpInfo (ShippingPricesRequest shippingPricesRequest, string partnerBillingKey = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Get a list of shipping options and prices for items
        /// </summary>
        /// <remarks>
        /// Get a list of shipping options and prices for items.
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shippingPricesRequest">DTO with required information</param>
        /// <param name="partnerBillingKey">Partner billing key</param>
        /// <returns>Task of ShippingPricesResult</returns>
        System.Threading.Tasks.Task<ShippingPricesResult> POSTShippingpricesAsync (ShippingPricesRequest shippingPricesRequest, string partnerBillingKey = null);

        /// <summary>
        /// Get a list of shipping options and prices for items
        /// </summary>
        /// <remarks>
        /// Get a list of shipping options and prices for items.
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shippingPricesRequest">DTO with required information</param>
        /// <param name="partnerBillingKey">Partner billing key</param>
        /// <returns>Task of ApiResponse (ShippingPricesResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<ShippingPricesResult>> POSTShippingpricesAsyncWithHttpInfo (ShippingPricesRequest shippingPricesRequest, string partnerBillingKey = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ShippingpricesApi : IShippingpricesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingpricesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShippingpricesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingpricesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ShippingpricesApi(Configuration configuration = null)
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
        /// Get a list of shipping options and prices for items Get a list of shipping options and prices for items.
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shippingPricesRequest">DTO with required information</param> 
        /// <param name="partnerBillingKey">Partner billing key</param> 
        /// <returns>ShippingPricesResult</returns>
        public ShippingPricesResult POSTShippingprices (ShippingPricesRequest shippingPricesRequest, string partnerBillingKey = null)
        {
             ApiResponse<ShippingPricesResult> localVarResponse = POSTShippingpricesWithHttpInfo(shippingPricesRequest, partnerBillingKey);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of shipping options and prices for items Get a list of shipping options and prices for items.
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shippingPricesRequest">DTO with required information</param> 
        /// <param name="partnerBillingKey">Partner billing key</param> 
        /// <returns>ApiResponse of ShippingPricesResult</returns>
        public ApiResponse< ShippingPricesResult > POSTShippingpricesWithHttpInfo (ShippingPricesRequest shippingPricesRequest, string partnerBillingKey = null)
        {
            
            // verify the required parameter 'shippingPricesRequest' is set
            if (shippingPricesRequest == null)
                throw new ApiException(400, "Missing required parameter 'shippingPricesRequest' when calling ShippingpricesApi->POSTShippingprices");
            
    
            var localVarPath = "/shippingprices/";
    
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
            
            if (partnerBillingKey != null) localVarQueryParams.Add("partnerBillingKey", Configuration.ApiClient.ParameterToString(partnerBillingKey)); // query parameter
            
            
            
            if (shippingPricesRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(shippingPricesRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = shippingPricesRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling POSTShippingprices: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling POSTShippingprices: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ShippingPricesResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ShippingPricesResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ShippingPricesResult)));
            
        }

        
        /// <summary>
        /// Get a list of shipping options and prices for items Get a list of shipping options and prices for items.
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shippingPricesRequest">DTO with required information</param>
        /// <param name="partnerBillingKey">Partner billing key</param>
        /// <returns>Task of ShippingPricesResult</returns>
        public async System.Threading.Tasks.Task<ShippingPricesResult> POSTShippingpricesAsync (ShippingPricesRequest shippingPricesRequest, string partnerBillingKey = null)
        {
             ApiResponse<ShippingPricesResult> localVarResponse = await POSTShippingpricesAsyncWithHttpInfo(shippingPricesRequest, partnerBillingKey);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of shipping options and prices for items Get a list of shipping options and prices for items.
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shippingPricesRequest">DTO with required information</param>
        /// <param name="partnerBillingKey">Partner billing key</param>
        /// <returns>Task of ApiResponse (ShippingPricesResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ShippingPricesResult>> POSTShippingpricesAsyncWithHttpInfo (ShippingPricesRequest shippingPricesRequest, string partnerBillingKey = null)
        {
            // verify the required parameter 'shippingPricesRequest' is set
            if (shippingPricesRequest == null) throw new ApiException(400, "Missing required parameter 'shippingPricesRequest' when calling POSTShippingprices");
            
    
            var localVarPath = "/shippingprices/";
    
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
            
            if (partnerBillingKey != null) localVarQueryParams.Add("partnerBillingKey", Configuration.ApiClient.ParameterToString(partnerBillingKey)); // query parameter
            
            
            
            if (shippingPricesRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(shippingPricesRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = shippingPricesRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling POSTShippingprices: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling POSTShippingprices: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ShippingPricesResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ShippingPricesResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ShippingPricesResult)));
            
        }
        
    }
    
}

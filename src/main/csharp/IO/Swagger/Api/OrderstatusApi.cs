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
    public interface IOrderstatusApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Update an order status
        /// </summary>
        /// <remarks>
        /// Update status of each order item.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Order Id</param>
        /// <param name="orderStatusName">Order status name for update</param>
        /// <returns>OrderStatusUpdateResult</returns>
        OrderStatusUpdateResult POSTOrderstatus (string id, string orderStatusName);
  
        /// <summary>
        /// Update an order status
        /// </summary>
        /// <remarks>
        /// Update status of each order item.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Order Id</param>
        /// <param name="orderStatusName">Order status name for update</param>
        /// <returns>ApiResponse of OrderStatusUpdateResult</returns>
        ApiResponse<OrderStatusUpdateResult> POSTOrderstatusWithHttpInfo (string id, string orderStatusName);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Update an order status
        /// </summary>
        /// <remarks>
        /// Update status of each order item.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Order Id</param>
        /// <param name="orderStatusName">Order status name for update</param>
        /// <returns>Task of OrderStatusUpdateResult</returns>
        System.Threading.Tasks.Task<OrderStatusUpdateResult> POSTOrderstatusAsync (string id, string orderStatusName);

        /// <summary>
        /// Update an order status
        /// </summary>
        /// <remarks>
        /// Update status of each order item.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Order Id</param>
        /// <param name="orderStatusName">Order status name for update</param>
        /// <returns>Task of ApiResponse (OrderStatusUpdateResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrderStatusUpdateResult>> POSTOrderstatusAsyncWithHttpInfo (string id, string orderStatusName);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrderstatusApi : IOrderstatusApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderstatusApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrderstatusApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderstatusApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OrderstatusApi(Configuration configuration = null)
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
        /// Update an order status Update status of each order item.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Order Id</param> 
        /// <param name="orderStatusName">Order status name for update</param> 
        /// <returns>OrderStatusUpdateResult</returns>
        public OrderStatusUpdateResult POSTOrderstatus (string id, string orderStatusName)
        {
             ApiResponse<OrderStatusUpdateResult> localVarResponse = POSTOrderstatusWithHttpInfo(id, orderStatusName);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an order status Update status of each order item.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Order Id</param> 
        /// <param name="orderStatusName">Order status name for update</param> 
        /// <returns>ApiResponse of OrderStatusUpdateResult</returns>
        public ApiResponse< OrderStatusUpdateResult > POSTOrderstatusWithHttpInfo (string id, string orderStatusName)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OrderstatusApi->POSTOrderstatus");
            
            // verify the required parameter 'orderStatusName' is set
            if (orderStatusName == null)
                throw new ApiException(400, "Missing required parameter 'orderStatusName' when calling OrderstatusApi->POSTOrderstatus");
            
    
            var localVarPath = "/orderstatus/";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (orderStatusName != null) localVarQueryParams.Add("orderStatusName", Configuration.ApiClient.ParameterToString(orderStatusName)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling POSTOrderstatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling POSTOrderstatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OrderStatusUpdateResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrderStatusUpdateResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderStatusUpdateResult)));
            
        }

        
        /// <summary>
        /// Update an order status Update status of each order item.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Order Id</param>
        /// <param name="orderStatusName">Order status name for update</param>
        /// <returns>Task of OrderStatusUpdateResult</returns>
        public async System.Threading.Tasks.Task<OrderStatusUpdateResult> POSTOrderstatusAsync (string id, string orderStatusName)
        {
             ApiResponse<OrderStatusUpdateResult> localVarResponse = await POSTOrderstatusAsyncWithHttpInfo(id, orderStatusName);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an order status Update status of each order item.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Order Id</param>
        /// <param name="orderStatusName">Order status name for update</param>
        /// <returns>Task of ApiResponse (OrderStatusUpdateResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrderStatusUpdateResult>> POSTOrderstatusAsyncWithHttpInfo (string id, string orderStatusName)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling POSTOrderstatus");
            // verify the required parameter 'orderStatusName' is set
            if (orderStatusName == null) throw new ApiException(400, "Missing required parameter 'orderStatusName' when calling POSTOrderstatus");
            
    
            var localVarPath = "/orderstatus/";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (orderStatusName != null) localVarQueryParams.Add("orderStatusName", Configuration.ApiClient.ParameterToString(orderStatusName)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling POSTOrderstatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling POSTOrderstatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrderStatusUpdateResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrderStatusUpdateResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderStatusUpdateResult)));
            
        }
        
    }
    
}

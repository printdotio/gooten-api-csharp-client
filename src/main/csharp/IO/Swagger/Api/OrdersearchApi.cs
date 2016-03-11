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
    public interface IOrdersearchApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Search an orders
        /// </summary>
        /// <remarks>
        /// Search through the orders and return information about orders that match search criteria.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="genericValues">Any value which is related to order (partner name, address, phone, couponCode, etc...)</param>
        /// <param name="lastName">Partner last name</param>
        /// <param name="email">Partner email</param>
        /// <param name="postalCode">Billing/Shipping address postal code</param>
        /// <param name="startDate">Start date of the date range when order was created</param>
        /// <param name="endDate">End date of the date range when order was created</param>
        /// <param name="uniqueUserId">User Id</param>
        /// <param name="partnerId">Partner Id</param>
        /// <param name="pageSize">How many items to return in reponse.</param>
        /// <param name="page">Page number, how many items to skip.</param>
        /// <returns>SubmittedOrderList</returns>
        SubmittedOrderList GETOrdersearch (string genericValues = null, string lastName = null, string email = null, string postalCode = null, string startDate = null, string endDate = null, string uniqueUserId = null, int? partnerId = null, int? pageSize = null, int? page = null);
  
        /// <summary>
        /// Search an orders
        /// </summary>
        /// <remarks>
        /// Search through the orders and return information about orders that match search criteria.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="genericValues">Any value which is related to order (partner name, address, phone, couponCode, etc...)</param>
        /// <param name="lastName">Partner last name</param>
        /// <param name="email">Partner email</param>
        /// <param name="postalCode">Billing/Shipping address postal code</param>
        /// <param name="startDate">Start date of the date range when order was created</param>
        /// <param name="endDate">End date of the date range when order was created</param>
        /// <param name="uniqueUserId">User Id</param>
        /// <param name="partnerId">Partner Id</param>
        /// <param name="pageSize">How many items to return in reponse.</param>
        /// <param name="page">Page number, how many items to skip.</param>
        /// <returns>ApiResponse of SubmittedOrderList</returns>
        ApiResponse<SubmittedOrderList> GETOrdersearchWithHttpInfo (string genericValues = null, string lastName = null, string email = null, string postalCode = null, string startDate = null, string endDate = null, string uniqueUserId = null, int? partnerId = null, int? pageSize = null, int? page = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Search an orders
        /// </summary>
        /// <remarks>
        /// Search through the orders and return information about orders that match search criteria.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="genericValues">Any value which is related to order (partner name, address, phone, couponCode, etc...)</param>
        /// <param name="lastName">Partner last name</param>
        /// <param name="email">Partner email</param>
        /// <param name="postalCode">Billing/Shipping address postal code</param>
        /// <param name="startDate">Start date of the date range when order was created</param>
        /// <param name="endDate">End date of the date range when order was created</param>
        /// <param name="uniqueUserId">User Id</param>
        /// <param name="partnerId">Partner Id</param>
        /// <param name="pageSize">How many items to return in reponse.</param>
        /// <param name="page">Page number, how many items to skip.</param>
        /// <returns>Task of SubmittedOrderList</returns>
        System.Threading.Tasks.Task<SubmittedOrderList> GETOrdersearchAsync (string genericValues = null, string lastName = null, string email = null, string postalCode = null, string startDate = null, string endDate = null, string uniqueUserId = null, int? partnerId = null, int? pageSize = null, int? page = null);

        /// <summary>
        /// Search an orders
        /// </summary>
        /// <remarks>
        /// Search through the orders and return information about orders that match search criteria.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="genericValues">Any value which is related to order (partner name, address, phone, couponCode, etc...)</param>
        /// <param name="lastName">Partner last name</param>
        /// <param name="email">Partner email</param>
        /// <param name="postalCode">Billing/Shipping address postal code</param>
        /// <param name="startDate">Start date of the date range when order was created</param>
        /// <param name="endDate">End date of the date range when order was created</param>
        /// <param name="uniqueUserId">User Id</param>
        /// <param name="partnerId">Partner Id</param>
        /// <param name="pageSize">How many items to return in reponse.</param>
        /// <param name="page">Page number, how many items to skip.</param>
        /// <returns>Task of ApiResponse (SubmittedOrderList)</returns>
        System.Threading.Tasks.Task<ApiResponse<SubmittedOrderList>> GETOrdersearchAsyncWithHttpInfo (string genericValues = null, string lastName = null, string email = null, string postalCode = null, string startDate = null, string endDate = null, string uniqueUserId = null, int? partnerId = null, int? pageSize = null, int? page = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrdersearchApi : IOrdersearchApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersearchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrdersearchApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersearchApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OrdersearchApi(Configuration configuration = null)
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
        /// Search an orders Search through the orders and return information about orders that match search criteria.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="genericValues">Any value which is related to order (partner name, address, phone, couponCode, etc...)</param> 
        /// <param name="lastName">Partner last name</param> 
        /// <param name="email">Partner email</param> 
        /// <param name="postalCode">Billing/Shipping address postal code</param> 
        /// <param name="startDate">Start date of the date range when order was created</param> 
        /// <param name="endDate">End date of the date range when order was created</param> 
        /// <param name="uniqueUserId">User Id</param> 
        /// <param name="partnerId">Partner Id</param> 
        /// <param name="pageSize">How many items to return in reponse.</param> 
        /// <param name="page">Page number, how many items to skip.</param> 
        /// <returns>SubmittedOrderList</returns>
        public SubmittedOrderList GETOrdersearch (string genericValues = null, string lastName = null, string email = null, string postalCode = null, string startDate = null, string endDate = null, string uniqueUserId = null, int? partnerId = null, int? pageSize = null, int? page = null)
        {
             ApiResponse<SubmittedOrderList> localVarResponse = GETOrdersearchWithHttpInfo(genericValues, lastName, email, postalCode, startDate, endDate, uniqueUserId, partnerId, pageSize, page);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search an orders Search through the orders and return information about orders that match search criteria.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="genericValues">Any value which is related to order (partner name, address, phone, couponCode, etc...)</param> 
        /// <param name="lastName">Partner last name</param> 
        /// <param name="email">Partner email</param> 
        /// <param name="postalCode">Billing/Shipping address postal code</param> 
        /// <param name="startDate">Start date of the date range when order was created</param> 
        /// <param name="endDate">End date of the date range when order was created</param> 
        /// <param name="uniqueUserId">User Id</param> 
        /// <param name="partnerId">Partner Id</param> 
        /// <param name="pageSize">How many items to return in reponse.</param> 
        /// <param name="page">Page number, how many items to skip.</param> 
        /// <returns>ApiResponse of SubmittedOrderList</returns>
        public ApiResponse< SubmittedOrderList > GETOrdersearchWithHttpInfo (string genericValues = null, string lastName = null, string email = null, string postalCode = null, string startDate = null, string endDate = null, string uniqueUserId = null, int? partnerId = null, int? pageSize = null, int? page = null)
        {
            
    
            var localVarPath = "/ordersearch/";
    
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
            
            if (genericValues != null) localVarQueryParams.Add("genericValues", Configuration.ApiClient.ParameterToString(genericValues)); // query parameter
            if (lastName != null) localVarQueryParams.Add("lastName", Configuration.ApiClient.ParameterToString(lastName)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (postalCode != null) localVarQueryParams.Add("postalCode", Configuration.ApiClient.ParameterToString(postalCode)); // query parameter
            if (startDate != null) localVarQueryParams.Add("startDate", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) localVarQueryParams.Add("endDate", Configuration.ApiClient.ParameterToString(endDate)); // query parameter
            if (uniqueUserId != null) localVarQueryParams.Add("uniqueUserId", Configuration.ApiClient.ParameterToString(uniqueUserId)); // query parameter
            if (partnerId != null) localVarQueryParams.Add("partnerId", Configuration.ApiClient.ParameterToString(partnerId)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GETOrdersearch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GETOrdersearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<SubmittedOrderList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubmittedOrderList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SubmittedOrderList)));
            
        }

        
        /// <summary>
        /// Search an orders Search through the orders and return information about orders that match search criteria.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="genericValues">Any value which is related to order (partner name, address, phone, couponCode, etc...)</param>
        /// <param name="lastName">Partner last name</param>
        /// <param name="email">Partner email</param>
        /// <param name="postalCode">Billing/Shipping address postal code</param>
        /// <param name="startDate">Start date of the date range when order was created</param>
        /// <param name="endDate">End date of the date range when order was created</param>
        /// <param name="uniqueUserId">User Id</param>
        /// <param name="partnerId">Partner Id</param>
        /// <param name="pageSize">How many items to return in reponse.</param>
        /// <param name="page">Page number, how many items to skip.</param>
        /// <returns>Task of SubmittedOrderList</returns>
        public async System.Threading.Tasks.Task<SubmittedOrderList> GETOrdersearchAsync (string genericValues = null, string lastName = null, string email = null, string postalCode = null, string startDate = null, string endDate = null, string uniqueUserId = null, int? partnerId = null, int? pageSize = null, int? page = null)
        {
             ApiResponse<SubmittedOrderList> localVarResponse = await GETOrdersearchAsyncWithHttpInfo(genericValues, lastName, email, postalCode, startDate, endDate, uniqueUserId, partnerId, pageSize, page);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search an orders Search through the orders and return information about orders that match search criteria.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="genericValues">Any value which is related to order (partner name, address, phone, couponCode, etc...)</param>
        /// <param name="lastName">Partner last name</param>
        /// <param name="email">Partner email</param>
        /// <param name="postalCode">Billing/Shipping address postal code</param>
        /// <param name="startDate">Start date of the date range when order was created</param>
        /// <param name="endDate">End date of the date range when order was created</param>
        /// <param name="uniqueUserId">User Id</param>
        /// <param name="partnerId">Partner Id</param>
        /// <param name="pageSize">How many items to return in reponse.</param>
        /// <param name="page">Page number, how many items to skip.</param>
        /// <returns>Task of ApiResponse (SubmittedOrderList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SubmittedOrderList>> GETOrdersearchAsyncWithHttpInfo (string genericValues = null, string lastName = null, string email = null, string postalCode = null, string startDate = null, string endDate = null, string uniqueUserId = null, int? partnerId = null, int? pageSize = null, int? page = null)
        {
            
    
            var localVarPath = "/ordersearch/";
    
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
            
            if (genericValues != null) localVarQueryParams.Add("genericValues", Configuration.ApiClient.ParameterToString(genericValues)); // query parameter
            if (lastName != null) localVarQueryParams.Add("lastName", Configuration.ApiClient.ParameterToString(lastName)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (postalCode != null) localVarQueryParams.Add("postalCode", Configuration.ApiClient.ParameterToString(postalCode)); // query parameter
            if (startDate != null) localVarQueryParams.Add("startDate", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) localVarQueryParams.Add("endDate", Configuration.ApiClient.ParameterToString(endDate)); // query parameter
            if (uniqueUserId != null) localVarQueryParams.Add("uniqueUserId", Configuration.ApiClient.ParameterToString(uniqueUserId)); // query parameter
            if (partnerId != null) localVarQueryParams.Add("partnerId", Configuration.ApiClient.ParameterToString(partnerId)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GETOrdersearch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GETOrdersearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SubmittedOrderList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubmittedOrderList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SubmittedOrderList)));
            
        }
        
    }
    
}

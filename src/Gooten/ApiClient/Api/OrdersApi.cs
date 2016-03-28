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
    public interface IOrdersApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Get an order
        /// </summary>
        /// <remarks>
        /// Gets basic information about an order.
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Order Id</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <param name="languageCode">Resultant info language. Defaults to &#39;en&#39;.</param>
        /// <returns>PostSubmittedOrder</returns>
        PostSubmittedOrder GETOrders (string id, int? version, string source, string languageCode = null);
  
        /// <summary>
        /// Get an order
        /// </summary>
        /// <remarks>
        /// Gets basic information about an order.
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Order Id</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <param name="languageCode">Resultant info language. Defaults to &#39;en&#39;.</param>
        /// <returns>ApiResponse of PostSubmittedOrder</returns>
        ApiResponse<PostSubmittedOrder> GETOrdersWithHttpInfo (string id, int? version, string source, string languageCode = null);
        
        /// <summary>
        /// Submit an order
        /// </summary>
        /// <remarks>
        /// Places an order into the system. An order can be submitted as PrePayment (in order to temporarily place an order and get an ID for Paypal) using the IsPreSubmit flag.
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="order">Order to be submitted</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <returns>OrderResult</returns>
        OrderResult POSTOrders (PostOrder order, int? version, string source);
  
        /// <summary>
        /// Submit an order
        /// </summary>
        /// <remarks>
        /// Places an order into the system. An order can be submitted as PrePayment (in order to temporarily place an order and get an ID for Paypal) using the IsPreSubmit flag.
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="order">Order to be submitted</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <returns>ApiResponse of OrderResult</returns>
        ApiResponse<OrderResult> POSTOrdersWithHttpInfo (PostOrder order, int? version, string source);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Get an order
        /// </summary>
        /// <remarks>
        /// Gets basic information about an order.
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Order Id</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <param name="languageCode">Resultant info language. Defaults to &#39;en&#39;.</param>
        /// <returns>Task of PostSubmittedOrder</returns>
        System.Threading.Tasks.Task<PostSubmittedOrder> GETOrdersAsync (string id, int? version, string source, string languageCode = null);

        /// <summary>
        /// Get an order
        /// </summary>
        /// <remarks>
        /// Gets basic information about an order.
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Order Id</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <param name="languageCode">Resultant info language. Defaults to &#39;en&#39;.</param>
        /// <returns>Task of ApiResponse (PostSubmittedOrder)</returns>
        System.Threading.Tasks.Task<ApiResponse<PostSubmittedOrder>> GETOrdersAsyncWithHttpInfo (string id, int? version, string source, string languageCode = null);
        
        /// <summary>
        /// Submit an order
        /// </summary>
        /// <remarks>
        /// Places an order into the system. An order can be submitted as PrePayment (in order to temporarily place an order and get an ID for Paypal) using the IsPreSubmit flag.
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="order">Order to be submitted</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <returns>Task of OrderResult</returns>
        System.Threading.Tasks.Task<OrderResult> POSTOrdersAsync (PostOrder order, int? version, string source);

        /// <summary>
        /// Submit an order
        /// </summary>
        /// <remarks>
        /// Places an order into the system. An order can be submitted as PrePayment (in order to temporarily place an order and get an ID for Paypal) using the IsPreSubmit flag.
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="order">Order to be submitted</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <returns>Task of ApiResponse (OrderResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrderResult>> POSTOrdersAsyncWithHttpInfo (PostOrder order, int? version, string source);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrdersApi : IOrdersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrdersApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OrdersApi(Configuration configuration = null)
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
        /// Get an order Gets basic information about an order.
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Order Id</param> 
        /// <param name="version">Version of the api being used</param> 
        /// <param name="source">Description of the source-- ios, android, api</param> 
        /// <param name="languageCode">Resultant info language. Defaults to &#39;en&#39;.</param> 
        /// <returns>PostSubmittedOrder</returns>
        public PostSubmittedOrder GETOrders (string id, int? version, string source, string languageCode = null)
        {
             ApiResponse<PostSubmittedOrder> localVarResponse = GETOrdersWithHttpInfo(id, version, source, languageCode);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an order Gets basic information about an order.
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Order Id</param> 
        /// <param name="version">Version of the api being used</param> 
        /// <param name="source">Description of the source-- ios, android, api</param> 
        /// <param name="languageCode">Resultant info language. Defaults to &#39;en&#39;.</param> 
        /// <returns>ApiResponse of PostSubmittedOrder</returns>
        public ApiResponse< PostSubmittedOrder > GETOrdersWithHttpInfo (string id, int? version, string source, string languageCode = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OrdersApi->GETOrders");
            
            // verify the required parameter 'version' is set
            if (version == null)
                throw new ApiException(400, "Missing required parameter 'version' when calling OrdersApi->GETOrders");
            
            // verify the required parameter 'source' is set
            if (source == null)
                throw new ApiException(400, "Missing required parameter 'source' when calling OrdersApi->GETOrders");
            
    
            var localVarPath = "/v/{version}/source/{source}/orders/";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (languageCode != null) localVarQueryParams.Add("languageCode", Configuration.ApiClient.ParameterToString(languageCode)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GETOrders: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GETOrders: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PostSubmittedOrder>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PostSubmittedOrder) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PostSubmittedOrder)));
            
        }

        
        /// <summary>
        /// Get an order Gets basic information about an order.
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Order Id</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <param name="languageCode">Resultant info language. Defaults to &#39;en&#39;.</param>
        /// <returns>Task of PostSubmittedOrder</returns>
        public async System.Threading.Tasks.Task<PostSubmittedOrder> GETOrdersAsync (string id, int? version, string source, string languageCode = null)
        {
             ApiResponse<PostSubmittedOrder> localVarResponse = await GETOrdersAsyncWithHttpInfo(id, version, source, languageCode);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an order Gets basic information about an order.
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Order Id</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <param name="languageCode">Resultant info language. Defaults to &#39;en&#39;.</param>
        /// <returns>Task of ApiResponse (PostSubmittedOrder)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PostSubmittedOrder>> GETOrdersAsyncWithHttpInfo (string id, int? version, string source, string languageCode = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GETOrders");
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling GETOrders");
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling GETOrders");
            
    
            var localVarPath = "/v/{version}/source/{source}/orders/";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (languageCode != null) localVarQueryParams.Add("languageCode", Configuration.ApiClient.ParameterToString(languageCode)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GETOrders: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GETOrders: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PostSubmittedOrder>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PostSubmittedOrder) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PostSubmittedOrder)));
            
        }
        
        /// <summary>
        /// Submit an order Places an order into the system. An order can be submitted as PrePayment (in order to temporarily place an order and get an ID for Paypal) using the IsPreSubmit flag.
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="order">Order to be submitted</param> 
        /// <param name="version">Version of the api being used</param> 
        /// <param name="source">Description of the source-- ios, android, api</param> 
        /// <returns>OrderResult</returns>
        public OrderResult POSTOrders (PostOrder order, int? version, string source)
        {
             ApiResponse<OrderResult> localVarResponse = POSTOrdersWithHttpInfo(order, version, source);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Submit an order Places an order into the system. An order can be submitted as PrePayment (in order to temporarily place an order and get an ID for Paypal) using the IsPreSubmit flag.
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="order">Order to be submitted</param> 
        /// <param name="version">Version of the api being used</param> 
        /// <param name="source">Description of the source-- ios, android, api</param> 
        /// <returns>ApiResponse of OrderResult</returns>
        public ApiResponse< OrderResult > POSTOrdersWithHttpInfo (PostOrder order, int? version, string source)
        {
            
            // verify the required parameter 'order' is set
            if (order == null)
                throw new ApiException(400, "Missing required parameter 'order' when calling OrdersApi->POSTOrders");
            
            // verify the required parameter 'version' is set
            if (version == null)
                throw new ApiException(400, "Missing required parameter 'version' when calling OrdersApi->POSTOrders");
            
            // verify the required parameter 'source' is set
            if (source == null)
                throw new ApiException(400, "Missing required parameter 'source' when calling OrdersApi->POSTOrders");
            
    
            var localVarPath = "/v/{version}/source/{source}/orders/";
    
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
                throw new ApiException (localVarStatusCode, "Error calling POSTOrders: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling POSTOrders: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OrderResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrderResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderResult)));
            
        }

        
        /// <summary>
        /// Submit an order Places an order into the system. An order can be submitted as PrePayment (in order to temporarily place an order and get an ID for Paypal) using the IsPreSubmit flag.
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="order">Order to be submitted</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <returns>Task of OrderResult</returns>
        public async System.Threading.Tasks.Task<OrderResult> POSTOrdersAsync (PostOrder order, int? version, string source)
        {
             ApiResponse<OrderResult> localVarResponse = await POSTOrdersAsyncWithHttpInfo(order, version, source);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Submit an order Places an order into the system. An order can be submitted as PrePayment (in order to temporarily place an order and get an ID for Paypal) using the IsPreSubmit flag.
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="order">Order to be submitted</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <returns>Task of ApiResponse (OrderResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrderResult>> POSTOrdersAsyncWithHttpInfo (PostOrder order, int? version, string source)
        {
            // verify the required parameter 'order' is set
            if (order == null) throw new ApiException(400, "Missing required parameter 'order' when calling POSTOrders");
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling POSTOrders");
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling POSTOrders");
            
    
            var localVarPath = "/v/{version}/source/{source}/orders/";
    
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
                throw new ApiException (localVarStatusCode, "Error calling POSTOrders: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling POSTOrders: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrderResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrderResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderResult)));
            
        }
        
    }
    
}

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
    public interface IPaymentvalidationApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Submit payment validation for PayPal
        /// </summary>
        /// <remarks>
        /// Submit payment validation for PayPal
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">Order Id returned from orders/POST</param>
        /// <param name="payPalKey">The PayPal key returned from the Mobile SDK</param>
        /// <returns>PaymentValidationResponse</returns>
        PaymentValidationResponse Paymentvalidation (string orderId, string payPalKey);
  
        /// <summary>
        /// Submit payment validation for PayPal
        /// </summary>
        /// <remarks>
        /// Submit payment validation for PayPal
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">Order Id returned from orders/POST</param>
        /// <param name="payPalKey">The PayPal key returned from the Mobile SDK</param>
        /// <returns>ApiResponse of PaymentValidationResponse</returns>
        ApiResponse<PaymentValidationResponse> PaymentvalidationWithHttpInfo (string orderId, string payPalKey);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Submit payment validation for PayPal
        /// </summary>
        /// <remarks>
        /// Submit payment validation for PayPal
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">Order Id returned from orders/POST</param>
        /// <param name="payPalKey">The PayPal key returned from the Mobile SDK</param>
        /// <returns>Task of PaymentValidationResponse</returns>
        System.Threading.Tasks.Task<PaymentValidationResponse> PaymentvalidationAsync (string orderId, string payPalKey);

        /// <summary>
        /// Submit payment validation for PayPal
        /// </summary>
        /// <remarks>
        /// Submit payment validation for PayPal
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">Order Id returned from orders/POST</param>
        /// <param name="payPalKey">The PayPal key returned from the Mobile SDK</param>
        /// <returns>Task of ApiResponse (PaymentValidationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PaymentValidationResponse>> PaymentvalidationAsyncWithHttpInfo (string orderId, string payPalKey);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PaymentvalidationApi : IPaymentvalidationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentvalidationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PaymentvalidationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentvalidationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PaymentvalidationApi(Configuration configuration = null)
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
        /// Submit payment validation for PayPal Submit payment validation for PayPal
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">Order Id returned from orders/POST</param> 
        /// <param name="payPalKey">The PayPal key returned from the Mobile SDK</param> 
        /// <returns>PaymentValidationResponse</returns>
        public PaymentValidationResponse Paymentvalidation (string orderId, string payPalKey)
        {
             ApiResponse<PaymentValidationResponse> localVarResponse = PaymentvalidationWithHttpInfo(orderId, payPalKey);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Submit payment validation for PayPal Submit payment validation for PayPal
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">Order Id returned from orders/POST</param> 
        /// <param name="payPalKey">The PayPal key returned from the Mobile SDK</param> 
        /// <returns>ApiResponse of PaymentValidationResponse</returns>
        public ApiResponse< PaymentValidationResponse > PaymentvalidationWithHttpInfo (string orderId, string payPalKey)
        {
            
            // verify the required parameter 'orderId' is set
            if (orderId == null)
                throw new ApiException(400, "Missing required parameter 'orderId' when calling PaymentvalidationApi->Paymentvalidation");
            
            // verify the required parameter 'payPalKey' is set
            if (payPalKey == null)
                throw new ApiException(400, "Missing required parameter 'payPalKey' when calling PaymentvalidationApi->Paymentvalidation");
            
    
            var localVarPath = "/paymentvalidation/";
    
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
            
            if (orderId != null) localVarQueryParams.Add("OrderId", Configuration.ApiClient.ParameterToString(orderId)); // query parameter
            if (payPalKey != null) localVarQueryParams.Add("PayPalKey", Configuration.ApiClient.ParameterToString(payPalKey)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Paymentvalidation: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Paymentvalidation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PaymentValidationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PaymentValidationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaymentValidationResponse)));
            
        }

        
        /// <summary>
        /// Submit payment validation for PayPal Submit payment validation for PayPal
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">Order Id returned from orders/POST</param>
        /// <param name="payPalKey">The PayPal key returned from the Mobile SDK</param>
        /// <returns>Task of PaymentValidationResponse</returns>
        public async System.Threading.Tasks.Task<PaymentValidationResponse> PaymentvalidationAsync (string orderId, string payPalKey)
        {
             ApiResponse<PaymentValidationResponse> localVarResponse = await PaymentvalidationAsyncWithHttpInfo(orderId, payPalKey);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Submit payment validation for PayPal Submit payment validation for PayPal
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">Order Id returned from orders/POST</param>
        /// <param name="payPalKey">The PayPal key returned from the Mobile SDK</param>
        /// <returns>Task of ApiResponse (PaymentValidationResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PaymentValidationResponse>> PaymentvalidationAsyncWithHttpInfo (string orderId, string payPalKey)
        {
            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling Paymentvalidation");
            // verify the required parameter 'payPalKey' is set
            if (payPalKey == null) throw new ApiException(400, "Missing required parameter 'payPalKey' when calling Paymentvalidation");
            
    
            var localVarPath = "/paymentvalidation/";
    
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
            
            if (orderId != null) localVarQueryParams.Add("OrderId", Configuration.ApiClient.ParameterToString(orderId)); // query parameter
            if (payPalKey != null) localVarQueryParams.Add("PayPalKey", Configuration.ApiClient.ParameterToString(payPalKey)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Paymentvalidation: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Paymentvalidation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PaymentValidationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PaymentValidationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaymentValidationResponse)));
            
        }
        
    }
    
}

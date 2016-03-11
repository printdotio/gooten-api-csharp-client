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
    public interface IProducttemplatesApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Get a list of product templates
        /// </summary>
        /// <remarks>
        /// Get a list of product templates.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sku">Productvariant sku.</param>
        /// <param name="languageCode">Two-character language code, defaults to \&quot;en\&quot; (english)</param>
        /// <returns>ProductBuildInfoResponse</returns>
        ProductBuildInfoResponse GetProducttemplates (string sku, string languageCode = null);
  
        /// <summary>
        /// Get a list of product templates
        /// </summary>
        /// <remarks>
        /// Get a list of product templates.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sku">Productvariant sku.</param>
        /// <param name="languageCode">Two-character language code, defaults to \&quot;en\&quot; (english)</param>
        /// <returns>ApiResponse of ProductBuildInfoResponse</returns>
        ApiResponse<ProductBuildInfoResponse> GetProducttemplatesWithHttpInfo (string sku, string languageCode = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Get a list of product templates
        /// </summary>
        /// <remarks>
        /// Get a list of product templates.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sku">Productvariant sku.</param>
        /// <param name="languageCode">Two-character language code, defaults to \&quot;en\&quot; (english)</param>
        /// <returns>Task of ProductBuildInfoResponse</returns>
        System.Threading.Tasks.Task<ProductBuildInfoResponse> GetProducttemplatesAsync (string sku, string languageCode = null);

        /// <summary>
        /// Get a list of product templates
        /// </summary>
        /// <remarks>
        /// Get a list of product templates.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sku">Productvariant sku.</param>
        /// <param name="languageCode">Two-character language code, defaults to \&quot;en\&quot; (english)</param>
        /// <returns>Task of ApiResponse (ProductBuildInfoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductBuildInfoResponse>> GetProducttemplatesAsyncWithHttpInfo (string sku, string languageCode = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ProducttemplatesApi : IProducttemplatesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProducttemplatesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProducttemplatesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProducttemplatesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProducttemplatesApi(Configuration configuration = null)
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
        /// Get a list of product templates Get a list of product templates.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sku">Productvariant sku.</param> 
        /// <param name="languageCode">Two-character language code, defaults to \&quot;en\&quot; (english)</param> 
        /// <returns>ProductBuildInfoResponse</returns>
        public ProductBuildInfoResponse GetProducttemplates (string sku, string languageCode = null)
        {
             ApiResponse<ProductBuildInfoResponse> localVarResponse = GetProducttemplatesWithHttpInfo(sku, languageCode);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of product templates Get a list of product templates.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sku">Productvariant sku.</param> 
        /// <param name="languageCode">Two-character language code, defaults to \&quot;en\&quot; (english)</param> 
        /// <returns>ApiResponse of ProductBuildInfoResponse</returns>
        public ApiResponse< ProductBuildInfoResponse > GetProducttemplatesWithHttpInfo (string sku, string languageCode = null)
        {
            
            // verify the required parameter 'sku' is set
            if (sku == null)
                throw new ApiException(400, "Missing required parameter 'sku' when calling ProducttemplatesApi->GetProducttemplates");
            
    
            var localVarPath = "/producttemplates/";
    
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
            
            if (sku != null) localVarQueryParams.Add("sku", Configuration.ApiClient.ParameterToString(sku)); // query parameter
            if (languageCode != null) localVarQueryParams.Add("languageCode", Configuration.ApiClient.ParameterToString(languageCode)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetProducttemplates: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProducttemplates: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ProductBuildInfoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProductBuildInfoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductBuildInfoResponse)));
            
        }

        
        /// <summary>
        /// Get a list of product templates Get a list of product templates.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sku">Productvariant sku.</param>
        /// <param name="languageCode">Two-character language code, defaults to \&quot;en\&quot; (english)</param>
        /// <returns>Task of ProductBuildInfoResponse</returns>
        public async System.Threading.Tasks.Task<ProductBuildInfoResponse> GetProducttemplatesAsync (string sku, string languageCode = null)
        {
             ApiResponse<ProductBuildInfoResponse> localVarResponse = await GetProducttemplatesAsyncWithHttpInfo(sku, languageCode);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of product templates Get a list of product templates.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sku">Productvariant sku.</param>
        /// <param name="languageCode">Two-character language code, defaults to \&quot;en\&quot; (english)</param>
        /// <returns>Task of ApiResponse (ProductBuildInfoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductBuildInfoResponse>> GetProducttemplatesAsyncWithHttpInfo (string sku, string languageCode = null)
        {
            // verify the required parameter 'sku' is set
            if (sku == null) throw new ApiException(400, "Missing required parameter 'sku' when calling GetProducttemplates");
            
    
            var localVarPath = "/producttemplates/";
    
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
            
            if (sku != null) localVarQueryParams.Add("sku", Configuration.ApiClient.ParameterToString(sku)); // query parameter
            if (languageCode != null) localVarQueryParams.Add("languageCode", Configuration.ApiClient.ParameterToString(languageCode)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetProducttemplates: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProducttemplates: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProductBuildInfoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProductBuildInfoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductBuildInfoResponse)));
            
        }
        
    }
    
}

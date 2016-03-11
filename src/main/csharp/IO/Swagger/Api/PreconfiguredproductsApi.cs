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
    public interface IPreconfiguredproductsApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Insert a preconfigured product
        /// </summary>
        /// <remarks>
        /// Insert a preconfigured product into your recipe.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="preconfiguredProductInsert">The product to be inserted</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <returns>PreconfiguredProductsInsertResponse</returns>
        PreconfiguredProductsInsertResponse CreatePreconfiguredproducts (PreconfiguredProductInsert preconfiguredProductInsert, int? version, string source);
  
        /// <summary>
        /// Insert a preconfigured product
        /// </summary>
        /// <remarks>
        /// Insert a preconfigured product into your recipe.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="preconfiguredProductInsert">The product to be inserted</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <returns>ApiResponse of PreconfiguredProductsInsertResponse</returns>
        ApiResponse<PreconfiguredProductsInsertResponse> CreatePreconfiguredproductsWithHttpInfo (PreconfiguredProductInsert preconfiguredProductInsert, int? version, string source);
        
        /// <summary>
        /// Delete a preconfigured product
        /// </summary>
        /// <remarks>
        /// Delete a preconfigured product from your recipe.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <param name="sku">The preconfigured product&#39;s sku.</param>
        /// <returns>PreconfiguredProductsInsertResponse</returns>
        PreconfiguredProductsInsertResponse DeletePreconfiguredproducts (int? version, string source, string sku = null);
  
        /// <summary>
        /// Delete a preconfigured product
        /// </summary>
        /// <remarks>
        /// Delete a preconfigured product from your recipe.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <param name="sku">The preconfigured product&#39;s sku.</param>
        /// <returns>ApiResponse of PreconfiguredProductsInsertResponse</returns>
        ApiResponse<PreconfiguredProductsInsertResponse> DeletePreconfiguredproductsWithHttpInfo (int? version, string source, string sku = null);
        
        /// <summary>
        /// Get a list of your preconfigured products
        /// </summary>
        /// <remarks>
        /// Get a list of your preconfigured products. The products returned are entirely specific to your recipe.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryCode">The country code where it would be shipped to. For example, &#39;US&#39; or &#39;CA&#39;</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <param name="languageCode">Two-character language code, defaults to \&quot;en\&quot; (english)</param>
        /// <param name="currencyCode">Three character currency code, defaults to \&quot;USD\&quot; (united states dollar)</param>
        /// <returns>PreconfiguredProductsResponse</returns>
        PreconfiguredProductsResponse GetPreconfiguredproducts (string countryCode, int? version, string source, string languageCode = null, string currencyCode = null);
  
        /// <summary>
        /// Get a list of your preconfigured products
        /// </summary>
        /// <remarks>
        /// Get a list of your preconfigured products. The products returned are entirely specific to your recipe.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryCode">The country code where it would be shipped to. For example, &#39;US&#39; or &#39;CA&#39;</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <param name="languageCode">Two-character language code, defaults to \&quot;en\&quot; (english)</param>
        /// <param name="currencyCode">Three character currency code, defaults to \&quot;USD\&quot; (united states dollar)</param>
        /// <returns>ApiResponse of PreconfiguredProductsResponse</returns>
        ApiResponse<PreconfiguredProductsResponse> GetPreconfiguredproductsWithHttpInfo (string countryCode, int? version, string source, string languageCode = null, string currencyCode = null);
        
        /// <summary>
        /// Update a preconfigured product
        /// </summary>
        /// <remarks>
        /// Update a preconfigured product into your recipe.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="preconfiguredProductInsert">The product to be inserted</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <returns>PreconfiguredProductsInsertResponse</returns>
        PreconfiguredProductsInsertResponse UpdatePreconfiguredproducts (PreconfiguredProductInsert preconfiguredProductInsert, int? version, string source);
  
        /// <summary>
        /// Update a preconfigured product
        /// </summary>
        /// <remarks>
        /// Update a preconfigured product into your recipe.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="preconfiguredProductInsert">The product to be inserted</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <returns>ApiResponse of PreconfiguredProductsInsertResponse</returns>
        ApiResponse<PreconfiguredProductsInsertResponse> UpdatePreconfiguredproductsWithHttpInfo (PreconfiguredProductInsert preconfiguredProductInsert, int? version, string source);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Insert a preconfigured product
        /// </summary>
        /// <remarks>
        /// Insert a preconfigured product into your recipe.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="preconfiguredProductInsert">The product to be inserted</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <returns>Task of PreconfiguredProductsInsertResponse</returns>
        System.Threading.Tasks.Task<PreconfiguredProductsInsertResponse> CreatePreconfiguredproductsAsync (PreconfiguredProductInsert preconfiguredProductInsert, int? version, string source);

        /// <summary>
        /// Insert a preconfigured product
        /// </summary>
        /// <remarks>
        /// Insert a preconfigured product into your recipe.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="preconfiguredProductInsert">The product to be inserted</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <returns>Task of ApiResponse (PreconfiguredProductsInsertResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PreconfiguredProductsInsertResponse>> CreatePreconfiguredproductsAsyncWithHttpInfo (PreconfiguredProductInsert preconfiguredProductInsert, int? version, string source);
        
        /// <summary>
        /// Delete a preconfigured product
        /// </summary>
        /// <remarks>
        /// Delete a preconfigured product from your recipe.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <param name="sku">The preconfigured product&#39;s sku.</param>
        /// <returns>Task of PreconfiguredProductsInsertResponse</returns>
        System.Threading.Tasks.Task<PreconfiguredProductsInsertResponse> DeletePreconfiguredproductsAsync (int? version, string source, string sku = null);

        /// <summary>
        /// Delete a preconfigured product
        /// </summary>
        /// <remarks>
        /// Delete a preconfigured product from your recipe.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <param name="sku">The preconfigured product&#39;s sku.</param>
        /// <returns>Task of ApiResponse (PreconfiguredProductsInsertResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PreconfiguredProductsInsertResponse>> DeletePreconfiguredproductsAsyncWithHttpInfo (int? version, string source, string sku = null);
        
        /// <summary>
        /// Get a list of your preconfigured products
        /// </summary>
        /// <remarks>
        /// Get a list of your preconfigured products. The products returned are entirely specific to your recipe.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryCode">The country code where it would be shipped to. For example, &#39;US&#39; or &#39;CA&#39;</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <param name="languageCode">Two-character language code, defaults to \&quot;en\&quot; (english)</param>
        /// <param name="currencyCode">Three character currency code, defaults to \&quot;USD\&quot; (united states dollar)</param>
        /// <returns>Task of PreconfiguredProductsResponse</returns>
        System.Threading.Tasks.Task<PreconfiguredProductsResponse> GetPreconfiguredproductsAsync (string countryCode, int? version, string source, string languageCode = null, string currencyCode = null);

        /// <summary>
        /// Get a list of your preconfigured products
        /// </summary>
        /// <remarks>
        /// Get a list of your preconfigured products. The products returned are entirely specific to your recipe.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryCode">The country code where it would be shipped to. For example, &#39;US&#39; or &#39;CA&#39;</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <param name="languageCode">Two-character language code, defaults to \&quot;en\&quot; (english)</param>
        /// <param name="currencyCode">Three character currency code, defaults to \&quot;USD\&quot; (united states dollar)</param>
        /// <returns>Task of ApiResponse (PreconfiguredProductsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PreconfiguredProductsResponse>> GetPreconfiguredproductsAsyncWithHttpInfo (string countryCode, int? version, string source, string languageCode = null, string currencyCode = null);
        
        /// <summary>
        /// Update a preconfigured product
        /// </summary>
        /// <remarks>
        /// Update a preconfigured product into your recipe.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="preconfiguredProductInsert">The product to be inserted</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <returns>Task of PreconfiguredProductsInsertResponse</returns>
        System.Threading.Tasks.Task<PreconfiguredProductsInsertResponse> UpdatePreconfiguredproductsAsync (PreconfiguredProductInsert preconfiguredProductInsert, int? version, string source);

        /// <summary>
        /// Update a preconfigured product
        /// </summary>
        /// <remarks>
        /// Update a preconfigured product into your recipe.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="preconfiguredProductInsert">The product to be inserted</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <returns>Task of ApiResponse (PreconfiguredProductsInsertResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PreconfiguredProductsInsertResponse>> UpdatePreconfiguredproductsAsyncWithHttpInfo (PreconfiguredProductInsert preconfiguredProductInsert, int? version, string source);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PreconfiguredproductsApi : IPreconfiguredproductsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PreconfiguredproductsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PreconfiguredproductsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PreconfiguredproductsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PreconfiguredproductsApi(Configuration configuration = null)
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
        /// Insert a preconfigured product Insert a preconfigured product into your recipe.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="preconfiguredProductInsert">The product to be inserted</param> 
        /// <param name="version">Version of the api being used</param> 
        /// <param name="source">Description of the source-- ios, android, api</param> 
        /// <returns>PreconfiguredProductsInsertResponse</returns>
        public PreconfiguredProductsInsertResponse CreatePreconfiguredproducts (PreconfiguredProductInsert preconfiguredProductInsert, int? version, string source)
        {
             ApiResponse<PreconfiguredProductsInsertResponse> localVarResponse = CreatePreconfiguredproductsWithHttpInfo(preconfiguredProductInsert, version, source);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Insert a preconfigured product Insert a preconfigured product into your recipe.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="preconfiguredProductInsert">The product to be inserted</param> 
        /// <param name="version">Version of the api being used</param> 
        /// <param name="source">Description of the source-- ios, android, api</param> 
        /// <returns>ApiResponse of PreconfiguredProductsInsertResponse</returns>
        public ApiResponse< PreconfiguredProductsInsertResponse > CreatePreconfiguredproductsWithHttpInfo (PreconfiguredProductInsert preconfiguredProductInsert, int? version, string source)
        {
            
            // verify the required parameter 'preconfiguredProductInsert' is set
            if (preconfiguredProductInsert == null)
                throw new ApiException(400, "Missing required parameter 'preconfiguredProductInsert' when calling PreconfiguredproductsApi->CreatePreconfiguredproducts");
            
            // verify the required parameter 'version' is set
            if (version == null)
                throw new ApiException(400, "Missing required parameter 'version' when calling PreconfiguredproductsApi->CreatePreconfiguredproducts");
            
            // verify the required parameter 'source' is set
            if (source == null)
                throw new ApiException(400, "Missing required parameter 'source' when calling PreconfiguredproductsApi->CreatePreconfiguredproducts");
            
    
            var localVarPath = "/preconfiguredproducts/v/{version}/source/{source}/";
    
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
            
            
            
            
            if (preconfiguredProductInsert.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(preconfiguredProductInsert); // http body (model) parameter
            }
            else
            {
                localVarPostBody = preconfiguredProductInsert; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CreatePreconfiguredproducts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreatePreconfiguredproducts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PreconfiguredProductsInsertResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PreconfiguredProductsInsertResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PreconfiguredProductsInsertResponse)));
            
        }

        
        /// <summary>
        /// Insert a preconfigured product Insert a preconfigured product into your recipe.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="preconfiguredProductInsert">The product to be inserted</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <returns>Task of PreconfiguredProductsInsertResponse</returns>
        public async System.Threading.Tasks.Task<PreconfiguredProductsInsertResponse> CreatePreconfiguredproductsAsync (PreconfiguredProductInsert preconfiguredProductInsert, int? version, string source)
        {
             ApiResponse<PreconfiguredProductsInsertResponse> localVarResponse = await CreatePreconfiguredproductsAsyncWithHttpInfo(preconfiguredProductInsert, version, source);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Insert a preconfigured product Insert a preconfigured product into your recipe.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="preconfiguredProductInsert">The product to be inserted</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <returns>Task of ApiResponse (PreconfiguredProductsInsertResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PreconfiguredProductsInsertResponse>> CreatePreconfiguredproductsAsyncWithHttpInfo (PreconfiguredProductInsert preconfiguredProductInsert, int? version, string source)
        {
            // verify the required parameter 'preconfiguredProductInsert' is set
            if (preconfiguredProductInsert == null) throw new ApiException(400, "Missing required parameter 'preconfiguredProductInsert' when calling CreatePreconfiguredproducts");
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling CreatePreconfiguredproducts");
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling CreatePreconfiguredproducts");
            
    
            var localVarPath = "/preconfiguredproducts/v/{version}/source/{source}/";
    
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
            
            
            
            
            if (preconfiguredProductInsert.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(preconfiguredProductInsert); // http body (model) parameter
            }
            else
            {
                localVarPostBody = preconfiguredProductInsert; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CreatePreconfiguredproducts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreatePreconfiguredproducts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PreconfiguredProductsInsertResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PreconfiguredProductsInsertResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PreconfiguredProductsInsertResponse)));
            
        }
        
        /// <summary>
        /// Delete a preconfigured product Delete a preconfigured product from your recipe.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Version of the api being used</param> 
        /// <param name="source">Description of the source-- ios, android, api</param> 
        /// <param name="sku">The preconfigured product&#39;s sku.</param> 
        /// <returns>PreconfiguredProductsInsertResponse</returns>
        public PreconfiguredProductsInsertResponse DeletePreconfiguredproducts (int? version, string source, string sku = null)
        {
             ApiResponse<PreconfiguredProductsInsertResponse> localVarResponse = DeletePreconfiguredproductsWithHttpInfo(version, source, sku);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a preconfigured product Delete a preconfigured product from your recipe.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Version of the api being used</param> 
        /// <param name="source">Description of the source-- ios, android, api</param> 
        /// <param name="sku">The preconfigured product&#39;s sku.</param> 
        /// <returns>ApiResponse of PreconfiguredProductsInsertResponse</returns>
        public ApiResponse< PreconfiguredProductsInsertResponse > DeletePreconfiguredproductsWithHttpInfo (int? version, string source, string sku = null)
        {
            
            // verify the required parameter 'version' is set
            if (version == null)
                throw new ApiException(400, "Missing required parameter 'version' when calling PreconfiguredproductsApi->DeletePreconfiguredproducts");
            
            // verify the required parameter 'source' is set
            if (source == null)
                throw new ApiException(400, "Missing required parameter 'source' when calling PreconfiguredproductsApi->DeletePreconfiguredproducts");
            
    
            var localVarPath = "/preconfiguredproducts/v/{version}/source/{source}/";
    
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
            
            if (sku != null) localVarQueryParams.Add("sku", Configuration.ApiClient.ParameterToString(sku)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeletePreconfiguredproducts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletePreconfiguredproducts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PreconfiguredProductsInsertResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PreconfiguredProductsInsertResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PreconfiguredProductsInsertResponse)));
            
        }

        
        /// <summary>
        /// Delete a preconfigured product Delete a preconfigured product from your recipe.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <param name="sku">The preconfigured product&#39;s sku.</param>
        /// <returns>Task of PreconfiguredProductsInsertResponse</returns>
        public async System.Threading.Tasks.Task<PreconfiguredProductsInsertResponse> DeletePreconfiguredproductsAsync (int? version, string source, string sku = null)
        {
             ApiResponse<PreconfiguredProductsInsertResponse> localVarResponse = await DeletePreconfiguredproductsAsyncWithHttpInfo(version, source, sku);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a preconfigured product Delete a preconfigured product from your recipe.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <param name="sku">The preconfigured product&#39;s sku.</param>
        /// <returns>Task of ApiResponse (PreconfiguredProductsInsertResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PreconfiguredProductsInsertResponse>> DeletePreconfiguredproductsAsyncWithHttpInfo (int? version, string source, string sku = null)
        {
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling DeletePreconfiguredproducts");
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling DeletePreconfiguredproducts");
            
    
            var localVarPath = "/preconfiguredproducts/v/{version}/source/{source}/";
    
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
            
            if (sku != null) localVarQueryParams.Add("sku", Configuration.ApiClient.ParameterToString(sku)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeletePreconfiguredproducts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletePreconfiguredproducts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PreconfiguredProductsInsertResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PreconfiguredProductsInsertResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PreconfiguredProductsInsertResponse)));
            
        }
        
        /// <summary>
        /// Get a list of your preconfigured products Get a list of your preconfigured products. The products returned are entirely specific to your recipe.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryCode">The country code where it would be shipped to. For example, &#39;US&#39; or &#39;CA&#39;</param> 
        /// <param name="version">Version of the api being used</param> 
        /// <param name="source">Description of the source-- ios, android, api</param> 
        /// <param name="languageCode">Two-character language code, defaults to \&quot;en\&quot; (english)</param> 
        /// <param name="currencyCode">Three character currency code, defaults to \&quot;USD\&quot; (united states dollar)</param> 
        /// <returns>PreconfiguredProductsResponse</returns>
        public PreconfiguredProductsResponse GetPreconfiguredproducts (string countryCode, int? version, string source, string languageCode = null, string currencyCode = null)
        {
             ApiResponse<PreconfiguredProductsResponse> localVarResponse = GetPreconfiguredproductsWithHttpInfo(countryCode, version, source, languageCode, currencyCode);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of your preconfigured products Get a list of your preconfigured products. The products returned are entirely specific to your recipe.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryCode">The country code where it would be shipped to. For example, &#39;US&#39; or &#39;CA&#39;</param> 
        /// <param name="version">Version of the api being used</param> 
        /// <param name="source">Description of the source-- ios, android, api</param> 
        /// <param name="languageCode">Two-character language code, defaults to \&quot;en\&quot; (english)</param> 
        /// <param name="currencyCode">Three character currency code, defaults to \&quot;USD\&quot; (united states dollar)</param> 
        /// <returns>ApiResponse of PreconfiguredProductsResponse</returns>
        public ApiResponse< PreconfiguredProductsResponse > GetPreconfiguredproductsWithHttpInfo (string countryCode, int? version, string source, string languageCode = null, string currencyCode = null)
        {
            
            // verify the required parameter 'countryCode' is set
            if (countryCode == null)
                throw new ApiException(400, "Missing required parameter 'countryCode' when calling PreconfiguredproductsApi->GetPreconfiguredproducts");
            
            // verify the required parameter 'version' is set
            if (version == null)
                throw new ApiException(400, "Missing required parameter 'version' when calling PreconfiguredproductsApi->GetPreconfiguredproducts");
            
            // verify the required parameter 'source' is set
            if (source == null)
                throw new ApiException(400, "Missing required parameter 'source' when calling PreconfiguredproductsApi->GetPreconfiguredproducts");
            
    
            var localVarPath = "/preconfiguredproducts/v/{version}/source/{source}/";
    
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
            if (languageCode != null) localVarQueryParams.Add("languageCode", Configuration.ApiClient.ParameterToString(languageCode)); // query parameter
            if (currencyCode != null) localVarQueryParams.Add("currencyCode", Configuration.ApiClient.ParameterToString(currencyCode)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetPreconfiguredproducts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPreconfiguredproducts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PreconfiguredProductsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PreconfiguredProductsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PreconfiguredProductsResponse)));
            
        }

        
        /// <summary>
        /// Get a list of your preconfigured products Get a list of your preconfigured products. The products returned are entirely specific to your recipe.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryCode">The country code where it would be shipped to. For example, &#39;US&#39; or &#39;CA&#39;</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <param name="languageCode">Two-character language code, defaults to \&quot;en\&quot; (english)</param>
        /// <param name="currencyCode">Three character currency code, defaults to \&quot;USD\&quot; (united states dollar)</param>
        /// <returns>Task of PreconfiguredProductsResponse</returns>
        public async System.Threading.Tasks.Task<PreconfiguredProductsResponse> GetPreconfiguredproductsAsync (string countryCode, int? version, string source, string languageCode = null, string currencyCode = null)
        {
             ApiResponse<PreconfiguredProductsResponse> localVarResponse = await GetPreconfiguredproductsAsyncWithHttpInfo(countryCode, version, source, languageCode, currencyCode);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of your preconfigured products Get a list of your preconfigured products. The products returned are entirely specific to your recipe.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryCode">The country code where it would be shipped to. For example, &#39;US&#39; or &#39;CA&#39;</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <param name="languageCode">Two-character language code, defaults to \&quot;en\&quot; (english)</param>
        /// <param name="currencyCode">Three character currency code, defaults to \&quot;USD\&quot; (united states dollar)</param>
        /// <returns>Task of ApiResponse (PreconfiguredProductsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PreconfiguredProductsResponse>> GetPreconfiguredproductsAsyncWithHttpInfo (string countryCode, int? version, string source, string languageCode = null, string currencyCode = null)
        {
            // verify the required parameter 'countryCode' is set
            if (countryCode == null) throw new ApiException(400, "Missing required parameter 'countryCode' when calling GetPreconfiguredproducts");
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling GetPreconfiguredproducts");
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling GetPreconfiguredproducts");
            
    
            var localVarPath = "/preconfiguredproducts/v/{version}/source/{source}/";
    
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
            if (languageCode != null) localVarQueryParams.Add("languageCode", Configuration.ApiClient.ParameterToString(languageCode)); // query parameter
            if (currencyCode != null) localVarQueryParams.Add("currencyCode", Configuration.ApiClient.ParameterToString(currencyCode)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetPreconfiguredproducts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPreconfiguredproducts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PreconfiguredProductsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PreconfiguredProductsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PreconfiguredProductsResponse)));
            
        }
        
        /// <summary>
        /// Update a preconfigured product Update a preconfigured product into your recipe.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="preconfiguredProductInsert">The product to be inserted</param> 
        /// <param name="version">Version of the api being used</param> 
        /// <param name="source">Description of the source-- ios, android, api</param> 
        /// <returns>PreconfiguredProductsInsertResponse</returns>
        public PreconfiguredProductsInsertResponse UpdatePreconfiguredproducts (PreconfiguredProductInsert preconfiguredProductInsert, int? version, string source)
        {
             ApiResponse<PreconfiguredProductsInsertResponse> localVarResponse = UpdatePreconfiguredproductsWithHttpInfo(preconfiguredProductInsert, version, source);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a preconfigured product Update a preconfigured product into your recipe.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="preconfiguredProductInsert">The product to be inserted</param> 
        /// <param name="version">Version of the api being used</param> 
        /// <param name="source">Description of the source-- ios, android, api</param> 
        /// <returns>ApiResponse of PreconfiguredProductsInsertResponse</returns>
        public ApiResponse< PreconfiguredProductsInsertResponse > UpdatePreconfiguredproductsWithHttpInfo (PreconfiguredProductInsert preconfiguredProductInsert, int? version, string source)
        {
            
            // verify the required parameter 'preconfiguredProductInsert' is set
            if (preconfiguredProductInsert == null)
                throw new ApiException(400, "Missing required parameter 'preconfiguredProductInsert' when calling PreconfiguredproductsApi->UpdatePreconfiguredproducts");
            
            // verify the required parameter 'version' is set
            if (version == null)
                throw new ApiException(400, "Missing required parameter 'version' when calling PreconfiguredproductsApi->UpdatePreconfiguredproducts");
            
            // verify the required parameter 'source' is set
            if (source == null)
                throw new ApiException(400, "Missing required parameter 'source' when calling PreconfiguredproductsApi->UpdatePreconfiguredproducts");
            
    
            var localVarPath = "/preconfiguredproducts/v/{version}/source/{source}/";
    
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
            
            
            
            
            if (preconfiguredProductInsert.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(preconfiguredProductInsert); // http body (model) parameter
            }
            else
            {
                localVarPostBody = preconfiguredProductInsert; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdatePreconfiguredproducts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdatePreconfiguredproducts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PreconfiguredProductsInsertResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PreconfiguredProductsInsertResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PreconfiguredProductsInsertResponse)));
            
        }

        
        /// <summary>
        /// Update a preconfigured product Update a preconfigured product into your recipe.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="preconfiguredProductInsert">The product to be inserted</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <returns>Task of PreconfiguredProductsInsertResponse</returns>
        public async System.Threading.Tasks.Task<PreconfiguredProductsInsertResponse> UpdatePreconfiguredproductsAsync (PreconfiguredProductInsert preconfiguredProductInsert, int? version, string source)
        {
             ApiResponse<PreconfiguredProductsInsertResponse> localVarResponse = await UpdatePreconfiguredproductsAsyncWithHttpInfo(preconfiguredProductInsert, version, source);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a preconfigured product Update a preconfigured product into your recipe.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="preconfiguredProductInsert">The product to be inserted</param>
        /// <param name="version">Version of the api being used</param>
        /// <param name="source">Description of the source-- ios, android, api</param>
        /// <returns>Task of ApiResponse (PreconfiguredProductsInsertResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PreconfiguredProductsInsertResponse>> UpdatePreconfiguredproductsAsyncWithHttpInfo (PreconfiguredProductInsert preconfiguredProductInsert, int? version, string source)
        {
            // verify the required parameter 'preconfiguredProductInsert' is set
            if (preconfiguredProductInsert == null) throw new ApiException(400, "Missing required parameter 'preconfiguredProductInsert' when calling UpdatePreconfiguredproducts");
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling UpdatePreconfiguredproducts");
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling UpdatePreconfiguredproducts");
            
    
            var localVarPath = "/preconfiguredproducts/v/{version}/source/{source}/";
    
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
            
            
            
            
            if (preconfiguredProductInsert.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(preconfiguredProductInsert); // http body (model) parameter
            }
            else
            {
                localVarPostBody = preconfiguredProductInsert; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdatePreconfiguredproducts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdatePreconfiguredproducts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PreconfiguredProductsInsertResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PreconfiguredProductsInsertResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PreconfiguredProductsInsertResponse)));
            
        }
        
    }
    
}

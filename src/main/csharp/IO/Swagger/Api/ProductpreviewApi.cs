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
    public interface IProductpreviewApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Submit an image (or images) to be rendered into a product preview.
        /// </summary>
        /// <remarks>
        /// Submit an image (or images) to be rendered into a product preview.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productPreviewRequest">Request detailing the operation needing completed</param>
        /// <returns>ProductPreviewResponse</returns>
        ProductPreviewResponse POSTProductpreview (ProductPreviewRequest productPreviewRequest);
  
        /// <summary>
        /// Submit an image (or images) to be rendered into a product preview.
        /// </summary>
        /// <remarks>
        /// Submit an image (or images) to be rendered into a product preview.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productPreviewRequest">Request detailing the operation needing completed</param>
        /// <returns>ApiResponse of ProductPreviewResponse</returns>
        ApiResponse<ProductPreviewResponse> POSTProductpreviewWithHttpInfo (ProductPreviewRequest productPreviewRequest);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Submit an image (or images) to be rendered into a product preview.
        /// </summary>
        /// <remarks>
        /// Submit an image (or images) to be rendered into a product preview.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productPreviewRequest">Request detailing the operation needing completed</param>
        /// <returns>Task of ProductPreviewResponse</returns>
        System.Threading.Tasks.Task<ProductPreviewResponse> POSTProductpreviewAsync (ProductPreviewRequest productPreviewRequest);

        /// <summary>
        /// Submit an image (or images) to be rendered into a product preview.
        /// </summary>
        /// <remarks>
        /// Submit an image (or images) to be rendered into a product preview.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productPreviewRequest">Request detailing the operation needing completed</param>
        /// <returns>Task of ApiResponse (ProductPreviewResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductPreviewResponse>> POSTProductpreviewAsyncWithHttpInfo (ProductPreviewRequest productPreviewRequest);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ProductpreviewApi : IProductpreviewApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductpreviewApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductpreviewApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductpreviewApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProductpreviewApi(Configuration configuration = null)
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
        /// Submit an image (or images) to be rendered into a product preview. Submit an image (or images) to be rendered into a product preview.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productPreviewRequest">Request detailing the operation needing completed</param> 
        /// <returns>ProductPreviewResponse</returns>
        public ProductPreviewResponse POSTProductpreview (ProductPreviewRequest productPreviewRequest)
        {
             ApiResponse<ProductPreviewResponse> localVarResponse = POSTProductpreviewWithHttpInfo(productPreviewRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Submit an image (or images) to be rendered into a product preview. Submit an image (or images) to be rendered into a product preview.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productPreviewRequest">Request detailing the operation needing completed</param> 
        /// <returns>ApiResponse of ProductPreviewResponse</returns>
        public ApiResponse< ProductPreviewResponse > POSTProductpreviewWithHttpInfo (ProductPreviewRequest productPreviewRequest)
        {
            
            // verify the required parameter 'productPreviewRequest' is set
            if (productPreviewRequest == null)
                throw new ApiException(400, "Missing required parameter 'productPreviewRequest' when calling ProductpreviewApi->POSTProductpreview");
            
    
            var localVarPath = "/productpreview/";
    
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
            
            
            
            
            if (productPreviewRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(productPreviewRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = productPreviewRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling POSTProductpreview: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling POSTProductpreview: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ProductPreviewResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProductPreviewResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductPreviewResponse)));
            
        }

        
        /// <summary>
        /// Submit an image (or images) to be rendered into a product preview. Submit an image (or images) to be rendered into a product preview.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productPreviewRequest">Request detailing the operation needing completed</param>
        /// <returns>Task of ProductPreviewResponse</returns>
        public async System.Threading.Tasks.Task<ProductPreviewResponse> POSTProductpreviewAsync (ProductPreviewRequest productPreviewRequest)
        {
             ApiResponse<ProductPreviewResponse> localVarResponse = await POSTProductpreviewAsyncWithHttpInfo(productPreviewRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Submit an image (or images) to be rendered into a product preview. Submit an image (or images) to be rendered into a product preview.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productPreviewRequest">Request detailing the operation needing completed</param>
        /// <returns>Task of ApiResponse (ProductPreviewResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductPreviewResponse>> POSTProductpreviewAsyncWithHttpInfo (ProductPreviewRequest productPreviewRequest)
        {
            // verify the required parameter 'productPreviewRequest' is set
            if (productPreviewRequest == null) throw new ApiException(400, "Missing required parameter 'productPreviewRequest' when calling POSTProductpreview");
            
    
            var localVarPath = "/productpreview/";
    
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
            
            
            
            
            if (productPreviewRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(productPreviewRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = productPreviewRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling POSTProductpreview: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling POSTProductpreview: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProductPreviewResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProductPreviewResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductPreviewResponse)));
            
        }
        
    }
    
}

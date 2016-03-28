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
    public interface IImagevalidationApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Submit image validation
        /// </summary>
        /// <remarks>
        /// Validates an images and returns a validation errors (if available).
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="req">Image validation request, contains sku and image sizes per space</param>
        /// <returns>ImageValidatorResult</returns>
        ImageValidatorResult POSTImagevalidation (ImageValidationVm req);
  
        /// <summary>
        /// Submit image validation
        /// </summary>
        /// <remarks>
        /// Validates an images and returns a validation errors (if available).
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="req">Image validation request, contains sku and image sizes per space</param>
        /// <returns>ApiResponse of ImageValidatorResult</returns>
        ApiResponse<ImageValidatorResult> POSTImagevalidationWithHttpInfo (ImageValidationVm req);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Submit image validation
        /// </summary>
        /// <remarks>
        /// Validates an images and returns a validation errors (if available).
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="req">Image validation request, contains sku and image sizes per space</param>
        /// <returns>Task of ImageValidatorResult</returns>
        System.Threading.Tasks.Task<ImageValidatorResult> POSTImagevalidationAsync (ImageValidationVm req);

        /// <summary>
        /// Submit image validation
        /// </summary>
        /// <remarks>
        /// Validates an images and returns a validation errors (if available).
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="req">Image validation request, contains sku and image sizes per space</param>
        /// <returns>Task of ApiResponse (ImageValidatorResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageValidatorResult>> POSTImagevalidationAsyncWithHttpInfo (ImageValidationVm req);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ImagevalidationApi : IImagevalidationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImagevalidationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ImagevalidationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ImagevalidationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ImagevalidationApi(Configuration configuration = null)
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
        /// Submit image validation Validates an images and returns a validation errors (if available).
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="req">Image validation request, contains sku and image sizes per space</param> 
        /// <returns>ImageValidatorResult</returns>
        public ImageValidatorResult POSTImagevalidation (ImageValidationVm req)
        {
             ApiResponse<ImageValidatorResult> localVarResponse = POSTImagevalidationWithHttpInfo(req);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Submit image validation Validates an images and returns a validation errors (if available).
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="req">Image validation request, contains sku and image sizes per space</param> 
        /// <returns>ApiResponse of ImageValidatorResult</returns>
        public ApiResponse< ImageValidatorResult > POSTImagevalidationWithHttpInfo (ImageValidationVm req)
        {
            
            // verify the required parameter 'req' is set
            if (req == null)
                throw new ApiException(400, "Missing required parameter 'req' when calling ImagevalidationApi->POSTImagevalidation");
            
    
            var localVarPath = "/imagevalidation/";
    
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
            
            
            
            
            if (req.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(req); // http body (model) parameter
            }
            else
            {
                localVarPostBody = req; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling POSTImagevalidation: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling POSTImagevalidation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ImageValidatorResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ImageValidatorResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageValidatorResult)));
            
        }

        
        /// <summary>
        /// Submit image validation Validates an images and returns a validation errors (if available).
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="req">Image validation request, contains sku and image sizes per space</param>
        /// <returns>Task of ImageValidatorResult</returns>
        public async System.Threading.Tasks.Task<ImageValidatorResult> POSTImagevalidationAsync (ImageValidationVm req)
        {
             ApiResponse<ImageValidatorResult> localVarResponse = await POSTImagevalidationAsyncWithHttpInfo(req);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Submit image validation Validates an images and returns a validation errors (if available).
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="req">Image validation request, contains sku and image sizes per space</param>
        /// <returns>Task of ApiResponse (ImageValidatorResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageValidatorResult>> POSTImagevalidationAsyncWithHttpInfo (ImageValidationVm req)
        {
            // verify the required parameter 'req' is set
            if (req == null) throw new ApiException(400, "Missing required parameter 'req' when calling POSTImagevalidation");
            
    
            var localVarPath = "/imagevalidation/";
    
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
            
            
            
            
            if (req.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(req); // http body (model) parameter
            }
            else
            {
                localVarPostBody = req; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling POSTImagevalidation: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling POSTImagevalidation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ImageValidatorResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ImageValidatorResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageValidatorResult)));
            
        }
        
    }
    
}

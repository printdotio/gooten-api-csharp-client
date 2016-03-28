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
    public interface IImagesApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// POSTs files to a temporary store
        /// </summary>
        /// <remarks>
        /// POSTs files to a temporary store
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="images">Form/multipart file post</param>
        /// <returns>FileResult</returns>
        FileResult PostImages (Stream images);
  
        /// <summary>
        /// POSTs files to a temporary store
        /// </summary>
        /// <remarks>
        /// POSTs files to a temporary store
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="images">Form/multipart file post</param>
        /// <returns>ApiResponse of FileResult</returns>
        ApiResponse<FileResult> PostImagesWithHttpInfo (Stream images);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// POSTs files to a temporary store
        /// </summary>
        /// <remarks>
        /// POSTs files to a temporary store
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="images">Form/multipart file post</param>
        /// <returns>Task of FileResult</returns>
        System.Threading.Tasks.Task<FileResult> PostImagesAsync (Stream images);

        /// <summary>
        /// POSTs files to a temporary store
        /// </summary>
        /// <remarks>
        /// POSTs files to a temporary store
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="images">Form/multipart file post</param>
        /// <returns>Task of ApiResponse (FileResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileResult>> PostImagesAsyncWithHttpInfo (Stream images);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ImagesApi : IImagesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ImagesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ImagesApi(Configuration configuration = null)
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
        /// POSTs files to a temporary store POSTs files to a temporary store
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="images">Form/multipart file post</param> 
        /// <returns>FileResult</returns>
        public FileResult PostImages (Stream images)
        {
             ApiResponse<FileResult> localVarResponse = PostImagesWithHttpInfo(images);
             return localVarResponse.Data;
        }

        /// <summary>
        /// POSTs files to a temporary store POSTs files to a temporary store
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="images">Form/multipart file post</param> 
        /// <returns>ApiResponse of FileResult</returns>
        public ApiResponse< FileResult > PostImagesWithHttpInfo (Stream images)
        {
            
            // verify the required parameter 'images' is set
            if (images == null)
                throw new ApiException(400, "Missing required parameter 'images' when calling ImagesApi->PostImages");
            
    
            var localVarPath = "/images/";
    
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
            
            
            
            if (images != null) localVarFileParams.Add("Images", Configuration.ApiClient.ParameterToFile("Images", images));
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostImages: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostImages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<FileResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FileResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FileResult)));
            
        }

        
        /// <summary>
        /// POSTs files to a temporary store POSTs files to a temporary store
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="images">Form/multipart file post</param>
        /// <returns>Task of FileResult</returns>
        public async System.Threading.Tasks.Task<FileResult> PostImagesAsync (Stream images)
        {
             ApiResponse<FileResult> localVarResponse = await PostImagesAsyncWithHttpInfo(images);
             return localVarResponse.Data;

        }

        /// <summary>
        /// POSTs files to a temporary store POSTs files to a temporary store
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="images">Form/multipart file post</param>
        /// <returns>Task of ApiResponse (FileResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileResult>> PostImagesAsyncWithHttpInfo (Stream images)
        {
            // verify the required parameter 'images' is set
            if (images == null) throw new ApiException(400, "Missing required parameter 'images' when calling PostImages");
            
    
            var localVarPath = "/images/";
    
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
            
            
            
            if (images != null) localVarFileParams.Add("Images", Configuration.ApiClient.ParameterToFile("Images", images));
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostImages: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostImages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FileResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FileResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FileResult)));
            
        }
        
    }
    
}

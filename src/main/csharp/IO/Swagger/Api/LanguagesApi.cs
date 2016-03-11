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
    public interface ILanguagesApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Get text in a specified language
        /// </summary>
        /// <remarks>
        /// Get text in a specified language
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Two-character language code, like \&quot;en\&quot; (english)</param>
        /// <param name="key">A string used to query the language dictionary for specific values within a category.</param>
        /// <returns>LanguageDictionary</returns>
        LanguageDictionary GetLanguageText (string languageCode, string key = null);
  
        /// <summary>
        /// Get text in a specified language
        /// </summary>
        /// <remarks>
        /// Get text in a specified language
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Two-character language code, like \&quot;en\&quot; (english)</param>
        /// <param name="key">A string used to query the language dictionary for specific values within a category.</param>
        /// <returns>ApiResponse of LanguageDictionary</returns>
        ApiResponse<LanguageDictionary> GetLanguageTextWithHttpInfo (string languageCode, string key = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Get text in a specified language
        /// </summary>
        /// <remarks>
        /// Get text in a specified language
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Two-character language code, like \&quot;en\&quot; (english)</param>
        /// <param name="key">A string used to query the language dictionary for specific values within a category.</param>
        /// <returns>Task of LanguageDictionary</returns>
        System.Threading.Tasks.Task<LanguageDictionary> GetLanguageTextAsync (string languageCode, string key = null);

        /// <summary>
        /// Get text in a specified language
        /// </summary>
        /// <remarks>
        /// Get text in a specified language
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Two-character language code, like \&quot;en\&quot; (english)</param>
        /// <param name="key">A string used to query the language dictionary for specific values within a category.</param>
        /// <returns>Task of ApiResponse (LanguageDictionary)</returns>
        System.Threading.Tasks.Task<ApiResponse<LanguageDictionary>> GetLanguageTextAsyncWithHttpInfo (string languageCode, string key = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LanguagesApi : ILanguagesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LanguagesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LanguagesApi(Configuration configuration = null)
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
        /// Get text in a specified language Get text in a specified language
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Two-character language code, like \&quot;en\&quot; (english)</param> 
        /// <param name="key">A string used to query the language dictionary for specific values within a category.</param> 
        /// <returns>LanguageDictionary</returns>
        public LanguageDictionary GetLanguageText (string languageCode, string key = null)
        {
             ApiResponse<LanguageDictionary> localVarResponse = GetLanguageTextWithHttpInfo(languageCode, key);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get text in a specified language Get text in a specified language
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Two-character language code, like \&quot;en\&quot; (english)</param> 
        /// <param name="key">A string used to query the language dictionary for specific values within a category.</param> 
        /// <returns>ApiResponse of LanguageDictionary</returns>
        public ApiResponse< LanguageDictionary > GetLanguageTextWithHttpInfo (string languageCode, string key = null)
        {
            
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling LanguagesApi->GetLanguageText");
            
    
            var localVarPath = "/languages/";
    
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
            
            if (languageCode != null) localVarQueryParams.Add("languageCode", Configuration.ApiClient.ParameterToString(languageCode)); // query parameter
            if (key != null) localVarQueryParams.Add("key", Configuration.ApiClient.ParameterToString(key)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageText: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageText: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LanguageDictionary>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LanguageDictionary) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LanguageDictionary)));
            
        }

        
        /// <summary>
        /// Get text in a specified language Get text in a specified language
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Two-character language code, like \&quot;en\&quot; (english)</param>
        /// <param name="key">A string used to query the language dictionary for specific values within a category.</param>
        /// <returns>Task of LanguageDictionary</returns>
        public async System.Threading.Tasks.Task<LanguageDictionary> GetLanguageTextAsync (string languageCode, string key = null)
        {
             ApiResponse<LanguageDictionary> localVarResponse = await GetLanguageTextAsyncWithHttpInfo(languageCode, key);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get text in a specified language Get text in a specified language
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Two-character language code, like \&quot;en\&quot; (english)</param>
        /// <param name="key">A string used to query the language dictionary for specific values within a category.</param>
        /// <returns>Task of ApiResponse (LanguageDictionary)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LanguageDictionary>> GetLanguageTextAsyncWithHttpInfo (string languageCode, string key = null)
        {
            // verify the required parameter 'languageCode' is set
            if (languageCode == null) throw new ApiException(400, "Missing required parameter 'languageCode' when calling GetLanguageText");
            
    
            var localVarPath = "/languages/";
    
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
            
            if (languageCode != null) localVarQueryParams.Add("languageCode", Configuration.ApiClient.ParameterToString(languageCode)); // query parameter
            if (key != null) localVarQueryParams.Add("key", Configuration.ApiClient.ParameterToString(key)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageText: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLanguageText: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LanguageDictionary>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LanguageDictionary) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LanguageDictionary)));
            
        }
        
    }
    
}

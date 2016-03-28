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
    public interface ICountriesApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Get a list of supported countries. Output is in specified language.
        /// </summary>
        /// <remarks>
        /// Get a list of supported countries. Output is in specified language.
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Two-character language code, like \&quot;en\&quot; (english)</param>
        /// <param name="key">A string used to query the language dictionary for specific values within a category.</param>
        /// <returns>CountryList</returns>
        CountryList Countries (string languageCode = null, string key = null);
  
        /// <summary>
        /// Get a list of supported countries. Output is in specified language.
        /// </summary>
        /// <remarks>
        /// Get a list of supported countries. Output is in specified language.
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Two-character language code, like \&quot;en\&quot; (english)</param>
        /// <param name="key">A string used to query the language dictionary for specific values within a category.</param>
        /// <returns>ApiResponse of CountryList</returns>
        ApiResponse<CountryList> CountriesWithHttpInfo (string languageCode = null, string key = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Get a list of supported countries. Output is in specified language.
        /// </summary>
        /// <remarks>
        /// Get a list of supported countries. Output is in specified language.
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Two-character language code, like \&quot;en\&quot; (english)</param>
        /// <param name="key">A string used to query the language dictionary for specific values within a category.</param>
        /// <returns>Task of CountryList</returns>
        System.Threading.Tasks.Task<CountryList> CountriesAsync (string languageCode = null, string key = null);

        /// <summary>
        /// Get a list of supported countries. Output is in specified language.
        /// </summary>
        /// <remarks>
        /// Get a list of supported countries. Output is in specified language.
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Two-character language code, like \&quot;en\&quot; (english)</param>
        /// <param name="key">A string used to query the language dictionary for specific values within a category.</param>
        /// <returns>Task of ApiResponse (CountryList)</returns>
        System.Threading.Tasks.Task<ApiResponse<CountryList>> CountriesAsyncWithHttpInfo (string languageCode = null, string key = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CountriesApi : ICountriesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountriesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CountriesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CountriesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CountriesApi(Configuration configuration = null)
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
        /// Get a list of supported countries. Output is in specified language. Get a list of supported countries. Output is in specified language.
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Two-character language code, like \&quot;en\&quot; (english)</param> 
        /// <param name="key">A string used to query the language dictionary for specific values within a category.</param> 
        /// <returns>CountryList</returns>
        public CountryList Countries (string languageCode = null, string key = null)
        {
             ApiResponse<CountryList> localVarResponse = CountriesWithHttpInfo(languageCode, key);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of supported countries. Output is in specified language. Get a list of supported countries. Output is in specified language.
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Two-character language code, like \&quot;en\&quot; (english)</param> 
        /// <param name="key">A string used to query the language dictionary for specific values within a category.</param> 
        /// <returns>ApiResponse of CountryList</returns>
        public ApiResponse< CountryList > CountriesWithHttpInfo (string languageCode = null, string key = null)
        {
            
    
            var localVarPath = "/countries/";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Countries: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Countries: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CountryList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CountryList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CountryList)));
            
        }

        
        /// <summary>
        /// Get a list of supported countries. Output is in specified language. Get a list of supported countries. Output is in specified language.
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Two-character language code, like \&quot;en\&quot; (english)</param>
        /// <param name="key">A string used to query the language dictionary for specific values within a category.</param>
        /// <returns>Task of CountryList</returns>
        public async System.Threading.Tasks.Task<CountryList> CountriesAsync (string languageCode = null, string key = null)
        {
             ApiResponse<CountryList> localVarResponse = await CountriesAsyncWithHttpInfo(languageCode, key);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of supported countries. Output is in specified language. Get a list of supported countries. Output is in specified language.
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageCode">Two-character language code, like \&quot;en\&quot; (english)</param>
        /// <param name="key">A string used to query the language dictionary for specific values within a category.</param>
        /// <returns>Task of ApiResponse (CountryList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CountryList>> CountriesAsyncWithHttpInfo (string languageCode = null, string key = null)
        {
            
    
            var localVarPath = "/countries/";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Countries: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Countries: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CountryList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CountryList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CountryList)));
            
        }
        
    }
    
}

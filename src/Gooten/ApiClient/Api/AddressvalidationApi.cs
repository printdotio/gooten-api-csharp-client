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
    public interface IAddressvalidationApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Validates an address and returns a suggested address (if available) and a validation score.
        /// </summary>
        /// <remarks>
        /// Validates an address and returns a suggested address (if available) and a validation score.
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="line1">Address line1.</param>
        /// <param name="line2">Address line2.</param>
        /// <param name="city">Address city.</param>
        /// <param name="state">Address state.</param>
        /// <param name="postalCode">Address postal code/zip.</param>
        /// <param name="countryCode">Address country code.</param>
        /// <returns>Result</returns>
        Result Addressvalidation (string line1 = null, string line2 = null, string city = null, string state = null, string postalCode = null, string countryCode = null);
  
        /// <summary>
        /// Validates an address and returns a suggested address (if available) and a validation score.
        /// </summary>
        /// <remarks>
        /// Validates an address and returns a suggested address (if available) and a validation score.
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="line1">Address line1.</param>
        /// <param name="line2">Address line2.</param>
        /// <param name="city">Address city.</param>
        /// <param name="state">Address state.</param>
        /// <param name="postalCode">Address postal code/zip.</param>
        /// <param name="countryCode">Address country code.</param>
        /// <returns>ApiResponse of Result</returns>
        ApiResponse<Result> AddressvalidationWithHttpInfo (string line1 = null, string line2 = null, string city = null, string state = null, string postalCode = null, string countryCode = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Validates an address and returns a suggested address (if available) and a validation score.
        /// </summary>
        /// <remarks>
        /// Validates an address and returns a suggested address (if available) and a validation score.
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="line1">Address line1.</param>
        /// <param name="line2">Address line2.</param>
        /// <param name="city">Address city.</param>
        /// <param name="state">Address state.</param>
        /// <param name="postalCode">Address postal code/zip.</param>
        /// <param name="countryCode">Address country code.</param>
        /// <returns>Task of Result</returns>
        System.Threading.Tasks.Task<Result> AddressvalidationAsync (string line1 = null, string line2 = null, string city = null, string state = null, string postalCode = null, string countryCode = null);

        /// <summary>
        /// Validates an address and returns a suggested address (if available) and a validation score.
        /// </summary>
        /// <remarks>
        /// Validates an address and returns a suggested address (if available) and a validation score.
        /// </remarks>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="line1">Address line1.</param>
        /// <param name="line2">Address line2.</param>
        /// <param name="city">Address city.</param>
        /// <param name="state">Address state.</param>
        /// <param name="postalCode">Address postal code/zip.</param>
        /// <param name="countryCode">Address country code.</param>
        /// <returns>Task of ApiResponse (Result)</returns>
        System.Threading.Tasks.Task<ApiResponse<Result>> AddressvalidationAsyncWithHttpInfo (string line1 = null, string line2 = null, string city = null, string state = null, string postalCode = null, string countryCode = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AddressvalidationApi : IAddressvalidationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressvalidationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AddressvalidationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressvalidationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AddressvalidationApi(Configuration configuration = null)
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
        /// Validates an address and returns a suggested address (if available) and a validation score. Validates an address and returns a suggested address (if available) and a validation score.
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="line1">Address line1.</param> 
        /// <param name="line2">Address line2.</param> 
        /// <param name="city">Address city.</param> 
        /// <param name="state">Address state.</param> 
        /// <param name="postalCode">Address postal code/zip.</param> 
        /// <param name="countryCode">Address country code.</param> 
        /// <returns>Result</returns>
        public Result Addressvalidation (string line1 = null, string line2 = null, string city = null, string state = null, string postalCode = null, string countryCode = null)
        {
             ApiResponse<Result> localVarResponse = AddressvalidationWithHttpInfo(line1, line2, city, state, postalCode, countryCode);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Validates an address and returns a suggested address (if available) and a validation score. Validates an address and returns a suggested address (if available) and a validation score.
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="line1">Address line1.</param> 
        /// <param name="line2">Address line2.</param> 
        /// <param name="city">Address city.</param> 
        /// <param name="state">Address state.</param> 
        /// <param name="postalCode">Address postal code/zip.</param> 
        /// <param name="countryCode">Address country code.</param> 
        /// <returns>ApiResponse of Result</returns>
        public ApiResponse< Result > AddressvalidationWithHttpInfo (string line1 = null, string line2 = null, string city = null, string state = null, string postalCode = null, string countryCode = null)
        {
            
    
            var localVarPath = "/addressvalidation/";
    
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
            
            if (line1 != null) localVarQueryParams.Add("line1", Configuration.ApiClient.ParameterToString(line1)); // query parameter
            if (line2 != null) localVarQueryParams.Add("line2", Configuration.ApiClient.ParameterToString(line2)); // query parameter
            if (city != null) localVarQueryParams.Add("city", Configuration.ApiClient.ParameterToString(city)); // query parameter
            if (state != null) localVarQueryParams.Add("state", Configuration.ApiClient.ParameterToString(state)); // query parameter
            if (postalCode != null) localVarQueryParams.Add("postalCode", Configuration.ApiClient.ParameterToString(postalCode)); // query parameter
            if (countryCode != null) localVarQueryParams.Add("countryCode", Configuration.ApiClient.ParameterToString(countryCode)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Addressvalidation: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Addressvalidation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Result>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Result) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Result)));
            
        }

        
        /// <summary>
        /// Validates an address and returns a suggested address (if available) and a validation score. Validates an address and returns a suggested address (if available) and a validation score.
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="line1">Address line1.</param>
        /// <param name="line2">Address line2.</param>
        /// <param name="city">Address city.</param>
        /// <param name="state">Address state.</param>
        /// <param name="postalCode">Address postal code/zip.</param>
        /// <param name="countryCode">Address country code.</param>
        /// <returns>Task of Result</returns>
        public async System.Threading.Tasks.Task<Result> AddressvalidationAsync (string line1 = null, string line2 = null, string city = null, string state = null, string postalCode = null, string countryCode = null)
        {
             ApiResponse<Result> localVarResponse = await AddressvalidationAsyncWithHttpInfo(line1, line2, city, state, postalCode, countryCode);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Validates an address and returns a suggested address (if available) and a validation score. Validates an address and returns a suggested address (if available) and a validation score.
        /// </summary>
        /// <exception cref="Gooten.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="line1">Address line1.</param>
        /// <param name="line2">Address line2.</param>
        /// <param name="city">Address city.</param>
        /// <param name="state">Address state.</param>
        /// <param name="postalCode">Address postal code/zip.</param>
        /// <param name="countryCode">Address country code.</param>
        /// <returns>Task of ApiResponse (Result)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Result>> AddressvalidationAsyncWithHttpInfo (string line1 = null, string line2 = null, string city = null, string state = null, string postalCode = null, string countryCode = null)
        {
            
    
            var localVarPath = "/addressvalidation/";
    
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
            
            if (line1 != null) localVarQueryParams.Add("line1", Configuration.ApiClient.ParameterToString(line1)); // query parameter
            if (line2 != null) localVarQueryParams.Add("line2", Configuration.ApiClient.ParameterToString(line2)); // query parameter
            if (city != null) localVarQueryParams.Add("city", Configuration.ApiClient.ParameterToString(city)); // query parameter
            if (state != null) localVarQueryParams.Add("state", Configuration.ApiClient.ParameterToString(state)); // query parameter
            if (postalCode != null) localVarQueryParams.Add("postalCode", Configuration.ApiClient.ParameterToString(postalCode)); // query parameter
            if (countryCode != null) localVarQueryParams.Add("countryCode", Configuration.ApiClient.ParameterToString(countryCode)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Addressvalidation: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Addressvalidation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Result>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Result) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Result)));
            
        }
        
    }
    
}

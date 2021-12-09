/* 
 * bSDD API prototype
 *
 * API to access the buildingSMART Data Dictionary
 *
 * OpenAPI spec version: v1
 * Contact: bsdd_support@buildingsmart.org
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
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
        public interface IDomainApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Domain with the classification tree
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceUri">Required parameter to select the domain.</param>
        /// <param name="useNestedClassifications">Set to true if you want a tree of classifications, set to false to get a flat list of classifications (optional)</param>
        /// <returns>DomainWithClassificationsContractV2</returns>
        DomainWithClassificationsContractV2 ApiDomainV2ClassificationsGet (string namespaceUri, bool? useNestedClassifications = null);

        /// <summary>
        /// Get Domain with the classification tree
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceUri">Required parameter to select the domain.</param>
        /// <param name="useNestedClassifications">Set to true if you want a tree of classifications, set to false to get a flat list of classifications (optional)</param>
        /// <returns>ApiResponse of DomainWithClassificationsContractV2</returns>
        ApiResponse<DomainWithClassificationsContractV2> ApiDomainV2ClassificationsGetWithHttpInfo (string namespaceUri, bool? useNestedClassifications = null);
        /// <summary>
        /// Get list of available Domains
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceUri">Optional parameter to filter by first part of namespace URI. Use this one to get details of just one domain version              or, if you leave out the version number at the end, get all the versions of a domain. (optional)</param>
        /// <returns>List&lt;DomainContractV2&gt;</returns>
        List<DomainContractV2> ApiDomainV2Get (string namespaceUri = null);

        /// <summary>
        /// Get list of available Domains
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceUri">Optional parameter to filter by first part of namespace URI. Use this one to get details of just one domain version              or, if you leave out the version number at the end, get all the versions of a domain. (optional)</param>
        /// <returns>ApiResponse of List&lt;DomainContractV2&gt;</returns>
        ApiResponse<List<DomainContractV2>> ApiDomainV2GetWithHttpInfo (string namespaceUri = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get Domain with the classification tree
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceUri">Required parameter to select the domain.</param>
        /// <param name="useNestedClassifications">Set to true if you want a tree of classifications, set to false to get a flat list of classifications (optional)</param>
        /// <returns>Task of DomainWithClassificationsContractV2</returns>
        System.Threading.Tasks.Task<DomainWithClassificationsContractV2> ApiDomainV2ClassificationsGetAsync (string namespaceUri, bool? useNestedClassifications = null);

        /// <summary>
        /// Get Domain with the classification tree
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceUri">Required parameter to select the domain.</param>
        /// <param name="useNestedClassifications">Set to true if you want a tree of classifications, set to false to get a flat list of classifications (optional)</param>
        /// <returns>Task of ApiResponse (DomainWithClassificationsContractV2)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainWithClassificationsContractV2>> ApiDomainV2ClassificationsGetAsyncWithHttpInfo (string namespaceUri, bool? useNestedClassifications = null);
        /// <summary>
        /// Get list of available Domains
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceUri">Optional parameter to filter by first part of namespace URI. Use this one to get details of just one domain version              or, if you leave out the version number at the end, get all the versions of a domain. (optional)</param>
        /// <returns>Task of List&lt;DomainContractV2&gt;</returns>
        System.Threading.Tasks.Task<List<DomainContractV2>> ApiDomainV2GetAsync (string namespaceUri = null);

        /// <summary>
        /// Get list of available Domains
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceUri">Optional parameter to filter by first part of namespace URI. Use this one to get details of just one domain version              or, if you leave out the version number at the end, get all the versions of a domain. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;DomainContractV2&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<DomainContractV2>>> ApiDomainV2GetAsyncWithHttpInfo (string namespaceUri = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class DomainApi : IDomainApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DomainApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainApi"/> class
        /// </summary>
        /// <returns></returns>
        public DomainApi()
        {
            this.Configuration = IO.Swagger.Client.Configuration.Default;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DomainApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
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
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
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
        /// Get Domain with the classification tree 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceUri">Required parameter to select the domain.</param>
        /// <param name="useNestedClassifications">Set to true if you want a tree of classifications, set to false to get a flat list of classifications (optional)</param>
        /// <returns>DomainWithClassificationsContractV2</returns>
        public DomainWithClassificationsContractV2 ApiDomainV2ClassificationsGet (string namespaceUri, bool? useNestedClassifications = null)
        {
             ApiResponse<DomainWithClassificationsContractV2> localVarResponse = ApiDomainV2ClassificationsGetWithHttpInfo(namespaceUri, useNestedClassifications);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Domain with the classification tree 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceUri">Required parameter to select the domain.</param>
        /// <param name="useNestedClassifications">Set to true if you want a tree of classifications, set to false to get a flat list of classifications (optional)</param>
        /// <returns>ApiResponse of DomainWithClassificationsContractV2</returns>
        public ApiResponse< DomainWithClassificationsContractV2 > ApiDomainV2ClassificationsGetWithHttpInfo (string namespaceUri, bool? useNestedClassifications = null)
        {
            // verify the required parameter 'namespaceUri' is set
            if (namespaceUri == null)
                throw new ApiException(400, "Missing required parameter 'namespaceUri' when calling DomainApi->ApiDomainV2ClassificationsGet");

            var localVarPath = "/api/Domain/v2/Classifications";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (namespaceUri != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "namespaceUri", namespaceUri)); // query parameter
            if (useNestedClassifications != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "useNestedClassifications", useNestedClassifications)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApiDomainV2ClassificationsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DomainWithClassificationsContractV2>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (DomainWithClassificationsContractV2) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainWithClassificationsContractV2)));
        }

        /// <summary>
        /// Get Domain with the classification tree 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceUri">Required parameter to select the domain.</param>
        /// <param name="useNestedClassifications">Set to true if you want a tree of classifications, set to false to get a flat list of classifications (optional)</param>
        /// <returns>Task of DomainWithClassificationsContractV2</returns>
        public async System.Threading.Tasks.Task<DomainWithClassificationsContractV2> ApiDomainV2ClassificationsGetAsync (string namespaceUri, bool? useNestedClassifications = null)
        {
             ApiResponse<DomainWithClassificationsContractV2> localVarResponse = await ApiDomainV2ClassificationsGetAsyncWithHttpInfo(namespaceUri, useNestedClassifications);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Domain with the classification tree 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceUri">Required parameter to select the domain.</param>
        /// <param name="useNestedClassifications">Set to true if you want a tree of classifications, set to false to get a flat list of classifications (optional)</param>
        /// <returns>Task of ApiResponse (DomainWithClassificationsContractV2)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainWithClassificationsContractV2>> ApiDomainV2ClassificationsGetAsyncWithHttpInfo (string namespaceUri, bool? useNestedClassifications = null)
        {
            // verify the required parameter 'namespaceUri' is set
            if (namespaceUri == null)
                throw new ApiException(400, "Missing required parameter 'namespaceUri' when calling DomainApi->ApiDomainV2ClassificationsGet");

            var localVarPath = "/api/Domain/v2/Classifications";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (namespaceUri != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "namespaceUri", namespaceUri)); // query parameter
            if (useNestedClassifications != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "useNestedClassifications", useNestedClassifications)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApiDomainV2ClassificationsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DomainWithClassificationsContractV2>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (DomainWithClassificationsContractV2) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainWithClassificationsContractV2)));
        }

        /// <summary>
        /// Get list of available Domains 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceUri">Optional parameter to filter by first part of namespace URI. Use this one to get details of just one domain version              or, if you leave out the version number at the end, get all the versions of a domain. (optional)</param>
        /// <returns>List&lt;DomainContractV2&gt;</returns>
        public List<DomainContractV2> ApiDomainV2Get (string namespaceUri = null)
        {
             ApiResponse<List<DomainContractV2>> localVarResponse = ApiDomainV2GetWithHttpInfo(namespaceUri);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of available Domains 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceUri">Optional parameter to filter by first part of namespace URI. Use this one to get details of just one domain version              or, if you leave out the version number at the end, get all the versions of a domain. (optional)</param>
        /// <returns>ApiResponse of List&lt;DomainContractV2&gt;</returns>
        public ApiResponse< List<DomainContractV2> > ApiDomainV2GetWithHttpInfo (string namespaceUri = null)
        {

            var localVarPath = "/api/Domain/v2";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (namespaceUri != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "namespaceUri", namespaceUri)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApiDomainV2Get", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<DomainContractV2>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<DomainContractV2>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<DomainContractV2>)));
        }

        /// <summary>
        /// Get list of available Domains 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceUri">Optional parameter to filter by first part of namespace URI. Use this one to get details of just one domain version              or, if you leave out the version number at the end, get all the versions of a domain. (optional)</param>
        /// <returns>Task of List&lt;DomainContractV2&gt;</returns>
        public async System.Threading.Tasks.Task<List<DomainContractV2>> ApiDomainV2GetAsync (string namespaceUri = null)
        {
             ApiResponse<List<DomainContractV2>> localVarResponse = await ApiDomainV2GetAsyncWithHttpInfo(namespaceUri);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of available Domains 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="namespaceUri">Optional parameter to filter by first part of namespace URI. Use this one to get details of just one domain version              or, if you leave out the version number at the end, get all the versions of a domain. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;DomainContractV2&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<DomainContractV2>>> ApiDomainV2GetAsyncWithHttpInfo (string namespaceUri = null)
        {

            var localVarPath = "/api/Domain/v2";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (namespaceUri != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "namespaceUri", namespaceUri)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApiDomainV2Get", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<DomainContractV2>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<DomainContractV2>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<DomainContractV2>)));
        }

    }
}

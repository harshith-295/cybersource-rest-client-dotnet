/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVerificationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Validate export compliance
        /// </summary>
        /// <remarks>
        /// This call checks customer data against specified watch lists to ensure export compliance. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="validateExportComplianceRequest"></param>
        /// <returns>RiskV1ExportComplianceInquiriesPost201Response</returns>
        RiskV1ExportComplianceInquiriesPost201Response ValidateExportCompliance (ValidateExportComplianceRequest validateExportComplianceRequest);

        /// <summary>
        /// Validate export compliance
        /// </summary>
        /// <remarks>
        /// This call checks customer data against specified watch lists to ensure export compliance. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="validateExportComplianceRequest"></param>
        /// <returns>ApiResponse of RiskV1ExportComplianceInquiriesPost201Response</returns>
        ApiResponse<RiskV1ExportComplianceInquiriesPost201Response> ValidateExportComplianceWithHttpInfo (ValidateExportComplianceRequest validateExportComplianceRequest);
        /// <summary>
        /// Verify customer address
        /// </summary>
        /// <remarks>
        /// This call verifies that the customer address submitted is valid.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifyCustomerAddressRequest"></param>
        /// <returns>RiskV1AddressVerificationsPost201Response</returns>
        RiskV1AddressVerificationsPost201Response VerifyCustomerAddress (VerifyCustomerAddressRequest verifyCustomerAddressRequest);

        /// <summary>
        /// Verify customer address
        /// </summary>
        /// <remarks>
        /// This call verifies that the customer address submitted is valid.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifyCustomerAddressRequest"></param>
        /// <returns>ApiResponse of RiskV1AddressVerificationsPost201Response</returns>
        ApiResponse<RiskV1AddressVerificationsPost201Response> VerifyCustomerAddressWithHttpInfo (VerifyCustomerAddressRequest verifyCustomerAddressRequest);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Validate export compliance
        /// </summary>
        /// <remarks>
        /// This call checks customer data against specified watch lists to ensure export compliance. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="validateExportComplianceRequest"></param>
        /// <returns>Task of RiskV1ExportComplianceInquiriesPost201Response</returns>
        System.Threading.Tasks.Task<RiskV1ExportComplianceInquiriesPost201Response> ValidateExportComplianceAsync (ValidateExportComplianceRequest validateExportComplianceRequest);

        /// <summary>
        /// Validate export compliance
        /// </summary>
        /// <remarks>
        /// This call checks customer data against specified watch lists to ensure export compliance. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="validateExportComplianceRequest"></param>
        /// <returns>Task of ApiResponse (RiskV1ExportComplianceInquiriesPost201Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<RiskV1ExportComplianceInquiriesPost201Response>> ValidateExportComplianceAsyncWithHttpInfo (ValidateExportComplianceRequest validateExportComplianceRequest);
        /// <summary>
        /// Verify customer address
        /// </summary>
        /// <remarks>
        /// This call verifies that the customer address submitted is valid.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifyCustomerAddressRequest"></param>
        /// <returns>Task of RiskV1AddressVerificationsPost201Response</returns>
        System.Threading.Tasks.Task<RiskV1AddressVerificationsPost201Response> VerifyCustomerAddressAsync (VerifyCustomerAddressRequest verifyCustomerAddressRequest);

        /// <summary>
        /// Verify customer address
        /// </summary>
        /// <remarks>
        /// This call verifies that the customer address submitted is valid.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifyCustomerAddressRequest"></param>
        /// <returns>Task of ApiResponse (RiskV1AddressVerificationsPost201Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<RiskV1AddressVerificationsPost201Response>> VerifyCustomerAddressAsyncWithHttpInfo (VerifyCustomerAddressRequest verifyCustomerAddressRequest);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class VerificationApi : IVerificationApi
    {
        private CyberSource.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="VerificationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VerificationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = CyberSource.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerificationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VerificationApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = CyberSource.Client.Configuration.DefaultExceptionFactory;

            this.Configuration.ApiClient.Configuration = this.Configuration;
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
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public CyberSource.Client.ExceptionFactory ExceptionFactory
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
        /// Validate export compliance This call checks customer data against specified watch lists to ensure export compliance. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="validateExportComplianceRequest"></param>
        /// <returns>RiskV1ExportComplianceInquiriesPost201Response</returns>
        public RiskV1ExportComplianceInquiriesPost201Response ValidateExportCompliance (ValidateExportComplianceRequest validateExportComplianceRequest)
        {
             ApiResponse<RiskV1ExportComplianceInquiriesPost201Response> localVarResponse = ValidateExportComplianceWithHttpInfo(validateExportComplianceRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Validate export compliance This call checks customer data against specified watch lists to ensure export compliance. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="validateExportComplianceRequest"></param>
        /// <returns>ApiResponse of RiskV1ExportComplianceInquiriesPost201Response</returns>
        public ApiResponse< RiskV1ExportComplianceInquiriesPost201Response > ValidateExportComplianceWithHttpInfo (ValidateExportComplianceRequest validateExportComplianceRequest)
        {
            // verify the required parameter 'validateExportComplianceRequest' is set
            if (validateExportComplianceRequest == null)
                throw new ApiException(400, "Missing required parameter 'validateExportComplianceRequest' when calling VerificationApi->ValidateExportCompliance");

            var localVarPath = $"/risk/v1/export-compliance-inquiries";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/hal+json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (validateExportComplianceRequest != null && validateExportComplianceRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(validateExportComplianceRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = validateExportComplianceRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ValidateExportCompliance", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RiskV1ExportComplianceInquiriesPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RiskV1ExportComplianceInquiriesPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RiskV1ExportComplianceInquiriesPost201Response))); // Return statement
        }

        /// <summary>
        /// Validate export compliance This call checks customer data against specified watch lists to ensure export compliance. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="validateExportComplianceRequest"></param>
        /// <returns>Task of RiskV1ExportComplianceInquiriesPost201Response</returns>
        public async System.Threading.Tasks.Task<RiskV1ExportComplianceInquiriesPost201Response> ValidateExportComplianceAsync (ValidateExportComplianceRequest validateExportComplianceRequest)
        {
             ApiResponse<RiskV1ExportComplianceInquiriesPost201Response> localVarResponse = await ValidateExportComplianceAsyncWithHttpInfo(validateExportComplianceRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Validate export compliance This call checks customer data against specified watch lists to ensure export compliance. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="validateExportComplianceRequest"></param>
        /// <returns>Task of ApiResponse (RiskV1ExportComplianceInquiriesPost201Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RiskV1ExportComplianceInquiriesPost201Response>> ValidateExportComplianceAsyncWithHttpInfo (ValidateExportComplianceRequest validateExportComplianceRequest)
        {
            // verify the required parameter 'validateExportComplianceRequest' is set
            if (validateExportComplianceRequest == null)
                throw new ApiException(400, "Missing required parameter 'validateExportComplianceRequest' when calling VerificationApi->ValidateExportCompliance");

            var localVarPath = $"/risk/v1/export-compliance-inquiries";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/hal+json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (validateExportComplianceRequest != null && validateExportComplianceRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(validateExportComplianceRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = validateExportComplianceRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ValidateExportCompliance", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RiskV1ExportComplianceInquiriesPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RiskV1ExportComplianceInquiriesPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RiskV1ExportComplianceInquiriesPost201Response))); // Return statement
        }

        /// <summary>
        /// Verify customer address This call verifies that the customer address submitted is valid.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifyCustomerAddressRequest"></param>
        /// <returns>RiskV1AddressVerificationsPost201Response</returns>
        public RiskV1AddressVerificationsPost201Response VerifyCustomerAddress (VerifyCustomerAddressRequest verifyCustomerAddressRequest)
        {
             ApiResponse<RiskV1AddressVerificationsPost201Response> localVarResponse = VerifyCustomerAddressWithHttpInfo(verifyCustomerAddressRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Verify customer address This call verifies that the customer address submitted is valid.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifyCustomerAddressRequest"></param>
        /// <returns>ApiResponse of RiskV1AddressVerificationsPost201Response</returns>
        public ApiResponse< RiskV1AddressVerificationsPost201Response > VerifyCustomerAddressWithHttpInfo (VerifyCustomerAddressRequest verifyCustomerAddressRequest)
        {
            // verify the required parameter 'verifyCustomerAddressRequest' is set
            if (verifyCustomerAddressRequest == null)
                throw new ApiException(400, "Missing required parameter 'verifyCustomerAddressRequest' when calling VerificationApi->VerifyCustomerAddress");

            var localVarPath = $"/risk/v1/address-verifications";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/hal+json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (verifyCustomerAddressRequest != null && verifyCustomerAddressRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(verifyCustomerAddressRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = verifyCustomerAddressRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("VerifyCustomerAddress", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RiskV1AddressVerificationsPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RiskV1AddressVerificationsPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RiskV1AddressVerificationsPost201Response))); // Return statement
        }

        /// <summary>
        /// Verify customer address This call verifies that the customer address submitted is valid.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifyCustomerAddressRequest"></param>
        /// <returns>Task of RiskV1AddressVerificationsPost201Response</returns>
        public async System.Threading.Tasks.Task<RiskV1AddressVerificationsPost201Response> VerifyCustomerAddressAsync (VerifyCustomerAddressRequest verifyCustomerAddressRequest)
        {
             ApiResponse<RiskV1AddressVerificationsPost201Response> localVarResponse = await VerifyCustomerAddressAsyncWithHttpInfo(verifyCustomerAddressRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Verify customer address This call verifies that the customer address submitted is valid.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifyCustomerAddressRequest"></param>
        /// <returns>Task of ApiResponse (RiskV1AddressVerificationsPost201Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RiskV1AddressVerificationsPost201Response>> VerifyCustomerAddressAsyncWithHttpInfo (VerifyCustomerAddressRequest verifyCustomerAddressRequest)
        {
            // verify the required parameter 'verifyCustomerAddressRequest' is set
            if (verifyCustomerAddressRequest == null)
                throw new ApiException(400, "Missing required parameter 'verifyCustomerAddressRequest' when calling VerificationApi->VerifyCustomerAddress");

            var localVarPath = $"/risk/v1/address-verifications";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/hal+json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (verifyCustomerAddressRequest != null && verifyCustomerAddressRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(verifyCustomerAddressRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = verifyCustomerAddressRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("VerifyCustomerAddress", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RiskV1AddressVerificationsPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RiskV1AddressVerificationsPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RiskV1AddressVerificationsPost201Response))); // Return statement
        }

    }
}

# Iatec.Adems.PeopleManagement.Client.Api.ScholarityApi

All URIs are relative to *https://ws-peoplemgmt.sdasystems.org/bra*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetListScholarityByFilter**](ScholarityApi.md#getlistscholaritybyfilter) | **GET** /scholarity/byFilter | 
[**GetListScholarityByIdList**](ScholarityApi.md#getlistscholaritybyidlist) | **GET** /scholarity/byIdList | 
[**GetScholarityById**](ScholarityApi.md#getscholaritybyid) | **GET** /scholarity/byId | 
[**ScholarityDeleteSystemReference**](ScholarityApi.md#scholaritydeletesystemreference) | **DELETE** /scholarity/systemReference | 
[**ScholaritySaveSystemReference**](ScholarityApi.md#scholaritysavesystemreference) | **PUT** /scholarity/systemReference | 


<a name="getlistscholaritybyfilter"></a>
# **GetListScholarityByFilter**
> List<ScholarityModel> GetListScholarityByFilter (string filter = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListScholarityByFilterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScholarityApi();
            var filter = filter_example;  // string |  (optional) 

            try
            {
                List&lt;ScholarityModel&gt; result = apiInstance.GetListScholarityByFilter(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScholarityApi.GetListScholarityByFilter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**|  | [optional] 

### Return type

[**List<ScholarityModel>**](ScholarityModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistscholaritybyidlist"></a>
# **GetListScholarityByIdList**
> List<ScholarityModel> GetListScholarityByIdList (List<Guid?> idList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListScholarityByIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScholarityApi();
            var idList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;ScholarityModel&gt; result = apiInstance.GetListScholarityByIdList(idList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScholarityApi.GetListScholarityByIdList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idList** | [**List&lt;Guid?&gt;**](Guid?.md)|  | [optional] 

### Return type

[**List<ScholarityModel>**](ScholarityModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getscholaritybyid"></a>
# **GetScholarityById**
> ScholarityModel GetScholarityById (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetScholarityByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScholarityApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                ScholarityModel result = apiInstance.GetScholarityById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScholarityApi.GetScholarityById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

[**ScholarityModel**](ScholarityModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scholaritydeletesystemreference"></a>
# **ScholarityDeleteSystemReference**
> void ScholarityDeleteSystemReference (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class ScholarityDeleteSystemReferenceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScholarityApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.ScholarityDeleteSystemReference(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScholarityApi.ScholarityDeleteSystemReference: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scholaritysavesystemreference"></a>
# **ScholaritySaveSystemReference**
> void ScholaritySaveSystemReference (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class ScholaritySaveSystemReferenceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScholarityApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.ScholaritySaveSystemReference(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScholarityApi.ScholaritySaveSystemReference: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


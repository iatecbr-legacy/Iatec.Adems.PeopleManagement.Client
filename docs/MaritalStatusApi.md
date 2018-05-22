# Iatec.Adems.PeopleManagement.Client.Api.MaritalStatusApi

All URIs are relative to *https://ws-peoplemgmt.sdasystems.org/bra*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetListMaritalStatusByFilter**](MaritalStatusApi.md#getlistmaritalstatusbyfilter) | **GET** /maritalStatus/byFilter | 
[**GetListMaritalStatusByIdList**](MaritalStatusApi.md#getlistmaritalstatusbyidlist) | **GET** /maritalStatus/byIdList | 
[**GetMaritalStatusById**](MaritalStatusApi.md#getmaritalstatusbyid) | **GET** /maritalStatus/byId | 
[**MaritalStatusDeleteSystemReference**](MaritalStatusApi.md#maritalstatusdeletesystemreference) | **DELETE** /maritalStatus/systemReference | 
[**MaritalStatusSaveSystemReference**](MaritalStatusApi.md#maritalstatussavesystemreference) | **PUT** /maritalStatus/systemReference | 


<a name="getlistmaritalstatusbyfilter"></a>
# **GetListMaritalStatusByFilter**
> List<MaritalStatusModel> GetListMaritalStatusByFilter (string filter = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListMaritalStatusByFilterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MaritalStatusApi();
            var filter = filter_example;  // string |  (optional) 

            try
            {
                List&lt;MaritalStatusModel&gt; result = apiInstance.GetListMaritalStatusByFilter(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MaritalStatusApi.GetListMaritalStatusByFilter: " + e.Message );
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

[**List<MaritalStatusModel>**](MaritalStatusModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistmaritalstatusbyidlist"></a>
# **GetListMaritalStatusByIdList**
> List<MaritalStatusModel> GetListMaritalStatusByIdList (List<Guid?> idList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListMaritalStatusByIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MaritalStatusApi();
            var idList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;MaritalStatusModel&gt; result = apiInstance.GetListMaritalStatusByIdList(idList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MaritalStatusApi.GetListMaritalStatusByIdList: " + e.Message );
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

[**List<MaritalStatusModel>**](MaritalStatusModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmaritalstatusbyid"></a>
# **GetMaritalStatusById**
> MaritalStatusModel GetMaritalStatusById (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetMaritalStatusByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MaritalStatusApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                MaritalStatusModel result = apiInstance.GetMaritalStatusById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MaritalStatusApi.GetMaritalStatusById: " + e.Message );
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

[**MaritalStatusModel**](MaritalStatusModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="maritalstatusdeletesystemreference"></a>
# **MaritalStatusDeleteSystemReference**
> void MaritalStatusDeleteSystemReference (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class MaritalStatusDeleteSystemReferenceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MaritalStatusApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.MaritalStatusDeleteSystemReference(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MaritalStatusApi.MaritalStatusDeleteSystemReference: " + e.Message );
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

<a name="maritalstatussavesystemreference"></a>
# **MaritalStatusSaveSystemReference**
> void MaritalStatusSaveSystemReference (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class MaritalStatusSaveSystemReferenceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MaritalStatusApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.MaritalStatusSaveSystemReference(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MaritalStatusApi.MaritalStatusSaveSystemReference: " + e.Message );
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


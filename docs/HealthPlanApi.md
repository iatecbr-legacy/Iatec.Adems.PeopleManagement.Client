# Iatec.Adems.PeopleManagement.Client.Api.HealthPlanApi

All URIs are relative to *https://ws-peoplemgmt.sdasystems.org/bra*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteHealthPlan**](HealthPlanApi.md#deletehealthplan) | **DELETE** /healthPlan | 
[**GetHealthPlanById**](HealthPlanApi.md#gethealthplanbyid) | **GET** /healthPlan/byId | 
[**GetListHealthPlanByIdList**](HealthPlanApi.md#getlisthealthplanbyidlist) | **GET** /healthPlan/byIdList | 
[**GetPageHealthPlanByFilter**](HealthPlanApi.md#getpagehealthplanbyfilter) | **GET** /healthPlan/pageByFilter | 
[**HealthPlanDeleteSystemReference**](HealthPlanApi.md#healthplandeletesystemreference) | **DELETE** /healthPlan/systemReference | 
[**HealthPlanSaveSystemReference**](HealthPlanApi.md#healthplansavesystemreference) | **PUT** /healthPlan/systemReference | 
[**SaveHealthPlan**](HealthPlanApi.md#savehealthplan) | **PUT** /healthPlan | 


<a name="deletehealthplan"></a>
# **DeleteHealthPlan**
> void DeleteHealthPlan (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class DeleteHealthPlanExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HealthPlanApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.DeleteHealthPlan(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthPlanApi.DeleteHealthPlan: " + e.Message );
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

<a name="gethealthplanbyid"></a>
# **GetHealthPlanById**
> HealthPlanModel GetHealthPlanById (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetHealthPlanByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HealthPlanApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                HealthPlanModel result = apiInstance.GetHealthPlanById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthPlanApi.GetHealthPlanById: " + e.Message );
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

[**HealthPlanModel**](HealthPlanModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlisthealthplanbyidlist"></a>
# **GetListHealthPlanByIdList**
> List<HealthPlanModel> GetListHealthPlanByIdList (List<Guid?> idList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListHealthPlanByIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HealthPlanApi();
            var idList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;HealthPlanModel&gt; result = apiInstance.GetListHealthPlanByIdList(idList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthPlanApi.GetListHealthPlanByIdList: " + e.Message );
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

[**List<HealthPlanModel>**](HealthPlanModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagehealthplanbyfilter"></a>
# **GetPageHealthPlanByFilter**
> PagedHealthPlanModel GetPageHealthPlanByFilter (int? numRows, int? pageIndex, string filter = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetPageHealthPlanByFilterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HealthPlanApi();
            var numRows = 56;  // int? | 
            var pageIndex = 56;  // int? | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                PagedHealthPlanModel result = apiInstance.GetPageHealthPlanByFilter(numRows, pageIndex, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthPlanApi.GetPageHealthPlanByFilter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **numRows** | **int?**|  | 
 **pageIndex** | **int?**|  | 
 **filter** | **string**|  | [optional] 

### Return type

[**PagedHealthPlanModel**](PagedHealthPlanModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="healthplandeletesystemreference"></a>
# **HealthPlanDeleteSystemReference**
> void HealthPlanDeleteSystemReference (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class HealthPlanDeleteSystemReferenceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HealthPlanApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.HealthPlanDeleteSystemReference(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthPlanApi.HealthPlanDeleteSystemReference: " + e.Message );
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

<a name="healthplansavesystemreference"></a>
# **HealthPlanSaveSystemReference**
> void HealthPlanSaveSystemReference (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class HealthPlanSaveSystemReferenceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HealthPlanApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.HealthPlanSaveSystemReference(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthPlanApi.HealthPlanSaveSystemReference: " + e.Message );
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

<a name="savehealthplan"></a>
# **SaveHealthPlan**
> HealthPlanModel SaveHealthPlan (HealthPlanModel healthPlan = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class SaveHealthPlanExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HealthPlanApi();
            var healthPlan = new HealthPlanModel(); // HealthPlanModel |  (optional) 

            try
            {
                HealthPlanModel result = apiInstance.SaveHealthPlan(healthPlan);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthPlanApi.SaveHealthPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **healthPlan** | [**HealthPlanModel**](HealthPlanModel.md)|  | [optional] 

### Return type

[**HealthPlanModel**](HealthPlanModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# Iatec.Adems.PeopleManagement.Client.Api.OccupationApi

All URIs are relative to *https://ws-peoplemgmt.sdasystems.org/bra*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetListOccupationByFilter**](OccupationApi.md#getlistoccupationbyfilter) | **GET** /occupation/byFilter | 
[**GetListOccupationByIdList**](OccupationApi.md#getlistoccupationbyidlist) | **GET** /occupation/byIdList | 
[**GetOccupationById**](OccupationApi.md#getoccupationbyid) | **GET** /occupation/byId | 
[**OccupationDeleteSystemReference**](OccupationApi.md#occupationdeletesystemreference) | **DELETE** /occupation/systemReference | 
[**OccupationSaveSystemReference**](OccupationApi.md#occupationsavesystemreference) | **PUT** /occupation/systemReference | 


<a name="getlistoccupationbyfilter"></a>
# **GetListOccupationByFilter**
> List<OccupationModel> GetListOccupationByFilter (string filter = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListOccupationByFilterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OccupationApi();
            var filter = filter_example;  // string |  (optional) 

            try
            {
                List&lt;OccupationModel&gt; result = apiInstance.GetListOccupationByFilter(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OccupationApi.GetListOccupationByFilter: " + e.Message );
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

[**List<OccupationModel>**](OccupationModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistoccupationbyidlist"></a>
# **GetListOccupationByIdList**
> List<OccupationModel> GetListOccupationByIdList (List<Guid?> idList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListOccupationByIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OccupationApi();
            var idList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;OccupationModel&gt; result = apiInstance.GetListOccupationByIdList(idList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OccupationApi.GetListOccupationByIdList: " + e.Message );
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

[**List<OccupationModel>**](OccupationModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoccupationbyid"></a>
# **GetOccupationById**
> OccupationModel GetOccupationById (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetOccupationByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OccupationApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                OccupationModel result = apiInstance.GetOccupationById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OccupationApi.GetOccupationById: " + e.Message );
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

[**OccupationModel**](OccupationModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="occupationdeletesystemreference"></a>
# **OccupationDeleteSystemReference**
> void OccupationDeleteSystemReference (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class OccupationDeleteSystemReferenceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OccupationApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.OccupationDeleteSystemReference(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OccupationApi.OccupationDeleteSystemReference: " + e.Message );
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

<a name="occupationsavesystemreference"></a>
# **OccupationSaveSystemReference**
> void OccupationSaveSystemReference (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class OccupationSaveSystemReferenceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OccupationApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.OccupationSaveSystemReference(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OccupationApi.OccupationSaveSystemReference: " + e.Message );
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


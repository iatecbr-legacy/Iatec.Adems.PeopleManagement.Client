# Iatec.Adems.PeopleManagement.Client.Api.DisabilityTypeApi

All URIs are relative to *https://ws-peoplemgmt.sdasystems.org/bra*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DisabilityTypeDeleteSystemReference**](DisabilityTypeApi.md#disabilitytypedeletesystemreference) | **DELETE** /disabilityType/systemReference | 
[**DisabilityTypeSaveSystemReference**](DisabilityTypeApi.md#disabilitytypesavesystemreference) | **PUT** /disabilityType/systemReference | 
[**GetDisabilityTypeById**](DisabilityTypeApi.md#getdisabilitytypebyid) | **GET** /disabilityType/byId | 
[**GetListDisabilityByIdList**](DisabilityTypeApi.md#getlistdisabilitybyidlist) | **GET** /disabilityType/disabilityByIdList | 
[**GetListDisabilityTypeByFilter**](DisabilityTypeApi.md#getlistdisabilitytypebyfilter) | **GET** /disabilityType/byFilter | 
[**GetPageDisabilityTypeAvailableToNaturalPerson**](DisabilityTypeApi.md#getpagedisabilitytypeavailabletonaturalperson) | **GET** /disabilityType/pageAvailableToNaturalPerson | 


<a name="disabilitytypedeletesystemreference"></a>
# **DisabilityTypeDeleteSystemReference**
> void DisabilityTypeDeleteSystemReference (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class DisabilityTypeDeleteSystemReferenceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DisabilityTypeApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.DisabilityTypeDeleteSystemReference(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DisabilityTypeApi.DisabilityTypeDeleteSystemReference: " + e.Message );
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

<a name="disabilitytypesavesystemreference"></a>
# **DisabilityTypeSaveSystemReference**
> void DisabilityTypeSaveSystemReference (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class DisabilityTypeSaveSystemReferenceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DisabilityTypeApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.DisabilityTypeSaveSystemReference(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DisabilityTypeApi.DisabilityTypeSaveSystemReference: " + e.Message );
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

<a name="getdisabilitytypebyid"></a>
# **GetDisabilityTypeById**
> DisabilityTypeModel GetDisabilityTypeById (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetDisabilityTypeByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DisabilityTypeApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                DisabilityTypeModel result = apiInstance.GetDisabilityTypeById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DisabilityTypeApi.GetDisabilityTypeById: " + e.Message );
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

[**DisabilityTypeModel**](DisabilityTypeModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistdisabilitybyidlist"></a>
# **GetListDisabilityByIdList**
> List<DisabilityTypeModel> GetListDisabilityByIdList (List<Guid?> idList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListDisabilityByIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DisabilityTypeApi();
            var idList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;DisabilityTypeModel&gt; result = apiInstance.GetListDisabilityByIdList(idList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DisabilityTypeApi.GetListDisabilityByIdList: " + e.Message );
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

[**List<DisabilityTypeModel>**](DisabilityTypeModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistdisabilitytypebyfilter"></a>
# **GetListDisabilityTypeByFilter**
> List<DisabilityTypeModel> GetListDisabilityTypeByFilter (string filter = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListDisabilityTypeByFilterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DisabilityTypeApi();
            var filter = filter_example;  // string |  (optional) 

            try
            {
                List&lt;DisabilityTypeModel&gt; result = apiInstance.GetListDisabilityTypeByFilter(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DisabilityTypeApi.GetListDisabilityTypeByFilter: " + e.Message );
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

[**List<DisabilityTypeModel>**](DisabilityTypeModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagedisabilitytypeavailabletonaturalperson"></a>
# **GetPageDisabilityTypeAvailableToNaturalPerson**
> PagedDisabilityTypeModel GetPageDisabilityTypeAvailableToNaturalPerson (Guid? naturalPersonId, int? numRows, int? pageIndex, List<Guid?> selectedItems = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetPageDisabilityTypeAvailableToNaturalPersonExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DisabilityTypeApi();
            var naturalPersonId = new Guid?(); // Guid? | 
            var numRows = 56;  // int? | 
            var pageIndex = 56;  // int? | 
            var selectedItems = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                PagedDisabilityTypeModel result = apiInstance.GetPageDisabilityTypeAvailableToNaturalPerson(naturalPersonId, numRows, pageIndex, selectedItems);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DisabilityTypeApi.GetPageDisabilityTypeAvailableToNaturalPerson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **naturalPersonId** | [**Guid?**](Guid?.md)|  | 
 **numRows** | **int?**|  | 
 **pageIndex** | **int?**|  | 
 **selectedItems** | [**List&lt;Guid?&gt;**](Guid?.md)|  | [optional] 

### Return type

[**PagedDisabilityTypeModel**](PagedDisabilityTypeModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


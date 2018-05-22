# Iatec.Adems.PeopleManagement.Client.Api.NaturalPersonDisabilityApi

All URIs are relative to *https://ws-peoplemgmt.sdasystems.org/bra*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteNaturalPersonDisability**](NaturalPersonDisabilityApi.md#deletenaturalpersondisability) | **DELETE** /naturalPersonDisability | 
[**GetListNaturalPersonDisabilityByNaturalPerson**](NaturalPersonDisabilityApi.md#getlistnaturalpersondisabilitybynaturalperson) | **GET** /naturalPersonDisability/byNaturalPerson | 
[**GetListNaturalPersonDisabilityByNaturalPersonIdList**](NaturalPersonDisabilityApi.md#getlistnaturalpersondisabilitybynaturalpersonidlist) | **GET** /naturalPersonDisability/byNaturalPersonIdList | 
[**GetListNaturalPersonDisabilityByTypeAndNaturalPersonIdList**](NaturalPersonDisabilityApi.md#getlistnaturalpersondisabilitybytypeandnaturalpersonidlist) | **GET** /naturalPersonDisability/byTypeAndNaturalPersonIdList | 
[**GetNaturalPersonDisabilityById**](NaturalPersonDisabilityApi.md#getnaturalpersondisabilitybyid) | **GET** /naturalPersonDisability/byId | 
[**SaveNaturalPersonDisabilityList**](NaturalPersonDisabilityApi.md#savenaturalpersondisabilitylist) | **PUT** /naturalPersonDisability | 


<a name="deletenaturalpersondisability"></a>
# **DeleteNaturalPersonDisability**
> void DeleteNaturalPersonDisability (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class DeleteNaturalPersonDisabilityExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonDisabilityApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.DeleteNaturalPersonDisability(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonDisabilityApi.DeleteNaturalPersonDisability: " + e.Message );
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

<a name="getlistnaturalpersondisabilitybynaturalperson"></a>
# **GetListNaturalPersonDisabilityByNaturalPerson**
> List<NaturalPersonDisabilityLiteModel> GetListNaturalPersonDisabilityByNaturalPerson (Guid? naturalPersonId)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListNaturalPersonDisabilityByNaturalPersonExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonDisabilityApi();
            var naturalPersonId = new Guid?(); // Guid? | 

            try
            {
                List&lt;NaturalPersonDisabilityLiteModel&gt; result = apiInstance.GetListNaturalPersonDisabilityByNaturalPerson(naturalPersonId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonDisabilityApi.GetListNaturalPersonDisabilityByNaturalPerson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **naturalPersonId** | [**Guid?**](Guid?.md)|  | 

### Return type

[**List<NaturalPersonDisabilityLiteModel>**](NaturalPersonDisabilityLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistnaturalpersondisabilitybynaturalpersonidlist"></a>
# **GetListNaturalPersonDisabilityByNaturalPersonIdList**
> List<NaturalPersonDisabilityLiteModel> GetListNaturalPersonDisabilityByNaturalPersonIdList (List<Guid?> naturalPersonIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListNaturalPersonDisabilityByNaturalPersonIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonDisabilityApi();
            var naturalPersonIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;NaturalPersonDisabilityLiteModel&gt; result = apiInstance.GetListNaturalPersonDisabilityByNaturalPersonIdList(naturalPersonIdList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonDisabilityApi.GetListNaturalPersonDisabilityByNaturalPersonIdList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **naturalPersonIdList** | [**List&lt;Guid?&gt;**](Guid?.md)|  | [optional] 

### Return type

[**List<NaturalPersonDisabilityLiteModel>**](NaturalPersonDisabilityLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistnaturalpersondisabilitybytypeandnaturalpersonidlist"></a>
# **GetListNaturalPersonDisabilityByTypeAndNaturalPersonIdList**
> List<NaturalPersonDisabilityLiteModel> GetListNaturalPersonDisabilityByTypeAndNaturalPersonIdList (Guid? disabilityTypeId, List<Guid?> naturalPersonIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListNaturalPersonDisabilityByTypeAndNaturalPersonIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonDisabilityApi();
            var disabilityTypeId = new Guid?(); // Guid? | 
            var naturalPersonIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;NaturalPersonDisabilityLiteModel&gt; result = apiInstance.GetListNaturalPersonDisabilityByTypeAndNaturalPersonIdList(disabilityTypeId, naturalPersonIdList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonDisabilityApi.GetListNaturalPersonDisabilityByTypeAndNaturalPersonIdList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **disabilityTypeId** | [**Guid?**](Guid?.md)|  | 
 **naturalPersonIdList** | [**List&lt;Guid?&gt;**](Guid?.md)|  | [optional] 

### Return type

[**List<NaturalPersonDisabilityLiteModel>**](NaturalPersonDisabilityLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnaturalpersondisabilitybyid"></a>
# **GetNaturalPersonDisabilityById**
> NaturalPersonDisabilityLiteModel GetNaturalPersonDisabilityById (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetNaturalPersonDisabilityByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonDisabilityApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                NaturalPersonDisabilityLiteModel result = apiInstance.GetNaturalPersonDisabilityById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonDisabilityApi.GetNaturalPersonDisabilityById: " + e.Message );
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

[**NaturalPersonDisabilityLiteModel**](NaturalPersonDisabilityLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savenaturalpersondisabilitylist"></a>
# **SaveNaturalPersonDisabilityList**
> List<NaturalPersonDisabilityLiteModel> SaveNaturalPersonDisabilityList (List<NaturalPersonDisabilityLiteModel> naturalPersonDisabilityList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class SaveNaturalPersonDisabilityListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonDisabilityApi();
            var naturalPersonDisabilityList = new List<NaturalPersonDisabilityLiteModel>(); // List<NaturalPersonDisabilityLiteModel> |  (optional) 

            try
            {
                List&lt;NaturalPersonDisabilityLiteModel&gt; result = apiInstance.SaveNaturalPersonDisabilityList(naturalPersonDisabilityList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonDisabilityApi.SaveNaturalPersonDisabilityList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **naturalPersonDisabilityList** | [**List&lt;NaturalPersonDisabilityLiteModel&gt;**](NaturalPersonDisabilityLiteModel.md)|  | [optional] 

### Return type

[**List<NaturalPersonDisabilityLiteModel>**](NaturalPersonDisabilityLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


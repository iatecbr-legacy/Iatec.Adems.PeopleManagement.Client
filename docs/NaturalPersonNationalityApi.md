# Iatec.Adems.PeopleManagement.Client.Api.NaturalPersonNationalityApi

All URIs are relative to *https://ws-peoplemgmt.sdasystems.org/bra*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteNaturalPersonNationality**](NaturalPersonNationalityApi.md#deletenaturalpersonnationality) | **DELETE** /naturalPersonNationality | 
[**GetListNaturalPersonNationalityByNaturalPerson**](NaturalPersonNationalityApi.md#getlistnaturalpersonnationalitybynaturalperson) | **GET** /naturalPersonNationality/byNaturalPerson | 
[**GetListNaturalPersonNationalityByNaturalPersonIdList**](NaturalPersonNationalityApi.md#getlistnaturalpersonnationalitybynaturalpersonidlist) | **GET** /naturalPersonNationality/byNaturalPersonIdList | 
[**GetNaturalPersonNationalityById**](NaturalPersonNationalityApi.md#getnaturalpersonnationalitybyid) | **GET** /naturalPersonNationality/byId | 
[**SaveNaturalPersonNationalityList**](NaturalPersonNationalityApi.md#savenaturalpersonnationalitylist) | **PUT** /naturalPersonNationality | 


<a name="deletenaturalpersonnationality"></a>
# **DeleteNaturalPersonNationality**
> void DeleteNaturalPersonNationality (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class DeleteNaturalPersonNationalityExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonNationalityApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.DeleteNaturalPersonNationality(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonNationalityApi.DeleteNaturalPersonNationality: " + e.Message );
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

<a name="getlistnaturalpersonnationalitybynaturalperson"></a>
# **GetListNaturalPersonNationalityByNaturalPerson**
> List<NaturalPersonNationalityLiteModel> GetListNaturalPersonNationalityByNaturalPerson (Guid? naturalPersonId)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListNaturalPersonNationalityByNaturalPersonExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonNationalityApi();
            var naturalPersonId = new Guid?(); // Guid? | 

            try
            {
                List&lt;NaturalPersonNationalityLiteModel&gt; result = apiInstance.GetListNaturalPersonNationalityByNaturalPerson(naturalPersonId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonNationalityApi.GetListNaturalPersonNationalityByNaturalPerson: " + e.Message );
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

[**List<NaturalPersonNationalityLiteModel>**](NaturalPersonNationalityLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistnaturalpersonnationalitybynaturalpersonidlist"></a>
# **GetListNaturalPersonNationalityByNaturalPersonIdList**
> List<NaturalPersonNationalityLiteModel> GetListNaturalPersonNationalityByNaturalPersonIdList (List<Guid?> naturalPersonIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListNaturalPersonNationalityByNaturalPersonIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonNationalityApi();
            var naturalPersonIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;NaturalPersonNationalityLiteModel&gt; result = apiInstance.GetListNaturalPersonNationalityByNaturalPersonIdList(naturalPersonIdList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonNationalityApi.GetListNaturalPersonNationalityByNaturalPersonIdList: " + e.Message );
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

[**List<NaturalPersonNationalityLiteModel>**](NaturalPersonNationalityLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnaturalpersonnationalitybyid"></a>
# **GetNaturalPersonNationalityById**
> NaturalPersonNationalityLiteModel GetNaturalPersonNationalityById (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetNaturalPersonNationalityByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonNationalityApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                NaturalPersonNationalityLiteModel result = apiInstance.GetNaturalPersonNationalityById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonNationalityApi.GetNaturalPersonNationalityById: " + e.Message );
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

[**NaturalPersonNationalityLiteModel**](NaturalPersonNationalityLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savenaturalpersonnationalitylist"></a>
# **SaveNaturalPersonNationalityList**
> List<NaturalPersonNationalityLiteModel> SaveNaturalPersonNationalityList (List<NaturalPersonNationalityLiteModel> naturalPersonNationalityList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class SaveNaturalPersonNationalityListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonNationalityApi();
            var naturalPersonNationalityList = new List<NaturalPersonNationalityLiteModel>(); // List<NaturalPersonNationalityLiteModel> |  (optional) 

            try
            {
                List&lt;NaturalPersonNationalityLiteModel&gt; result = apiInstance.SaveNaturalPersonNationalityList(naturalPersonNationalityList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonNationalityApi.SaveNaturalPersonNationalityList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **naturalPersonNationalityList** | [**List&lt;NaturalPersonNationalityLiteModel&gt;**](NaturalPersonNationalityLiteModel.md)|  | [optional] 

### Return type

[**List<NaturalPersonNationalityLiteModel>**](NaturalPersonNationalityLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


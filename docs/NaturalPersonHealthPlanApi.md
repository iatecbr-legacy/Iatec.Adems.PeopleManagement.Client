# Iatec.Adems.PeopleManagement.Client.Api.NaturalPersonHealthPlanApi

All URIs are relative to *https://ws-peoplemgmt.sdasystems.org/bra*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteNaturalPersonHealthPlan**](NaturalPersonHealthPlanApi.md#deletenaturalpersonhealthplan) | **DELETE** /naturalPersonHealthPlan | 
[**GetListByPlanAndNaturalPersonIdList**](NaturalPersonHealthPlanApi.md#getlistbyplanandnaturalpersonidlist) | **GET** /naturalPersonHealthPlan/byPlanAndNaturalPersonIdList | 
[**GetListNaturalPersonHealthPlanByNaturalPerson**](NaturalPersonHealthPlanApi.md#getlistnaturalpersonhealthplanbynaturalperson) | **GET** /naturalPersonHealthPlan/byNaturalPerson | 
[**GetListNaturalPersonHealthPlanByNaturalPersonIdList**](NaturalPersonHealthPlanApi.md#getlistnaturalpersonhealthplanbynaturalpersonidlist) | **GET** /naturalPersonHealthPlan/byNaturalPersonIdList | 
[**GetNaturalPersonHealthPlanById**](NaturalPersonHealthPlanApi.md#getnaturalpersonhealthplanbyid) | **GET** /naturalPersonHealthPlan/byId | 
[**SaveNaturalPersonHealthPlan**](NaturalPersonHealthPlanApi.md#savenaturalpersonhealthplan) | **PUT** /naturalPersonHealthPlan | 


<a name="deletenaturalpersonhealthplan"></a>
# **DeleteNaturalPersonHealthPlan**
> void DeleteNaturalPersonHealthPlan (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class DeleteNaturalPersonHealthPlanExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonHealthPlanApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.DeleteNaturalPersonHealthPlan(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonHealthPlanApi.DeleteNaturalPersonHealthPlan: " + e.Message );
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

<a name="getlistbyplanandnaturalpersonidlist"></a>
# **GetListByPlanAndNaturalPersonIdList**
> List<NaturalPersonHealthPlanLiteModel> GetListByPlanAndNaturalPersonIdList (Guid? healthPlanId, List<Guid?> naturalPersonIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListByPlanAndNaturalPersonIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonHealthPlanApi();
            var healthPlanId = new Guid?(); // Guid? | 
            var naturalPersonIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;NaturalPersonHealthPlanLiteModel&gt; result = apiInstance.GetListByPlanAndNaturalPersonIdList(healthPlanId, naturalPersonIdList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonHealthPlanApi.GetListByPlanAndNaturalPersonIdList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **healthPlanId** | [**Guid?**](Guid?.md)|  | 
 **naturalPersonIdList** | [**List&lt;Guid?&gt;**](Guid?.md)|  | [optional] 

### Return type

[**List<NaturalPersonHealthPlanLiteModel>**](NaturalPersonHealthPlanLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistnaturalpersonhealthplanbynaturalperson"></a>
# **GetListNaturalPersonHealthPlanByNaturalPerson**
> List<NaturalPersonHealthPlanLiteModel> GetListNaturalPersonHealthPlanByNaturalPerson (Guid? naturalPersonId)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListNaturalPersonHealthPlanByNaturalPersonExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonHealthPlanApi();
            var naturalPersonId = new Guid?(); // Guid? | 

            try
            {
                List&lt;NaturalPersonHealthPlanLiteModel&gt; result = apiInstance.GetListNaturalPersonHealthPlanByNaturalPerson(naturalPersonId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonHealthPlanApi.GetListNaturalPersonHealthPlanByNaturalPerson: " + e.Message );
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

[**List<NaturalPersonHealthPlanLiteModel>**](NaturalPersonHealthPlanLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistnaturalpersonhealthplanbynaturalpersonidlist"></a>
# **GetListNaturalPersonHealthPlanByNaturalPersonIdList**
> List<NaturalPersonHealthPlanLiteModel> GetListNaturalPersonHealthPlanByNaturalPersonIdList (List<Guid?> naturalPersonIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListNaturalPersonHealthPlanByNaturalPersonIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonHealthPlanApi();
            var naturalPersonIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;NaturalPersonHealthPlanLiteModel&gt; result = apiInstance.GetListNaturalPersonHealthPlanByNaturalPersonIdList(naturalPersonIdList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonHealthPlanApi.GetListNaturalPersonHealthPlanByNaturalPersonIdList: " + e.Message );
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

[**List<NaturalPersonHealthPlanLiteModel>**](NaturalPersonHealthPlanLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnaturalpersonhealthplanbyid"></a>
# **GetNaturalPersonHealthPlanById**
> NaturalPersonHealthPlanLiteModel GetNaturalPersonHealthPlanById (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetNaturalPersonHealthPlanByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonHealthPlanApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                NaturalPersonHealthPlanLiteModel result = apiInstance.GetNaturalPersonHealthPlanById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonHealthPlanApi.GetNaturalPersonHealthPlanById: " + e.Message );
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

[**NaturalPersonHealthPlanLiteModel**](NaturalPersonHealthPlanLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savenaturalpersonhealthplan"></a>
# **SaveNaturalPersonHealthPlan**
> NaturalPersonHealthPlanLiteModel SaveNaturalPersonHealthPlan (NaturalPersonHealthPlanLiteModel naturalPersonHealthPlan = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class SaveNaturalPersonHealthPlanExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonHealthPlanApi();
            var naturalPersonHealthPlan = new NaturalPersonHealthPlanLiteModel(); // NaturalPersonHealthPlanLiteModel |  (optional) 

            try
            {
                NaturalPersonHealthPlanLiteModel result = apiInstance.SaveNaturalPersonHealthPlan(naturalPersonHealthPlan);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonHealthPlanApi.SaveNaturalPersonHealthPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **naturalPersonHealthPlan** | [**NaturalPersonHealthPlanLiteModel**](NaturalPersonHealthPlanLiteModel.md)|  | [optional] 

### Return type

[**NaturalPersonHealthPlanLiteModel**](NaturalPersonHealthPlanLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


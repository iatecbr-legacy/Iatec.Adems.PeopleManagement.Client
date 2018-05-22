# Iatec.Adems.PeopleManagement.Client.Api.NaturalPersonDiseaseApi

All URIs are relative to *https://ws-peoplemgmt.sdasystems.org/bra*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteNaturalPersonDisease**](NaturalPersonDiseaseApi.md#deletenaturalpersondisease) | **DELETE** /naturalPersonDisease | 
[**GetListNaturalPersonDiseaseByNaturalPerson**](NaturalPersonDiseaseApi.md#getlistnaturalpersondiseasebynaturalperson) | **GET** /naturalPersonDisease/byNaturalPerson | 
[**GetListNaturalPersonDiseaseByNaturalPersonIdList**](NaturalPersonDiseaseApi.md#getlistnaturalpersondiseasebynaturalpersonidlist) | **GET** /naturalPersonDisease/byNaturalPersonIdList | 
[**GetListNaturalPersonDiseaseByTypeAndNaturalPersonIdList**](NaturalPersonDiseaseApi.md#getlistnaturalpersondiseasebytypeandnaturalpersonidlist) | **GET** /naturalPersonDisease/byTypeAndNaturalPersonIdList | 
[**GetNaturalPersonDiseaseById**](NaturalPersonDiseaseApi.md#getnaturalpersondiseasebyid) | **GET** /naturalPersonDisease/byId | 
[**SaveNaturalPersonDiseaseList**](NaturalPersonDiseaseApi.md#savenaturalpersondiseaselist) | **PUT** /naturalPersonDisease | 


<a name="deletenaturalpersondisease"></a>
# **DeleteNaturalPersonDisease**
> void DeleteNaturalPersonDisease (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class DeleteNaturalPersonDiseaseExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonDiseaseApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.DeleteNaturalPersonDisease(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonDiseaseApi.DeleteNaturalPersonDisease: " + e.Message );
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

<a name="getlistnaturalpersondiseasebynaturalperson"></a>
# **GetListNaturalPersonDiseaseByNaturalPerson**
> List<NaturalPersonDiseaseLiteModel> GetListNaturalPersonDiseaseByNaturalPerson (Guid? naturalPersonId)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListNaturalPersonDiseaseByNaturalPersonExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonDiseaseApi();
            var naturalPersonId = new Guid?(); // Guid? | 

            try
            {
                List&lt;NaturalPersonDiseaseLiteModel&gt; result = apiInstance.GetListNaturalPersonDiseaseByNaturalPerson(naturalPersonId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonDiseaseApi.GetListNaturalPersonDiseaseByNaturalPerson: " + e.Message );
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

[**List<NaturalPersonDiseaseLiteModel>**](NaturalPersonDiseaseLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistnaturalpersondiseasebynaturalpersonidlist"></a>
# **GetListNaturalPersonDiseaseByNaturalPersonIdList**
> List<NaturalPersonDiseaseLiteModel> GetListNaturalPersonDiseaseByNaturalPersonIdList (List<Guid?> naturalPersonIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListNaturalPersonDiseaseByNaturalPersonIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonDiseaseApi();
            var naturalPersonIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;NaturalPersonDiseaseLiteModel&gt; result = apiInstance.GetListNaturalPersonDiseaseByNaturalPersonIdList(naturalPersonIdList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonDiseaseApi.GetListNaturalPersonDiseaseByNaturalPersonIdList: " + e.Message );
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

[**List<NaturalPersonDiseaseLiteModel>**](NaturalPersonDiseaseLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistnaturalpersondiseasebytypeandnaturalpersonidlist"></a>
# **GetListNaturalPersonDiseaseByTypeAndNaturalPersonIdList**
> List<NaturalPersonDiseaseLiteModel> GetListNaturalPersonDiseaseByTypeAndNaturalPersonIdList (Guid? diseaseTypeId, List<Guid?> naturalPersonIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListNaturalPersonDiseaseByTypeAndNaturalPersonIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonDiseaseApi();
            var diseaseTypeId = new Guid?(); // Guid? | 
            var naturalPersonIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;NaturalPersonDiseaseLiteModel&gt; result = apiInstance.GetListNaturalPersonDiseaseByTypeAndNaturalPersonIdList(diseaseTypeId, naturalPersonIdList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonDiseaseApi.GetListNaturalPersonDiseaseByTypeAndNaturalPersonIdList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **diseaseTypeId** | [**Guid?**](Guid?.md)|  | 
 **naturalPersonIdList** | [**List&lt;Guid?&gt;**](Guid?.md)|  | [optional] 

### Return type

[**List<NaturalPersonDiseaseLiteModel>**](NaturalPersonDiseaseLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnaturalpersondiseasebyid"></a>
# **GetNaturalPersonDiseaseById**
> NaturalPersonDiseaseLiteModel GetNaturalPersonDiseaseById (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetNaturalPersonDiseaseByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonDiseaseApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                NaturalPersonDiseaseLiteModel result = apiInstance.GetNaturalPersonDiseaseById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonDiseaseApi.GetNaturalPersonDiseaseById: " + e.Message );
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

[**NaturalPersonDiseaseLiteModel**](NaturalPersonDiseaseLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savenaturalpersondiseaselist"></a>
# **SaveNaturalPersonDiseaseList**
> List<NaturalPersonDiseaseLiteModel> SaveNaturalPersonDiseaseList (List<NaturalPersonDiseaseLiteModel> naturalPersonDisease = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class SaveNaturalPersonDiseaseListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonDiseaseApi();
            var naturalPersonDisease = new List<NaturalPersonDiseaseLiteModel>(); // List<NaturalPersonDiseaseLiteModel> |  (optional) 

            try
            {
                List&lt;NaturalPersonDiseaseLiteModel&gt; result = apiInstance.SaveNaturalPersonDiseaseList(naturalPersonDisease);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonDiseaseApi.SaveNaturalPersonDiseaseList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **naturalPersonDisease** | [**List&lt;NaturalPersonDiseaseLiteModel&gt;**](NaturalPersonDiseaseLiteModel.md)|  | [optional] 

### Return type

[**List<NaturalPersonDiseaseLiteModel>**](NaturalPersonDiseaseLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


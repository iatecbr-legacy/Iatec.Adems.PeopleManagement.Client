# Iatec.Adems.PeopleManagement.Client.Api.NaturalPersonAllergyApi

All URIs are relative to *https://ws-peoplemgmt.sdasystems.org/bra*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetListNaturalPersonAllergyByNaturalPerson**](NaturalPersonAllergyApi.md#getlistnaturalpersonallergybynaturalperson) | **GET** /naturalPersonAllergy/byNaturalPerson | 
[**GetListNaturalPersonAllergyByNaturalPersonIdList**](NaturalPersonAllergyApi.md#getlistnaturalpersonallergybynaturalpersonidlist) | **GET** /naturalPersonAllergy/byNaturalPersonIdList | 
[**GetListNaturalPersonAllergyByTypeAndNaturalPersonIdList**](NaturalPersonAllergyApi.md#getlistnaturalpersonallergybytypeandnaturalpersonidlist) | **GET** /naturalPersonAllergy/byTypeAndNaturalPersonIdList | 
[**GetNaturalPersonAllergyById**](NaturalPersonAllergyApi.md#getnaturalpersonallergybyid) | **GET** /naturalPersonAllergy/byId | 
[**NaturalPersonAllergyDeleteNaturalPerson**](NaturalPersonAllergyApi.md#naturalpersonallergydeletenaturalperson) | **DELETE** /naturalPersonAllergy/naturalPerson | 
[**SaveNaturalPersonAllergy**](NaturalPersonAllergyApi.md#savenaturalpersonallergy) | **PUT** /naturalPersonAllergy | 


<a name="getlistnaturalpersonallergybynaturalperson"></a>
# **GetListNaturalPersonAllergyByNaturalPerson**
> List<NaturalPersonAllergyLiteModel> GetListNaturalPersonAllergyByNaturalPerson (Guid? naturalPersonId)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListNaturalPersonAllergyByNaturalPersonExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonAllergyApi();
            var naturalPersonId = new Guid?(); // Guid? | 

            try
            {
                List&lt;NaturalPersonAllergyLiteModel&gt; result = apiInstance.GetListNaturalPersonAllergyByNaturalPerson(naturalPersonId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonAllergyApi.GetListNaturalPersonAllergyByNaturalPerson: " + e.Message );
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

[**List<NaturalPersonAllergyLiteModel>**](NaturalPersonAllergyLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistnaturalpersonallergybynaturalpersonidlist"></a>
# **GetListNaturalPersonAllergyByNaturalPersonIdList**
> List<NaturalPersonAllergyLiteModel> GetListNaturalPersonAllergyByNaturalPersonIdList (List<Guid?> naturalPersonIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListNaturalPersonAllergyByNaturalPersonIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonAllergyApi();
            var naturalPersonIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;NaturalPersonAllergyLiteModel&gt; result = apiInstance.GetListNaturalPersonAllergyByNaturalPersonIdList(naturalPersonIdList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonAllergyApi.GetListNaturalPersonAllergyByNaturalPersonIdList: " + e.Message );
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

[**List<NaturalPersonAllergyLiteModel>**](NaturalPersonAllergyLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistnaturalpersonallergybytypeandnaturalpersonidlist"></a>
# **GetListNaturalPersonAllergyByTypeAndNaturalPersonIdList**
> List<NaturalPersonAllergyLiteModel> GetListNaturalPersonAllergyByTypeAndNaturalPersonIdList (Guid? allergyTypeId, List<Guid?> naturalPersonIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListNaturalPersonAllergyByTypeAndNaturalPersonIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonAllergyApi();
            var allergyTypeId = new Guid?(); // Guid? | 
            var naturalPersonIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;NaturalPersonAllergyLiteModel&gt; result = apiInstance.GetListNaturalPersonAllergyByTypeAndNaturalPersonIdList(allergyTypeId, naturalPersonIdList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonAllergyApi.GetListNaturalPersonAllergyByTypeAndNaturalPersonIdList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **allergyTypeId** | [**Guid?**](Guid?.md)|  | 
 **naturalPersonIdList** | [**List&lt;Guid?&gt;**](Guid?.md)|  | [optional] 

### Return type

[**List<NaturalPersonAllergyLiteModel>**](NaturalPersonAllergyLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnaturalpersonallergybyid"></a>
# **GetNaturalPersonAllergyById**
> NaturalPersonAllergyLiteModel GetNaturalPersonAllergyById (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetNaturalPersonAllergyByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonAllergyApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                NaturalPersonAllergyLiteModel result = apiInstance.GetNaturalPersonAllergyById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonAllergyApi.GetNaturalPersonAllergyById: " + e.Message );
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

[**NaturalPersonAllergyLiteModel**](NaturalPersonAllergyLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="naturalpersonallergydeletenaturalperson"></a>
# **NaturalPersonAllergyDeleteNaturalPerson**
> void NaturalPersonAllergyDeleteNaturalPerson (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class NaturalPersonAllergyDeleteNaturalPersonExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonAllergyApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.NaturalPersonAllergyDeleteNaturalPerson(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonAllergyApi.NaturalPersonAllergyDeleteNaturalPerson: " + e.Message );
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

<a name="savenaturalpersonallergy"></a>
# **SaveNaturalPersonAllergy**
> NaturalPersonAllergyLiteModel SaveNaturalPersonAllergy (NaturalPersonAllergyLiteModel naturalPersonAllergy = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class SaveNaturalPersonAllergyExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonAllergyApi();
            var naturalPersonAllergy = new NaturalPersonAllergyLiteModel(); // NaturalPersonAllergyLiteModel |  (optional) 

            try
            {
                NaturalPersonAllergyLiteModel result = apiInstance.SaveNaturalPersonAllergy(naturalPersonAllergy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonAllergyApi.SaveNaturalPersonAllergy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **naturalPersonAllergy** | [**NaturalPersonAllergyLiteModel**](NaturalPersonAllergyLiteModel.md)|  | [optional] 

### Return type

[**NaturalPersonAllergyLiteModel**](NaturalPersonAllergyLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


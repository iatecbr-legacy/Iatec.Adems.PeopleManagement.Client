# Iatec.Adems.PeopleManagement.Client.Api.NaturalPersonMedicineApi

All URIs are relative to *https://ws-peoplemgmt.sdasystems.org/bra*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteNaturalPersonMedicine**](NaturalPersonMedicineApi.md#deletenaturalpersonmedicine) | **DELETE** /naturalPersonMedicine | 
[**GetListNaturalPersonMedicineByNaturalPerson**](NaturalPersonMedicineApi.md#getlistnaturalpersonmedicinebynaturalperson) | **GET** /naturalPersonMedicine/byNaturalPerson | 
[**GetListNaturalPersonMedicineByNaturalPersonIdList**](NaturalPersonMedicineApi.md#getlistnaturalpersonmedicinebynaturalpersonidlist) | **GET** /naturalPersonMedicine/byNaturalPersonIdList | 
[**GetNaturalPersonMedicineById**](NaturalPersonMedicineApi.md#getnaturalpersonmedicinebyid) | **GET** /naturalPersonMedicine/byId | 
[**SaveNaturalPersonMedicine**](NaturalPersonMedicineApi.md#savenaturalpersonmedicine) | **PUT** /naturalPersonMedicine | 


<a name="deletenaturalpersonmedicine"></a>
# **DeleteNaturalPersonMedicine**
> void DeleteNaturalPersonMedicine (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class DeleteNaturalPersonMedicineExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonMedicineApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.DeleteNaturalPersonMedicine(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonMedicineApi.DeleteNaturalPersonMedicine: " + e.Message );
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

<a name="getlistnaturalpersonmedicinebynaturalperson"></a>
# **GetListNaturalPersonMedicineByNaturalPerson**
> List<NaturalPersonMedicineLiteModel> GetListNaturalPersonMedicineByNaturalPerson (Guid? naturalPersonId)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListNaturalPersonMedicineByNaturalPersonExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonMedicineApi();
            var naturalPersonId = new Guid?(); // Guid? | 

            try
            {
                List&lt;NaturalPersonMedicineLiteModel&gt; result = apiInstance.GetListNaturalPersonMedicineByNaturalPerson(naturalPersonId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonMedicineApi.GetListNaturalPersonMedicineByNaturalPerson: " + e.Message );
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

[**List<NaturalPersonMedicineLiteModel>**](NaturalPersonMedicineLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistnaturalpersonmedicinebynaturalpersonidlist"></a>
# **GetListNaturalPersonMedicineByNaturalPersonIdList**
> List<NaturalPersonMedicineLiteModel> GetListNaturalPersonMedicineByNaturalPersonIdList (List<Guid?> naturalPersonIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListNaturalPersonMedicineByNaturalPersonIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonMedicineApi();
            var naturalPersonIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;NaturalPersonMedicineLiteModel&gt; result = apiInstance.GetListNaturalPersonMedicineByNaturalPersonIdList(naturalPersonIdList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonMedicineApi.GetListNaturalPersonMedicineByNaturalPersonIdList: " + e.Message );
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

[**List<NaturalPersonMedicineLiteModel>**](NaturalPersonMedicineLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnaturalpersonmedicinebyid"></a>
# **GetNaturalPersonMedicineById**
> NaturalPersonMedicineLiteModel GetNaturalPersonMedicineById (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetNaturalPersonMedicineByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonMedicineApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                NaturalPersonMedicineLiteModel result = apiInstance.GetNaturalPersonMedicineById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonMedicineApi.GetNaturalPersonMedicineById: " + e.Message );
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

[**NaturalPersonMedicineLiteModel**](NaturalPersonMedicineLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savenaturalpersonmedicine"></a>
# **SaveNaturalPersonMedicine**
> NaturalPersonMedicineLiteModel SaveNaturalPersonMedicine (NaturalPersonMedicineLiteModel naturalPersonMedicineLite = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class SaveNaturalPersonMedicineExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonMedicineApi();
            var naturalPersonMedicineLite = new NaturalPersonMedicineLiteModel(); // NaturalPersonMedicineLiteModel |  (optional) 

            try
            {
                NaturalPersonMedicineLiteModel result = apiInstance.SaveNaturalPersonMedicine(naturalPersonMedicineLite);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonMedicineApi.SaveNaturalPersonMedicine: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **naturalPersonMedicineLite** | [**NaturalPersonMedicineLiteModel**](NaturalPersonMedicineLiteModel.md)|  | [optional] 

### Return type

[**NaturalPersonMedicineLiteModel**](NaturalPersonMedicineLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# Iatec.Adems.PeopleManagement.Client.Api.IntegrationApi

All URIs are relative to *https://ws-peoplemgmt.sdasystems.org/bra*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetNaturalPersonById**](IntegrationApi.md#getnaturalpersonbyid) | **GET** /integration/naturalPersonById | 
[**SaveNaturalPersonList**](IntegrationApi.md#savenaturalpersonlist) | **PUT** /integration/naturalPersonList | 


<a name="getnaturalpersonbyid"></a>
# **GetNaturalPersonById**
> NaturalPersonIntegrationModel GetNaturalPersonById (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetNaturalPersonByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IntegrationApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                NaturalPersonIntegrationModel result = apiInstance.GetNaturalPersonById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationApi.GetNaturalPersonById: " + e.Message );
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

[**NaturalPersonIntegrationModel**](NaturalPersonIntegrationModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savenaturalpersonlist"></a>
# **SaveNaturalPersonList**
> List<MessageLogIntegrationModel> SaveNaturalPersonList (List<NaturalPersonIntegrationModel> naturalPersonList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class SaveNaturalPersonListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IntegrationApi();
            var naturalPersonList = new List<NaturalPersonIntegrationModel>(); // List<NaturalPersonIntegrationModel> |  (optional) 

            try
            {
                List&lt;MessageLogIntegrationModel&gt; result = apiInstance.SaveNaturalPersonList(naturalPersonList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationApi.SaveNaturalPersonList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **naturalPersonList** | [**List&lt;NaturalPersonIntegrationModel&gt;**](NaturalPersonIntegrationModel.md)|  | [optional] 

### Return type

[**List<MessageLogIntegrationModel>**](MessageLogIntegrationModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


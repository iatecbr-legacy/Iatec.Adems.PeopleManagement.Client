# Iatec.Adems.PeopleManagement.Client.Api.EmergencyContactApi

All URIs are relative to *https://ws-peoplemgmt.sdasystems.org/bra*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteEmergencyContact**](EmergencyContactApi.md#deleteemergencycontact) | **DELETE** /emergencyContact | 
[**GetEmergencyContactById**](EmergencyContactApi.md#getemergencycontactbyid) | **GET** /emergencyContact/byId | 
[**GetListEmergencyContactByNaturalPerson**](EmergencyContactApi.md#getlistemergencycontactbynaturalperson) | **GET** /emergencyContact/byNaturalPerson | 
[**GetListEmergencyContactByNaturalPersonIdList**](EmergencyContactApi.md#getlistemergencycontactbynaturalpersonidlist) | **GET** /emergencyContact/byNaturalPersonIdList | 
[**SaveEmergencyContact**](EmergencyContactApi.md#saveemergencycontact) | **PUT** /emergencyContact | 


<a name="deleteemergencycontact"></a>
# **DeleteEmergencyContact**
> void DeleteEmergencyContact (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class DeleteEmergencyContactExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmergencyContactApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.DeleteEmergencyContact(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmergencyContactApi.DeleteEmergencyContact: " + e.Message );
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

<a name="getemergencycontactbyid"></a>
# **GetEmergencyContactById**
> EmergencyContactLiteModel GetEmergencyContactById (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetEmergencyContactByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmergencyContactApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                EmergencyContactLiteModel result = apiInstance.GetEmergencyContactById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmergencyContactApi.GetEmergencyContactById: " + e.Message );
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

[**EmergencyContactLiteModel**](EmergencyContactLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistemergencycontactbynaturalperson"></a>
# **GetListEmergencyContactByNaturalPerson**
> List<EmergencyContactLiteModel> GetListEmergencyContactByNaturalPerson (Guid? naturalPersonId)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListEmergencyContactByNaturalPersonExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmergencyContactApi();
            var naturalPersonId = new Guid?(); // Guid? | 

            try
            {
                List&lt;EmergencyContactLiteModel&gt; result = apiInstance.GetListEmergencyContactByNaturalPerson(naturalPersonId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmergencyContactApi.GetListEmergencyContactByNaturalPerson: " + e.Message );
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

[**List<EmergencyContactLiteModel>**](EmergencyContactLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistemergencycontactbynaturalpersonidlist"></a>
# **GetListEmergencyContactByNaturalPersonIdList**
> List<EmergencyContactLiteModel> GetListEmergencyContactByNaturalPersonIdList (List<Guid?> naturalPersonIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListEmergencyContactByNaturalPersonIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmergencyContactApi();
            var naturalPersonIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;EmergencyContactLiteModel&gt; result = apiInstance.GetListEmergencyContactByNaturalPersonIdList(naturalPersonIdList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmergencyContactApi.GetListEmergencyContactByNaturalPersonIdList: " + e.Message );
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

[**List<EmergencyContactLiteModel>**](EmergencyContactLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="saveemergencycontact"></a>
# **SaveEmergencyContact**
> EmergencyContactLiteModel SaveEmergencyContact (EmergencyContactLiteModel emergencyContactLite = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class SaveEmergencyContactExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmergencyContactApi();
            var emergencyContactLite = new EmergencyContactLiteModel(); // EmergencyContactLiteModel |  (optional) 

            try
            {
                EmergencyContactLiteModel result = apiInstance.SaveEmergencyContact(emergencyContactLite);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmergencyContactApi.SaveEmergencyContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emergencyContactLite** | [**EmergencyContactLiteModel**](EmergencyContactLiteModel.md)|  | [optional] 

### Return type

[**EmergencyContactLiteModel**](EmergencyContactLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


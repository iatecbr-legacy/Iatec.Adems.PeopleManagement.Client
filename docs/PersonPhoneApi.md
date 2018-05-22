# Iatec.Adems.PeopleManagement.Client.Api.PersonPhoneApi

All URIs are relative to *https://ws-peoplemgmt.sdasystems.org/bra*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletePersonPhone**](PersonPhoneApi.md#deletepersonphone) | **DELETE** /personPhone | 
[**GetIsDefault**](PersonPhoneApi.md#getisdefault) | **GET** /personPhone/isDefault | 
[**GetListIsDefaultByPersonIdList**](PersonPhoneApi.md#getlistisdefaultbypersonidlist) | **GET** /personPhone/isDefaultByPersonIdList | 
[**GetListPersonPhoneByPerson**](PersonPhoneApi.md#getlistpersonphonebyperson) | **GET** /personPhone/byPerson | 
[**GetListPersonPhoneByPersonIdList**](PersonPhoneApi.md#getlistpersonphonebypersonidlist) | **GET** /personPhone/byPersonIdList | 
[**GetListPersonPhoneByTypeAndPersonIdList**](PersonPhoneApi.md#getlistpersonphonebytypeandpersonidlist) | **GET** /personPhone/byTypeAndPersonIdList | 
[**GetPersonPhoneById**](PersonPhoneApi.md#getpersonphonebyid) | **GET** /personPhone/byId | 
[**SavePersonPhone**](PersonPhoneApi.md#savepersonphone) | **PUT** /personPhone | 


<a name="deletepersonphone"></a>
# **DeletePersonPhone**
> void DeletePersonPhone (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class DeletePersonPhoneExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonPhoneApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.DeletePersonPhone(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonPhoneApi.DeletePersonPhone: " + e.Message );
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

<a name="getisdefault"></a>
# **GetIsDefault**
> PersonPhoneLiteModel GetIsDefault (Guid? personId)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetIsDefaultExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonPhoneApi();
            var personId = new Guid?(); // Guid? | 

            try
            {
                PersonPhoneLiteModel result = apiInstance.GetIsDefault(personId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonPhoneApi.GetIsDefault: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **personId** | [**Guid?**](Guid?.md)|  | 

### Return type

[**PersonPhoneLiteModel**](PersonPhoneLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistisdefaultbypersonidlist"></a>
# **GetListIsDefaultByPersonIdList**
> List<PersonPhoneLiteModel> GetListIsDefaultByPersonIdList (List<Guid?> personIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListIsDefaultByPersonIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonPhoneApi();
            var personIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;PersonPhoneLiteModel&gt; result = apiInstance.GetListIsDefaultByPersonIdList(personIdList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonPhoneApi.GetListIsDefaultByPersonIdList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **personIdList** | [**List&lt;Guid?&gt;**](Guid?.md)|  | [optional] 

### Return type

[**List<PersonPhoneLiteModel>**](PersonPhoneLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistpersonphonebyperson"></a>
# **GetListPersonPhoneByPerson**
> List<PersonPhoneLiteModel> GetListPersonPhoneByPerson (Guid? personId)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListPersonPhoneByPersonExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonPhoneApi();
            var personId = new Guid?(); // Guid? | 

            try
            {
                List&lt;PersonPhoneLiteModel&gt; result = apiInstance.GetListPersonPhoneByPerson(personId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonPhoneApi.GetListPersonPhoneByPerson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **personId** | [**Guid?**](Guid?.md)|  | 

### Return type

[**List<PersonPhoneLiteModel>**](PersonPhoneLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistpersonphonebypersonidlist"></a>
# **GetListPersonPhoneByPersonIdList**
> List<PersonPhoneLiteModel> GetListPersonPhoneByPersonIdList (List<Guid?> personIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListPersonPhoneByPersonIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonPhoneApi();
            var personIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;PersonPhoneLiteModel&gt; result = apiInstance.GetListPersonPhoneByPersonIdList(personIdList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonPhoneApi.GetListPersonPhoneByPersonIdList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **personIdList** | [**List&lt;Guid?&gt;**](Guid?.md)|  | [optional] 

### Return type

[**List<PersonPhoneLiteModel>**](PersonPhoneLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistpersonphonebytypeandpersonidlist"></a>
# **GetListPersonPhoneByTypeAndPersonIdList**
> List<PersonPhoneLiteModel> GetListPersonPhoneByTypeAndPersonIdList (Guid? phoneTypeId, List<Guid?> personIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListPersonPhoneByTypeAndPersonIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonPhoneApi();
            var phoneTypeId = new Guid?(); // Guid? | 
            var personIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;PersonPhoneLiteModel&gt; result = apiInstance.GetListPersonPhoneByTypeAndPersonIdList(phoneTypeId, personIdList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonPhoneApi.GetListPersonPhoneByTypeAndPersonIdList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **phoneTypeId** | [**Guid?**](Guid?.md)|  | 
 **personIdList** | [**List&lt;Guid?&gt;**](Guid?.md)|  | [optional] 

### Return type

[**List<PersonPhoneLiteModel>**](PersonPhoneLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpersonphonebyid"></a>
# **GetPersonPhoneById**
> PersonPhoneLiteModel GetPersonPhoneById (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetPersonPhoneByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonPhoneApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                PersonPhoneLiteModel result = apiInstance.GetPersonPhoneById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonPhoneApi.GetPersonPhoneById: " + e.Message );
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

[**PersonPhoneLiteModel**](PersonPhoneLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savepersonphone"></a>
# **SavePersonPhone**
> PersonPhoneLiteModel SavePersonPhone (PersonPhoneLiteModel personPhone = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class SavePersonPhoneExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonPhoneApi();
            var personPhone = new PersonPhoneLiteModel(); // PersonPhoneLiteModel |  (optional) 

            try
            {
                PersonPhoneLiteModel result = apiInstance.SavePersonPhone(personPhone);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonPhoneApi.SavePersonPhone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **personPhone** | [**PersonPhoneLiteModel**](PersonPhoneLiteModel.md)|  | [optional] 

### Return type

[**PersonPhoneLiteModel**](PersonPhoneLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


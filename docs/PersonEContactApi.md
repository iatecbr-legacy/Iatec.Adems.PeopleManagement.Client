# Iatec.Adems.PeopleManagement.Client.Api.PersonEContactApi

All URIs are relative to *https://ws-peoplemgmt.sdasystems.org/bra*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletePersonEContact**](PersonEContactApi.md#deletepersonecontact) | **DELETE** /personEContact | 
[**GetListByTypeAndContact**](PersonEContactApi.md#getlistbytypeandcontact) | **GET** /personEContact/byTypeAndContact | 
[**GetListPersonEContactByPerson**](PersonEContactApi.md#getlistpersonecontactbyperson) | **GET** /personEContact/byPerson | 
[**GetListPersonEContactByPersonIdList**](PersonEContactApi.md#getlistpersonecontactbypersonidlist) | **GET** /personEContact/byPersonIdList | 
[**GetListPersonEContactByTypeAndPersonIdList**](PersonEContactApi.md#getlistpersonecontactbytypeandpersonidlist) | **GET** /personEContact/byTypeAndPersonIdList | 
[**GetPersonEContactById**](PersonEContactApi.md#getpersonecontactbyid) | **GET** /personEContact/byId | 
[**SavePersonEContact**](PersonEContactApi.md#savepersonecontact) | **PUT** /personEContact | 


<a name="deletepersonecontact"></a>
# **DeletePersonEContact**
> void DeletePersonEContact (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class DeletePersonEContactExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonEContactApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.DeletePersonEContact(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonEContactApi.DeletePersonEContact: " + e.Message );
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

<a name="getlistbytypeandcontact"></a>
# **GetListByTypeAndContact**
> List<PersonEContactLiteModel> GetListByTypeAndContact (ContactTypeModel type, string contact = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListByTypeAndContactExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonEContactApi();
            var type = new ContactTypeModel(); // ContactTypeModel | 
            var contact = contact_example;  // string |  (optional) 

            try
            {
                List&lt;PersonEContactLiteModel&gt; result = apiInstance.GetListByTypeAndContact(type, contact);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonEContactApi.GetListByTypeAndContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | [**ContactTypeModel**](ContactTypeModel.md)|  | 
 **contact** | **string**|  | [optional] 

### Return type

[**List<PersonEContactLiteModel>**](PersonEContactLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistpersonecontactbyperson"></a>
# **GetListPersonEContactByPerson**
> List<PersonEContactLiteModel> GetListPersonEContactByPerson (Guid? personId)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListPersonEContactByPersonExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonEContactApi();
            var personId = new Guid?(); // Guid? | 

            try
            {
                List&lt;PersonEContactLiteModel&gt; result = apiInstance.GetListPersonEContactByPerson(personId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonEContactApi.GetListPersonEContactByPerson: " + e.Message );
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

[**List<PersonEContactLiteModel>**](PersonEContactLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistpersonecontactbypersonidlist"></a>
# **GetListPersonEContactByPersonIdList**
> List<PersonEContactLiteModel> GetListPersonEContactByPersonIdList (List<Guid?> personIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListPersonEContactByPersonIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonEContactApi();
            var personIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;PersonEContactLiteModel&gt; result = apiInstance.GetListPersonEContactByPersonIdList(personIdList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonEContactApi.GetListPersonEContactByPersonIdList: " + e.Message );
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

[**List<PersonEContactLiteModel>**](PersonEContactLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistpersonecontactbytypeandpersonidlist"></a>
# **GetListPersonEContactByTypeAndPersonIdList**
> List<PersonEContactLiteModel> GetListPersonEContactByTypeAndPersonIdList (ContactTypeModel type, List<Guid?> personIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListPersonEContactByTypeAndPersonIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonEContactApi();
            var type = new ContactTypeModel(); // ContactTypeModel | 
            var personIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;PersonEContactLiteModel&gt; result = apiInstance.GetListPersonEContactByTypeAndPersonIdList(type, personIdList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonEContactApi.GetListPersonEContactByTypeAndPersonIdList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | [**ContactTypeModel**](ContactTypeModel.md)|  | 
 **personIdList** | [**List&lt;Guid?&gt;**](Guid?.md)|  | [optional] 

### Return type

[**List<PersonEContactLiteModel>**](PersonEContactLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpersonecontactbyid"></a>
# **GetPersonEContactById**
> PersonEContactLiteModel GetPersonEContactById (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetPersonEContactByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonEContactApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                PersonEContactLiteModel result = apiInstance.GetPersonEContactById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonEContactApi.GetPersonEContactById: " + e.Message );
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

[**PersonEContactLiteModel**](PersonEContactLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savepersonecontact"></a>
# **SavePersonEContact**
> PersonEContactLiteModel SavePersonEContact (PersonEContactLiteModel personEContact = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class SavePersonEContactExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonEContactApi();
            var personEContact = new PersonEContactLiteModel(); // PersonEContactLiteModel |  (optional) 

            try
            {
                PersonEContactLiteModel result = apiInstance.SavePersonEContact(personEContact);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonEContactApi.SavePersonEContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **personEContact** | [**PersonEContactLiteModel**](PersonEContactLiteModel.md)|  | [optional] 

### Return type

[**PersonEContactLiteModel**](PersonEContactLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


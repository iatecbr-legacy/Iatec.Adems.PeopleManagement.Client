# Iatec.Adems.PeopleManagement.Client.Api.PersonDocumentApi

All URIs are relative to *https://ws-peoplemgmt.sdasystems.org/bra*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletePersonDocument**](PersonDocumentApi.md#deletepersondocument) | **DELETE** /personDocument | 
[**GetListPersonDocumentByPerson**](PersonDocumentApi.md#getlistpersondocumentbyperson) | **GET** /personDocument/byPerson | 
[**GetListPersonDocumentByPersonIdList**](PersonDocumentApi.md#getlistpersondocumentbypersonidlist) | **GET** /personDocument/byPersonIdList | 
[**GetListPersonDocumentByTypeAndPersonIdList**](PersonDocumentApi.md#getlistpersondocumentbytypeandpersonidlist) | **GET** /personDocument/byTypeAndPersonIdList | 
[**GetPersonDocumentById**](PersonDocumentApi.md#getpersondocumentbyid) | **GET** /personDocument/byId | 
[**SavePersonDocument**](PersonDocumentApi.md#savepersondocument) | **PUT** /personDocument | 
[**SavePersonDocumentList**](PersonDocumentApi.md#savepersondocumentlist) | **PUT** /personDocument/list | 
[**ValidateDocNumber**](PersonDocumentApi.md#validatedocnumber) | **POST** /personDocument/validateDocNumber | 


<a name="deletepersondocument"></a>
# **DeletePersonDocument**
> void DeletePersonDocument (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class DeletePersonDocumentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonDocumentApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.DeletePersonDocument(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonDocumentApi.DeletePersonDocument: " + e.Message );
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

<a name="getlistpersondocumentbyperson"></a>
# **GetListPersonDocumentByPerson**
> List<PersonDocumentLiteModel> GetListPersonDocumentByPerson (Guid? personId)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListPersonDocumentByPersonExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonDocumentApi();
            var personId = new Guid?(); // Guid? | 

            try
            {
                List&lt;PersonDocumentLiteModel&gt; result = apiInstance.GetListPersonDocumentByPerson(personId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonDocumentApi.GetListPersonDocumentByPerson: " + e.Message );
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

[**List<PersonDocumentLiteModel>**](PersonDocumentLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistpersondocumentbypersonidlist"></a>
# **GetListPersonDocumentByPersonIdList**
> List<PersonDocumentLiteModel> GetListPersonDocumentByPersonIdList (List<Guid?> personIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListPersonDocumentByPersonIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonDocumentApi();
            var personIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;PersonDocumentLiteModel&gt; result = apiInstance.GetListPersonDocumentByPersonIdList(personIdList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonDocumentApi.GetListPersonDocumentByPersonIdList: " + e.Message );
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

[**List<PersonDocumentLiteModel>**](PersonDocumentLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistpersondocumentbytypeandpersonidlist"></a>
# **GetListPersonDocumentByTypeAndPersonIdList**
> List<PersonDocumentLiteModel> GetListPersonDocumentByTypeAndPersonIdList (Guid? documentTypeId, List<Guid?> personIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListPersonDocumentByTypeAndPersonIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonDocumentApi();
            var documentTypeId = new Guid?(); // Guid? | 
            var personIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;PersonDocumentLiteModel&gt; result = apiInstance.GetListPersonDocumentByTypeAndPersonIdList(documentTypeId, personIdList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonDocumentApi.GetListPersonDocumentByTypeAndPersonIdList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentTypeId** | [**Guid?**](Guid?.md)|  | 
 **personIdList** | [**List&lt;Guid?&gt;**](Guid?.md)|  | [optional] 

### Return type

[**List<PersonDocumentLiteModel>**](PersonDocumentLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpersondocumentbyid"></a>
# **GetPersonDocumentById**
> PersonDocumentLiteModel GetPersonDocumentById (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetPersonDocumentByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonDocumentApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                PersonDocumentLiteModel result = apiInstance.GetPersonDocumentById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonDocumentApi.GetPersonDocumentById: " + e.Message );
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

[**PersonDocumentLiteModel**](PersonDocumentLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savepersondocument"></a>
# **SavePersonDocument**
> PersonDocumentLiteModel SavePersonDocument (PersonDocumentLiteModel personDocument = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class SavePersonDocumentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonDocumentApi();
            var personDocument = new PersonDocumentLiteModel(); // PersonDocumentLiteModel |  (optional) 

            try
            {
                PersonDocumentLiteModel result = apiInstance.SavePersonDocument(personDocument);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonDocumentApi.SavePersonDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **personDocument** | [**PersonDocumentLiteModel**](PersonDocumentLiteModel.md)|  | [optional] 

### Return type

[**PersonDocumentLiteModel**](PersonDocumentLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savepersondocumentlist"></a>
# **SavePersonDocumentList**
> List<PersonDocumentLiteModel> SavePersonDocumentList (List<PersonDocumentLiteModel> personDocumentList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class SavePersonDocumentListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonDocumentApi();
            var personDocumentList = new List<PersonDocumentLiteModel>(); // List<PersonDocumentLiteModel> |  (optional) 

            try
            {
                List&lt;PersonDocumentLiteModel&gt; result = apiInstance.SavePersonDocumentList(personDocumentList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonDocumentApi.SavePersonDocumentList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **personDocumentList** | [**List&lt;PersonDocumentLiteModel&gt;**](PersonDocumentLiteModel.md)|  | [optional] 

### Return type

[**List<PersonDocumentLiteModel>**](PersonDocumentLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatedocnumber"></a>
# **ValidateDocNumber**
> bool? ValidateDocNumber (Guid? typeId, string docNumber = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class ValidateDocNumberExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonDocumentApi();
            var typeId = new Guid?(); // Guid? | 
            var docNumber = docNumber_example;  // string |  (optional) 

            try
            {
                bool? result = apiInstance.ValidateDocNumber(typeId, docNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonDocumentApi.ValidateDocNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **typeId** | [**Guid?**](Guid?.md)|  | 
 **docNumber** | **string**|  | [optional] 

### Return type

**bool?**

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


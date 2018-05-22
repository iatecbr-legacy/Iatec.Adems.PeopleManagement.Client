# Iatec.Adems.PeopleManagement.Client.Api.NaturalPersonRelationshipApi

All URIs are relative to *https://ws-peoplemgmt.sdasystems.org/bra*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteNaturalPersonRelationship**](NaturalPersonRelationshipApi.md#deletenaturalpersonrelationship) | **DELETE** /naturalPersonRelationship | 
[**GetByNaturalPerson**](NaturalPersonRelationshipApi.md#getbynaturalperson) | **GET** /naturalPersonRelationship/byNaturalPerson | 
[**GetByNaturalPersonIdList**](NaturalPersonRelationshipApi.md#getbynaturalpersonidlist) | **GET** /naturalPersonRelationship/byNaturalPersonIdList | 
[**GetListByRelationshipAndNaturalPersonIdList**](NaturalPersonRelationshipApi.md#getlistbyrelationshipandnaturalpersonidlist) | **GET** /naturalPersonRelationship/byRelationshipAndNaturalPersonIdList | 
[**GetListChildren**](NaturalPersonRelationshipApi.md#getlistchildren) | **GET** /naturalPersonRelationship/children | 
[**GetListLivesWithByNaturalPersonIdList**](NaturalPersonRelationshipApi.md#getlistliveswithbynaturalpersonidlist) | **GET** /naturalPersonRelationship/livesWithByNaturalPersonIdList | 
[**GetListSiblingsByNaturalPerson**](NaturalPersonRelationshipApi.md#getlistsiblingsbynaturalperson) | **GET** /naturalPersonRelationship/siblingsByNaturalPerson | 
[**GetNaturalPersonRelationshipById**](NaturalPersonRelationshipApi.md#getnaturalpersonrelationshipbyid) | **GET** /naturalPersonRelationship/byId | 
[**SaveNaturalPersonRelationship**](NaturalPersonRelationshipApi.md#savenaturalpersonrelationship) | **PUT** /naturalPersonRelationship | 


<a name="deletenaturalpersonrelationship"></a>
# **DeleteNaturalPersonRelationship**
> void DeleteNaturalPersonRelationship (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class DeleteNaturalPersonRelationshipExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonRelationshipApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.DeleteNaturalPersonRelationship(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonRelationshipApi.DeleteNaturalPersonRelationship: " + e.Message );
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

<a name="getbynaturalperson"></a>
# **GetByNaturalPerson**
> List<NaturalPersonRelationshipLiteModel> GetByNaturalPerson (Guid? naturalPersonId)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetByNaturalPersonExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonRelationshipApi();
            var naturalPersonId = new Guid?(); // Guid? | 

            try
            {
                List&lt;NaturalPersonRelationshipLiteModel&gt; result = apiInstance.GetByNaturalPerson(naturalPersonId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonRelationshipApi.GetByNaturalPerson: " + e.Message );
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

[**List<NaturalPersonRelationshipLiteModel>**](NaturalPersonRelationshipLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbynaturalpersonidlist"></a>
# **GetByNaturalPersonIdList**
> List<NaturalPersonRelationshipLiteModel> GetByNaturalPersonIdList (List<Guid?> naturalPersonIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetByNaturalPersonIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonRelationshipApi();
            var naturalPersonIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;NaturalPersonRelationshipLiteModel&gt; result = apiInstance.GetByNaturalPersonIdList(naturalPersonIdList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonRelationshipApi.GetByNaturalPersonIdList: " + e.Message );
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

[**List<NaturalPersonRelationshipLiteModel>**](NaturalPersonRelationshipLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistbyrelationshipandnaturalpersonidlist"></a>
# **GetListByRelationshipAndNaturalPersonIdList**
> List<NaturalPersonRelationshipLiteModel> GetListByRelationshipAndNaturalPersonIdList (RelationshipModel relationship, List<Guid?> naturalPersonIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListByRelationshipAndNaturalPersonIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonRelationshipApi();
            var relationship = new RelationshipModel(); // RelationshipModel | 
            var naturalPersonIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;NaturalPersonRelationshipLiteModel&gt; result = apiInstance.GetListByRelationshipAndNaturalPersonIdList(relationship, naturalPersonIdList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonRelationshipApi.GetListByRelationshipAndNaturalPersonIdList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **relationship** | [**RelationshipModel**](RelationshipModel.md)|  | 
 **naturalPersonIdList** | [**List&lt;Guid?&gt;**](Guid?.md)|  | [optional] 

### Return type

[**List<NaturalPersonRelationshipLiteModel>**](NaturalPersonRelationshipLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistchildren"></a>
# **GetListChildren**
> List<DictionaryEntityLiteModel> GetListChildren (Guid? naturalPersonId)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListChildrenExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonRelationshipApi();
            var naturalPersonId = new Guid?(); // Guid? | 

            try
            {
                List&lt;DictionaryEntityLiteModel&gt; result = apiInstance.GetListChildren(naturalPersonId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonRelationshipApi.GetListChildren: " + e.Message );
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

[**List<DictionaryEntityLiteModel>**](DictionaryEntityLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistliveswithbynaturalpersonidlist"></a>
# **GetListLivesWithByNaturalPersonIdList**
> List<NaturalPersonRelationshipLiteModel> GetListLivesWithByNaturalPersonIdList (List<Guid?> naturalPersonIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListLivesWithByNaturalPersonIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonRelationshipApi();
            var naturalPersonIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;NaturalPersonRelationshipLiteModel&gt; result = apiInstance.GetListLivesWithByNaturalPersonIdList(naturalPersonIdList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonRelationshipApi.GetListLivesWithByNaturalPersonIdList: " + e.Message );
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

[**List<NaturalPersonRelationshipLiteModel>**](NaturalPersonRelationshipLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistsiblingsbynaturalperson"></a>
# **GetListSiblingsByNaturalPerson**
> List<DictionaryEntityLiteModel> GetListSiblingsByNaturalPerson (Guid? naturalPersonId)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListSiblingsByNaturalPersonExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonRelationshipApi();
            var naturalPersonId = new Guid?(); // Guid? | 

            try
            {
                List&lt;DictionaryEntityLiteModel&gt; result = apiInstance.GetListSiblingsByNaturalPerson(naturalPersonId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonRelationshipApi.GetListSiblingsByNaturalPerson: " + e.Message );
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

[**List<DictionaryEntityLiteModel>**](DictionaryEntityLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnaturalpersonrelationshipbyid"></a>
# **GetNaturalPersonRelationshipById**
> NaturalPersonRelationshipLiteModel GetNaturalPersonRelationshipById (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetNaturalPersonRelationshipByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonRelationshipApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                NaturalPersonRelationshipLiteModel result = apiInstance.GetNaturalPersonRelationshipById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonRelationshipApi.GetNaturalPersonRelationshipById: " + e.Message );
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

[**NaturalPersonRelationshipLiteModel**](NaturalPersonRelationshipLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savenaturalpersonrelationship"></a>
# **SaveNaturalPersonRelationship**
> NaturalPersonRelationshipLiteModel SaveNaturalPersonRelationship (NaturalPersonRelationshipLiteModel naturalPersonRelationship = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class SaveNaturalPersonRelationshipExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonRelationshipApi();
            var naturalPersonRelationship = new NaturalPersonRelationshipLiteModel(); // NaturalPersonRelationshipLiteModel |  (optional) 

            try
            {
                NaturalPersonRelationshipLiteModel result = apiInstance.SaveNaturalPersonRelationship(naturalPersonRelationship);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonRelationshipApi.SaveNaturalPersonRelationship: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **naturalPersonRelationship** | [**NaturalPersonRelationshipLiteModel**](NaturalPersonRelationshipLiteModel.md)|  | [optional] 

### Return type

[**NaturalPersonRelationshipLiteModel**](NaturalPersonRelationshipLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


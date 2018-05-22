# Iatec.Adems.PeopleManagement.Client.Api.DocumentTypeApi

All URIs are relative to *https://ws-peoplemgmt.sdasystems.org/bra*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DocumentTypeDeleteSystemReference**](DocumentTypeApi.md#documenttypedeletesystemreference) | **DELETE** /documentType/systemReference | 
[**DocumentTypeSaveSystemReference**](DocumentTypeApi.md#documenttypesavesystemreference) | **PUT** /documentType/systemReference | 
[**GetDocumentTypeById**](DocumentTypeApi.md#getdocumenttypebyid) | **GET** /documentType/byId | 
[**GetIdentifierByClassification**](DocumentTypeApi.md#getidentifierbyclassification) | **GET** /documentType/identifierByClassification | 
[**GetListByIdListForSearch**](DocumentTypeApi.md#getlistbyidlistforsearch) | **GET** /documentType/byIdListForSearch | 
[**GetListDocumentTypeByFilter**](DocumentTypeApi.md#getlistdocumenttypebyfilter) | **GET** /documentType/byFilter | 
[**GetListDocumentTypeByIdList**](DocumentTypeApi.md#getlistdocumenttypebyidlist) | **GET** /documentType/byIdList | 
[**GetListForNaturalPersonByFilter**](DocumentTypeApi.md#getlistfornaturalpersonbyfilter) | **GET** /documentType/forNaturalPersonByFilter | 
[**GetListForNaturalPersonByFilterForSearch**](DocumentTypeApi.md#getlistfornaturalpersonbyfilterforsearch) | **GET** /documentType/forNaturalPersonByFilterForSearch | 
[**GetListForSpecificPersonByFilter**](DocumentTypeApi.md#getlistforspecificpersonbyfilter) | **GET** /documentType/forSpecificPersonByFilter | 


<a name="documenttypedeletesystemreference"></a>
# **DocumentTypeDeleteSystemReference**
> void DocumentTypeDeleteSystemReference (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class DocumentTypeDeleteSystemReferenceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DocumentTypeApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.DocumentTypeDeleteSystemReference(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTypeApi.DocumentTypeDeleteSystemReference: " + e.Message );
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

<a name="documenttypesavesystemreference"></a>
# **DocumentTypeSaveSystemReference**
> void DocumentTypeSaveSystemReference (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class DocumentTypeSaveSystemReferenceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DocumentTypeApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.DocumentTypeSaveSystemReference(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTypeApi.DocumentTypeSaveSystemReference: " + e.Message );
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

<a name="getdocumenttypebyid"></a>
# **GetDocumentTypeById**
> DocumentTypeModel GetDocumentTypeById (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetDocumentTypeByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DocumentTypeApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                DocumentTypeModel result = apiInstance.GetDocumentTypeById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTypeApi.GetDocumentTypeById: " + e.Message );
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

[**DocumentTypeModel**](DocumentTypeModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getidentifierbyclassification"></a>
# **GetIdentifierByClassification**
> DocumentTypeModel GetIdentifierByClassification (DocumentTypeClassificationModel classification)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetIdentifierByClassificationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DocumentTypeApi();
            var classification = new DocumentTypeClassificationModel(); // DocumentTypeClassificationModel | 

            try
            {
                DocumentTypeModel result = apiInstance.GetIdentifierByClassification(classification);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTypeApi.GetIdentifierByClassification: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **classification** | [**DocumentTypeClassificationModel**](DocumentTypeClassificationModel.md)|  | 

### Return type

[**DocumentTypeModel**](DocumentTypeModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistbyidlistforsearch"></a>
# **GetListByIdListForSearch**
> List<DocumentTypeLiteSearchModel> GetListByIdListForSearch (List<Guid?> idList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListByIdListForSearchExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DocumentTypeApi();
            var idList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;DocumentTypeLiteSearchModel&gt; result = apiInstance.GetListByIdListForSearch(idList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTypeApi.GetListByIdListForSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idList** | [**List&lt;Guid?&gt;**](Guid?.md)|  | [optional] 

### Return type

[**List<DocumentTypeLiteSearchModel>**](DocumentTypeLiteSearchModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistdocumenttypebyfilter"></a>
# **GetListDocumentTypeByFilter**
> List<DocumentTypeModel> GetListDocumentTypeByFilter (string filter = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListDocumentTypeByFilterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DocumentTypeApi();
            var filter = filter_example;  // string |  (optional) 

            try
            {
                List&lt;DocumentTypeModel&gt; result = apiInstance.GetListDocumentTypeByFilter(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTypeApi.GetListDocumentTypeByFilter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**|  | [optional] 

### Return type

[**List<DocumentTypeModel>**](DocumentTypeModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistdocumenttypebyidlist"></a>
# **GetListDocumentTypeByIdList**
> List<DocumentTypeModel> GetListDocumentTypeByIdList (List<Guid?> idList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListDocumentTypeByIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DocumentTypeApi();
            var idList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;DocumentTypeModel&gt; result = apiInstance.GetListDocumentTypeByIdList(idList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTypeApi.GetListDocumentTypeByIdList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idList** | [**List&lt;Guid?&gt;**](Guid?.md)|  | [optional] 

### Return type

[**List<DocumentTypeModel>**](DocumentTypeModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistfornaturalpersonbyfilter"></a>
# **GetListForNaturalPersonByFilter**
> List<DocumentTypeModel> GetListForNaturalPersonByFilter (string filter = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListForNaturalPersonByFilterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DocumentTypeApi();
            var filter = filter_example;  // string |  (optional) 

            try
            {
                List&lt;DocumentTypeModel&gt; result = apiInstance.GetListForNaturalPersonByFilter(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTypeApi.GetListForNaturalPersonByFilter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**|  | [optional] 

### Return type

[**List<DocumentTypeModel>**](DocumentTypeModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistfornaturalpersonbyfilterforsearch"></a>
# **GetListForNaturalPersonByFilterForSearch**
> List<DocumentTypeLiteSearchModel> GetListForNaturalPersonByFilterForSearch (string filter = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListForNaturalPersonByFilterForSearchExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DocumentTypeApi();
            var filter = filter_example;  // string |  (optional) 

            try
            {
                List&lt;DocumentTypeLiteSearchModel&gt; result = apiInstance.GetListForNaturalPersonByFilterForSearch(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTypeApi.GetListForNaturalPersonByFilterForSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**|  | [optional] 

### Return type

[**List<DocumentTypeLiteSearchModel>**](DocumentTypeLiteSearchModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistforspecificpersonbyfilter"></a>
# **GetListForSpecificPersonByFilter**
> List<DocumentTypeModel> GetListForSpecificPersonByFilter (Guid? personId, string filter = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListForSpecificPersonByFilterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DocumentTypeApi();
            var personId = new Guid?(); // Guid? | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                List&lt;DocumentTypeModel&gt; result = apiInstance.GetListForSpecificPersonByFilter(personId, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTypeApi.GetListForSpecificPersonByFilter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **personId** | [**Guid?**](Guid?.md)|  | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<DocumentTypeModel>**](DocumentTypeModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# Iatec.Adems.PeopleManagement.Client.Api.LegalEntityApi

All URIs are relative to *https://ws-peoplemgmt.sdasystems.org/bra*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteLegalEntity**](LegalEntityApi.md#deletelegalentity) | **DELETE** /legalEntity | 
[**GetByCode**](LegalEntityApi.md#getbycode) | **GET** /legalEntity/byCode | 
[**GetByIdentifierDocumentNumber**](LegalEntityApi.md#getbyidentifierdocumentnumber) | **GET** /legalEntity/byIdentifierDocumentNumber | 
[**GetLegalEntityById**](LegalEntityApi.md#getlegalentitybyid) | **GET** /legalEntity/byId | 
[**GetListIsAdventistActiveByFilter**](LegalEntityApi.md#getlistisadventistactivebyfilter) | **GET** /legalEntity/isAdventistActiveByFilter | 
[**GetListLegalEntityByDocumentNumberList**](LegalEntityApi.md#getlistlegalentitybydocumentnumberlist) | **GET** /legalEntity/byDocumentNumberList | 
[**GetListLegalEntityByIdList**](LegalEntityApi.md#getlistlegalentitybyidlist) | **GET** /legalEntity/byIdList | 
[**GetListLegalEntityLastSystemUpdate**](LegalEntityApi.md#getlistlegalentitylastsystemupdate) | **GET** /legalEntity/lastSystemUpdate | 
[**GetPageByFilterAndDocNumber**](LegalEntityApi.md#getpagebyfilteranddocnumber) | **GET** /legalEntity/pageByFilterAndDocNumber | 
[**GetPageLegalEntityByFilter**](LegalEntityApi.md#getpagelegalentitybyfilter) | **GET** /legalEntity/pageByFilter | 
[**InsertForImport**](LegalEntityApi.md#insertforimport) | **POST** /legalEntity/insertForImport | 
[**LegalEntitySaveSystemReference**](LegalEntityApi.md#legalentitysavesystemreference) | **PUT** /legalEntity/systemReference | 
[**LegalEntityUpdateNotice**](LegalEntityApi.md#legalentityupdatenotice) | **POST** /legalEntity/notice | 
[**SaveLegalEntity**](LegalEntityApi.md#savelegalentity) | **PUT** /legalEntity | 


<a name="deletelegalentity"></a>
# **DeleteLegalEntity**
> void DeleteLegalEntity (List<Guid?> legalEntityIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class DeleteLegalEntityExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntityApi();
            var legalEntityIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                apiInstance.DeleteLegalEntity(legalEntityIdList);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegalEntityApi.DeleteLegalEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **legalEntityIdList** | [**List&lt;Guid?&gt;**](Guid?.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbycode"></a>
# **GetByCode**
> LegalEntityLiteExternalModel GetByCode (string code = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetByCodeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntityApi();
            var code = code_example;  // string |  (optional) 

            try
            {
                LegalEntityLiteExternalModel result = apiInstance.GetByCode(code);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegalEntityApi.GetByCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**|  | [optional] 

### Return type

[**LegalEntityLiteExternalModel**](LegalEntityLiteExternalModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyidentifierdocumentnumber"></a>
# **GetByIdentifierDocumentNumber**
> LegalEntityLiteExternalModel GetByIdentifierDocumentNumber (string documentNumber = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetByIdentifierDocumentNumberExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntityApi();
            var documentNumber = documentNumber_example;  // string |  (optional) 

            try
            {
                LegalEntityLiteExternalModel result = apiInstance.GetByIdentifierDocumentNumber(documentNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegalEntityApi.GetByIdentifierDocumentNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentNumber** | **string**|  | [optional] 

### Return type

[**LegalEntityLiteExternalModel**](LegalEntityLiteExternalModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlegalentitybyid"></a>
# **GetLegalEntityById**
> LegalEntityLiteExternalModel GetLegalEntityById (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetLegalEntityByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntityApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                LegalEntityLiteExternalModel result = apiInstance.GetLegalEntityById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegalEntityApi.GetLegalEntityById: " + e.Message );
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

[**LegalEntityLiteExternalModel**](LegalEntityLiteExternalModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistisadventistactivebyfilter"></a>
# **GetListIsAdventistActiveByFilter**
> List<LegalEntityLiteExternalModel> GetListIsAdventistActiveByFilter (string filter = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListIsAdventistActiveByFilterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntityApi();
            var filter = filter_example;  // string |  (optional) 

            try
            {
                List&lt;LegalEntityLiteExternalModel&gt; result = apiInstance.GetListIsAdventistActiveByFilter(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegalEntityApi.GetListIsAdventistActiveByFilter: " + e.Message );
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

[**List<LegalEntityLiteExternalModel>**](LegalEntityLiteExternalModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistlegalentitybydocumentnumberlist"></a>
# **GetListLegalEntityByDocumentNumberList**
> List<LegalEntityLiteExternalModel> GetListLegalEntityByDocumentNumberList (List<string> documentNumberList = null, List<Guid?> documentTypeIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListLegalEntityByDocumentNumberListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntityApi();
            var documentNumberList = new List<string>(); // List<string> |  (optional) 
            var documentTypeIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;LegalEntityLiteExternalModel&gt; result = apiInstance.GetListLegalEntityByDocumentNumberList(documentNumberList, documentTypeIdList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegalEntityApi.GetListLegalEntityByDocumentNumberList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentNumberList** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **documentTypeIdList** | [**List&lt;Guid?&gt;**](Guid?.md)|  | [optional] 

### Return type

[**List<LegalEntityLiteExternalModel>**](LegalEntityLiteExternalModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistlegalentitybyidlist"></a>
# **GetListLegalEntityByIdList**
> List<LegalEntityLiteExternalModel> GetListLegalEntityByIdList (List<Guid?> idList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListLegalEntityByIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntityApi();
            var idList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;LegalEntityLiteExternalModel&gt; result = apiInstance.GetListLegalEntityByIdList(idList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegalEntityApi.GetListLegalEntityByIdList: " + e.Message );
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

[**List<LegalEntityLiteExternalModel>**](LegalEntityLiteExternalModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistlegalentitylastsystemupdate"></a>
# **GetListLegalEntityLastSystemUpdate**
> List<LegalEntitySystemUpdateLiteModel> GetListLegalEntityLastSystemUpdate ()



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListLegalEntityLastSystemUpdateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntityApi();

            try
            {
                List&lt;LegalEntitySystemUpdateLiteModel&gt; result = apiInstance.GetListLegalEntityLastSystemUpdate();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegalEntityApi.GetListLegalEntityLastSystemUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<LegalEntitySystemUpdateLiteModel>**](LegalEntitySystemUpdateLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagebyfilteranddocnumber"></a>
# **GetPageByFilterAndDocNumber**
> PagedLegalEntityLiteExternalModel GetPageByFilterAndDocNumber (int? numRows, int? pageIndex, string filter = null, bool? isAdventist = null, string documentNumber = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetPageByFilterAndDocNumberExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntityApi();
            var numRows = 56;  // int? | 
            var pageIndex = 56;  // int? | 
            var filter = filter_example;  // string |  (optional) 
            var isAdventist = true;  // bool? |  (optional) 
            var documentNumber = documentNumber_example;  // string |  (optional) 

            try
            {
                PagedLegalEntityLiteExternalModel result = apiInstance.GetPageByFilterAndDocNumber(numRows, pageIndex, filter, isAdventist, documentNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegalEntityApi.GetPageByFilterAndDocNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **numRows** | **int?**|  | 
 **pageIndex** | **int?**|  | 
 **filter** | **string**|  | [optional] 
 **isAdventist** | **bool?**|  | [optional] 
 **documentNumber** | **string**|  | [optional] 

### Return type

[**PagedLegalEntityLiteExternalModel**](PagedLegalEntityLiteExternalModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagelegalentitybyfilter"></a>
# **GetPageLegalEntityByFilter**
> PagedLegalEntityLiteExternalModel GetPageLegalEntityByFilter (int? numRows, int? pageIndex, string filter = null, bool? isAdventist = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetPageLegalEntityByFilterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntityApi();
            var numRows = 56;  // int? | 
            var pageIndex = 56;  // int? | 
            var filter = filter_example;  // string |  (optional) 
            var isAdventist = true;  // bool? |  (optional) 

            try
            {
                PagedLegalEntityLiteExternalModel result = apiInstance.GetPageLegalEntityByFilter(numRows, pageIndex, filter, isAdventist);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegalEntityApi.GetPageLegalEntityByFilter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **numRows** | **int?**|  | 
 **pageIndex** | **int?**|  | 
 **filter** | **string**|  | [optional] 
 **isAdventist** | **bool?**|  | [optional] 

### Return type

[**PagedLegalEntityLiteExternalModel**](PagedLegalEntityLiteExternalModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertforimport"></a>
# **InsertForImport**
> LegalEntityLiteExternalModel InsertForImport (LegalEntityLiteExternalModel legalEntity = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class InsertForImportExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntityApi();
            var legalEntity = new LegalEntityLiteExternalModel(); // LegalEntityLiteExternalModel |  (optional) 

            try
            {
                LegalEntityLiteExternalModel result = apiInstance.InsertForImport(legalEntity);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegalEntityApi.InsertForImport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **legalEntity** | [**LegalEntityLiteExternalModel**](LegalEntityLiteExternalModel.md)|  | [optional] 

### Return type

[**LegalEntityLiteExternalModel**](LegalEntityLiteExternalModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="legalentitysavesystemreference"></a>
# **LegalEntitySaveSystemReference**
> void LegalEntitySaveSystemReference (List<Guid?> legalEntityIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class LegalEntitySaveSystemReferenceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntityApi();
            var legalEntityIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                apiInstance.LegalEntitySaveSystemReference(legalEntityIdList);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegalEntityApi.LegalEntitySaveSystemReference: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **legalEntityIdList** | [**List&lt;Guid?&gt;**](Guid?.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="legalentityupdatenotice"></a>
# **LegalEntityUpdateNotice**
> void LegalEntityUpdateNotice (List<Guid?> legalEntityIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class LegalEntityUpdateNoticeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntityApi();
            var legalEntityIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                apiInstance.LegalEntityUpdateNotice(legalEntityIdList);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegalEntityApi.LegalEntityUpdateNotice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **legalEntityIdList** | [**List&lt;Guid?&gt;**](Guid?.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savelegalentity"></a>
# **SaveLegalEntity**
> LegalEntityLiteExternalModel SaveLegalEntity (LegalEntityLiteExternalModel legalEntity = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class SaveLegalEntityExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntityApi();
            var legalEntity = new LegalEntityLiteExternalModel(); // LegalEntityLiteExternalModel |  (optional) 

            try
            {
                LegalEntityLiteExternalModel result = apiInstance.SaveLegalEntity(legalEntity);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegalEntityApi.SaveLegalEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **legalEntity** | [**LegalEntityLiteExternalModel**](LegalEntityLiteExternalModel.md)|  | [optional] 

### Return type

[**LegalEntityLiteExternalModel**](LegalEntityLiteExternalModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


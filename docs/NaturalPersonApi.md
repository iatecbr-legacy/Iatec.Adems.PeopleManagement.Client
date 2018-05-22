# Iatec.Adems.PeopleManagement.Client.Api.NaturalPersonApi

All URIs are relative to *https://ws-peoplemgmt.sdasystems.org/bra*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetByDocument**](NaturalPersonApi.md#getbydocument) | **GET** /naturalPerson/byDocument | 
[**GetByIdForExternal**](NaturalPersonApi.md#getbyidforexternal) | **GET** /naturalPerson/byIdForExternal | 
[**GetByIdentifierDocumentNumberLiteExternal**](NaturalPersonApi.md#getbyidentifierdocumentnumberliteexternal) | **GET** /naturalPerson/byIdentifierDocumentNumberLiteExternal | 
[**GetByUserName**](NaturalPersonApi.md#getbyusername) | **GET** /naturalPerson/byUserName | 
[**GetListByBasicPropertyList**](NaturalPersonApi.md#getlistbybasicpropertylist) | **GET** /naturalPerson/byBasicPropertyList | 
[**GetListByDocument**](NaturalPersonApi.md#getlistbydocument) | **GET** /naturalPerson/byDocument/list | 
[**GetListByIdListForExternal**](NaturalPersonApi.md#getlistbyidlistforexternal) | **GET** /naturalPerson/byIdListForExternal | 
[**GetListByLastUpdate**](NaturalPersonApi.md#getlistbylastupdate) | **GET** /naturalPerson/byLastUpdate | 
[**GetListNaturalPersonByDocumentNumberList**](NaturalPersonApi.md#getlistnaturalpersonbydocumentnumberlist) | **GET** /naturalPerson/byDocumentNumberList | 
[**GetListNaturalPersonLastSystemUpdate**](NaturalPersonApi.md#getlistnaturalpersonlastsystemupdate) | **GET** /naturalPerson/lastSystemUpdate | 
[**GetPageActiveByFilterForExternal**](NaturalPersonApi.md#getpageactivebyfilterforexternal) | **GET** /naturalPerson/pageActiveByFilterForExternal | 
[**GetPageActiveByFilterForExternal2**](NaturalPersonApi.md#getpageactivebyfilterforexternal2) | **GET** /naturalPerson/pageActiveByFilterForExternal2 | 
[**GetPageSimilarActiveById**](NaturalPersonApi.md#getpagesimilaractivebyid) | **GET** /naturalPerson/pageSimilarActiveById | 
[**GetPageSimilarActiveForExternal**](NaturalPersonApi.md#getpagesimilaractiveforexternal) | **GET** /naturalPerson/pageSimilarActiveForExternal | 
[**GetSimilarLiteExternal**](NaturalPersonApi.md#getsimilarliteexternal) | **GET** /naturalPerson/similarLiteExternal | 
[**NaturalPersonDeleteNaturalPerson**](NaturalPersonApi.md#naturalpersondeletenaturalperson) | **DELETE** /naturalPerson | 
[**NaturalPersonSaveSystemReference**](NaturalPersonApi.md#naturalpersonsavesystemreference) | **PUT** /naturalPerson/systemReference | 
[**NaturalPersonUpdateNotice**](NaturalPersonApi.md#naturalpersonupdatenotice) | **POST** /naturalPerson/notice | 
[**SaveForExternal**](NaturalPersonApi.md#saveforexternal) | **PUT** /naturalPerson/forExternal | 


<a name="getbydocument"></a>
# **GetByDocument**
> NaturalPersonLiteExternalModel GetByDocument (Guid? documentTypeId, string docNumber = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetByDocumentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonApi();
            var documentTypeId = new Guid?(); // Guid? | 
            var docNumber = docNumber_example;  // string |  (optional) 

            try
            {
                NaturalPersonLiteExternalModel result = apiInstance.GetByDocument(documentTypeId, docNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonApi.GetByDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentTypeId** | [**Guid?**](Guid?.md)|  | 
 **docNumber** | **string**|  | [optional] 

### Return type

[**NaturalPersonLiteExternalModel**](NaturalPersonLiteExternalModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyidforexternal"></a>
# **GetByIdForExternal**
> NaturalPersonLiteExternalModel GetByIdForExternal (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetByIdForExternalExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                NaturalPersonLiteExternalModel result = apiInstance.GetByIdForExternal(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonApi.GetByIdForExternal: " + e.Message );
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

[**NaturalPersonLiteExternalModel**](NaturalPersonLiteExternalModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyidentifierdocumentnumberliteexternal"></a>
# **GetByIdentifierDocumentNumberLiteExternal**
> NaturalPersonLiteExternalModel GetByIdentifierDocumentNumberLiteExternal (string identifierDocumentNumber = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetByIdentifierDocumentNumberLiteExternalExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonApi();
            var identifierDocumentNumber = identifierDocumentNumber_example;  // string |  (optional) 

            try
            {
                NaturalPersonLiteExternalModel result = apiInstance.GetByIdentifierDocumentNumberLiteExternal(identifierDocumentNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonApi.GetByIdentifierDocumentNumberLiteExternal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifierDocumentNumber** | **string**|  | [optional] 

### Return type

[**NaturalPersonLiteExternalModel**](NaturalPersonLiteExternalModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyusername"></a>
# **GetByUserName**
> NaturalPersonLiteExternalModel GetByUserName (string userName = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetByUserNameExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonApi();
            var userName = userName_example;  // string |  (optional) 

            try
            {
                NaturalPersonLiteExternalModel result = apiInstance.GetByUserName(userName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonApi.GetByUserName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userName** | **string**|  | [optional] 

### Return type

[**NaturalPersonLiteExternalModel**](NaturalPersonLiteExternalModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistbybasicpropertylist"></a>
# **GetListByBasicPropertyList**
> List<NaturalPersonLiteExternalModel> GetListByBasicPropertyList (List<NPBasicPropertyModel> basicPropertyList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListByBasicPropertyListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonApi();
            var basicPropertyList = new List<NPBasicPropertyModel>(); // List<NPBasicPropertyModel> |  (optional) 

            try
            {
                List&lt;NaturalPersonLiteExternalModel&gt; result = apiInstance.GetListByBasicPropertyList(basicPropertyList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonApi.GetListByBasicPropertyList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **basicPropertyList** | [**List&lt;NPBasicPropertyModel&gt;**](NPBasicPropertyModel.md)|  | [optional] 

### Return type

[**List<NaturalPersonLiteExternalModel>**](NaturalPersonLiteExternalModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistbydocument"></a>
# **GetListByDocument**
> List<NaturalPersonLiteExternalModel> GetListByDocument (Guid? documentTypeId, string docNumber = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListByDocumentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonApi();
            var documentTypeId = new Guid?(); // Guid? | 
            var docNumber = docNumber_example;  // string |  (optional) 

            try
            {
                List&lt;NaturalPersonLiteExternalModel&gt; result = apiInstance.GetListByDocument(documentTypeId, docNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonApi.GetListByDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentTypeId** | [**Guid?**](Guid?.md)|  | 
 **docNumber** | **string**|  | [optional] 

### Return type

[**List<NaturalPersonLiteExternalModel>**](NaturalPersonLiteExternalModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistbyidlistforexternal"></a>
# **GetListByIdListForExternal**
> List<NaturalPersonLiteExternalModel> GetListByIdListForExternal (List<Guid?> idList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListByIdListForExternalExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonApi();
            var idList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;NaturalPersonLiteExternalModel&gt; result = apiInstance.GetListByIdListForExternal(idList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonApi.GetListByIdListForExternal: " + e.Message );
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

[**List<NaturalPersonLiteExternalModel>**](NaturalPersonLiteExternalModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistbylastupdate"></a>
# **GetListByLastUpdate**
> List<NaturalPersonLiteExternalModel> GetListByLastUpdate (string lastUpdate)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListByLastUpdateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonApi();
            var lastUpdate = lastUpdate_example;  // string | 

            try
            {
                List&lt;NaturalPersonLiteExternalModel&gt; result = apiInstance.GetListByLastUpdate(lastUpdate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonApi.GetListByLastUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lastUpdate** | **string**|  | 

### Return type

[**List<NaturalPersonLiteExternalModel>**](NaturalPersonLiteExternalModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistnaturalpersonbydocumentnumberlist"></a>
# **GetListNaturalPersonByDocumentNumberList**
> List<NaturalPersonLiteExternalModel> GetListNaturalPersonByDocumentNumberList (List<string> documentNumberList = null, List<Guid?> documentTypeIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListNaturalPersonByDocumentNumberListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonApi();
            var documentNumberList = new List<string>(); // List<string> |  (optional) 
            var documentTypeIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;NaturalPersonLiteExternalModel&gt; result = apiInstance.GetListNaturalPersonByDocumentNumberList(documentNumberList, documentTypeIdList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonApi.GetListNaturalPersonByDocumentNumberList: " + e.Message );
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

[**List<NaturalPersonLiteExternalModel>**](NaturalPersonLiteExternalModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistnaturalpersonlastsystemupdate"></a>
# **GetListNaturalPersonLastSystemUpdate**
> List<NaturalPersonSystemUpdateLiteModel> GetListNaturalPersonLastSystemUpdate ()



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListNaturalPersonLastSystemUpdateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonApi();

            try
            {
                List&lt;NaturalPersonSystemUpdateLiteModel&gt; result = apiInstance.GetListNaturalPersonLastSystemUpdate();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonApi.GetListNaturalPersonLastSystemUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<NaturalPersonSystemUpdateLiteModel>**](NaturalPersonSystemUpdateLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpageactivebyfilterforexternal"></a>
# **GetPageActiveByFilterForExternal**
> PagedNaturalPersonLiteExternalModel GetPageActiveByFilterForExternal (int? numRows, int? pageIndex, string name = null, string birthDate = null, GenderModel gender = null, Guid? documentTypeId = null, string documentNumber = null, string parentName = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetPageActiveByFilterForExternalExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonApi();
            var numRows = 56;  // int? | 
            var pageIndex = 56;  // int? | 
            var name = name_example;  // string |  (optional) 
            var birthDate = birthDate_example;  // string |  (optional) 
            var gender = new GenderModel(); // GenderModel |  (optional) 
            var documentTypeId = new Guid?(); // Guid? |  (optional) 
            var documentNumber = documentNumber_example;  // string |  (optional) 
            var parentName = parentName_example;  // string |  (optional) 

            try
            {
                PagedNaturalPersonLiteExternalModel result = apiInstance.GetPageActiveByFilterForExternal(numRows, pageIndex, name, birthDate, gender, documentTypeId, documentNumber, parentName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonApi.GetPageActiveByFilterForExternal: " + e.Message );
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
 **name** | **string**|  | [optional] 
 **birthDate** | **string**|  | [optional] 
 **gender** | [**GenderModel**](GenderModel.md)|  | [optional] 
 **documentTypeId** | [**Guid?**](Guid?.md)|  | [optional] 
 **documentNumber** | **string**|  | [optional] 
 **parentName** | **string**|  | [optional] 

### Return type

[**PagedNaturalPersonLiteExternalModel**](PagedNaturalPersonLiteExternalModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpageactivebyfilterforexternal2"></a>
# **GetPageActiveByFilterForExternal2**
> PagedNaturalPersonLiteExternalModel GetPageActiveByFilterForExternal2 (string birthDate, GenderModel gender, int? numRows, int? pageIndex, string firstName = null, string middleName = null, string lastName = null, string motherName = null, string identifierDocumentNumber = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetPageActiveByFilterForExternal2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonApi();
            var birthDate = birthDate_example;  // string | 
            var gender = new GenderModel(); // GenderModel | 
            var numRows = 56;  // int? | 
            var pageIndex = 56;  // int? | 
            var firstName = firstName_example;  // string |  (optional) 
            var middleName = middleName_example;  // string |  (optional) 
            var lastName = lastName_example;  // string |  (optional) 
            var motherName = motherName_example;  // string |  (optional) 
            var identifierDocumentNumber = identifierDocumentNumber_example;  // string |  (optional) 

            try
            {
                PagedNaturalPersonLiteExternalModel result = apiInstance.GetPageActiveByFilterForExternal2(birthDate, gender, numRows, pageIndex, firstName, middleName, lastName, motherName, identifierDocumentNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonApi.GetPageActiveByFilterForExternal2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **birthDate** | **string**|  | 
 **gender** | [**GenderModel**](GenderModel.md)|  | 
 **numRows** | **int?**|  | 
 **pageIndex** | **int?**|  | 
 **firstName** | **string**|  | [optional] 
 **middleName** | **string**|  | [optional] 
 **lastName** | **string**|  | [optional] 
 **motherName** | **string**|  | [optional] 
 **identifierDocumentNumber** | **string**|  | [optional] 

### Return type

[**PagedNaturalPersonLiteExternalModel**](PagedNaturalPersonLiteExternalModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagesimilaractivebyid"></a>
# **GetPageSimilarActiveById**
> PagedNaturalPersonLiteExternalModel GetPageSimilarActiveById (Guid? naturalPersonId, int? numRows, int? pageIndex)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetPageSimilarActiveByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonApi();
            var naturalPersonId = new Guid?(); // Guid? | 
            var numRows = 56;  // int? | 
            var pageIndex = 56;  // int? | 

            try
            {
                PagedNaturalPersonLiteExternalModel result = apiInstance.GetPageSimilarActiveById(naturalPersonId, numRows, pageIndex);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonApi.GetPageSimilarActiveById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **naturalPersonId** | [**Guid?**](Guid?.md)|  | 
 **numRows** | **int?**|  | 
 **pageIndex** | **int?**|  | 

### Return type

[**PagedNaturalPersonLiteExternalModel**](PagedNaturalPersonLiteExternalModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagesimilaractiveforexternal"></a>
# **GetPageSimilarActiveForExternal**
> PagedNaturalPersonLiteExternalModel GetPageSimilarActiveForExternal (string birthDate, GenderModel gender, int? numRows, int? pageIndex, string firstName = null, string middleName = null, string lastName = null, string motherName = null, string identifierDocumentNumber = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetPageSimilarActiveForExternalExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonApi();
            var birthDate = birthDate_example;  // string | 
            var gender = new GenderModel(); // GenderModel | 
            var numRows = 56;  // int? | 
            var pageIndex = 56;  // int? | 
            var firstName = firstName_example;  // string |  (optional) 
            var middleName = middleName_example;  // string |  (optional) 
            var lastName = lastName_example;  // string |  (optional) 
            var motherName = motherName_example;  // string |  (optional) 
            var identifierDocumentNumber = identifierDocumentNumber_example;  // string |  (optional) 

            try
            {
                PagedNaturalPersonLiteExternalModel result = apiInstance.GetPageSimilarActiveForExternal(birthDate, gender, numRows, pageIndex, firstName, middleName, lastName, motherName, identifierDocumentNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonApi.GetPageSimilarActiveForExternal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **birthDate** | **string**|  | 
 **gender** | [**GenderModel**](GenderModel.md)|  | 
 **numRows** | **int?**|  | 
 **pageIndex** | **int?**|  | 
 **firstName** | **string**|  | [optional] 
 **middleName** | **string**|  | [optional] 
 **lastName** | **string**|  | [optional] 
 **motherName** | **string**|  | [optional] 
 **identifierDocumentNumber** | **string**|  | [optional] 

### Return type

[**PagedNaturalPersonLiteExternalModel**](PagedNaturalPersonLiteExternalModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsimilarliteexternal"></a>
# **GetSimilarLiteExternal**
> NaturalPersonLiteExternalModel GetSimilarLiteExternal (string birthDate, string fullName = null, string motherName = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetSimilarLiteExternalExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonApi();
            var birthDate = birthDate_example;  // string | 
            var fullName = fullName_example;  // string |  (optional) 
            var motherName = motherName_example;  // string |  (optional) 

            try
            {
                NaturalPersonLiteExternalModel result = apiInstance.GetSimilarLiteExternal(birthDate, fullName, motherName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonApi.GetSimilarLiteExternal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **birthDate** | **string**|  | 
 **fullName** | **string**|  | [optional] 
 **motherName** | **string**|  | [optional] 

### Return type

[**NaturalPersonLiteExternalModel**](NaturalPersonLiteExternalModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="naturalpersondeletenaturalperson"></a>
# **NaturalPersonDeleteNaturalPerson**
> void NaturalPersonDeleteNaturalPerson (List<Guid?> naturalPersonIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class NaturalPersonDeleteNaturalPersonExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonApi();
            var naturalPersonIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                apiInstance.NaturalPersonDeleteNaturalPerson(naturalPersonIdList);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonApi.NaturalPersonDeleteNaturalPerson: " + e.Message );
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

void (empty response body)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="naturalpersonsavesystemreference"></a>
# **NaturalPersonSaveSystemReference**
> void NaturalPersonSaveSystemReference (List<Guid?> naturalPersonIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class NaturalPersonSaveSystemReferenceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonApi();
            var naturalPersonIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                apiInstance.NaturalPersonSaveSystemReference(naturalPersonIdList);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonApi.NaturalPersonSaveSystemReference: " + e.Message );
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

void (empty response body)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="naturalpersonupdatenotice"></a>
# **NaturalPersonUpdateNotice**
> void NaturalPersonUpdateNotice (List<Guid?> naturalPersonIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class NaturalPersonUpdateNoticeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonApi();
            var naturalPersonIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                apiInstance.NaturalPersonUpdateNotice(naturalPersonIdList);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonApi.NaturalPersonUpdateNotice: " + e.Message );
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

void (empty response body)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="saveforexternal"></a>
# **SaveForExternal**
> NaturalPersonLiteExternalModel SaveForExternal (NaturalPersonLiteExternalModel naturalPerson = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class SaveForExternalExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NaturalPersonApi();
            var naturalPerson = new NaturalPersonLiteExternalModel(); // NaturalPersonLiteExternalModel |  (optional) 

            try
            {
                NaturalPersonLiteExternalModel result = apiInstance.SaveForExternal(naturalPerson);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPersonApi.SaveForExternal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **naturalPerson** | [**NaturalPersonLiteExternalModel**](NaturalPersonLiteExternalModel.md)|  | [optional] 

### Return type

[**NaturalPersonLiteExternalModel**](NaturalPersonLiteExternalModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


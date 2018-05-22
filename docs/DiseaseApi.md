# Iatec.Adems.PeopleManagement.Client.Api.DiseaseApi

All URIs are relative to *https://ws-peoplemgmt.sdasystems.org/bra*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DiseaseDeleteSystemReference**](DiseaseApi.md#diseasedeletesystemreference) | **DELETE** /disease/systemReference | 
[**DiseaseSaveSystemReference**](DiseaseApi.md#diseasesavesystemreference) | **PUT** /disease/systemReference | 
[**GetDiseaseById**](DiseaseApi.md#getdiseasebyid) | **GET** /disease/byId | 
[**GetListByType**](DiseaseApi.md#getlistbytype) | **GET** /disease/byType | 
[**GetListDiseaseByFilter**](DiseaseApi.md#getlistdiseasebyfilter) | **GET** /disease/byFilter | 
[**GetListDiseaseByIdList**](DiseaseApi.md#getlistdiseasebyidlist) | **GET** /disease/byIdList | 
[**GetPageDiseaseAvailableToNaturalPerson**](DiseaseApi.md#getpagediseaseavailabletonaturalperson) | **GET** /disease/pageAvailableToNaturalPerson | 


<a name="diseasedeletesystemreference"></a>
# **DiseaseDeleteSystemReference**
> void DiseaseDeleteSystemReference (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class DiseaseDeleteSystemReferenceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DiseaseApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.DiseaseDeleteSystemReference(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiseaseApi.DiseaseDeleteSystemReference: " + e.Message );
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

<a name="diseasesavesystemreference"></a>
# **DiseaseSaveSystemReference**
> void DiseaseSaveSystemReference (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class DiseaseSaveSystemReferenceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DiseaseApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.DiseaseSaveSystemReference(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiseaseApi.DiseaseSaveSystemReference: " + e.Message );
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

<a name="getdiseasebyid"></a>
# **GetDiseaseById**
> DiseaseModel GetDiseaseById (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetDiseaseByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DiseaseApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                DiseaseModel result = apiInstance.GetDiseaseById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiseaseApi.GetDiseaseById: " + e.Message );
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

[**DiseaseModel**](DiseaseModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistbytype"></a>
# **GetListByType**
> List<DiseaseModel> GetListByType (Guid? diseaseTypeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListByTypeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DiseaseApi();
            var diseaseTypeId = new Guid?(); // Guid? | 

            try
            {
                List&lt;DiseaseModel&gt; result = apiInstance.GetListByType(diseaseTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiseaseApi.GetListByType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **diseaseTypeId** | [**Guid?**](Guid?.md)|  | 

### Return type

[**List<DiseaseModel>**](DiseaseModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistdiseasebyfilter"></a>
# **GetListDiseaseByFilter**
> List<DiseaseModel> GetListDiseaseByFilter (string filter = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListDiseaseByFilterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DiseaseApi();
            var filter = filter_example;  // string |  (optional) 

            try
            {
                List&lt;DiseaseModel&gt; result = apiInstance.GetListDiseaseByFilter(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiseaseApi.GetListDiseaseByFilter: " + e.Message );
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

[**List<DiseaseModel>**](DiseaseModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistdiseasebyidlist"></a>
# **GetListDiseaseByIdList**
> List<DiseaseModel> GetListDiseaseByIdList (List<Guid?> idList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListDiseaseByIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DiseaseApi();
            var idList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;DiseaseModel&gt; result = apiInstance.GetListDiseaseByIdList(idList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiseaseApi.GetListDiseaseByIdList: " + e.Message );
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

[**List<DiseaseModel>**](DiseaseModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagediseaseavailabletonaturalperson"></a>
# **GetPageDiseaseAvailableToNaturalPerson**
> PagedDiseaseModel GetPageDiseaseAvailableToNaturalPerson (Guid? naturalPerson, int? numRows, int? pageIndex, List<Guid?> selectedItems = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetPageDiseaseAvailableToNaturalPersonExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DiseaseApi();
            var naturalPerson = new Guid?(); // Guid? | 
            var numRows = 56;  // int? | 
            var pageIndex = 56;  // int? | 
            var selectedItems = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                PagedDiseaseModel result = apiInstance.GetPageDiseaseAvailableToNaturalPerson(naturalPerson, numRows, pageIndex, selectedItems);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiseaseApi.GetPageDiseaseAvailableToNaturalPerson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **naturalPerson** | [**Guid?**](Guid?.md)|  | 
 **numRows** | **int?**|  | 
 **pageIndex** | **int?**|  | 
 **selectedItems** | [**List&lt;Guid?&gt;**](Guid?.md)|  | [optional] 

### Return type

[**PagedDiseaseModel**](PagedDiseaseModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


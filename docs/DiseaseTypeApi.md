# Iatec.Adems.PeopleManagement.Client.Api.DiseaseTypeApi

All URIs are relative to *https://ws-peoplemgmt.sdasystems.org/bra*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DiseaseTypeDeleteSystemReference**](DiseaseTypeApi.md#diseasetypedeletesystemreference) | **DELETE** /diseaseType/systemReference | 
[**DiseaseTypeSaveSystemReference**](DiseaseTypeApi.md#diseasetypesavesystemreference) | **PUT** /diseaseType/systemReference | 
[**GetDiseaseTypeById**](DiseaseTypeApi.md#getdiseasetypebyid) | **GET** /diseaseType/byId | 
[**GetListDiseaseTypeByFilter**](DiseaseTypeApi.md#getlistdiseasetypebyfilter) | **GET** /diseaseType/byFilter | 
[**GetListDiseaseTypeByIdList**](DiseaseTypeApi.md#getlistdiseasetypebyidlist) | **GET** /diseaseType/byIdList | 


<a name="diseasetypedeletesystemreference"></a>
# **DiseaseTypeDeleteSystemReference**
> void DiseaseTypeDeleteSystemReference (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class DiseaseTypeDeleteSystemReferenceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DiseaseTypeApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.DiseaseTypeDeleteSystemReference(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiseaseTypeApi.DiseaseTypeDeleteSystemReference: " + e.Message );
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

<a name="diseasetypesavesystemreference"></a>
# **DiseaseTypeSaveSystemReference**
> void DiseaseTypeSaveSystemReference (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class DiseaseTypeSaveSystemReferenceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DiseaseTypeApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.DiseaseTypeSaveSystemReference(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiseaseTypeApi.DiseaseTypeSaveSystemReference: " + e.Message );
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

<a name="getdiseasetypebyid"></a>
# **GetDiseaseTypeById**
> DiseaseTypeModel GetDiseaseTypeById (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetDiseaseTypeByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DiseaseTypeApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                DiseaseTypeModel result = apiInstance.GetDiseaseTypeById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiseaseTypeApi.GetDiseaseTypeById: " + e.Message );
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

[**DiseaseTypeModel**](DiseaseTypeModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistdiseasetypebyfilter"></a>
# **GetListDiseaseTypeByFilter**
> List<DiseaseTypeModel> GetListDiseaseTypeByFilter (string filter = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListDiseaseTypeByFilterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DiseaseTypeApi();
            var filter = filter_example;  // string |  (optional) 

            try
            {
                List&lt;DiseaseTypeModel&gt; result = apiInstance.GetListDiseaseTypeByFilter(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiseaseTypeApi.GetListDiseaseTypeByFilter: " + e.Message );
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

[**List<DiseaseTypeModel>**](DiseaseTypeModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistdiseasetypebyidlist"></a>
# **GetListDiseaseTypeByIdList**
> List<DiseaseTypeModel> GetListDiseaseTypeByIdList (List<Guid?> idList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListDiseaseTypeByIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DiseaseTypeApi();
            var idList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;DiseaseTypeModel&gt; result = apiInstance.GetListDiseaseTypeByIdList(idList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiseaseTypeApi.GetListDiseaseTypeByIdList: " + e.Message );
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

[**List<DiseaseTypeModel>**](DiseaseTypeModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


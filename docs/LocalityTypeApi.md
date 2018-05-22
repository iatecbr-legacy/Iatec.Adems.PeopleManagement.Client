# Iatec.Adems.PeopleManagement.Client.Api.LocalityTypeApi

All URIs are relative to *https://ws-peoplemgmt.sdasystems.org/bra*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetByDivisionTypeAndCountry**](LocalityTypeApi.md#getbydivisiontypeandcountry) | **GET** /localityType/byDivisionTypeAndCountry | 
[**GetListByCountry**](LocalityTypeApi.md#getlistbycountry) | **GET** /localityType/byCountry | 
[**GetListByCountryForSearch**](LocalityTypeApi.md#getlistbycountryforsearch) | **GET** /localityType/byCountryForSearch | 
[**GetListByFilter**](LocalityTypeApi.md#getlistbyfilter) | **GET** /localityType/byFilter | 
[**GetListLocalityTypeByIdList**](LocalityTypeApi.md#getlistlocalitytypebyidlist) | **GET** /localityType/byIdList | 
[**GetLocalityTypeById**](LocalityTypeApi.md#getlocalitytypebyid) | **GET** /localityType/byId | 
[**LocalityTypeDeleteSystemReference**](LocalityTypeApi.md#localitytypedeletesystemreference) | **DELETE** /localityType/systemReference | 
[**LocalityTypeSaveSystemReference**](LocalityTypeApi.md#localitytypesavesystemreference) | **PUT** /localityType/systemReference | 


<a name="getbydivisiontypeandcountry"></a>
# **GetByDivisionTypeAndCountry**
> LocalityTypeLiteModel GetByDivisionTypeAndCountry (PoliticalDivisionTypeModel divisionType, Guid? countryId)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetByDivisionTypeAndCountryExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalityTypeApi();
            var divisionType = new PoliticalDivisionTypeModel(); // PoliticalDivisionTypeModel | 
            var countryId = new Guid?(); // Guid? | 

            try
            {
                LocalityTypeLiteModel result = apiInstance.GetByDivisionTypeAndCountry(divisionType, countryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalityTypeApi.GetByDivisionTypeAndCountry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **divisionType** | [**PoliticalDivisionTypeModel**](PoliticalDivisionTypeModel.md)|  | 
 **countryId** | [**Guid?**](Guid?.md)|  | 

### Return type

[**LocalityTypeLiteModel**](LocalityTypeLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistbycountry"></a>
# **GetListByCountry**
> List<LocalityTypeLiteModel> GetListByCountry (Guid? countryId)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListByCountryExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalityTypeApi();
            var countryId = new Guid?(); // Guid? | 

            try
            {
                List&lt;LocalityTypeLiteModel&gt; result = apiInstance.GetListByCountry(countryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalityTypeApi.GetListByCountry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryId** | [**Guid?**](Guid?.md)|  | 

### Return type

[**List<LocalityTypeLiteModel>**](LocalityTypeLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistbycountryforsearch"></a>
# **GetListByCountryForSearch**
> List<LocalityTypeLiteSearchModel> GetListByCountryForSearch (Guid? countryId)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListByCountryForSearchExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalityTypeApi();
            var countryId = new Guid?(); // Guid? | 

            try
            {
                List&lt;LocalityTypeLiteSearchModel&gt; result = apiInstance.GetListByCountryForSearch(countryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalityTypeApi.GetListByCountryForSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryId** | [**Guid?**](Guid?.md)|  | 

### Return type

[**List<LocalityTypeLiteSearchModel>**](LocalityTypeLiteSearchModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistbyfilter"></a>
# **GetListByFilter**
> List<LocalityTypeLiteModel> GetListByFilter (string filter = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListByFilterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalityTypeApi();
            var filter = filter_example;  // string |  (optional) 

            try
            {
                List&lt;LocalityTypeLiteModel&gt; result = apiInstance.GetListByFilter(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalityTypeApi.GetListByFilter: " + e.Message );
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

[**List<LocalityTypeLiteModel>**](LocalityTypeLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistlocalitytypebyidlist"></a>
# **GetListLocalityTypeByIdList**
> List<LocalityTypeLiteModel> GetListLocalityTypeByIdList (List<Guid?> idList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListLocalityTypeByIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalityTypeApi();
            var idList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;LocalityTypeLiteModel&gt; result = apiInstance.GetListLocalityTypeByIdList(idList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalityTypeApi.GetListLocalityTypeByIdList: " + e.Message );
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

[**List<LocalityTypeLiteModel>**](LocalityTypeLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocalitytypebyid"></a>
# **GetLocalityTypeById**
> LocalityTypeLiteModel GetLocalityTypeById (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetLocalityTypeByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalityTypeApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                LocalityTypeLiteModel result = apiInstance.GetLocalityTypeById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalityTypeApi.GetLocalityTypeById: " + e.Message );
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

[**LocalityTypeLiteModel**](LocalityTypeLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="localitytypedeletesystemreference"></a>
# **LocalityTypeDeleteSystemReference**
> void LocalityTypeDeleteSystemReference (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class LocalityTypeDeleteSystemReferenceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalityTypeApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.LocalityTypeDeleteSystemReference(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalityTypeApi.LocalityTypeDeleteSystemReference: " + e.Message );
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

<a name="localitytypesavesystemreference"></a>
# **LocalityTypeSaveSystemReference**
> void LocalityTypeSaveSystemReference (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class LocalityTypeSaveSystemReferenceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalityTypeApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.LocalityTypeSaveSystemReference(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalityTypeApi.LocalityTypeSaveSystemReference: " + e.Message );
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


# Iatec.Adems.PeopleManagement.Client.Api.LocalityApi

All URIs are relative to *https://ws-peoplemgmt.sdasystems.org/bra*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAddressByZipPostalCode**](LocalityApi.md#getaddressbyzippostalcode) | **GET** /locality/addressByZipPostalCode | 
[**GetListByDivisionTypeAndCountry**](LocalityApi.md#getlistbydivisiontypeandcountry) | **GET** /locality/byDivisionTypeAndCountry | 
[**GetListByTypeAndParent**](LocalityApi.md#getlistbytypeandparent) | **GET** /locality/byTypeAndParent | 
[**GetListLocalityByIdList**](LocalityApi.md#getlistlocalitybyidlist) | **GET** /locality/byIdList | 
[**GetListLocalityByNameList**](LocalityApi.md#getlistlocalitybynamelist) | **GET** /locality/byNameList | 
[**GetLocalityById**](LocalityApi.md#getlocalitybyid) | **GET** /locality/byId | 
[**GetPageCityByFilterAndCountry**](LocalityApi.md#getpagecitybyfilterandcountry) | **GET** /locality/pageCityByFilterAndCountry | 
[**GetPageHasAddressByFilterAndCountry**](LocalityApi.md#getpagehasaddressbyfilterandcountry) | **GET** /locality/pageHasAddressByFilterAndCountry | 
[**GetPageLocalityByFilter**](LocalityApi.md#getpagelocalitybyfilter) | **GET** /locality/pageByFilter | 
[**LocalityDeleteSystemReference**](LocalityApi.md#localitydeletesystemreference) | **DELETE** /locality/systemReference | 
[**LocalitySaveSystemReference**](LocalityApi.md#localitysavesystemreference) | **PUT** /locality/systemReference | 


<a name="getaddressbyzippostalcode"></a>
# **GetAddressByZipPostalCode**
> ZipPostalCodeAddressLiteModel GetAddressByZipPostalCode (Guid? countryId, string zipCode = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetAddressByZipPostalCodeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalityApi();
            var countryId = new Guid?(); // Guid? | 
            var zipCode = zipCode_example;  // string |  (optional) 

            try
            {
                ZipPostalCodeAddressLiteModel result = apiInstance.GetAddressByZipPostalCode(countryId, zipCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalityApi.GetAddressByZipPostalCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryId** | [**Guid?**](Guid?.md)|  | 
 **zipCode** | **string**|  | [optional] 

### Return type

[**ZipPostalCodeAddressLiteModel**](ZipPostalCodeAddressLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistbydivisiontypeandcountry"></a>
# **GetListByDivisionTypeAndCountry**
> List<LocalityLiteSearchModel> GetListByDivisionTypeAndCountry (PoliticalDivisionTypeModel divisionType, Guid? countryId, string filter = null, Guid? parentId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListByDivisionTypeAndCountryExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalityApi();
            var divisionType = new PoliticalDivisionTypeModel(); // PoliticalDivisionTypeModel | 
            var countryId = new Guid?(); // Guid? | 
            var filter = filter_example;  // string |  (optional) 
            var parentId = new Guid?(); // Guid? |  (optional) 

            try
            {
                List&lt;LocalityLiteSearchModel&gt; result = apiInstance.GetListByDivisionTypeAndCountry(divisionType, countryId, filter, parentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalityApi.GetListByDivisionTypeAndCountry: " + e.Message );
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
 **filter** | **string**|  | [optional] 
 **parentId** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

[**List<LocalityLiteSearchModel>**](LocalityLiteSearchModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistbytypeandparent"></a>
# **GetListByTypeAndParent**
> List<LocalityLiteSearchModel> GetListByTypeAndParent (Guid? localityTypeId, string filter = null, Guid? parentId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListByTypeAndParentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalityApi();
            var localityTypeId = new Guid?(); // Guid? | 
            var filter = filter_example;  // string |  (optional) 
            var parentId = new Guid?(); // Guid? |  (optional) 

            try
            {
                List&lt;LocalityLiteSearchModel&gt; result = apiInstance.GetListByTypeAndParent(localityTypeId, filter, parentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalityApi.GetListByTypeAndParent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **localityTypeId** | [**Guid?**](Guid?.md)|  | 
 **filter** | **string**|  | [optional] 
 **parentId** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

[**List<LocalityLiteSearchModel>**](LocalityLiteSearchModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistlocalitybyidlist"></a>
# **GetListLocalityByIdList**
> List<LocalityLiteModel> GetListLocalityByIdList (List<Guid?> idList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListLocalityByIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalityApi();
            var idList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;LocalityLiteModel&gt; result = apiInstance.GetListLocalityByIdList(idList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalityApi.GetListLocalityByIdList: " + e.Message );
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

[**List<LocalityLiteModel>**](LocalityLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistlocalitybynamelist"></a>
# **GetListLocalityByNameList**
> List<LocalityLiteModel> GetListLocalityByNameList (List<string> nameList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListLocalityByNameListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalityApi();
            var nameList = new List<string>(); // List<string> |  (optional) 

            try
            {
                List&lt;LocalityLiteModel&gt; result = apiInstance.GetListLocalityByNameList(nameList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalityApi.GetListLocalityByNameList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nameList** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

[**List<LocalityLiteModel>**](LocalityLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocalitybyid"></a>
# **GetLocalityById**
> LocalityLiteModel GetLocalityById (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetLocalityByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalityApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                LocalityLiteModel result = apiInstance.GetLocalityById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalityApi.GetLocalityById: " + e.Message );
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

[**LocalityLiteModel**](LocalityLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagecitybyfilterandcountry"></a>
# **GetPageCityByFilterAndCountry**
> PagedLocalityLiteSearchModel GetPageCityByFilterAndCountry (Guid? countryId, int? numRows, int? pageIndex, string filter = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetPageCityByFilterAndCountryExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalityApi();
            var countryId = new Guid?(); // Guid? | 
            var numRows = 56;  // int? | 
            var pageIndex = 56;  // int? | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                PagedLocalityLiteSearchModel result = apiInstance.GetPageCityByFilterAndCountry(countryId, numRows, pageIndex, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalityApi.GetPageCityByFilterAndCountry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryId** | [**Guid?**](Guid?.md)|  | 
 **numRows** | **int?**|  | 
 **pageIndex** | **int?**|  | 
 **filter** | **string**|  | [optional] 

### Return type

[**PagedLocalityLiteSearchModel**](PagedLocalityLiteSearchModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagehasaddressbyfilterandcountry"></a>
# **GetPageHasAddressByFilterAndCountry**
> PagedLocalityLiteSearchModel GetPageHasAddressByFilterAndCountry (Guid? countryId, int? numRows, int? pageIndex, string filter = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetPageHasAddressByFilterAndCountryExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalityApi();
            var countryId = new Guid?(); // Guid? | 
            var numRows = 56;  // int? | 
            var pageIndex = 56;  // int? | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                PagedLocalityLiteSearchModel result = apiInstance.GetPageHasAddressByFilterAndCountry(countryId, numRows, pageIndex, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalityApi.GetPageHasAddressByFilterAndCountry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryId** | [**Guid?**](Guid?.md)|  | 
 **numRows** | **int?**|  | 
 **pageIndex** | **int?**|  | 
 **filter** | **string**|  | [optional] 

### Return type

[**PagedLocalityLiteSearchModel**](PagedLocalityLiteSearchModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagelocalitybyfilter"></a>
# **GetPageLocalityByFilter**
> PagedLocalityLiteModel GetPageLocalityByFilter (int? numRows, int? pageIndex, string filter = null, Guid? countryId = null, Guid? localityTypeId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetPageLocalityByFilterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalityApi();
            var numRows = 56;  // int? | 
            var pageIndex = 56;  // int? | 
            var filter = filter_example;  // string |  (optional) 
            var countryId = new Guid?(); // Guid? |  (optional) 
            var localityTypeId = new Guid?(); // Guid? |  (optional) 

            try
            {
                PagedLocalityLiteModel result = apiInstance.GetPageLocalityByFilter(numRows, pageIndex, filter, countryId, localityTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalityApi.GetPageLocalityByFilter: " + e.Message );
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
 **countryId** | [**Guid?**](Guid?.md)|  | [optional] 
 **localityTypeId** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

[**PagedLocalityLiteModel**](PagedLocalityLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="localitydeletesystemreference"></a>
# **LocalityDeleteSystemReference**
> void LocalityDeleteSystemReference (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class LocalityDeleteSystemReferenceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalityApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.LocalityDeleteSystemReference(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalityApi.LocalityDeleteSystemReference: " + e.Message );
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

<a name="localitysavesystemreference"></a>
# **LocalitySaveSystemReference**
> void LocalitySaveSystemReference (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class LocalitySaveSystemReferenceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalityApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.LocalitySaveSystemReference(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalityApi.LocalitySaveSystemReference: " + e.Message );
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


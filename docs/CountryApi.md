# Iatec.Adems.PeopleManagement.Client.Api.CountryApi

All URIs are relative to *https://ws-peoplemgmt.sdasystems.org/bra*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CountryDeleteSystemReference**](CountryApi.md#countrydeletesystemreference) | **DELETE** /country/systemReference | 
[**CountrySaveSystemReference**](CountryApi.md#countrysavesystemreference) | **PUT** /country/systemReference | 
[**GetCountryById**](CountryApi.md#getcountrybyid) | **GET** /country/byId | 
[**GetCurrent**](CountryApi.md#getcurrent) | **GET** /country/current | 
[**GetListCountryByIdList**](CountryApi.md#getlistcountrybyidlist) | **GET** /country/byIdList | 
[**GetListCountryByNameList**](CountryApi.md#getlistcountrybynamelist) | **GET** /country/byNameList | 
[**GetPageAvailable**](CountryApi.md#getpageavailable) | **GET** /country/pageAvailable | 
[**GetPageCountryByFilter**](CountryApi.md#getpagecountrybyfilter) | **GET** /country/pageByFilter | 
[**GetPageForSearch**](CountryApi.md#getpageforsearch) | **GET** /country/pageForSearch | 
[**GetPagePhoneCodeByFilter**](CountryApi.md#getpagephonecodebyfilter) | **GET** /country/pagePhoneCodeByFilter | 


<a name="countrydeletesystemreference"></a>
# **CountryDeleteSystemReference**
> void CountryDeleteSystemReference (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class CountryDeleteSystemReferenceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CountryApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.CountryDeleteSystemReference(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CountryApi.CountryDeleteSystemReference: " + e.Message );
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

<a name="countrysavesystemreference"></a>
# **CountrySaveSystemReference**
> void CountrySaveSystemReference (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class CountrySaveSystemReferenceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CountryApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.CountrySaveSystemReference(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CountryApi.CountrySaveSystemReference: " + e.Message );
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

<a name="getcountrybyid"></a>
# **GetCountryById**
> CountryLiteModel GetCountryById (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetCountryByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CountryApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                CountryLiteModel result = apiInstance.GetCountryById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CountryApi.GetCountryById: " + e.Message );
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

[**CountryLiteModel**](CountryLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrent"></a>
# **GetCurrent**
> CountryLiteSearchModel GetCurrent ()



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetCurrentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CountryApi();

            try
            {
                CountryLiteSearchModel result = apiInstance.GetCurrent();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CountryApi.GetCurrent: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CountryLiteSearchModel**](CountryLiteSearchModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistcountrybyidlist"></a>
# **GetListCountryByIdList**
> List<CountryLiteModel> GetListCountryByIdList (List<Guid?> idList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListCountryByIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CountryApi();
            var idList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;CountryLiteModel&gt; result = apiInstance.GetListCountryByIdList(idList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CountryApi.GetListCountryByIdList: " + e.Message );
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

[**List<CountryLiteModel>**](CountryLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistcountrybynamelist"></a>
# **GetListCountryByNameList**
> List<CountryLiteModel> GetListCountryByNameList (List<string> nameList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListCountryByNameListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CountryApi();
            var nameList = new List<string>(); // List<string> |  (optional) 

            try
            {
                List&lt;CountryLiteModel&gt; result = apiInstance.GetListCountryByNameList(nameList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CountryApi.GetListCountryByNameList: " + e.Message );
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

[**List<CountryLiteModel>**](CountryLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpageavailable"></a>
# **GetPageAvailable**
> PagedCountryLiteSearchModel GetPageAvailable (int? numRows, int? pageIndex, string filter = null, List<Guid?> selectedItems = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetPageAvailableExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CountryApi();
            var numRows = 56;  // int? | 
            var pageIndex = 56;  // int? | 
            var filter = filter_example;  // string |  (optional) 
            var selectedItems = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                PagedCountryLiteSearchModel result = apiInstance.GetPageAvailable(numRows, pageIndex, filter, selectedItems);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CountryApi.GetPageAvailable: " + e.Message );
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
 **selectedItems** | [**List&lt;Guid?&gt;**](Guid?.md)|  | [optional] 

### Return type

[**PagedCountryLiteSearchModel**](PagedCountryLiteSearchModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagecountrybyfilter"></a>
# **GetPageCountryByFilter**
> PagedCountryLiteModel GetPageCountryByFilter (int? numRows, int? pageIndex, string filter = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetPageCountryByFilterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CountryApi();
            var numRows = 56;  // int? | 
            var pageIndex = 56;  // int? | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                PagedCountryLiteModel result = apiInstance.GetPageCountryByFilter(numRows, pageIndex, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CountryApi.GetPageCountryByFilter: " + e.Message );
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

### Return type

[**PagedCountryLiteModel**](PagedCountryLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpageforsearch"></a>
# **GetPageForSearch**
> PagedCountryLiteSearchModel GetPageForSearch (int? numRows, int? pageIndex, string filter = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetPageForSearchExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CountryApi();
            var numRows = 56;  // int? | 
            var pageIndex = 56;  // int? | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                PagedCountryLiteSearchModel result = apiInstance.GetPageForSearch(numRows, pageIndex, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CountryApi.GetPageForSearch: " + e.Message );
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

### Return type

[**PagedCountryLiteSearchModel**](PagedCountryLiteSearchModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagephonecodebyfilter"></a>
# **GetPagePhoneCodeByFilter**
> PagedCountryPhoneCodeModel GetPagePhoneCodeByFilter (int? numRows, int? pageIndex, string filter = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetPagePhoneCodeByFilterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CountryApi();
            var numRows = 56;  // int? | 
            var pageIndex = 56;  // int? | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                PagedCountryPhoneCodeModel result = apiInstance.GetPagePhoneCodeByFilter(numRows, pageIndex, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CountryApi.GetPagePhoneCodeByFilter: " + e.Message );
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

### Return type

[**PagedCountryPhoneCodeModel**](PagedCountryPhoneCodeModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


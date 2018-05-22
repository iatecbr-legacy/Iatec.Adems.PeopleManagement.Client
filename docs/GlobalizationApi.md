# Iatec.Adems.PeopleManagement.Client.Api.GlobalizationApi

All URIs are relative to *https://ws-peoplemgmt.sdasystems.org/bra*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCultureByName**](GlobalizationApi.md#getculturebyname) | **GET** /globalization/cultureByName | 
[**GetPageCultureByFilter**](GlobalizationApi.md#getpageculturebyfilter) | **GET** /globalization/pageCultureByFilter | 
[**GetPageTimeZoneByFilter**](GlobalizationApi.md#getpagetimezonebyfilter) | **GET** /globalization/pageTimeZoneByFilter | 
[**GetTimeZoneById**](GlobalizationApi.md#gettimezonebyid) | **GET** /globalization/timeZoneById | 


<a name="getculturebyname"></a>
# **GetCultureByName**
> CultureModel GetCultureByName (string name = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetCultureByNameExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GlobalizationApi();
            var name = name_example;  // string |  (optional) 

            try
            {
                CultureModel result = apiInstance.GetCultureByName(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GlobalizationApi.GetCultureByName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | [optional] 

### Return type

[**CultureModel**](CultureModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpageculturebyfilter"></a>
# **GetPageCultureByFilter**
> PagedCultureModel GetPageCultureByFilter (int? numRows, int? pageIndex, string filter = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetPageCultureByFilterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GlobalizationApi();
            var numRows = 56;  // int? | 
            var pageIndex = 56;  // int? | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                PagedCultureModel result = apiInstance.GetPageCultureByFilter(numRows, pageIndex, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GlobalizationApi.GetPageCultureByFilter: " + e.Message );
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

[**PagedCultureModel**](PagedCultureModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagetimezonebyfilter"></a>
# **GetPageTimeZoneByFilter**
> PagedTimeZoneModel GetPageTimeZoneByFilter (int? numRows, int? pageIndex, string filter = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetPageTimeZoneByFilterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GlobalizationApi();
            var numRows = 56;  // int? | 
            var pageIndex = 56;  // int? | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                PagedTimeZoneModel result = apiInstance.GetPageTimeZoneByFilter(numRows, pageIndex, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GlobalizationApi.GetPageTimeZoneByFilter: " + e.Message );
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

[**PagedTimeZoneModel**](PagedTimeZoneModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettimezonebyid"></a>
# **GetTimeZoneById**
> TimeZoneModel GetTimeZoneById (string id = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetTimeZoneByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GlobalizationApi();
            var id = id_example;  // string |  (optional) 

            try
            {
                TimeZoneModel result = apiInstance.GetTimeZoneById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GlobalizationApi.GetTimeZoneById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | [optional] 

### Return type

[**TimeZoneModel**](TimeZoneModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


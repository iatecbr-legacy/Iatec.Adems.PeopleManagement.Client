# Iatec.Adems.PeopleManagement.Client.Api.PersonAddressApi

All URIs are relative to *https://ws-peoplemgmt.sdasystems.org/bra*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletePersonAddress**](PersonAddressApi.md#deletepersonaddress) | **DELETE** /personAddress | 
[**GetIsMailling**](PersonAddressApi.md#getismailling) | **GET** /personAddress/isMailling | 
[**GetListIsMaillingByPersonIdList**](PersonAddressApi.md#getlistismaillingbypersonidlist) | **GET** /personAddress/isMaillingByPersonIdList | 
[**GetListPersonAddressByPerson**](PersonAddressApi.md#getlistpersonaddressbyperson) | **GET** /personAddress/byPerson | 
[**GetListPersonAddressByPersonIdList**](PersonAddressApi.md#getlistpersonaddressbypersonidlist) | **GET** /personAddress/byPersonIdList | 
[**GetListPersonAddressByTypeAndPersonIdList**](PersonAddressApi.md#getlistpersonaddressbytypeandpersonidlist) | **GET** /personAddress/byTypeAndPersonIdList | 
[**GetPersonAddressById**](PersonAddressApi.md#getpersonaddressbyid) | **GET** /personAddress/byId | 
[**SavePersonAddress**](PersonAddressApi.md#savepersonaddress) | **PUT** /personAddress | 


<a name="deletepersonaddress"></a>
# **DeletePersonAddress**
> void DeletePersonAddress (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class DeletePersonAddressExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonAddressApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                apiInstance.DeletePersonAddress(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonAddressApi.DeletePersonAddress: " + e.Message );
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

<a name="getismailling"></a>
# **GetIsMailling**
> PersonAddressLiteModel GetIsMailling (Guid? personId)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetIsMaillingExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonAddressApi();
            var personId = new Guid?(); // Guid? | 

            try
            {
                PersonAddressLiteModel result = apiInstance.GetIsMailling(personId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonAddressApi.GetIsMailling: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **personId** | [**Guid?**](Guid?.md)|  | 

### Return type

[**PersonAddressLiteModel**](PersonAddressLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistismaillingbypersonidlist"></a>
# **GetListIsMaillingByPersonIdList**
> List<PersonAddressLiteModel> GetListIsMaillingByPersonIdList (List<Guid?> personIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListIsMaillingByPersonIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonAddressApi();
            var personIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;PersonAddressLiteModel&gt; result = apiInstance.GetListIsMaillingByPersonIdList(personIdList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonAddressApi.GetListIsMaillingByPersonIdList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **personIdList** | [**List&lt;Guid?&gt;**](Guid?.md)|  | [optional] 

### Return type

[**List<PersonAddressLiteModel>**](PersonAddressLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistpersonaddressbyperson"></a>
# **GetListPersonAddressByPerson**
> List<PersonAddressLiteModel> GetListPersonAddressByPerson (Guid? personId)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListPersonAddressByPersonExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonAddressApi();
            var personId = new Guid?(); // Guid? | 

            try
            {
                List&lt;PersonAddressLiteModel&gt; result = apiInstance.GetListPersonAddressByPerson(personId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonAddressApi.GetListPersonAddressByPerson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **personId** | [**Guid?**](Guid?.md)|  | 

### Return type

[**List<PersonAddressLiteModel>**](PersonAddressLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistpersonaddressbypersonidlist"></a>
# **GetListPersonAddressByPersonIdList**
> List<PersonAddressLiteModel> GetListPersonAddressByPersonIdList (List<Guid?> personIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListPersonAddressByPersonIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonAddressApi();
            var personIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;PersonAddressLiteModel&gt; result = apiInstance.GetListPersonAddressByPersonIdList(personIdList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonAddressApi.GetListPersonAddressByPersonIdList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **personIdList** | [**List&lt;Guid?&gt;**](Guid?.md)|  | [optional] 

### Return type

[**List<PersonAddressLiteModel>**](PersonAddressLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistpersonaddressbytypeandpersonidlist"></a>
# **GetListPersonAddressByTypeAndPersonIdList**
> List<PersonAddressLiteModel> GetListPersonAddressByTypeAndPersonIdList (Guid? addressTypeId, List<Guid?> personIdList = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetListPersonAddressByTypeAndPersonIdListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonAddressApi();
            var addressTypeId = new Guid?(); // Guid? | 
            var personIdList = new List<Guid?>(); // List<Guid?> |  (optional) 

            try
            {
                List&lt;PersonAddressLiteModel&gt; result = apiInstance.GetListPersonAddressByTypeAndPersonIdList(addressTypeId, personIdList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonAddressApi.GetListPersonAddressByTypeAndPersonIdList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addressTypeId** | [**Guid?**](Guid?.md)|  | 
 **personIdList** | [**List&lt;Guid?&gt;**](Guid?.md)|  | [optional] 

### Return type

[**List<PersonAddressLiteModel>**](PersonAddressLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpersonaddressbyid"></a>
# **GetPersonAddressById**
> PersonAddressLiteModel GetPersonAddressById (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class GetPersonAddressByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonAddressApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                PersonAddressLiteModel result = apiInstance.GetPersonAddressById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonAddressApi.GetPersonAddressById: " + e.Message );
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

[**PersonAddressLiteModel**](PersonAddressLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savepersonaddress"></a>
# **SavePersonAddress**
> PersonAddressLiteModel SavePersonAddress (PersonAddressLiteModel personAddressLite = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Model;

namespace Example
{
    public class SavePersonAddressExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonAddressApi();
            var personAddressLite = new PersonAddressLiteModel(); // PersonAddressLiteModel |  (optional) 

            try
            {
                PersonAddressLiteModel result = apiInstance.SavePersonAddress(personAddressLite);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonAddressApi.SavePersonAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **personAddressLite** | [**PersonAddressLiteModel**](PersonAddressLiteModel.md)|  | [optional] 

### Return type

[**PersonAddressLiteModel**](PersonAddressLiteModel.md)

### Authorization

[client_credentials](../README.md#client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: applications/json, applications/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


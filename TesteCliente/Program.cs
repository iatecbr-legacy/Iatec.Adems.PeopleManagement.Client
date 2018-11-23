using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client.Model;
using IdentityModel.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace TesteCliente
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var teste = new MyClass1
            {
                casa = "teste",
                opa = 1,
                update = DateTime.UtcNow,
                sub = new SubClass1
                {
                    home = "casa",
                    lastdate = DateTime.Now,
                    oxi = 3
                }
            };


            //Bruno Lambert


            //client-credentials application
            const string CLIENT_ID = "0fbfaafa-c74b-4da2-9307-6fdcdc5cf58b";
            const string CLIENT_SECRET = "OLGSXm1Gf0MV8QfHASnepdXOLnIaBFBvMurCTGD5XnO7n3zAy1nX7AwOQ0lOtqjDYwDK783B9mY3jpCv";
            const string SCOPE = "peoplemgmt-ho";

            var httpClient = new HttpClient();
            var discovery = httpClient.GetDiscoveryDocumentAsync("https://login-ho.sdasystems.org").Result;

            var clientCredentialsTokenRequest = new ClientCredentialsTokenRequest()
            {
                ClientId = CLIENT_ID,
                ClientSecret = CLIENT_SECRET,
                Scope = SCOPE,
                Address = discovery.TokenEndpoint,
            };

            var tokens = httpClient.RequestClientCredentialsTokenAsync(clientCredentialsTokenRequest).Result;
            // ---------------------------------------------------------------------------------------------------------- //
            var apiConfig = new Configuration()
            {
                AccessToken = tokens.AccessToken,
                BasePath = "http://localhost:60736/",//-dev,-ho
                //BasePath = "https://ws-peoplemgmt-ho.sdasystems.org/bra/",//-dev,-ho
            };

            //PhoneTypeTest(apiConfig);
            //LegalEntityTest(apiConfig);
            //CountryTest(apiConfig);
            //EmergencyContactTest(apiConfig);
            //AddressTest(apiConfig);
            NaturalPersonTest(apiConfig);
            //AddressTypeTest(apiConfig);
            //AllergyTypeTeste(apiConfig);
            //DisabilityTypeTeste(apiConfig);
            //ZipPostalCodeAddressTest(apiConfig);

            Console.WriteLine("-- END --");
            Console.ReadLine();
        }

        private static bool PhoneTypeTest(Iatec.Adems.PeopleManagement.Client.Configuration apiConfig)
        {
            try
            {
                var phoneTypeApi = new PhoneTypeApi(apiConfig);
                var typeList = phoneTypeApi.GetListPhoneTypeByFilterAsync().Result;
                phoneTypeApi.PhoneTypeSaveSystemReference(typeList.First().Id);
                return true;
            }
            catch (ApiException)
            {
                throw;
            }
        }

        private static bool ZipPostalCodeAddressTest(Iatec.Adems.PeopleManagement.Client.Configuration apiConfig)
        {
            try
            {
                var zipPostalCodeAddressApi = new ZipPostalCodeAddressApi(apiConfig);
                var zipList = zipPostalCodeAddressApi.GetListZipPostalCodeAddressForSyncAsync(false, new DateTime(2018, 10, 30)).Result;
                return true;
            }
            catch (ApiException)
            {
                throw;
            }
        }

        private static bool CountryTest(Iatec.Adems.PeopleManagement.Client.Configuration apiConfig)
        {
            try
            {
                var countryApi = new CountryApi(apiConfig);
                var country = countryApi.GetCurrent();
                return true;
            }
            catch (ApiException)
            {
                throw;
            }
        }

        private static bool LegalEntityTest(Iatec.Adems.PeopleManagement.Client.Configuration apiConfig)
        {
            try
            {
                var legalEntityApi = new LegalEntityApi(apiConfig);
                var legalEntity = legalEntityApi.GetByIdentifierDocumentNumber("43283811001636");
                return true;
            }
            catch (ApiException)
            {
                throw;
            }
        }

        private static bool EmergencyContactTest(Iatec.Adems.PeopleManagement.Client.Configuration apiConfig)
        {
            try
            {
                var npApi = new NaturalPersonApi(apiConfig);
                var person2 = npApi.GetPageActiveByFilterForExternal2("05-02-1994", GenderModel.Male, 10, 0);

                npApi.NaturalPersonSaveSystemReference(person2.Items.Select(x => x.Id).ToList());

                var api = new EmergencyContactApi(apiConfig);
                var saved = api.SaveEmergencyContact(new EmergencyContactLiteModel
                {
                    ContactPhone = "Phone",
                    Name = "Name",
                    Relationship = "Pai",
                    NaturalPersonId = person2.Items.First().Id,
                });

                return true;
            }
            catch (ApiException)
            {
                throw;
            }
        }


        private static bool NaturalPersonTest(Iatec.Adems.PeopleManagement.Client.Configuration apiConfig)
        {
            try
            {
                var npApi = new NaturalPersonApi(apiConfig);

                var teste = npApi.GetPageActiveByFilterForExternalAsync(10, 0,birthDate: "05-02-1994").Result;
                //var teste = npApi.GetPageActiveByFilterForExternal(0,1);

                //var teste = npApi.SaveForExternal(new NaturalPersonLiteExternalModel
                //{
                //    AuthenticationUserName = "jabes.tao2",
                //    FirstName = "Jabes2",
                //    Gender = GenderModel.Male,
                //    BirthDate = new DateTime(1994, 2, 5),
                //    IdentifierDocumentNumber = "65534613688",
                //    MiddleName = "ta",
                //    LastName = "o",
                //    FullName = "Jabes ta o",
                //    MotherName = "mae",
                //});

                //var teste2 = npApi.GetByUserName("jabes.tao");
                //var teste2 = npApi.GetByIdForExternal(new Guid("2b0632f6-9503-4157-9122-a990004e6a1e"));

                //basicPropList.Add(new NPBasicPropertyModel
                //{
                //    BirthDate = teste.BirthDate,
                //    Gender = teste.Gender,
                //    Name = teste.FirstName,
                //});

                //var personList = npApi.GetListByBasicPropertyList(basicPropList);

                //var list = npApi.GetListNaturalPersonLastSystemUpdateAsync().Result;
                //var ids = list.Select(a => a.NaturalPersonId).Distinct().ToList();

                //npApi.NaturalPersonUpdateNotice(ids);

                //npApi.NaturalPersonDeleteNaturalPerson(new System.Collections.Generic.List<Guid> { teste2.Id });

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static bool AddressTest(Iatec.Adems.PeopleManagement.Client.Configuration apiConfig)
        {
            try
            {
                var api = new PersonAddressApi(apiConfig);
                var atapi = new AddressTypeApi(apiConfig);
                var npApi = new NaturalPersonApi(apiConfig);

                var list = atapi.GetListAddressTypeByFilter();
                var person2 = npApi.GetPageActiveByFilterForExternal(10, 0, "william de qua");
                var saved = api.SavePersonAddress(new PersonAddressLiteModel
                {
                    AddressLine01 = "teste erro",
                    AddressType = new AddressTypeModel { Id = list.First().Id },
                    PersonId = person2.Items.FirstOrDefault().Id
                });

                return true;
            }
            catch (ApiException)
            {
                throw;
            }
        }

        private static bool AddressTypeTest(Iatec.Adems.PeopleManagement.Client.Configuration apiConfig)
        {
            try
            {
                var api = new AddressTypeApi(apiConfig);

                var list = api.GetListAddressTypeByFilter();

                var obj = api.GetAddressTypeById(list.First().Id);

                var idList = list.Select(a => a.Id).ToList();
                var t2 = api.GetListAddressTypeByIdList(idList);

                api.AddressTypeSaveSystemReference(obj.Id);

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private static bool AllergyTypeTeste(Iatec.Adems.PeopleManagement.Client.Configuration apiConfig)
        {
            try
            {
                var api = new AllergyTypeApi(apiConfig);

                var list = api.GetListAllergyTypeByFilter();

                var obj = api.GetAllergyTypeById(list.First().Id);


                var idList = list.Select(a => a.Id).ToList();
                var t2 = api.GetListAllergyTypeByIdList(idList);

                api.AllergyTypeSaveSystemReference(obj.Id);

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private static bool DisabilityTypeTeste(Iatec.Adems.PeopleManagement.Client.Configuration apiConfig)
        {
            try
            {
                var api = new DisabilityTypeApi(apiConfig);

                var list = api.GetListDisabilityTypeByFilter();

                var obj = api.GetDisabilityTypeById(list.First().Id);

                var idList = list.Select(a => a.Id).ToList();
                var t2 = api.GetListDisabilityByIdList(idList);

                api.DisabilityTypeSaveSystemReference(obj.Id);

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }

    class SubClass1
    {
        public int oxi { get; set; }
        public string home { get; set; }
        public DateTime lastdate { get; set; }
    }

    class SubClass2
    {
        public int oxi { get; set; }
        public string home { get; set; }
        public DateTime lastdate { get; set; }
    }

    class MyClass2
    {
        public int opa { get; set; }
        public string casa { get; set; }
        public DateTime update { get; set; }
        public SubClass2 sub { get; set; }
    }

    class MyClass1
    {
        public int opa { get; set; }
        public string casa { get; set; }
        public DateTime update { get; set; }
        public SubClass1 sub { get; set; }
    }
}

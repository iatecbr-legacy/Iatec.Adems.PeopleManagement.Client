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

            //client-credentials application
            const string CLIENT_ID = "CLIENT_ID";
            const string CLIENT_SECRET = "CLIENT_SECRET";
            const string SCOPE = "peoplemgmt";
;

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
            };

            //DocumentTypeTest(apiConfig);
            //PhoneTypeTest(apiConfig);
            //LegalEntityTest(apiConfig);
            //CountryTest(apiConfig);
            //DiseaseTest(apiConfig);
            //EmergencyContactTest(apiConfig);
            AddressTest(apiConfig);
            //NaturalPersonTest(apiConfig);
            //AddressTypeTest(apiConfig);
            //AllergyTypeTeste(apiConfig);
            //DisabilityTypeTeste(apiConfig);
            //ZipPostalCodeAddressTest(apiConfig);

            Console.WriteLine("-- END --");
            Console.ReadLine();
        }

        private static bool DocumentTypeTest(Iatec.Adems.PeopleManagement.Client.Configuration apiConfig)
        {
            try
            {
                var documentTypeApi = new DocumentTypeApi(apiConfig);
                var typeList = documentTypeApi.GetIdentifierByClassificationAsync(DocumentTypeClassificationModel.LegalEntity).Result;
                return true;
            }
            catch (ApiException)
            {
                throw;
            }
        }

        private static bool DiseaseTest(Iatec.Adems.PeopleManagement.Client.Configuration apiConfig)
        {
            try
            {
                var diseaseApi = new DiseaseApi(apiConfig);
                var typeList = diseaseApi.GetListDiseaseByIdList(new List<Guid> { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() });
                return true;
            }
            catch (ApiException)
            {
                throw;
            }
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
                var zipList = zipPostalCodeAddressApi.GetListZipPostalCodeAddressForUpdateAsync(true, new DateTime(2018, 12, 4)).Result;
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
                var country = countryApi.GetPageAvailable(20, 0, "teste", new List<Guid> { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() });
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
                legalEntityApi.DeleteLegalEntity(new List<Guid> { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() });
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

                var person = new NaturalPersonLiteExternalModel
                {
                    BirthDate = DateTime.UtcNow,
                    FullName = "wilian de q moura",
                    FirstName = "wilian",
                    LastName = "moura",
                    Gender = GenderModel.Male,
                    IdentifierDocumentNumber = "91298431034",
                    MotherName = "rosangela q moura",
                };

                var teste = npApi.SaveForExternal(person);
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
                
               
                var list = api.GetListPersonAddressByPerson(Guid.Parse("82a91dc7-5db2-4168-a7f9-a2f300e9d24d"));
                //var person2 = npApi.GetPageActiveByFilterForExternal(10, 0, "william de qua");
                //var saved = api.SavePersonAddress(new PersonAddressLiteModel
                //{
                //    AddressLine01 = "teste erro",
                //    AddressType = new AddressTypeModel { Id = list.First().Id },
                //    PersonId = person2.Items.FirstOrDefault().Id
                //});

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

                var list = api.GetListAddressTypeByIdList(new List<Guid> { Guid.NewGuid(), Guid.NewGuid() });

                //var obj = api.GetAddressTypeById(list.First().Id);

                //var idList = list.Select(a => a.Id).ToList();
                //var t2 = api.GetListAddressTypeByIdList(idList);

                //api.AddressTypeSaveSystemReference(obj.Id);

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

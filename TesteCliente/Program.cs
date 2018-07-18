using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client.Model;
using IdentityModel.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TesteCliente
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            const string CLIENT_ID = "000000000000000000000000000000000000000"; //DEV
            const string CLIENT_SECRET = "XASUDIYASIODUYAOSUIDYAOSUDYAIASJFNASJFALSDHAISU";

            var discoveryClient = new DiscoveryClient("https://login-dev.sdasystems.org");
            var discovery = discoveryClient.GetAsync().Result;

            var tokenClient = new TokenClient(discovery.TokenEndpoint, CLIENT_ID, CLIENT_SECRET);
            var tokens = tokenClient.RequestClientCredentialsAsync("scope").Result;
            // ---------------------------------------------------------------------------------------------------------- //
            var apiConfig = new Iatec.Adems.PeopleManagement.Client.Configuration()
            {
                AccessToken = tokens.AccessToken,
                BasePath = "Uri_PeopleApi",//ws-peoplemgmt???.sdasystems.org/bra/
            };
          

            EmergencyContactTest(apiConfig);
            //AddressTest(apiConfig);
            //NaturalPersonTest(apiConfig);
            //AddressTypeTest(apiConfig);
            //AllergyTypeTeste(apiConfig);
            //DisabilityTypeTeste(apiConfig);


            Console.WriteLine("-- END --");
            Console.ReadLine();
        }

        private static bool EmergencyContactTest(Iatec.Adems.PeopleManagement.Client.Configuration apiConfig)
        {
            try
            {
                var api = new EmergencyContactApi(apiConfig);
                var npApi = new NaturalPersonApi(apiConfig);

                var person2 = npApi.GetPageActiveByFilterForExternal(10, 0, "william de qua");
                var saved = api.SaveEmergencyContact(new EmergencyContactLiteModel
                {
                    ContactPhone = "Phone",
                    Name = "Name",
                    Relationship = "Pai",
                    NaturalPersonId = person2.Items.First().Id,
                });

                return true;
            }
            catch (ApiException ex)
            {
                throw ex;
            }
        }


        private static bool NaturalPersonTest(Iatec.Adems.PeopleManagement.Client.Configuration apiConfig)
        {
            try
            {
                var npApi = new NaturalPersonApi(apiConfig);

                var teste = npApi.SaveForExternal(new NaturalPersonLiteExternalModel
                {
                    AuthenticationUserName = "jabes.tao",
                    FirstName = "Jabes",
                    Gender = GenderModel.Male,
                    BirthDate = new DateTime(1994, 2, 5),
                    IdentifierDocumentNumber = "87708647053",
                    MiddleName = "ta",
                    LastName = "o",
                    FullName = "Jabes ta o",
                    MotherName = "mae",
                });

                //var teste2 = npApi.GetByUserName("jabes.tao");

                //basicPropList.Add(new NPBasicPropertyModel
                //{
                //    BirthDate = teste.BirthDate,
                //    Gender = teste.Gender,
                //    Name = teste.FirstName,
                //});

                //var personList = npApi.GetListByBasicPropertyList(basicPropList);

                //npApi.NaturalPersonDeleteNaturalPerson(new System.Collections.Generic.List<Guid> { teste.Id });

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
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
                });

                return true;
            }
            catch (ApiException ex)
            {
                throw ex;
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
                throw ex;
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
                throw ex;
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
                throw ex;
            }
        }
    }
}

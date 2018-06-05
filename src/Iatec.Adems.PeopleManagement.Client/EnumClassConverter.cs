/*
 * People Management API - BRA
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 0.2.1
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;

namespace Iatec.Adems.PeopleManagement.Client
{
    internal class EnumClassConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(IConvertible).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var value = reader.Value as string;
            var parseMethod = objectType.GetMethod("Parse", new[] { typeof(string) });
            var result = parseMethod.Invoke(null, new[] { value });
            return result;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var iconvertible = value as IConvertible;
            writer.WriteValue(iconvertible.ToString());
        }
    }
}
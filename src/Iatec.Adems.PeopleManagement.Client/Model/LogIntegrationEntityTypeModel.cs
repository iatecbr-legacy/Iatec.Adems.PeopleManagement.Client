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
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Iatec.Adems.PeopleManagement.Client.Model
{
    /// <summary>
    /// Defines LogIntegrationEntityType
    /// </summary>

    [JsonConverter(typeof(EnumClassConverter))]
    public class LogIntegrationEntityTypeModel : IEquatable<LogIntegrationEntityTypeModel>, IConvertible
    {
        public LogIntegrationEntityTypeModel()
        {
        }

        private LogIntegrationEntityTypeModel(string name, int value_plus1)
        {
            this.Name = name;
            this.valuePlus1 = value_plus1;
        }

        public string Name { get; }
        private int valuePlus1;
        public int Value => valuePlus1 - 1;

        /// <summary>
        /// Enum MainPerson for value: MainPerson
        /// </summary>
        public static LogIntegrationEntityTypeModel MainPerson = new LogIntegrationEntityTypeModel("MainPerson", 1);

        /// <summary>
        /// Enum MainPersonAddress for value: MainPersonAddress
        /// </summary>
        public static LogIntegrationEntityTypeModel MainPersonAddress = new LogIntegrationEntityTypeModel("MainPersonAddress", 2);

        /// <summary>
        /// Enum MainPersonDocument for value: MainPersonDocument
        /// </summary>
        public static LogIntegrationEntityTypeModel MainPersonDocument = new LogIntegrationEntityTypeModel("MainPersonDocument", 3);

        /// <summary>
        /// Enum MainPersonEContact for value: MainPersonEContact
        /// </summary>
        public static LogIntegrationEntityTypeModel MainPersonEContact = new LogIntegrationEntityTypeModel("MainPersonEContact", 4);

        /// <summary>
        /// Enum MainPersonPhone for value: MainPersonPhone
        /// </summary>
        public static LogIntegrationEntityTypeModel MainPersonPhone = new LogIntegrationEntityTypeModel("MainPersonPhone", 5);

        /// <summary>
        /// Enum Parent01 for value: Parent01
        /// </summary>
        public static LogIntegrationEntityTypeModel Parent01 = new LogIntegrationEntityTypeModel("Parent01", 6);

        /// <summary>
        /// Enum Parent01Address for value: Parent01Address
        /// </summary>
        public static LogIntegrationEntityTypeModel Parent01Address = new LogIntegrationEntityTypeModel("Parent01Address", 7);

        /// <summary>
        /// Enum Parent01Document for value: Parent01Document
        /// </summary>
        public static LogIntegrationEntityTypeModel Parent01Document = new LogIntegrationEntityTypeModel("Parent01Document", 8);

        /// <summary>
        /// Enum Parent01EContact for value: Parent01EContact
        /// </summary>
        public static LogIntegrationEntityTypeModel Parent01EContact = new LogIntegrationEntityTypeModel("Parent01EContact", 9);

        /// <summary>
        /// Enum Parent01Phone for value: Parent01Phone
        /// </summary>
        public static LogIntegrationEntityTypeModel Parent01Phone = new LogIntegrationEntityTypeModel("Parent01Phone", 10);

        /// <summary>
        /// Enum Parent02 for value: Parent02
        /// </summary>
        public static LogIntegrationEntityTypeModel Parent02 = new LogIntegrationEntityTypeModel("Parent02", 11);

        /// <summary>
        /// Enum Parent02Address for value: Parent02Address
        /// </summary>
        public static LogIntegrationEntityTypeModel Parent02Address = new LogIntegrationEntityTypeModel("Parent02Address", 12);

        /// <summary>
        /// Enum Parent02Document for value: Parent02Document
        /// </summary>
        public static LogIntegrationEntityTypeModel Parent02Document = new LogIntegrationEntityTypeModel("Parent02Document", 13);

        /// <summary>
        /// Enum Parent02EContact for value: Parent02EContact
        /// </summary>
        public static LogIntegrationEntityTypeModel Parent02EContact = new LogIntegrationEntityTypeModel("Parent02EContact", 14);

        /// <summary>
        /// Enum Parent02Phone for value: Parent02Phone
        /// </summary>
        public static LogIntegrationEntityTypeModel Parent02Phone = new LogIntegrationEntityTypeModel("Parent02Phone", 15);

        /// <summary>
        /// Enum Spouse for value: Spouse
        /// </summary>
        public static LogIntegrationEntityTypeModel Spouse = new LogIntegrationEntityTypeModel("Spouse", 16);

        /// <summary>
        /// Enum SpouseAddress for value: SpouseAddress
        /// </summary>
        public static LogIntegrationEntityTypeModel SpouseAddress = new LogIntegrationEntityTypeModel("SpouseAddress", 17);

        /// <summary>
        /// Enum SpouseDocument for value: SpouseDocument
        /// </summary>
        public static LogIntegrationEntityTypeModel SpouseDocument = new LogIntegrationEntityTypeModel("SpouseDocument", 18);

        /// <summary>
        /// Enum SpouseEContact for value: SpouseEContact
        /// </summary>
        public static LogIntegrationEntityTypeModel SpouseEContact = new LogIntegrationEntityTypeModel("SpouseEContact", 19);

        /// <summary>
        /// Enum SpousePhone for value: SpousePhone
        /// </summary>
        public static LogIntegrationEntityTypeModel SpousePhone = new LogIntegrationEntityTypeModel("SpousePhone", 20);

        /// <summary>
        /// Enum RelationshipParent01 for value: RelationshipParent01
        /// </summary>
        public static LogIntegrationEntityTypeModel RelationshipParent01 = new LogIntegrationEntityTypeModel("RelationshipParent01", 21);

        /// <summary>
        /// Enum RelationshipParent02 for value: RelationshipParent02
        /// </summary>
        public static LogIntegrationEntityTypeModel RelationshipParent02 = new LogIntegrationEntityTypeModel("RelationshipParent02", 22);

        /// <summary>
        /// Enum RelationshipSpouse for value: RelationshipSpouse
        /// </summary>
        public static LogIntegrationEntityTypeModel RelationshipSpouse = new LogIntegrationEntityTypeModel("RelationshipSpouse", 23);

        private static IEnumerable<LogIntegrationEntityTypeModel> fields = new[] {
            MainPerson,
            MainPersonAddress,
            MainPersonDocument,
            MainPersonEContact,
            MainPersonPhone,
            Parent01,
            Parent01Address,
            Parent01Document,
            Parent01EContact,
            Parent01Phone,
            Parent02,
            Parent02Address,
            Parent02Document,
            Parent02EContact,
            Parent02Phone,
            Spouse,
            SpouseAddress,
            SpouseDocument,
            SpouseEContact,
            SpousePhone,
            RelationshipParent01,
            RelationshipParent02,
            RelationshipSpouse,
        };

        public override string ToString()
        {
            return this.Name;
        }

        public override bool Equals(object obj)
        {
            if (obj is LogIntegrationEntityTypeModel e)
            {
                return Equals(e);
            }
            else return false;
        }

        public bool Equals(LogIntegrationEntityTypeModel other)
        {
            if (other == null)
                return this.Name == null;
            return this.Value == other.Value;
        }

        public override int GetHashCode()
        {
            var hashCode = -244751520;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Value.GetHashCode();
            return hashCode;
        }

        public TypeCode GetTypeCode() => TypeCode.Int32;

        public bool ToBoolean(IFormatProvider provider) => true;

        public char ToChar(IFormatProvider provider) => (char)ToInt32(provider);

        public sbyte ToSByte(IFormatProvider provider) => (sbyte)ToInt32(provider);

        public byte ToByte(IFormatProvider provider) => (byte)ToInt32(provider);

        public short ToInt16(IFormatProvider provider) => (short)ToInt32(provider);

        public ushort ToUInt16(IFormatProvider provider) => (ushort)ToInt32(provider);

        public int ToInt32(IFormatProvider provider) => Value;

        public uint ToUInt32(IFormatProvider provider) => (uint)ToInt32(provider);

        public long ToInt64(IFormatProvider provider) => ToInt32(provider);

        public ulong ToUInt64(IFormatProvider provider) => (ulong)ToInt32(provider);

        public float ToSingle(IFormatProvider provider) => ToInt32(provider);

        public double ToDouble(IFormatProvider provider) => ToInt32(provider);

        public decimal ToDecimal(IFormatProvider provider) => ToInt32(provider);

        public DateTime ToDateTime(IFormatProvider provider) => throw new InvalidCastException();

        public string ToString(IFormatProvider provider) => Name;

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            if (conversionType == typeof(LogIntegrationEntityTypeModel))
                return this;

            if (conversionType == typeof(bool)) return ToBoolean(provider);
            if (conversionType == typeof(char)) return ToChar(provider);
            if (conversionType == typeof(sbyte)) return ToSByte(provider);
            if (conversionType == typeof(byte)) return ToByte(provider);
            if (conversionType == typeof(short)) return ToInt16(provider);
            if (conversionType == typeof(ushort)) return ToUInt16(provider);
            if (conversionType == typeof(int)) return ToInt32(provider);
            if (conversionType == typeof(uint)) return ToUInt32(provider);
            if (conversionType == typeof(long)) return ToInt64(provider);
            if (conversionType == typeof(ulong)) return ToUInt64(provider);
            if (conversionType == typeof(float)) return ToSingle(provider);
            if (conversionType == typeof(double)) return ToDouble(provider);
            if (conversionType == typeof(decimal)) return ToDecimal(provider);
            if (conversionType == typeof(DateTime)) return ToDateTime(provider);
            if (conversionType == typeof(string)) return ToString(provider);

            throw new InvalidCastException();
        }

        public static bool operator ==(LogIntegrationEntityTypeModel a, LogIntegrationEntityTypeModel b)
        {
            if (object.ReferenceEquals(a, b))
                return true;
            return object.ReferenceEquals(b, null)
                ? a.Equals(b)
                : b.Equals(a);
        }

        public static bool operator !=(LogIntegrationEntityTypeModel a, LogIntegrationEntityTypeModel b)
        {
            return !(a == b);
        }

        public static explicit operator char(LogIntegrationEntityTypeModel value) => value.ToChar(CultureInfo.InvariantCulture);

        public static explicit operator sbyte(LogIntegrationEntityTypeModel value) => value.ToSByte(CultureInfo.InvariantCulture);

        public static explicit operator byte(LogIntegrationEntityTypeModel value) => value.ToByte(CultureInfo.InvariantCulture);

        public static explicit operator short(LogIntegrationEntityTypeModel value) => value.ToInt16(CultureInfo.InvariantCulture);

        public static explicit operator ushort(LogIntegrationEntityTypeModel value) => value.ToUInt16(CultureInfo.InvariantCulture);

        public static explicit operator int(LogIntegrationEntityTypeModel value) => value.ToInt32(CultureInfo.InvariantCulture);

        public static explicit operator uint(LogIntegrationEntityTypeModel value) => value.ToUInt32(CultureInfo.InvariantCulture);

        public static explicit operator long(LogIntegrationEntityTypeModel value) => value.ToInt64(CultureInfo.InvariantCulture);

        public static explicit operator ulong(LogIntegrationEntityTypeModel value) => value.ToUInt64(CultureInfo.InvariantCulture);

        public static explicit operator float(LogIntegrationEntityTypeModel value) => value.ToSingle(CultureInfo.InvariantCulture);

        public static explicit operator double(LogIntegrationEntityTypeModel value) => value.ToDouble(CultureInfo.InvariantCulture);

        public static explicit operator decimal(LogIntegrationEntityTypeModel value) => value.ToDecimal(CultureInfo.InvariantCulture);

        public static explicit operator string(LogIntegrationEntityTypeModel value) => value.ToString(CultureInfo.InvariantCulture);

        public static bool TryParse(string name, out LogIntegrationEntityTypeModel parsed)
        {
            parsed = fields.FirstOrDefault(x => x.Name == name);
            return parsed != null;
        }

        public static bool TryParse(int value, out LogIntegrationEntityTypeModel parsed)
        {
            parsed = fields.FirstOrDefault(x => x.Value == value);
            return parsed != null;
        }

        public static LogIntegrationEntityTypeModel Parse(string name)
        {
            if (!TryParse(name, out LogIntegrationEntityTypeModel parsed))
                throw new InvalidCastException();
            return parsed;
        }

        public static LogIntegrationEntityTypeModel Parse(int value)
        {
            if (!TryParse(value, out LogIntegrationEntityTypeModel parsed))
                throw new InvalidCastException();
            return parsed;
        }

        public static explicit operator LogIntegrationEntityTypeModel(int value) => Parse(value);

        public static explicit operator LogIntegrationEntityTypeModel(string name) => Parse(name);
    }
}
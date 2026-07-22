namespace System;

[IsReadOnly]
public struct byte : IComparable, IConvertible, IFormattable, IComparable<Byte>, IEquatable<Byte>, ISpanFormattable
{
	private readonly byte m_value; //Field offset: 0x0

	[CalledBy(Type = "System.Xml.Schema.Datatype_unsignedByte", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public override int CompareTo(object value) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.MiscellaneousUtils", Member = "ByteArrayCompare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", "System.Byte[]"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.Common.ByteStorage", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.Common.ByteStorage", Member = "CompareValueTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	public override int CompareTo(byte value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 16)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[NonVersionable]
	public override bool Equals(byte obj) { }

	[CallerCount(Count = 89)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override TypeCode GetTypeCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(byte), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(byte))]
	public static byte Parse(string s, IFormatProvider provider) { }

	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(byte))]
	[CalledBy(Type = "System.ComponentModel.ByteConverter", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(byte), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(byte))]
	public static byte Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[CalledBy(Type = typeof(byte), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(byte), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(byte))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Number), Member = "ParseInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	private static byte Parse(ReadOnlySpan<Char> s, NumberStyles style, NumberFormatInfo info) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[CallerCount(Count = 89)]
	[DeduplicatedMethod]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(Decimal))]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ThrowSByteOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "DefaultToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConvertible), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.PrimitiveValue", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.SocketAddress", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlByte", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "Mono.Security.ASN1Convert", Member = "ToOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.ASN1"}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Number), Member = "FormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override string ToString(IFormatProvider provider) { }

	[CalledBy(Type = "SQLite.SQLiteConnection+<>c", Member = "<SetKey>b__55_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Manager.ImageHandler", Member = "GetHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(string))]
	[CalledBy(Type = "Manager.ImageHandler", Member = "MakeHashString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ASN1), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(AssemblyName), Member = "get_FullName", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Security.Cryptography.AsnEncodedData", Member = "Default", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "GetAuthorityKeyIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.X509.X509Extension"}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Extension", Member = "FormatUnkownData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509KeyUsageExtension", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierExtension", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.DigestSession", Member = "HashToHexString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Mono.Security.ASN1", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Number), Member = "FormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public string ToString(string format) { }

	[CalledBy(Type = "HostSettings", Member = "SetHostRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Data.GameSettings", typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.ChatWindow", Member = "ParseChatCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.String[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit+<>c__DisplayClass338_0", Member = "<GetTestInfo>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldSlot", Member = "UpdateSlotInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueTuple`3), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ValueTuple`3), Member = "System.IValueTupleInternal.ToStringEnd", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputActionState+BindingState", Member = "set_controlCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputActionState+BindingState", Member = "set_interactionCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputActionState+BindingState", Member = "set_processorCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputActionState+BindingState", Member = "set_mapIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Collections.Generic.SortedDictionary`2", Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CalledBy(Type = "Unity.Properties.TypeConversion+PrimitiveConverters+<>c", Member = "<RegisterStringConverters>b__13_13", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Drawing.Color", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(Number), Member = "FormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(DecoderExceptionFallbackBuffer), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StringBuilder), Member = "AppendSpanFormattable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.ComponentModel.ByteConverter", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.HttpListenerRequestUriBuilder", Member = "AppendOctetsPercentEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), "System.Collections.Generic.IEnumerable`1<Byte>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpListenerRequestUriBuilder", Member = "GetOctetsAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<Byte>"}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.Color32", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Mono.Security.X509.X509Extension", Member = "WriteLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.X509.Extensions.AuthorityKeyIdentifierExtension", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "Mono.Security.Cryptography.CryptoConvert", Member = "ToHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(string))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Number), Member = "FormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public override string ToString(string format, IFormatProvider provider) { }

	[CalledBy(Type = "System.IPv4AddressHelper", Member = "ParseCanonicalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Number), Member = "TryFormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Number), Member = "TryParseInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	private static bool TryParse(ReadOnlySpan<Char> s, NumberStyles style, NumberFormatInfo info, out byte result) { }

	[CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Net.HttpListenerRequestUriBuilder", Member = "AddPercentEncodedOctetToRawOctetsList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "TryParseInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out byte result) { }

	[CalledBy(Type = "HostSettings", Member = "GetGameSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Data.GameSettings&", typeof(UInt32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "HostSettings", Member = "ParseFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Enumerator.DuelRules&", typeof(Int32&), typeof(Int16&), typeof(Byte&), typeof(Byte&), typeof(Byte&), typeof(Byte&), typeof(UInt32&), "Enumerator.DuelMode&", typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.ChatWindow", Member = "ParseChatCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.String[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit+<>c__DisplayClass338_0", Member = "<GetTestInfo>b__4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "ClientAPI.WebServer+<OnBotFieldCardInfo>d__50", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "ClientAPI.WebServer+<OnFieldCardInfo>d__51", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "ClientAPI.WebServer", Member = "GetBotFromArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.HttpListenerResponse", "DuelBot.Game.GameBehavior&", "System.String[]"}, ReturnType = typeof(string))]
	[CalledBy(Type = "ClientAPI.WebServer", Member = "GetCustomBotFromArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.HttpListenerResponse", "DuelBot.Game.GameBehavior&", "System.String[]"}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UIElements.ConverterGroups+<>c", Member = "<RegisterUInt8Converters>b__21_12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&)}, ReturnType = typeof(byte))]
	[CalledBy(Type = "Unity.Properties.TypeConversion+PrimitiveConverters+<>c", Member = "<RegisterStringConverters>b__13_12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&)}, ReturnType = typeof(byte))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "TryParseInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	public static bool TryParse(string s, out byte result) { }

}


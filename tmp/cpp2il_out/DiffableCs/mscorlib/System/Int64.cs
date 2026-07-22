namespace System;

[IsReadOnly]
public struct long : IComparable, IConvertible, IFormattable, IComparable<Int64>, IEquatable<Int64>, ISpanFormattable
{
	private readonly long m_value; //Field offset: 0x0

	[CalledBy(Type = "System.Xml.Schema.Datatype_long", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public override int CompareTo(object value) { }

	[CalledBy(Type = "Unity.IntegerTime.DiscreteTime", Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.IntegerTime.DiscreteTime"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.Index", Member = "CompareDuplicateRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.Common.Int64Storage", Member = "CompareValueTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Unity.Burst.Intrinsics.X86+Avx2", Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", "System.Void*", "System.Int64*", typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Burst.Intrinsics.X86+Avx2", Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", "System.Void*", "System.Int32*", typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Numerics.BigInteger", Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	public override int CompareTo(long value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 9)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[NonVersionable]
	public override bool Equals(long obj) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override TypeCode GetTypeCode() { }

	[CalledBy(Type = "HostSettings+<>c__DisplayClass44_0", Member = "<OnCreateRoomButton>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.BanlistManager", Member = "ReadBanlistFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpListenerRequest", Member = "AddHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "BigIntegerLibrary.BigInteger", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "NGettext.Plural.Ast.AstTokenParser", Member = "GetNextToken", ReturnType = "NGettext.Plural.Ast.Token")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "ParseInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(long))]
	public static long Parse(string s) { }

	[CalledBy(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(PrimitiveArray), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "ParseInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(long))]
	public static long Parse(string s, IFormatProvider provider) { }

	[CalledBy(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[CalledBy(Type = "System.ComponentModel.Int64Converter", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "ParseInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(long))]
	public static long Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(byte))]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(char))]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(Decimal))]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(double))]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(short))]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(sbyte))]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(float))]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "DefaultToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConvertible), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(ushort))]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(uint))]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(ulong))]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[CalledBy(Type = typeof(IntPtr), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(IntPtr), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = "UnityEngine.UIElements.LongField", Member = "ValueToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.ComponentModel.Int64Converter", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Number), Member = "FormatInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public override string ToString(string format, IFormatProvider provider) { }

	[CalledBy(Type = "UnityEngine.UIElements.LongField+LongInput", Member = "ValueToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Number), Member = "FormatInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public string ToString(string format) { }

	[CalledBy(Type = "Scenes.Lobby.GameRoom", Member = "OnPlayerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Data.Player"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.LifePoints", Member = "OnClickLPBar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.RoomCard", Member = "PostSetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Diagnostics.TraceListener", Member = "WriteFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.TraceEventCache"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "GetHeaders", ReturnType = typeof(string))]
	[CalledBy(Type = "ZXing.OneD.RSS.RSS14Reader", Member = "constructResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ZXing.OneD.RSS.Pair", "ZXing.OneD.RSS.Pair"}, ReturnType = "ZXing.Result")]
	[CalledBy(Type = "Spine.SkeletonBinary", Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = "Spine.SkeletonData")]
	[CalledBy(Type = "Unity.Properties.TypeConversion+PrimitiveConverters+<>c", Member = "<RegisterStringConverters>b__13_11", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Number), Member = "FormatInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(ClaimsPrincipal), Member = "SerializeIdentities", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.JsonParser+JsonValue", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.PrimitiveValue", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "BuildCommandsList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebRequest"}, ReturnType = "PipelineEntry[]")]
	[CalledBy(Type = "System.Net.FileWebResponse", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.FileWebRequest", "System.Uri", typeof(FileAccess), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpListenerResponse", Member = "SendHeaders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(MemoryStream)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDateTimeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int), typeof(DateTime), "System.Nullable`1<TimeSpan>", typeof(DateTimeKind), "Newtonsoft.Json.DateFormatHandling"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.XmlTreeGen", Member = "AddColumnProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataColumn", "System.Xml.XmlElement"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.NewDiffgramGen", Member = "GenerateTableErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataTable"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.NewDiffgramGen", Member = "GenerateRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataRow"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XmlDataTreeWriter", Member = "XmlDataRowWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataRow", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlInt64", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Number), Member = "FormatInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override string ToString(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Number), Member = "TryFormatInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	[CalledBy(Type = typeof(ClaimsPrincipal), Member = "DeserializeIdentities", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.PrimitiveValue", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.InputSystem.Utilities.PrimitiveValue")]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int64&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "PipelineCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.CommandStream+PipelineEntry", "System.Net.ResponseDescription", typeof(bool), typeof(Stream&)}, ReturnType = "System.Net.CommandStream+PipelineInstruction")]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "TryUpdateContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.ExpressionEvaluator", Member = "TryParse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.JPath", Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Data.ConstNode", Member = "SmallestNumeric", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "TryParseInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Int64&)}, ReturnType = typeof(bool))]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result) { }

	[CalledBy(Type = "Scenes.Lobby.GameRoom+<>c__DisplayClass57_0", Member = "<Awake>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.TypeConversion+PrimitiveConverters+<>c", Member = "<RegisterStringConverters>b__13_10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&)}, ReturnType = typeof(long))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.UnixDateTimeConverter", Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(Type), typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Net.WebResponseStream", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.BufferOffsetSize"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpWebResponse", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Uri", typeof(string), "System.Net.WebResponseStream", "System.Net.CookieContainer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.StringHelpers", Member = "FromNicifiedMemorySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int64&), typeof(long)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.JsonParser+JsonValue", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "UnityEngine.InputSystem.Utilities.JsonParser+JsonValue"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.UxmlLongAttributeDescription+<>c", Member = "<GetValueFromBag>b__3_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(long)}, ReturnType = typeof(long))]
	[CalledBy(Type = "UnityEngine.UIElements.UxmlLongAttributeDescription", Member = "ConvertValueToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(long)}, ReturnType = typeof(long))]
	[CalledBy(Type = "UnityEngine.UIElements.ConverterGroups+<>c", Member = "<RegisterInt64Converters>b__20_11", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&)}, ReturnType = typeof(long))]
	[CalledBy(Type = "Manager.DiscordController", Member = "ParseDiscordImplicitGrantURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&), typeof(Int64&), "System.Collections.Generic.Dictionary`2<String, String>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "TryParseMicrosoftDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int64&), typeof(TimeSpan&), typeof(DateTimeKind&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Scenes.Battle.ManualStatus", Member = "<Start>b__26_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.ManualStatus", Member = "OnConfirm", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.GameRoom", Member = "OnClickPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Button", "UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.LongField", Member = "CanTryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Number), Member = "TryParseInt64IntegerStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Int64&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	public static bool TryParse(string s, out long result) { }

}


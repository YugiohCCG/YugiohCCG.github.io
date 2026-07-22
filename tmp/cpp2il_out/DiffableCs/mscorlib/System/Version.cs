namespace System;

public sealed class Version : ICloneable, IComparable, IComparable<Version>, IEquatable<Version>, ISpanFormattable
{
	private readonly int _Major; //Field offset: 0x10
	private readonly int _Minor; //Field offset: 0x14
	private readonly int _Build; //Field offset: 0x18
	private readonly int _Revision; //Field offset: 0x1C

	public int Build
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	private int DefaultFormatFieldCount
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 25
	}

	public int Major
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int Minor
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int Revision
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(Environment), Member = "get_OSVersion", ReturnType = typeof(OperatingSystem))]
	[CalledBy(Type = typeof(Environment), Member = "CreateVersionFromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Version))]
	[CalledBy(Type = typeof(AssemblyName), Member = "FillName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoAssemblyName*), typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	public Version(int major, int minor, int build, int revision) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public Version(int major, int minor, int build) { }

	[CalledBy(Type = "System.Net.HttpVersion", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetworkInformation.SystemNetworkInterface", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetworkInformation.NetworkInterfaceFactory", Member = "Create", ReturnType = "System.Net.NetworkInformation.NetworkInterfaceFactory")]
	[CalledBy(Type = "System.Net.NetworkInformation.NetworkInterfaceFactoryPal", Member = "Create", ReturnType = "System.Net.NetworkInformation.NetworkInterfaceFactory")]
	[CalledBy(Type = "System.Net.NetworkInformation.Win32NetworkInterfaceFactoryPal", Member = "Create", ReturnType = "System.Net.NetworkInformation.NetworkInterfaceFactory")]
	[CalledBy(Type = "System.Data.DataSet", Member = "SerializeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), "System.Data.SerializationFormat"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataTable", Member = "SerializeDataTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool), "System.Data.SerializationFormat"}, ReturnType = typeof(void))]
	[CalledBy(Type = "NGettext.Loaders.MoFileParser", Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = "NGettext.Loaders.MoFile")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public Version(int major, int minor) { }

	[CalledBy(Type = "UnityEngine.InputSystem.InputSystem", Member = "get_version", ReturnType = typeof(Version))]
	[CalledBy(Type = "System.Net.HttpListenerRequest", Member = "SetRequestLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.VersionConverter", Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(Type), typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Version), Member = "ParseVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(Version))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public Version(string version) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Version() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private Version(Version version) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override object Clone() { }

	[CallerCount(Count = 0)]
	public override int CompareTo(Version value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override int CompareTo(object version) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(Version obj) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_Build() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private int get_DefaultFormatFieldCount() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public int get_Major() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int get_Minor() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_Revision() { }

	[CallerCount(Count = 0)]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(AssemblyName), Member = "set_Version", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AssemblyName), Member = "OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpListenerRequest", Member = "get_KeepAlive", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "GetHeaders", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.ServicePoint", Member = "get_SendContinue", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.WebConnectionTunnel+<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.BufferOffsetSize"}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(Version v1, Version v2) { }

	[CalledBy(Type = "System.Net.HttpListenerRequest", Member = "FinishInitialization", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static bool op_GreaterThan(Version v1, Version v2) { }

	[CalledBy(Type = "System.Net.HttpListenerRequest", Member = "FinishInitialization", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.HttpListenerResponse", Member = "SendHeaders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(MemoryStream)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetworkInformation.SystemNetworkInterface", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetworkInformation.NetworkInterfaceFactory", Member = "Create", ReturnType = "System.Net.NetworkInformation.NetworkInterfaceFactory")]
	[CalledBy(Type = "System.Net.NetworkInformation.NetworkInterfaceFactoryPal", Member = "Create", ReturnType = "System.Net.NetworkInformation.NetworkInterfaceFactory")]
	[CalledBy(Type = "System.Net.NetworkInformation.Win32NetworkInterfaceFactoryPal", Member = "Create", ReturnType = "System.Net.NetworkInformation.NetworkInterfaceFactory")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static bool op_GreaterThanOrEqual(Version v1, Version v2) { }

	[CalledBy(Type = typeof(AssemblyName), Member = "get_FullName", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "GetRequestHeaders", ReturnType = "System.Byte[]")]
	[CalledBy(Type = "System.Net.WebConnection+<InitConnection>d__19", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebRequestStream", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebConnection", "System.Net.WebOperation", typeof(Stream), "System.Net.WebConnectionTunnel"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(Version v1, Version v2) { }

	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "GetRequestHeaders", ReturnType = "System.Byte[]")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static bool op_LessThan(Version v1, Version v2) { }

	[CalledBy(Type = "System.Net.HttpListenerResponse", Member = "SendHeaders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(MemoryStream)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static bool op_LessThanOrEqual(Version v1, Version v2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Version), Member = "ParseVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(Version))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static Version Parse(string input) { }

	[CalledBy(Type = typeof(Version), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Version), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Version))]
	[CalledBy(Type = typeof(Version), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Version&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Version), Member = "TryParseComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(string), typeof(bool), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 68)]
	private static Version ParseVersion(ReadOnlySpan<Char> input, bool throwOnFailure) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Version), Member = "ToCachedStringBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Span`1<System.Char>), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private override bool System.ISpanFormattable.TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format, IFormatProvider provider) { }

	[CalledBy(Type = typeof(Version), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Version), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Version), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Version), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Version), Member = "System.ISpanFormattable.TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 22)]
	private StringBuilder ToCachedStringBuilder(int fieldCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Version), Member = "ToCachedStringBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	public string ToString(int fieldCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Version), Member = "ToCachedStringBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[ContainsUnimplementedInstructions]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Version), Member = "ToCachedStringBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Span`1<System.Char>), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool TryFormat(Span<Char> destination, out int charsWritten) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Version), Member = "ToCachedStringBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Span`1<System.Char>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public bool TryFormat(Span<Char> destination, int fieldCount, out int charsWritten) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CultureInfo), typeof(Type), typeof(Object&)}, ReturnType = "Newtonsoft.Json.Utilities.ConvertUtils+ConvertResult")]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "VersionTryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Version&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Version), Member = "ParseVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(Version))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool TryParse(string input, out Version result) { }

	[CalledBy(Type = typeof(Version), Member = "ParseVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(Version))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(IFormatProvider), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static bool TryParseComponent(ReadOnlySpan<Char> component, string componentName, bool throwOnFailure, out int parsedComponent) { }

}


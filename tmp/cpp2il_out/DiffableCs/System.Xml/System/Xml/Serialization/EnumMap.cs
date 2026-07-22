namespace System.Xml.Serialization;

internal class EnumMap : ObjectMap
{
	internal class EnumMapMember
	{
		private readonly string _xmlName; //Field offset: 0x10
		private readonly string _enumName; //Field offset: 0x18
		private readonly long _value; //Field offset: 0x20

		public string EnumName
		{
			[CallerCount(Count = 31)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public long Value
		{
			[CallerCount(Count = 12)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public string XmlName
		{
			[CallerCount(Count = 106)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportEnumMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public EnumMapMember(string xmlName, string enumName, long value) { }

		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		public string get_EnumName() { }

		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		public long get_Value() { }

		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		public string get_XmlName() { }

	}

	private readonly EnumMapMember[] _members; //Field offset: 0x10
	private readonly bool _isFlags; //Field offset: 0x18
	private readonly String[] _enumNames; //Field offset: 0x20
	private readonly String[] _xmlNames; //Field offset: 0x28
	private readonly Int64[] _values; //Field offset: 0x30

	public String[] EnumNames
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool IsFlags
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Int64[] Values
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public String[] XmlNames
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportEnumMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public EnumMap(EnumMapMember[] members, bool isFlags) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public String[] get_EnumNames() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IsFlags() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public Int64[] get_Values() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public String[] get_XmlNames() { }

	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportElementInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(string), typeof(Type), typeof(XmlTypeMapMemberElement), typeof(XmlAttributes)}, ReturnType = typeof(XmlTypeMapElementInfoList))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "GetEnumValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	public string GetEnumName(string typeName, string xmlName) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteEnumElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(object), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "GetStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(TypeData), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "GetEnumXmlValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(XmlCustomFormatter), Member = "FromEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(String[]), typeof(Int64[]), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	public string GetXmlName(string typeName, object enumValue) { }

}


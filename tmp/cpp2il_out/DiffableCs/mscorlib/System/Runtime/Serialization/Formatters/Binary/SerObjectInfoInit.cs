namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class SerObjectInfoInit
{
	internal Hashtable seenBeforeTable; //Field offset: 0x10
	internal int objectInfoIdCount; //Field offset: 0x18
	internal SerStack oiPool; //Field offset: 0x20

	[CalledBy(Type = typeof(ObjectReader), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HeaderHandler), typeof(__BinaryParser), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Header[]), typeof(__BinaryWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SerStack), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public SerObjectInfoInit() { }

}


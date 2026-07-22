namespace System.Runtime.Serialization;

[ComVisible(True)]
public class ObjectIDGenerator
{
	private static readonly Int32[] sizes; //Field offset: 0x0
	internal int m_currentCount; //Field offset: 0x10
	internal int m_currentSize; //Field offset: 0x14
	internal Int64[] m_ids; //Field offset: 0x18
	internal Object[] m_objs; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static ObjectIDGenerator() { }

	[CalledBy(Type = typeof(ObjectWriter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Header[]), typeof(__BinaryWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Serialization.XmlSerializationWriter", Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public ObjectIDGenerator() { }

	[CalledBy(Type = typeof(ObjectIDGenerator), Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(ObjectIDGenerator), Member = "HasId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(ObjectIDGenerator), Member = "Rehash", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private int FindElement(object obj, out bool found) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectIDGenerator), Member = "FindElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ObjectIDGenerator), Member = "Rehash", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	public override long GetId(object obj, out bool firstTime) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectIDGenerator), Member = "FindElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public override long HasId(object obj, out bool firstTime) { }

	[CalledBy(Type = typeof(ObjectIDGenerator), Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectIDGenerator), Member = "FindElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private void Rehash() { }

}


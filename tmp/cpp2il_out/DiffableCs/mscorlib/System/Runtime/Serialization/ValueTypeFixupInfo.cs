namespace System.Runtime.Serialization;

internal sealed class ValueTypeFixupInfo
{
	private readonly long _containerID; //Field offset: 0x10
	private readonly FieldInfo _parentField; //Field offset: 0x18
	private readonly Int32[] _parentIndex; //Field offset: 0x20

	public long ContainerID
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public FieldInfo ParentField
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Int32[] ParentIndex
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(ObjectManager), Member = "RegisterObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(long), typeof(SerializationInfo), typeof(long), typeof(MemberInfo), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectHolder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(long), typeof(SerializationInfo), typeof(ISerializationSurrogate), typeof(long), typeof(FieldInfo), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectHolder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(long), typeof(SerializationInfo), typeof(ISerializationSurrogate), typeof(long), typeof(FieldInfo), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectHolder), Member = "UpdateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationInfo), typeof(ISerializationSurrogate), typeof(long), typeof(FieldInfo), typeof(Int32[]), typeof(ObjectManager)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 17)]
	public ValueTypeFixupInfo(long containerID, FieldInfo member, Int32[] parentIndex) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public long get_ContainerID() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public FieldInfo get_ParentField() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Int32[] get_ParentIndex() { }

}


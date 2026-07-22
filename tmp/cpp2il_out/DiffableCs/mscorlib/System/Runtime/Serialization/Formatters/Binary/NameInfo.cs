namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class NameInfo
{
	internal string NIFullName; //Field offset: 0x10
	internal long NIobjectId; //Field offset: 0x18
	internal long NIassemId; //Field offset: 0x20
	internal InternalPrimitiveTypeE NIprimitiveTypeEnum; //Field offset: 0x28
	internal Type NItype; //Field offset: 0x30
	internal bool NIisSealed; //Field offset: 0x38
	internal bool NIisArray; //Field offset: 0x39
	internal bool NIisArrayItem; //Field offset: 0x3A
	internal bool NItransmitTypeOnObject; //Field offset: 0x3B
	internal bool NItransmitTypeOnMember; //Field offset: 0x3C
	internal bool NIisParentTypeOnObject; //Field offset: 0x3D
	internal InternalArrayTypeE NIarrayEnum; //Field offset: 0x40
	private bool NIsealedStatusChecked; //Field offset: 0x44

	public bool IsSealed
	{
		[CalledBy(Type = typeof(ObjectWriter), Member = "WriteArrayMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Type), Member = "get_IsSealed", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 53
	}

	public string NIname
	{
		[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(int), typeof(String[]), typeof(Type[]), typeof(WriteObjectInfo[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteSingleArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(WriteObjectInfo), typeof(NameInfo), typeof(int), typeof(int), typeof(Array)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteJaggedArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(WriteObjectInfo), typeof(NameInfo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteRectangleArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(WriteObjectInfo), typeof(NameInfo), typeof(int), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectWriter), Member = "WriteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 72
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal NameInfo() { }

	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteArrayMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "get_IsSealed", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_IsSealed() { }

	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(int), typeof(String[]), typeof(Type[]), typeof(WriteObjectInfo[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteSingleArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(WriteObjectInfo), typeof(NameInfo), typeof(int), typeof(int), typeof(Array)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteJaggedArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(WriteObjectInfo), typeof(NameInfo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteRectangleArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(WriteObjectInfo), typeof(NameInfo), typeof(int), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public string get_NIname() { }

	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object), typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(WriteObjectInfo), typeof(InternalPrimitiveTypeE), typeof(NameInfo)}, ReturnType = typeof(NameInfo))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo)}, ReturnType = typeof(NameInfo))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(NameInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "GetNameInfo", ReturnType = typeof(NameInfo))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	internal void Init() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_NIname(string value) { }

}


namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class ValueFixup
{
	internal static MemberInfo valueInfo; //Field offset: 0x0
	internal ValueFixupEnum valueFixupEnum; //Field offset: 0x10
	internal Array arrayObj; //Field offset: 0x18
	internal Int32[] indexMap; //Field offset: 0x20
	internal object header; //Field offset: 0x28
	internal object memberObject; //Field offset: 0x30
	internal ReadObjectInfo objectInfo; //Field offset: 0x38
	internal string memberName; //Field offset: 0x40

	[CalledBy(Type = typeof(ObjectReader), Member = "ParseArrayMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal ValueFixup(Array arrayObj, Int32[] indexMap) { }

	[CalledBy(Type = typeof(ObjectReader), Member = "ParseMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal ValueFixup(object memberObject, string memberName, ReadObjectInfo objectInfo) { }

	[CalledBy(Type = typeof(ObjectReader), Member = "ParseObjectEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReadObjectInfo), Member = "GetMemberInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MemberInfo))]
	[Calls(Type = typeof(MemberInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(MemberInfo), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MemberInfo[]))]
	[Calls(Type = typeof(FormatterServices), Member = "SerializationSetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	internal void Fixup(ParseRecord record, ParseRecord parent) { }

}


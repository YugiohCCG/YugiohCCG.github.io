namespace System;

[CLSCompliant(False)]
[ComVisible(True)]
[IsByRefLike]
[NonVersionable]
public struct TypedReference
{
	private RuntimeTypeHandle type; //Field offset: 0x0
	private IntPtr Value; //Field offset: 0x8
	private IntPtr Type; //Field offset: 0x10

	internal bool IsNull
	{
		[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "SetValueDirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypedReference), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 19
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual bool Equals(object o) { }

	[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "SetValueDirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypedReference), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool get_IsNull() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void InternalMakeTypedReference(Void* result, object target, IntPtr[] flds, RuntimeType lastFieldType) { }

	[CalledBy(Type = typeof(ObjectManager), Member = "DoValueTypeFixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo), typeof(ObjectHolder), typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeFieldInfo), Member = "GetDeclaringTypeInternal", ReturnType = typeof(RuntimeType))]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MissingMemberException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 39)]
	[CLSCompliant(False)]
	public static TypedReference MakeTypedReference(object target, FieldInfo[] flds) { }

	[CalledBy(Type = typeof(ObjectManager), Member = "DoValueTypeFixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo), typeof(ObjectHolder), typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[CLSCompliant(False)]
	public static void SetTypedReference(TypedReference target, object value) { }

}


namespace UnityEngine;

[NativeHeader("Runtime/Mono/AssemblyFullName.h")]
[RequiredByNativeCode(GenerateProxy = True)]
internal struct AssemblyVersion
{
	public ushort major; //Field offset: 0x0
	public ushort minor; //Field offset: 0x2
	public ushort build; //Field offset: 0x4
	public ushort revision; //Field offset: 0x6

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object other) { }

	[CalledBy(Type = typeof(HashCode), Member = "Combine", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3", "T4"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3", "T4"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HashCode), Member = "Combine", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(ushort), typeof(ushort), typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(ushort), typeof(ushort), typeof(ushort)}, ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(AssemblyVersion lhs, AssemblyVersion rhs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 18)]
	public virtual string ToString() { }

}


namespace System.Collections.Specialized;

[DefaultMember("Item")]
public struct BitVector32
{
	private uint _data; //Field offset: 0x0

	public bool Item
	{
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_AmbientValue", ReturnType = typeof(object))]
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_DefaultValue", ReturnType = typeof(object))]
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_GetMethodValue", ReturnType = typeof(MethodInfo))]
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_ResetMethodValue", ReturnType = typeof(MethodInfo))]
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_SetMethodValue", ReturnType = typeof(MethodInfo))]
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_ShouldSerializeMethodValue", ReturnType = typeof(MethodInfo))]
		[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "OnValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(EventArgs)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 18
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public static int CreateMask() { }

	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static int CreateMask(int previous) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object o) { }

	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_AmbientValue", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_DefaultValue", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_GetMethodValue", ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_ResetMethodValue", ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_SetMethodValue", ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_ShouldSerializeMethodValue", ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "OnValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(EventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[ContainsUnimplementedInstructions]
	public bool get_Item(int bit) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public void set_Item(int bit, bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static string ToString(BitVector32 value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual string ToString() { }

}


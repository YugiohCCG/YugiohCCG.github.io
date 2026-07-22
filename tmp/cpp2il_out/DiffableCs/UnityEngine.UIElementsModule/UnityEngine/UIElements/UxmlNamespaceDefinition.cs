namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct UxmlNamespaceDefinition : IEquatable<UxmlNamespaceDefinition>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static readonly UxmlNamespaceDefinition <Empty>k__BackingField; //Field offset: 0x0
	public string prefix; //Field offset: 0x0
	public string resolvedNamespace; //Field offset: 0x8

	[CallerCount(Count = 0)]
	private static UxmlNamespaceDefinition() { }

	[CalledBy(Type = typeof(UxmlNamespaceDefinition), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public override bool Equals(UxmlNamespaceDefinition other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UxmlNamespaceDefinition), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UxmlNamespaceDefinition)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashCode), Member = "Combine", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(UxmlNamespaceDefinition lhs, UxmlNamespaceDefinition rhs) { }

}


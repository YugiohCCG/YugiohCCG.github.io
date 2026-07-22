namespace UnityEngine.UIElements;

public class ConverterGroup
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly string <id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly string <displayName>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly string <description>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly TypeConverterRegistry <registry>k__BackingField; //Field offset: 0x28

	internal TypeConverterRegistry registry
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CalledBy(Type = typeof(ConverterGroups), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataBinding), Member = "get_sourceToUiConverters", ReturnType = typeof(ConverterGroup))]
	[CalledBy(Type = typeof(DataBinding), Member = "get_uiToSourceConverters", ReturnType = typeof(ConverterGroup))]
	[CalledBy(Type = typeof(DataBinding), Member = "ApplyConverterGroupToSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConverterGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataBinding), Member = "ApplyConverterGroupToUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConverterGroup)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.TypeConverterRegistry+ConverterKey, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEqualityComparer`1<UnityEngine.UIElements.TypeConverterRegistry+ConverterKey>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public ConverterGroup(string id, string displayName = null, string description = null) { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal TypeConverterRegistry get_registry() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeConverterRegistry), Member = "TryGetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Delegate&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	public bool TryConvert(ref TSource source, out TDestination destination) { }

	[CalledBy(Type = typeof(DataBinding), Member = "UpdateUI", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), "TValue&"}, ReturnType = typeof(BindingResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PropertyPath), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(PropertyContainer), Member = "TryAccept", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPropertyBagVisitor), typeof(Object&), typeof(VisitReturnCode&), typeof(VisitParameters)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool TrySetValue(ref TContainer container, in PropertyPath path, TValue value, out VisitReturnCode returnCode) { }

}


namespace UnityEngine.UIElements;

[IsReadOnly]
public struct BindingInfo
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly VisualElement <targetElement>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly BindingId <bindingId>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly Binding <binding>k__BackingField; //Field offset: 0xA0

	public Binding binding
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CalledBy(Type = typeof(BindingInfo), Member = "FromBindingData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingData&)}, ReturnType = typeof(BindingInfo))]
	[CalledBy(Type = typeof(DataBindingUtility), Member = "TryGetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(BindingInfo&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private BindingInfo(VisualElement targetElement, in BindingId bindingId, Binding binding) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BindingInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(Binding)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal static BindingInfo FromBindingData(in BindingData bindingData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&)}, ReturnType = typeof(BindingId))]
	[CallsUnknownMethods(Count = 5)]
	internal static BindingInfo FromRequest(VisualElement target, in PropertyPath targetPath, Binding binding) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Binding get_binding() { }

}


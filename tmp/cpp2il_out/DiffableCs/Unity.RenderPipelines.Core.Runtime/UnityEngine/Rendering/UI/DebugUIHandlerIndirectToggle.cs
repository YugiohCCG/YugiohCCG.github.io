namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerIndirectToggle : DebugUIHandlerWidget
{
	public Text nameLabel; //Field offset: 0x60
	public Toggle valueToggle; //Field offset: 0x68
	public Image checkmarkImage; //Field offset: 0x70
	public Func<Int32, Boolean> getter; //Field offset: 0x78
	public Action<Int32, Boolean> setter; //Field offset: 0x80
	internal int index; //Field offset: 0x88

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DebugUIHandlerIndirectToggle() { }

	[CalledBy(Type = typeof(DebugUIHandlerBitField), Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUIHandlerRenderingLayerField), Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DebugUIHandlerIndirectToggle), Member = "UpdateValueLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Init() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUIHandlerIndirectToggle), Member = "UpdateValueLabel", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual void OnAction() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void OnDeselection() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnToggleValueChanged(bool value) { }

	[CalledBy(Type = typeof(DebugUIHandlerBitField), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUIHandlerIndirectToggle), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUIHandlerIndirectToggle), Member = "OnAction", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void UpdateValueLabel() { }

}


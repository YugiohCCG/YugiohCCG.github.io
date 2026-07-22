namespace UnityEngine.Rendering.UI;

public abstract class DebugUIHandlerField : DebugUIHandlerWidget
{
	public Text nextButtonText; //Field offset: 0x0
	public Text previousButtonText; //Field offset: 0x0
	public Text nameLabel; //Field offset: 0x0
	public Text valueLabel; //Field offset: 0x0
	protected private T m_Field; //Field offset: 0x0

	[CalledBy(Type = typeof(DebugUIHandlerEnumField), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUIHandlerEnumHistory), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUIHandlerObjectList), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUIHandlerObjectPopupField), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected DebugUIHandlerField`1() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void OnAction() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void OnDeselection() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[CalledBy(Type = typeof(DebugUIHandlerEnumField), Member = "UpdateValueLabel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUIHandlerObjectList), Member = "UpdateValueLabel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUIHandlerObjectPopupField), Member = "UpdateValueLabel", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected void SetLabelText(string text) { }

	[CalledBy(Type = typeof(DebugUIHandlerEnumHistory), Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUIHandlerObjectList), Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUIHandlerObjectPopupField), Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DebugUIHandlerWidget), Member = "CastWidget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal virtual void SetWidget(Widget widget) { }

	public abstract void UpdateValueLabel() { }

}


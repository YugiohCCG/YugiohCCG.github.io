namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerVector4 : DebugUIHandlerWidget
{
	public Text nameLabel; //Field offset: 0x60
	public UIFoldout valueToggle; //Field offset: 0x68
	public DebugUIHandlerIndirectFloatField fieldX; //Field offset: 0x70
	public DebugUIHandlerIndirectFloatField fieldY; //Field offset: 0x78
	public DebugUIHandlerIndirectFloatField fieldZ; //Field offset: 0x80
	public DebugUIHandlerIndirectFloatField fieldW; //Field offset: 0x88
	private Vector4Field m_Field; //Field offset: 0x90
	private DebugUIHandlerContainer m_Container; //Field offset: 0x98

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DebugUIHandlerVector4() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private float <SetupSettings>b__10_0() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private float <SetupSettings>b__10_1() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private float <SetupSettings>b__10_2() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Field`1), Member = "GetValue", ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private float <SetWidget>b__8_0() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Field`1), Member = "GetValue", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <SetWidget>b__8_1(float x) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Field`1), Member = "GetValue", ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private float <SetWidget>b__8_2() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Field`1), Member = "GetValue", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <SetWidget>b__8_3(float x) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Field`1), Member = "GetValue", ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private float <SetWidget>b__8_4() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Field`1), Member = "GetValue", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <SetWidget>b__8_5(float x) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Field`1), Member = "GetValue", ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private float <SetWidget>b__8_6() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Field`1), Member = "GetValue", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <SetWidget>b__8_7(float x) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugUIHandlerContainer), Member = "GetFirstItem", ReturnType = typeof(DebugUIHandlerWidget))]
	[Calls(Type = typeof(DebugUIHandlerWidget), Member = "Next", ReturnType = typeof(DebugUIHandlerWidget))]
	[CallsUnknownMethods(Count = 1)]
	public virtual DebugUIHandlerWidget Next() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual void OnAction() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void OnDecrement(bool fast) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void OnDeselection() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void OnIncrement(bool fast) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUIHandlerContainer), Member = "IsDirectChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugUIHandlerContainer), Member = "GetLastItem", ReturnType = typeof(DebugUIHandlerWidget))]
	[Calls(Type = typeof(DebugManager), Member = "get_instance", ReturnType = typeof(DebugManager))]
	[Calls(Type = typeof(DebugManager), Member = "ChangeSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugUIHandlerWidget), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[CalledBy(Type = typeof(DebugUIHandlerVector4), Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DebugUIHandlerIndirectFloatField), Member = "UpdateValueLabel", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void SetupSettings(DebugUIHandlerIndirectFloatField field) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Field`1), Member = "GetValue", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetValue(float v, bool x = false, bool y = false, bool z = false, bool w = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUIHandlerWidget), Member = "CastWidget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(DebugUIHandlerVector4), Member = "SetupSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugUIHandlerIndirectFloatField)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 18)]
	[ContainsInvalidInstructions]
	internal virtual void SetWidget(Widget widget) { }

}


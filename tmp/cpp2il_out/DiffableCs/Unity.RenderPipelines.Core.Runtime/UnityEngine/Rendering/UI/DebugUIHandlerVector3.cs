namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerVector3 : DebugUIHandlerWidget
{
	public Text nameLabel; //Field offset: 0x60
	public UIFoldout valueToggle; //Field offset: 0x68
	public DebugUIHandlerIndirectFloatField fieldX; //Field offset: 0x70
	public DebugUIHandlerIndirectFloatField fieldY; //Field offset: 0x78
	public DebugUIHandlerIndirectFloatField fieldZ; //Field offset: 0x80
	private Vector3Field m_Field; //Field offset: 0x88
	private DebugUIHandlerContainer m_Container; //Field offset: 0x90

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DebugUIHandlerVector3() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private float <SetupSettings>b__9_0() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private float <SetupSettings>b__9_1() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private float <SetupSettings>b__9_2() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.DebugUI+Field`1<UnityEngine.Vector3>), Member = "GetValue", ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private float <SetWidget>b__7_0() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.DebugUI+Field`1<UnityEngine.Vector3>), Member = "GetValue", ReturnType = typeof(Vector3))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <SetWidget>b__7_1(float v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.DebugUI+Field`1<UnityEngine.Vector3>), Member = "GetValue", ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private float <SetWidget>b__7_2() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.DebugUI+Field`1<UnityEngine.Vector3>), Member = "GetValue", ReturnType = typeof(Vector3))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <SetWidget>b__7_3(float v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.DebugUI+Field`1<UnityEngine.Vector3>), Member = "GetValue", ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private float <SetWidget>b__7_4() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.DebugUI+Field`1<UnityEngine.Vector3>), Member = "GetValue", ReturnType = typeof(Vector3))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <SetWidget>b__7_5(float v) { }

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

	[CalledBy(Type = typeof(DebugUIHandlerVector3), Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DebugUIHandlerIndirectFloatField), Member = "UpdateValueLabel", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void SetupSettings(DebugUIHandlerIndirectFloatField field) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.DebugUI+Field`1<UnityEngine.Vector3>), Member = "GetValue", ReturnType = typeof(Vector3))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetValue(float v, bool x = false, bool y = false, bool z = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUIHandlerWidget), Member = "CastWidget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(DebugUIHandlerVector3), Member = "SetupSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugUIHandlerIndirectFloatField)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsInvalidInstructions]
	internal virtual void SetWidget(Widget widget) { }

}


namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerColor : DebugUIHandlerWidget
{
	public Text nameLabel; //Field offset: 0x60
	public UIFoldout valueToggle; //Field offset: 0x68
	public Image colorImage; //Field offset: 0x70
	public DebugUIHandlerIndirectFloatField fieldR; //Field offset: 0x78
	public DebugUIHandlerIndirectFloatField fieldG; //Field offset: 0x80
	public DebugUIHandlerIndirectFloatField fieldB; //Field offset: 0x88
	public DebugUIHandlerIndirectFloatField fieldA; //Field offset: 0x90
	private ColorField m_Field; //Field offset: 0x98
	private DebugUIHandlerContainer m_Container; //Field offset: 0xA0

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DebugUIHandlerColor() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private float <SetupSettings>b__11_0() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private float <SetupSettings>b__11_1() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private float <SetupSettings>b__11_2() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Field`1), Member = "GetValue", ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private float <SetWidget>b__9_0() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Field`1), Member = "GetValue", ReturnType = "T")]
	[Calls(Type = typeof(DebugUIHandlerColor), Member = "UpdateColor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <SetWidget>b__9_1(float x) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Field`1), Member = "GetValue", ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private float <SetWidget>b__9_2() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Field`1), Member = "GetValue", ReturnType = "T")]
	[Calls(Type = typeof(DebugUIHandlerColor), Member = "UpdateColor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <SetWidget>b__9_3(float x) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Field`1), Member = "GetValue", ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private float <SetWidget>b__9_4() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Field`1), Member = "GetValue", ReturnType = "T")]
	[Calls(Type = typeof(DebugUIHandlerColor), Member = "UpdateColor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <SetWidget>b__9_5(float x) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Field`1), Member = "GetValue", ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private float <SetWidget>b__9_6() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Field`1), Member = "GetValue", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[ContainsInvalidInstructions]
	private void <SetWidget>b__9_7(float x) { }

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

	[CalledBy(Type = typeof(DebugUIHandlerColor), Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DebugUIHandlerIndirectFloatField), Member = "UpdateValueLabel", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void SetupSettings(DebugUIHandlerIndirectFloatField field) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Field`1), Member = "GetValue", ReturnType = "T")]
	[Calls(Type = typeof(DebugUIHandlerColor), Member = "UpdateColor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetValue(float x, bool r = false, bool g = false, bool b = false, bool a = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUIHandlerWidget), Member = "CastWidget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(DebugUIHandlerColor), Member = "SetupSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugUIHandlerIndirectFloatField)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugUIHandlerColor), Member = "UpdateColor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 18)]
	internal virtual void SetWidget(Widget widget) { }

	[CalledBy(Type = typeof(DebugUIHandlerColor), Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUIHandlerColor), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUIHandlerColor), Member = "<SetWidget>b__9_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUIHandlerColor), Member = "<SetWidget>b__9_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUIHandlerColor), Member = "<SetWidget>b__9_5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUIHandlerRow), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Field`1), Member = "GetValue", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void UpdateColor() { }

}


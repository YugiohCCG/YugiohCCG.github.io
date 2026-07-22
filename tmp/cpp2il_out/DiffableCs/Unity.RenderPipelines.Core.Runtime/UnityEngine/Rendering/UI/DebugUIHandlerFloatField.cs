namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerFloatField : DebugUIHandlerWidget
{
	public Text nameLabel; //Field offset: 0x60
	public Text valueLabel; //Field offset: 0x68
	private FloatField m_Field; //Field offset: 0x70

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DebugUIHandlerFloatField() { }

	[CalledBy(Type = typeof(DebugUIHandlerFloatField), Member = "OnIncrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUIHandlerFloatField), Member = "OnDecrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DebugUIHandlerFloatField), Member = "UpdateValueLabel", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void ChangeValue(bool fast, float multiplier) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUIHandlerFloatField), Member = "ChangeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(float)}, ReturnType = typeof(void))]
	public virtual void OnDecrement(bool fast) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void OnDeselection() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUIHandlerFloatField), Member = "ChangeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(float)}, ReturnType = typeof(void))]
	public virtual void OnIncrement(bool fast) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUIHandlerWidget), Member = "CastWidget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsInvalidInstructions]
	internal virtual void SetWidget(Widget widget) { }

	[CalledBy(Type = typeof(DebugUIHandlerFloatField), Member = "ChangeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateValueLabel() { }

}


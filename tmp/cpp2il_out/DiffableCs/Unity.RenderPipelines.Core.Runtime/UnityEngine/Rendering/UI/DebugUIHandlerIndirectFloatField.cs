namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerIndirectFloatField : DebugUIHandlerWidget
{
	public Text nameLabel; //Field offset: 0x60
	public Text valueLabel; //Field offset: 0x68
	public Func<Single> getter; //Field offset: 0x70
	public Action<Single> setter; //Field offset: 0x78
	public Func<Single> incStepGetter; //Field offset: 0x80
	public Func<Single> incStepMultGetter; //Field offset: 0x88
	public Func<Single> decimalsGetter; //Field offset: 0x90

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DebugUIHandlerIndirectFloatField() { }

	[CalledBy(Type = typeof(DebugUIHandlerIndirectFloatField), Member = "OnIncrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUIHandlerIndirectFloatField), Member = "OnDecrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	private void ChangeValue(bool fast, float multiplier) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUIHandlerIndirectFloatField), Member = "UpdateValueLabel", ReturnType = typeof(void))]
	public void Init() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUIHandlerIndirectFloatField), Member = "ChangeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(float)}, ReturnType = typeof(void))]
	public virtual void OnDecrement(bool fast) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void OnDeselection() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUIHandlerIndirectFloatField), Member = "ChangeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(float)}, ReturnType = typeof(void))]
	public virtual void OnIncrement(bool fast) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[CalledBy(Type = typeof(DebugUIHandlerColor), Member = "SetupSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugUIHandlerIndirectFloatField)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUIHandlerIndirectFloatField), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUIHandlerVector2), Member = "SetupSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugUIHandlerIndirectFloatField)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUIHandlerVector3), Member = "SetupSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugUIHandlerIndirectFloatField)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUIHandlerVector4), Member = "SetupSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugUIHandlerIndirectFloatField)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateValueLabel() { }

}


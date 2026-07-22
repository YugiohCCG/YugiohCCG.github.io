namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerEnumField : DebugUIHandlerField<EnumField>
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUIHandlerField`1), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public DebugUIHandlerEnumField() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnumField), Member = "get_currentIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(EnumField), Member = "InitQuickSeparators", ReturnType = typeof(void))]
	[Calls(Type = typeof(EnumField), Member = "set_currentIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void OnDecrement(bool fast) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnumField), Member = "get_currentIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(EnumField), Member = "InitQuickSeparators", ReturnType = typeof(void))]
	[Calls(Type = typeof(EnumField), Member = "set_currentIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void OnIncrement(bool fast) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnumField), Member = "get_currentIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(DebugUIHandlerField`1), Member = "SetLabelText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void UpdateValueLabel() { }

}


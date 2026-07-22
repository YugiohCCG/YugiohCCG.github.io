namespace UnityEngine.InputSystem.Controls;

[InputControlLayout(hideInUI = True)]
public class TouchPressControl : ButtonControl
{

	[CallerCount(Count = 141)]
	[Calls(Type = typeof(ButtonControl), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public TouchPressControl() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AxisControl), Member = "FinishSetup", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputState), Member = "IsIntegerFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FourCC)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	protected virtual void FinishSetup() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemoryHelpers), Member = "ReadMultipleBitsAsUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(AxisControl), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	public virtual float ReadUnprocessedValueFromState(Void* statePtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void WriteValueIntoState(float value, Void* statePtr) { }

}


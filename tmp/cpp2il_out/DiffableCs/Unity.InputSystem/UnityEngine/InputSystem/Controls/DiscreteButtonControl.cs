namespace UnityEngine.InputSystem.Controls;

public class DiscreteButtonControl : ButtonControl
{
	internal enum WriteMode
	{
		WriteDisabled = 0,
		WriteNullAndMaxValue = 1,
	}

	public int minValue; //Field offset: 0x148
	public int maxValue; //Field offset: 0x14C
	public int wrapAtValue; //Field offset: 0x150
	public int nullValue; //Field offset: 0x154
	public WriteMode writeMode; //Field offset: 0x158

	[CallerCount(Count = 141)]
	[Calls(Type = typeof(ButtonControl), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public DiscreteButtonControl() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AxisControl), Member = "FinishSetup", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputState), Member = "IsIntegerFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FourCC)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	protected virtual void FinishSetup() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemoryHelpers), Member = "ReadTwosComplementMultipleBitsAsInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint), typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AxisControl), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	public virtual float ReadUnprocessedValueFromState(Void* statePtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemoryHelpers), Member = "WriteIntAsTwosComplementMultipleBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint), typeof(uint), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual void WriteValueIntoState(float value, Void* statePtr) { }

}


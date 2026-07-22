namespace UnityEngine.InputSystem.Controls;

public class IntegerControl : InputControl<Int32>
{

	[CallerCount(Count = 37)]
	[Calls(Type = typeof(InputControl`1), Member = ".ctor", ReturnType = typeof(void))]
	public IntegerControl() { }

	[CallerCount(Count = 0)]
	protected virtual FourCC CalculateOptimizedControlDataType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputStateBlock), Member = "ReadInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(int))]
	public virtual int ReadUnprocessedValueFromState(Void* statePtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputStateBlock), Member = "WriteInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	public virtual void WriteValueIntoState(int value, Void* statePtr) { }

}


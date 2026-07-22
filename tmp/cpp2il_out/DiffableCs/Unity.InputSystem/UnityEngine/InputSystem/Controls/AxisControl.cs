namespace UnityEngine.InputSystem.Controls;

public class AxisControl : InputControl<Single>
{
	internal enum Clamp
	{
		None = 0,
		BeforeNormalize = 1,
		AfterNormalize = 2,
		ToConstantBeforeNormalize = 3,
	}

	public Clamp clamp; //Field offset: 0x108
	public float clampMin; //Field offset: 0x10C
	public float clampMax; //Field offset: 0x110
	public float clampConstant; //Field offset: 0x114
	public bool invert; //Field offset: 0x118
	public bool normalize; //Field offset: 0x119
	public float normalizeMin; //Field offset: 0x11C
	public float normalizeMax; //Field offset: 0x120
	public float normalizeZero; //Field offset: 0x124
	public bool scale; //Field offset: 0x128
	public float scaleFactor; //Field offset: 0x12C

	[CallerCount(Count = 173)]
	[Calls(Type = typeof(InputControl`1), Member = ".ctor", ReturnType = typeof(void))]
	public AxisControl() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	protected virtual FourCC CalculateOptimizedControlDataType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Single>), Member = "ReadValueFromState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool CompareValue(Void* firstStatePtr, Void* secondStatePtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Single>), Member = "ReadValueFromStateWithCaching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(PrimitiveValue), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(NormalizeProcessor), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 2)]
	public virtual float EvaluateMagnitude(Void* statePtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PrimitiveValue), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(NormalizeProcessor), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 2)]
	private float EvaluateMagnitude(float value) { }

	[CalledBy(Type = typeof(DiscreteButtonControl), Member = "FinishSetup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DpadAxisControl), Member = "FinishSetup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchPressControl), Member = "FinishSetup", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Single>), Member = "FinishSetup", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControl), Member = "get_hasDefaultState", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputStateBlock), Member = "FloatToPrimitiveValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(PrimitiveValue))]
	protected virtual void FinishSetup() { }

	[CalledBy(Type = typeof(AxisControl), Member = "ReadUnprocessedValueFromState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(DiscreteButtonControl), Member = "ReadUnprocessedValueFromState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TouchPressControl), Member = "ReadUnprocessedValueFromState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(float))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NormalizeProcessor), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	protected float Preprocess(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputStateBlock), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(AxisControl), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	public virtual float ReadUnprocessedValueFromState(Void* statePtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NormalizeProcessor), Member = "Denormalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	private float Unpreprocess(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NormalizeProcessor), Member = "Denormalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(InputStateBlock), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(float)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public virtual void WriteValueIntoState(float value, Void* statePtr) { }

}


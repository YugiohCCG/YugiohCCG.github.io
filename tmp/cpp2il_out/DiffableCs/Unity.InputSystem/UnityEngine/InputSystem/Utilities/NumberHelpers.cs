namespace UnityEngine.InputSystem.Utilities;

[Extension]
internal static class NumberHelpers
{

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static int AlignToMultipleOf(int number, int alignment) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static long AlignToMultipleOf(long number, long alignment) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static uint AlignToMultipleOf(uint number, uint alignment) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	public static bool Approximately(double a, double b) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float IntToNormalizedFloat(int value, int minValue, int maxValue) { }

	[CalledBy(Type = typeof(InputStateBlock), Member = "FloatToPrimitiveValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(PrimitiveValue))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static int NormalizedFloatToInt(float value, int intMinValue, int intMaxValue) { }

	[CalledBy(Type = typeof(InputStateBlock), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputStateBlock), Member = "FloatToPrimitiveValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(PrimitiveValue))]
	[CalledBy(Type = typeof(InputStateBlock), Member = "WriteDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(double)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[ContainsUnimplementedInstructions]
	public static uint NormalizedFloatToUInt(float value, uint uintMinValue, uint uintMaxValue) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Switch.SwitchProControllerHID+SwitchSimpleInputReport", Member = "ToHIDInputReport", ReturnType = typeof(SwitchProControllerHIDInputState))]
	[CalledBy(Type = "UnityEngine.InputSystem.Switch.SwitchProControllerHID+SwitchFullInputReport", Member = "ToHIDInputReport", ReturnType = typeof(SwitchProControllerHIDInputState))]
	[CalledBy(Type = typeof(Quaternion), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Quaternion)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[ContainsUnimplementedInstructions]
	public static uint RemapUIntBitsToNormalizeFloatToUIntBits(uint value, uint inBitSize, uint outBitSize) { }

	[CalledBy(Type = typeof(InputStateBlock), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(InputStateBlock), Member = "ReadDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(double))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static float UIntToNormalizedFloat(uint value, uint minValue, uint maxValue) { }

}


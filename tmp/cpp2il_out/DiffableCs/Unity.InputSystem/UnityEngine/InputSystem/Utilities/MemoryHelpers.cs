namespace UnityEngine.InputSystem.Utilities;

internal static class MemoryHelpers
{
	internal struct BitRegion
	{
		public uint bitOffset; //Field offset: 0x0
		public uint sizeInBits; //Field offset: 0x4

		public bool isEmpty
		{
			[CallerCount(Count = 6)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			 get { } //Length: 8
		}

		[CallerCount(Count = 104)]
		[DeduplicatedMethod]
		public BitRegion(uint bitOffset, uint sizeInBits) { }

		[CalledBy(Type = typeof(StateChangeMonitorsForDevice), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(IInputStateChangeMonitor), typeof(long), typeof(uint)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "ProcessStateChangeMonitors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Void*), typeof(Void*), typeof(uint), typeof(uint)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		public BitRegion(uint byteOffset, uint bitOffset, uint sizeInBits) { }

		[CallerCount(Count = 6)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public bool get_isEmpty() { }

		[CalledBy(Type = typeof(InputManager), Member = "ProcessStateChangeMonitors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Void*), typeof(Void*), typeof(uint), typeof(uint)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
		public BitRegion Overlap(BitRegion other) { }

	}


	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "ComputeStateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[ContainsUnimplementedInstructions]
	public static uint AlignNatural(uint offset, uint sizeInBytes) { }

	[CalledBy(Type = typeof(InputManager), Member = "ProcessStateChangeMonitors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Void*), typeof(Void*), typeof(uint), typeof(uint)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MemoryHelpers), Member = "MemCmpBitRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(uint), typeof(uint), typeof(Void*)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	public static bool Compare(Void* ptr1, Void* ptr2, BitRegion region) { }

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "ComputeStateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static uint ComputeFollowingByteOffset(uint byteOffset, uint sizeInBits) { }

	[CalledBy(Type = typeof(InputEventControlEnumerator), Member = "CheckDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputEventControlEnumerator), Member = "CheckCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputEventControlEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "CompareState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*), typeof(Void*), typeof(Void*)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputDevice), Member = "WriteChangedControlStatesInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Byte*), typeof(ControlBitRangeNode), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDevice), Member = "HasDataChangedInRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Void*), typeof(uint), typeof(uint)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputManager), Member = "UpdateState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUpdateType), typeof(Void*), typeof(uint), typeof(uint), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MemoryHelpers), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(BitRegion)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(int))]
	public static bool MemCmpBitRegion(Void* ptr1, Void* ptr2, uint bitOffset, uint bitCount, Void* mask = null) { }

	[CalledBy(Type = typeof(InputControlExtensions), Member = "ResetToDefaultStateInEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	public static void MemCpyBitRegion(Void* destination, Void* source, uint bitOffset, uint bitCount) { }

	[CalledBy(Type = typeof(InputManager), Member = "ResetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public static void MemCpyMasked(Void* destination, Void* source, int numBytes, Void* mask) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static void MemSet(Void* destination, int numBytes, byte value) { }

	[CalledBy(Type = typeof(InputStateBlock), Member = "ReadInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MemoryHelpers), Member = "ReadMultipleBitsAsUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	public static int ReadExcessKMultipleBitsAsInt(Void* ptr, uint bitOffset, uint bitCount) { }

	[CalledBy(Type = typeof(InputStateBlock), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(InputStateBlock), Member = "ReadDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(double))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(MemoryHelpers), Member = "ReadMultipleBitsAsUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[ContainsUnimplementedInstructions]
	public static float ReadMultipleBitsAsNormalizedUInt(Void* ptr, uint bitOffset, uint bitCount) { }

	[CalledBy(Type = typeof(InputStateBlock), Member = "ReadInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TouchPressControl), Member = "ReadUnprocessedValueFromState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(MemoryHelpers), Member = "ReadTwosComplementMultipleBitsAsInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint), typeof(uint)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MemoryHelpers), Member = "ReadExcessKMultipleBitsAsInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint), typeof(uint)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MemoryHelpers), Member = "ReadMultipleBitsAsNormalizedUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint), typeof(uint)}, ReturnType = typeof(float))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	public static uint ReadMultipleBitsAsUInt(Void* ptr, uint bitOffset, uint bitCount) { }

	[CalledBy(Type = typeof(InputControlExtensions), Member = "CompareState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*), typeof(Void*), typeof(Void*)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputDevice), Member = "WriteChangedControlStatesInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Byte*), typeof(ControlBitRangeNode), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDevice), Member = "HasDataChangedInRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Void*), typeof(uint), typeof(uint)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(KeyboardState), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputStateBlock), Member = "ReadInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputStateBlock), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(InputStateBlock), Member = "ReadDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(double))]
	[CallerCount(Count = 16)]
	[ContainsUnimplementedInstructions]
	public static bool ReadSingleBit(Void* ptr, uint bitOffset) { }

	[CalledBy(Type = typeof(DiscreteButtonControl), Member = "ReadUnprocessedValueFromState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MemoryHelpers), Member = "ReadMultipleBitsAsUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	public static int ReadTwosComplementMultipleBitsAsInt(Void* ptr, uint bitOffset, uint bitCount) { }

	[CalledBy(Type = typeof(InputManager), Member = "InitializeDeviceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 21)]
	public static void SetBitsInBuffer(Void* buffer, int byteOffset, int bitOffset, int sizeInBits, bool value) { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static void Swap(ref TValue a, ref TValue b) { }

	[CalledBy(Type = typeof(InputStateBlock), Member = "WriteInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputStateBlock), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(PrimitiveValue)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MemoryHelpers), Member = "WriteUIntAsMultipleBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	public static void WriteIntAsExcessKMultipleBits(Void* ptr, uint bitOffset, uint bitCount, int value) { }

	[CalledBy(Type = typeof(DiscreteButtonControl), Member = "WriteValueIntoState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Void*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MemoryHelpers), Member = "WriteUIntAsMultipleBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	public static void WriteIntAsTwosComplementMultipleBits(Void* ptr, uint bitOffset, uint bitCount, int value) { }

	[CalledBy(Type = typeof(InputStateBlock), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputStateBlock), Member = "WriteDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(double)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	public static void WriteNormalizedUIntAsMultipleBits(Void* ptr, uint bitOffset, uint bitCount, float value) { }

	[CalledBy(Type = typeof(KeyboardState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyboardState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Key[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyboardState), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyboardState), Member = "Press", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyboardState), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputStateBlock), Member = "WriteInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputStateBlock), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputStateBlock), Member = "WriteDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputStateBlock), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(PrimitiveValue)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[ContainsUnimplementedInstructions]
	public static void WriteSingleBit(Void* ptr, uint bitOffset, bool value) { }

	[CalledBy(Type = typeof(InputStateBlock), Member = "WriteInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputStateBlock), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(PrimitiveValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MemoryHelpers), Member = "WriteIntAsTwosComplementMultipleBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint), typeof(uint), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MemoryHelpers), Member = "WriteIntAsExcessKMultipleBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint), typeof(uint), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	public static void WriteUIntAsMultipleBits(Void* ptr, uint bitOffset, uint bitCount, uint value) { }

}


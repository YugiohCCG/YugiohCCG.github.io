namespace UnityEngine.InputSystem.LowLevel;

public struct InputStateBlock
{
	public const uint InvalidOffset = 4294967295; //Field offset: 0x0
	internal const int kFormatPose = 1349481317; //Field offset: 0x0
	internal const int kFormatQuaternion = 1364541780; //Field offset: 0x0
	internal const int kFormatVector3 = 1447379763; //Field offset: 0x0
	internal const int kFormatVector2 = 1447379762; //Field offset: 0x0
	internal const int kFormatDouble = 1145195552; //Field offset: 0x0
	internal const int kFormatFloat = 1179407392; //Field offset: 0x0
	internal const int kFormatULong = 1431064135; //Field offset: 0x0
	internal const int kFormatSByte = 1396857172; //Field offset: 0x0
	internal const int kFormatByte = 1113150533; //Field offset: 0x0
	internal const int kFormatUShort = 1431521364; //Field offset: 0x0
	internal const int kFormatShort = 1397248596; //Field offset: 0x0
	internal const int kFormatLong = 1280198432; //Field offset: 0x0
	internal const int kFormatUInt = 1430867540; //Field offset: 0x0
	internal const int kFormatBit = 1112101920; //Field offset: 0x0
	internal const int kFormatSBit = 1396853076; //Field offset: 0x0
	public static readonly FourCC FormatInvalid; //Field offset: 0x0
	public const uint AutomaticOffset = 4294967294; //Field offset: 0x0
	internal const int kFormatInvalid = 0; //Field offset: 0x0
	internal const int kFormatInt = 1229870112; //Field offset: 0x0
	public static readonly FourCC FormatBit; //Field offset: 0x4
	public static readonly FourCC FormatSBit; //Field offset: 0x8
	public static readonly FourCC FormatInt; //Field offset: 0xC
	public static readonly FourCC FormatUInt; //Field offset: 0x10
	public static readonly FourCC FormatShort; //Field offset: 0x14
	public static readonly FourCC FormatUShort; //Field offset: 0x18
	public static readonly FourCC FormatByte; //Field offset: 0x1C
	public static readonly FourCC FormatSByte; //Field offset: 0x20
	public static readonly FourCC FormatLong; //Field offset: 0x24
	public static readonly FourCC FormatULong; //Field offset: 0x28
	public static readonly FourCC FormatFloat; //Field offset: 0x2C
	public static readonly FourCC FormatDouble; //Field offset: 0x30
	public static readonly FourCC FormatVector2; //Field offset: 0x34
	public static readonly FourCC FormatVector3; //Field offset: 0x38
	public static readonly FourCC FormatQuaternion; //Field offset: 0x3C
	public static readonly FourCC FormatVector2Short; //Field offset: 0x40
	public static readonly FourCC FormatVector3Short; //Field offset: 0x44
	public static readonly FourCC FormatVector2Byte; //Field offset: 0x48
	public static readonly FourCC FormatVector3Byte; //Field offset: 0x4C
	public static readonly FourCC FormatPose; //Field offset: 0x50
	[CompilerGenerated]
	private FourCC <format>k__BackingField; //Field offset: 0x0
	internal uint m_ByteOffset; //Field offset: 0x4
	[CompilerGenerated]
	private uint <bitOffset>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private uint <sizeInBits>k__BackingField; //Field offset: 0xC

	internal uint alignedSizeInBytes
	{
		[CalledBy(Type = typeof(InputSystem), Member = "QueueDeltaStateEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelta"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), "TDelta", typeof(double)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputStateBuffers), Member = "MigrateSingleBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(InputDevice[]), typeof(int), typeof(Void*)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputStateBuffers), Member = "MigrateDoubleBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DoubleBuffers), typeof(InputDevice[]), typeof(int), typeof(DoubleBuffers)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputState), Member = "Change", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), "TState&", typeof(InputUpdateType), typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputEventTrace), Member = "OnInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeltaStateEvent), Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr&), typeof(Allocator)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.Byte>))]
		[CalledBy(Type = typeof(InputManager), Member = "ResetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Touchscreen), Member = "UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr), typeof(UInt32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputDevice), Member = "CompareValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputDevice), Member = "ReadValueFromStateIntoBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputDevice), Member = "ReadValueFromStateAsObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(InputDevice), Member = "get_valueSizeInBytes", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(InputControlExtensions), Member = "GetStatePtrFromStateEventUnchecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr), typeof(FourCC)}, ReturnType = typeof(Void*))]
		[CalledBy(Type = typeof(InputControlExtensions), Member = "CopyState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputControlExtensions), Member = "WriteValueIntoState", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControl`1<TValue>", "TValue", "TState&"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "ComputeStateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		internal get { } //Length: 73
	}

	public uint bitOffset
	{
		[CallerCount(Count = 28)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public uint byteOffset
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	internal uint effectiveBitOffset
	{
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "FinalizeControlHierarchyRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(int), typeof(InputControl[]), typeof(bool), typeof(bool), typeof(Int32&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "InsertControlBitRangeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlBitRangeNode&), typeof(InputControl), typeof(Int32&), typeof(ushort)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "GetBestMidPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlBitRangeNode), typeof(ushort)}, ReturnType = typeof(ushort))]
		[CallerCount(Count = 26)]
		internal get { } //Length: 73
	}

	internal uint effectiveByteOffset
	{
		[CalledBy(Type = typeof(InputControlExtensions), Member = "GetStatePtrFromStateEventUnchecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr), typeof(FourCC)}, ReturnType = typeof(Void*))]
		[CallerCount(Count = 1)]
		internal get { } //Length: 73
	}

	public FourCC format
	{
		[CallerCount(Count = 173)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 3
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	public uint sizeInBits
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	private static InputStateBlock() { }

	[CalledBy(Type = typeof(InputManager), Member = "InitializeDefaultState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "InitializeDeviceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void CopyToFrom(Void* toStatePtr, Void* fromStatePtr) { }

	[CalledBy(Type = typeof(AxisControl), Member = "FinishSetup", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberHelpers), Member = "NormalizedFloatToUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(NumberHelpers), Member = "NormalizedFloatToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	internal PrimitiveValue FloatToPrimitiveValue(float value) { }

	[CalledBy(Type = typeof(InputSystem), Member = "QueueDeltaStateEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelta"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), "TDelta", typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "WriteValueIntoState", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControl`1<TValue>", "TValue", "TState&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "CopyState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "GetStatePtrFromStateEventUnchecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr), typeof(FourCC)}, ReturnType = typeof(Void*))]
	[CalledBy(Type = typeof(InputDevice), Member = "get_valueSizeInBytes", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputDevice), Member = "ReadValueFromStateAsObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(InputDevice), Member = "ReadValueFromStateIntoBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDevice), Member = "CompareValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Touchscreen), Member = "UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputManager), Member = "ResetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeltaStateEvent), Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr&), typeof(Allocator)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.Byte>))]
	[CalledBy(Type = typeof(InputEventTrace), Member = "OnInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputState), Member = "Change", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), "TState&", typeof(InputUpdateType), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputStateBuffers), Member = "MigrateDoubleBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DoubleBuffers), typeof(InputDevice[]), typeof(int), typeof(DoubleBuffers)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputStateBuffers), Member = "MigrateSingleBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(InputDevice[]), typeof(int), typeof(Void*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "ComputeStateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	internal uint get_alignedSizeInBytes() { }

	[CallerCount(Count = 28)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public uint get_bitOffset() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public uint get_byteOffset() { }

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "FinalizeControlHierarchyRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(int), typeof(InputControl[]), typeof(bool), typeof(bool), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "InsertControlBitRangeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlBitRangeNode&), typeof(InputControl), typeof(Int32&), typeof(ushort)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "GetBestMidPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlBitRangeNode), typeof(ushort)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 26)]
	internal uint get_effectiveBitOffset() { }

	[CalledBy(Type = typeof(InputControlExtensions), Member = "GetStatePtrFromStateEventUnchecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr), typeof(FourCC)}, ReturnType = typeof(Void*))]
	[CallerCount(Count = 1)]
	internal uint get_effectiveByteOffset() { }

	[CallerCount(Count = 173)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public FourCC get_format() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public uint get_sizeInBits() { }

	[CalledBy(Type = typeof(InputControlLayout), Member = "CreateControlItemFromMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(InputControlAttribute)}, ReturnType = typeof(ControlItem))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	public static FourCC GetPrimitiveFormatFromType(Type type) { }

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "SetFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(ControlItem)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "ComputeStateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public static int GetSizeOfPrimitiveFormatInBits(FourCC type) { }

	[CalledBy(Type = typeof(DoubleControl), Member = "ReadUnprocessedValueFromState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(double))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberHelpers), Member = "UIntToNormalizedFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MemoryHelpers), Member = "ReadMultipleBitsAsNormalizedUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint), typeof(uint)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MemoryHelpers), Member = "ReadSingleBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public double ReadDouble(Void* statePtr) { }

	[CalledBy(Type = typeof(AxisControl), Member = "ReadUnprocessedValueFromState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberHelpers), Member = "UIntToNormalizedFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MemoryHelpers), Member = "ReadMultipleBitsAsNormalizedUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint), typeof(uint)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MemoryHelpers), Member = "ReadSingleBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public float ReadFloat(Void* statePtr) { }

	[CalledBy(Type = typeof(IntegerControl), Member = "ReadUnprocessedValueFromState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TouchPhaseControl), Member = "ReadUnprocessedValueFromState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(TouchPhase))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MemoryHelpers), Member = "ReadExcessKMultipleBitsAsInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint), typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MemoryHelpers), Member = "ReadSingleBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MemoryHelpers), Member = "ReadMultipleBitsAsUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public int ReadInt(Void* statePtr) { }

	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_bitOffset(uint value) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public void set_byteOffset(uint value) { }

	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_format(FourCC value) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_sizeInBits(uint value) { }

	[CalledBy(Type = typeof(InputManager), Member = "InitializeDefaultState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "InitializeDeviceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MemoryHelpers), Member = "WriteIntAsExcessKMultipleBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint), typeof(uint), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PrimitiveValue), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MemoryHelpers), Member = "WriteUIntAsMultipleBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PrimitiveValue), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MemoryHelpers), Member = "WriteSingleBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 8)]
	public void Write(Void* statePtr, PrimitiveValue value) { }

	[CalledBy(Type = typeof(DoubleControl), Member = "WriteValueIntoState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(Void*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberHelpers), Member = "NormalizedFloatToUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(MemoryHelpers), Member = "WriteNormalizedUIntAsMultipleBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint), typeof(uint), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MemoryHelpers), Member = "WriteSingleBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public void WriteDouble(Void* statePtr, double value) { }

	[CalledBy(Type = typeof(AxisControl), Member = "WriteValueIntoState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Void*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberHelpers), Member = "NormalizedFloatToUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(MemoryHelpers), Member = "WriteNormalizedUIntAsMultipleBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint), typeof(uint), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MemoryHelpers), Member = "WriteSingleBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public void WriteFloat(Void* statePtr, float value) { }

	[CalledBy(Type = typeof(IntegerControl), Member = "WriteValueIntoState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Void*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MemoryHelpers), Member = "WriteIntAsExcessKMultipleBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint), typeof(uint), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MemoryHelpers), Member = "WriteSingleBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MemoryHelpers), Member = "WriteUIntAsMultipleBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public void WriteInt(Void* statePtr, int value) { }

}


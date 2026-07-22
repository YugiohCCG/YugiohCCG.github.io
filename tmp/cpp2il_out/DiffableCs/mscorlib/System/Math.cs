namespace System;

public static class Math
{
	private static double doubleRoundLimit; //Field offset: 0x0
	private static Double[] roundPower10Double; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static Math() { }

	[CallerCount(Count = 0)]
	public static float Abs(float value) { }

	[CallerCount(Count = 0)]
	public static double Abs(double value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static int Abs(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decimal), Member = "Abs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&)}, ReturnType = typeof(Decimal))]
	public static decimal Abs(decimal value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static sbyte Abs(sbyte value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static long Abs(long value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static double Acos(double d) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static double Asin(double d) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static double Atan(double d) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static double Atan2(double y, double x) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static double Ceiling(double a) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "ThrowMinMaxException", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	public static float Clamp(float value, float min, float max) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "ThrowMinMaxException", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(void))]
	public static int Clamp(int value, int min, int max) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static double Cos(double d) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static double Cosh(double value) { }

	[CalledBy(Type = "System.Net.IPAddressParser", Member = "IPv4AddressToStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), "System.Char*"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.IPAddressParser", Member = "FormatIPv4AddressNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Char*", typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static int DivRem(int a, int b, out int result) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static double Exp(double d) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static double Floor(double d) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static double Log(double d) { }

	[CallerCount(Count = 49)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static double Log(double a, double newBase) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static double Log10(double d) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decimal), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(Decimal&))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static decimal Max(decimal val1, decimal val2) { }

	[CalledBy(Type = "System.Data.Common.UInt64Storage", Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "System.Data.AggregateType"}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[CLSCompliant(False)]
	[NonVersionable]
	public static ulong Max(ulong val1, ulong val2) { }

	[CalledBy(Type = "Unity.Burst.Intrinsics.X86+Sse4_1", Member = "max_epu16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Burst.Intrinsics.v128", "Unity.Burst.Intrinsics.v128"}, ReturnType = "Unity.Burst.Intrinsics.v128")]
	[CallerCount(Count = 1)]
	[CLSCompliant(False)]
	[NonVersionable]
	public static ushort Max(ushort val1, ushort val2) { }

	[CallerCount(Count = 58)]
	[ContainsUnimplementedInstructions]
	public static float Max(float val1, float val2) { }

	[CalledBy(Type = "Unity.Burst.Intrinsics.X86+Sse4_1", Member = "max_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Burst.Intrinsics.v128", "Unity.Burst.Intrinsics.v128"}, ReturnType = "Unity.Burst.Intrinsics.v128")]
	[CallerCount(Count = 1)]
	[CLSCompliant(False)]
	[NonVersionable]
	public static sbyte Max(sbyte val1, sbyte val2) { }

	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.InputEventTrace", Member = "OnInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.LowLevel.InputEventPtr", "UnityEngine.InputSystem.InputDevice"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "CalculateIntDragSensitivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(long)}, ReturnType = typeof(long))]
	[CalledBy(Type = "System.Data.Common.Int64Storage", Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "System.Data.AggregateType"}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[NonVersionable]
	public static long Max(long val1, long val2) { }

	[CallerCount(Count = 210)]
	[NonVersionable]
	public static int Max(int val1, int val2) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.InclusiveRange", Member = "Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.InclusiveRange", Member = "Clamp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(short)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.InclusiveRange", Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.InclusiveRange", "UnityEngine.Rendering.Universal.InclusiveRange"}, ReturnType = "UnityEngine.Rendering.Universal.InclusiveRange")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TilingJob", Member = "TileLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TilingJob", Member = "TileLightOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TilingJob", Member = "TileReflectionProbe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Burst.Intrinsics.X86+Sse2", Member = "max_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Burst.Intrinsics.v128", "Unity.Burst.Intrinsics.v128"}, ReturnType = "Unity.Burst.Intrinsics.v128")]
	[CallerCount(Count = 7)]
	[NonVersionable]
	public static short Max(short val1, short val2) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Controls.ButtonControl", Member = "IsValueConsideredPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.NumberHelpers", Member = "Approximately", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Mathf", Member = "GetNumberOfDecimalsForMinimumDifference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Mathf", Member = "RoundBasedOnMinimumDifference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[CalledBy(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "CalculateFloatDragSensitivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(double))]
	[CalledBy(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "CalculateIntDragSensitivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(double))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.MathUtils", Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<Double>", "System.Nullable`1<Double>"}, ReturnType = "System.Nullable`1<Double>")]
	[CalledBy(Type = "System.Data.Common.DoubleStorage", Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "System.Data.AggregateType"}, ReturnType = typeof(object))]
	[CalledBy(Type = "Unity.Burst.Intrinsics.X86+Sse2", Member = "max_sd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Burst.Intrinsics.v128", "Unity.Burst.Intrinsics.v128"}, ReturnType = "Unity.Burst.Intrinsics.v128")]
	[CalledBy(Type = "Unity.Burst.Intrinsics.X86+Sse2", Member = "max_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Burst.Intrinsics.v128", "Unity.Burst.Intrinsics.v128"}, ReturnType = "Unity.Burst.Intrinsics.v128")]
	[CallerCount(Count = 13)]
	[ContainsUnimplementedInstructions]
	public static double Max(double val1, double val2) { }

	[CalledBy(Type = "System.Data.SqlTypes.SqlDecimal", Member = "CalculatePrecision", ReturnType = typeof(byte))]
	[CalledBy(Type = "Unity.Burst.Intrinsics.X86+Sse2", Member = "max_epu8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Burst.Intrinsics.v128", "Unity.Burst.Intrinsics.v128"}, ReturnType = "Unity.Burst.Intrinsics.v128")]
	[CallerCount(Count = 2)]
	[NonVersionable]
	public static byte Max(byte val1, byte val2) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.MeshHandle", typeof(uint), typeof(uint), "Unity.Collections.NativeSlice`1<Vertex>&", "Unity.Collections.NativeSlice`1<UInt16>&", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.Page+DataSet`1", Member = "RegisterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputDevice", Member = "WritePartialChangedControlStatesInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), "UnityEngine.InputSystem.InputDevice+ControlBitRangeNode", typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.InputStateHistory", Member = "Allocate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.MemoryHelpers+BitRegion", Member = "Overlap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.MemoryHelpers+BitRegion"}, ReturnType = "UnityEngine.InputSystem.Utilities.MemoryHelpers+BitRegion")]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourcesData", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Burst.Intrinsics.X86+Sse4_1", Member = "max_epu32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Burst.Intrinsics.v128", "Unity.Burst.Intrinsics.v128"}, ReturnType = "Unity.Burst.Intrinsics.v128")]
	[CallerCount(Count = 12)]
	[CLSCompliant(False)]
	[NonVersionable]
	public static uint Max(uint val1, uint val2) { }

	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = "RunSchedulerLoop", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "ReadCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Stream), Member = "GetCopyBufferSize", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputControlExtensions", Member = "CopyState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputDevice", "System.Void*", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.StateEvent", Member = "GetState", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, ReturnType = "TState")]
	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.InputState", Member = "Change", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControl", "TState&", "UnityEngine.InputSystem.LowLevel.InputUpdateType", "UnityEngine.InputSystem.LowLevel.InputEventPtr"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FixedSizeReadStream+<ProcessReadAsync>d__5", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpListenerRequest", Member = "FlushInput", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.RequestStream", Member = "FillFromBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.RequestStream", Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Data.Common.Int64Storage", Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "System.Data.AggregateType"}, ReturnType = typeof(object))]
	[CalledBy(Type = "UnityEngine.Collision", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.ContactPairHeader&", "UnityEngine.ContactPair&", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.ContactPair", Member = "ExtractContactsArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.ContactPoint[]", typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 13)]
	[NonVersionable]
	public static long Min(long val1, long val2) { }

	[CalledBy(Type = "System.Data.Common.UInt64Storage", Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "System.Data.AggregateType"}, ReturnType = typeof(object))]
	[CalledBy(Type = "Unity.Burst.Intrinsics.X86+Sse2", Member = "sll_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Burst.Intrinsics.v128", "Unity.Burst.Intrinsics.v128"}, ReturnType = "Unity.Burst.Intrinsics.v128")]
	[CalledBy(Type = "Unity.Burst.Intrinsics.X86+Sse2", Member = "sll_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Burst.Intrinsics.v128", "Unity.Burst.Intrinsics.v128"}, ReturnType = "Unity.Burst.Intrinsics.v128")]
	[CalledBy(Type = "Unity.Burst.Intrinsics.X86+Sse2", Member = "sll_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Burst.Intrinsics.v128", "Unity.Burst.Intrinsics.v128"}, ReturnType = "Unity.Burst.Intrinsics.v128")]
	[CalledBy(Type = "Unity.Burst.Intrinsics.X86+Sse2", Member = "sra_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Burst.Intrinsics.v128", "Unity.Burst.Intrinsics.v128"}, ReturnType = "Unity.Burst.Intrinsics.v128")]
	[CalledBy(Type = "Unity.Burst.Intrinsics.X86+Sse2", Member = "sra_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Burst.Intrinsics.v128", "Unity.Burst.Intrinsics.v128"}, ReturnType = "Unity.Burst.Intrinsics.v128")]
	[CalledBy(Type = "Unity.Burst.Intrinsics.X86+Sse2", Member = "srl_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Burst.Intrinsics.v128", "Unity.Burst.Intrinsics.v128"}, ReturnType = "Unity.Burst.Intrinsics.v128")]
	[CalledBy(Type = "Unity.Burst.Intrinsics.X86+Sse2", Member = "srl_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Burst.Intrinsics.v128", "Unity.Burst.Intrinsics.v128"}, ReturnType = "Unity.Burst.Intrinsics.v128")]
	[CalledBy(Type = "Unity.Burst.Intrinsics.X86+Sse2", Member = "srl_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Burst.Intrinsics.v128", "Unity.Burst.Intrinsics.v128"}, ReturnType = "Unity.Burst.Intrinsics.v128")]
	[CallerCount(Count = 9)]
	[CLSCompliant(False)]
	[NonVersionable]
	public static ulong Min(ulong val1, ulong val2) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.MeshHandle", typeof(uint), typeof(uint), "Unity.Collections.NativeSlice`1<Vertex>&", "Unity.Collections.NativeSlice`1<UInt16>&", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.Page+DataSet`1", Member = "RegisterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.Page", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(uint), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputDevice", Member = "WritePartialChangedControlStatesInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), "UnityEngine.InputSystem.InputDevice+ControlBitRangeNode", typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.MemoryHelpers+BitRegion", Member = "Overlap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.MemoryHelpers+BitRegion"}, ReturnType = "UnityEngine.InputSystem.Utilities.MemoryHelpers+BitRegion")]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.MemoryHelpers", Member = "AlignNatural", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[CalledBy(Type = "System.Net.TimerThread", Member = "ThreadProc", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Texture2DAtlas", Member = "NeedsUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Texture", "UnityEngine.Texture", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUSort", Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.CommandBuffer", "UnityEngine.Rendering.GPUSort+Args"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Burst.Intrinsics.X86+Sse4_1", Member = "min_epu32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Burst.Intrinsics.v128", "Unity.Burst.Intrinsics.v128"}, ReturnType = "Unity.Burst.Intrinsics.v128")]
	[CallerCount(Count = 13)]
	[CLSCompliant(False)]
	[NonVersionable]
	public static uint Min(uint val1, uint val2) { }

	[CalledBy(Type = "Unity.Burst.Intrinsics.X86+Sse4_1", Member = "min_epu16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Burst.Intrinsics.v128", "Unity.Burst.Intrinsics.v128"}, ReturnType = "Unity.Burst.Intrinsics.v128")]
	[CallerCount(Count = 1)]
	[CLSCompliant(False)]
	[NonVersionable]
	public static ushort Min(ushort val1, ushort val2) { }

	[CallerCount(Count = 57)]
	[ContainsUnimplementedInstructions]
	public static float Min(float val1, float val2) { }

	[CalledBy(Type = "Unity.Burst.Intrinsics.X86+Sse4_1", Member = "min_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Burst.Intrinsics.v128", "Unity.Burst.Intrinsics.v128"}, ReturnType = "Unity.Burst.Intrinsics.v128")]
	[CallerCount(Count = 1)]
	[CLSCompliant(False)]
	[NonVersionable]
	public static sbyte Min(sbyte val1, sbyte val2) { }

	[CallerCount(Count = 244)]
	[NonVersionable]
	public static int Min(int val1, int val2) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.InclusiveRange", Member = "Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.InclusiveRange", Member = "Clamp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(short)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.InclusiveRange", Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.InclusiveRange", "UnityEngine.Rendering.Universal.InclusiveRange"}, ReturnType = "UnityEngine.Rendering.Universal.InclusiveRange")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TilingJob", Member = "TileLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TilingJob", Member = "TileLightOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TilingJob", Member = "TileReflectionProbe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "ZXing.Aztec.Internal.BinaryShiftToken", Member = "appendTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ZXing.Common.BitArray", "System.Byte[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Burst.Intrinsics.X86+Sse2", Member = "min_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Burst.Intrinsics.v128", "Unity.Burst.Intrinsics.v128"}, ReturnType = "Unity.Burst.Intrinsics.v128")]
	[CallerCount(Count = 8)]
	[NonVersionable]
	public static short Min(short val1, short val2) { }

	[CalledBy(Type = "System.Data.Common.DoubleStorage", Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "System.Data.AggregateType"}, ReturnType = typeof(object))]
	[CalledBy(Type = "Unity.Burst.Intrinsics.X86+Sse2", Member = "min_sd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Burst.Intrinsics.v128", "Unity.Burst.Intrinsics.v128"}, ReturnType = "Unity.Burst.Intrinsics.v128")]
	[CalledBy(Type = "Unity.Burst.Intrinsics.X86+Sse2", Member = "min_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Burst.Intrinsics.v128", "Unity.Burst.Intrinsics.v128"}, ReturnType = "Unity.Burst.Intrinsics.v128")]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static double Min(double val1, double val2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decimal), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(Decimal&))]
	public static decimal Min(decimal val1, decimal val2) { }

	[CalledBy(Type = "Scenes.Battle.ManualStatus", Member = "OnConfirm", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.ManualDuel+<OnDraw>d__39", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.ManualDuel+<OnTossCoin>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.ManualDuel+<OnTossDice>d__41", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Burst.Intrinsics.X86+Sse2", Member = "min_epu8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Burst.Intrinsics.v128", "Unity.Burst.Intrinsics.v128"}, ReturnType = "Unity.Burst.Intrinsics.v128")]
	[CallerCount(Count = 5)]
	[NonVersionable]
	public static byte Min(byte val1, byte val2) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static double ModF(double x, Double* intptr) { }

	[CallerCount(Count = 62)]
	[CallsUnknownMethods(Count = 1)]
	public static double Pow(double x, double y) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	public static double Round(double value, int digits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decimal), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int)}, ReturnType = typeof(Decimal))]
	public static decimal Round(decimal d) { }

	[CalledBy(Type = "UnityEngine.TextCore.LowLevel.FontEngine", Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(int)}, ReturnType = "UnityEngine.TextCore.LowLevel.FontEngineError")]
	[CalledBy(Type = "UnityEngine.CharacterInfo", Member = "get_advance", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextCore.LowLevel.FontEngine", Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float)}, ReturnType = "UnityEngine.TextCore.LowLevel.FontEngineError")]
	[CalledBy(Type = "UnityEngine.TextCore.LowLevel.FontEngine", Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Font", typeof(float), typeof(int)}, ReturnType = "UnityEngine.TextCore.LowLevel.FontEngineError")]
	[CalledBy(Type = "Unity.Burst.Intrinsics.X86+Sse", Member = "cvt_ss2si", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Burst.Intrinsics.v128"}, ReturnType = typeof(int))]
	[CalledBy(Type = "Unity.Burst.Intrinsics.X86+Sse", Member = "cvtss_si32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Burst.Intrinsics.v128"}, ReturnType = typeof(int))]
	[CalledBy(Type = "Unity.Burst.Intrinsics.X86+Sse", Member = "cvtss_si64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Burst.Intrinsics.v128"}, ReturnType = typeof(long))]
	[CalledBy(Type = "UnityEngine.Mathf", Member = "DiscardLeastSignificantDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(double))]
	[CalledBy(Type = "UnityEngine.Mathf", Member = "RoundBasedOnMinimumDifference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[CalledBy(Type = "UnityEngine.UIElements.Slider", Member = "SliderLerpUnclamped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Math), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(MidpointRounding)}, ReturnType = typeof(double))]
	[CalledBy(Type = "ZXing.Rendering.SvgRenderer+SvgImage", Member = "ConvertAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Color32"}, ReturnType = typeof(double))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(ArithmeticException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 20)]
	[ContainsUnimplementedInstructions]
	public static double Round(double value, int digits, MidpointRounding mode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(MidpointRounding)}, ReturnType = typeof(double))]
	public static double Round(double value, MidpointRounding mode) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static double Round(double a) { }

	[CalledBy(Type = "Spine.ScaleTimeline", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skeleton", typeof(float), typeof(float), "Spine.ExposedList`1<Event>", typeof(float), "Spine.MixBlend", "Spine.MixDirection"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.ScaleXTimeline", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skeleton", typeof(float), typeof(float), "Spine.ExposedList`1<Event>", typeof(float), "Spine.MixBlend", "Spine.MixDirection"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.ScaleYTimeline", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skeleton", typeof(float), typeof(float), "Spine.ExposedList`1<Event>", typeof(float), "Spine.MixBlend", "Spine.MixDirection"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.AnimationState", Member = "ApplyRotateTimeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.RotateTimeline", "Spine.Skeleton", typeof(float), typeof(float), "Spine.MixBlend", "System.Single[]", typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(ArithmeticException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static int Sign(float value) { }

	[CalledBy(Type = "System.Threading.Timer+TimerComparer", Member = "System.Collections.IComparer.Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Threading.Timer+TimerComparer", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Timer), typeof(Timer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	public static int Sign(long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArithmeticException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static int Sign(double value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static double Sin(double a) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static double Sinh(double value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static double Sqrt(double d) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static double Tan(double a) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static double Tanh(double value) { }

	[CallerCount(Count = 42)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[StackTraceHidden]
	private static void ThrowAbsOverflow() { }

	[CalledBy(Type = "Game.Local.LocalGame+<WritePublicCards>d__200", Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.ManualDuel", Member = "MoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"CardData&", typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Math), Member = "Clamp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerObjectList", Member = "UpdateValueLabel", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "CalculateSplitEventRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", "UnityEngine.Rendering.Universal.RenderPassEvent", "UnityEngine.Rendering.Universal.RenderPassEvent&", "UnityEngine.Rendering.Universal.RenderPassEvent&", "UnityEngine.Rendering.Universal.RenderPassEvent&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private static void ThrowMinMaxException(T min, T max) { }

	[CallerCount(Count = 44)]
	[CallsUnknownMethods(Count = 1)]
	public static double Truncate(double d) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decimal), Member = "Truncate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(Decimal))]
	public static decimal Truncate(decimal d) { }

}


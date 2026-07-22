namespace System;

[ComVisible(True)]
[IsReadOnly]
public struct IntPtr : ISerializable, IEquatable<IntPtr>
{
	public static readonly IntPtr Zero; //Field offset: 0x0
	private readonly Void* m_value; //Field offset: 0x0

	public static int Size
	{
		[CallerCount(Count = 19)]
		[DeduplicatedMethod]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		 get { } //Length: 6
	}

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	public IntPtr(int value) { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	public IntPtr(long value) { }

	[CallerCount(Count = 26)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	public IntPtr(Void* value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[CallsUnknownMethods(Count = 1)]
	private IntPtr(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 68)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	public static IntPtr Add(IntPtr pointer, int offset) { }

	[CalledBy(Type = "UnityEngine.AnimationCurve", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.AnimationCurve", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AnimationCurve"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Gradient", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Gradient", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Gradient"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.CullingResults", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.CullingResults"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.CullingResults", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.CullingResults", Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.CullingResults", "UnityEngine.Rendering.CullingResults"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.RendererListParams", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RendererListParams"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.ScriptableRenderContext", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ScriptableRenderContext"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.ScriptableRenderContext", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.ShadowDrawingSettings", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ShadowDrawingSettings"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 19)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static int get_Size() { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 13)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	internal bool IsNull() { }

	[CallerCount(Count = 68)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	public static IntPtr op_Addition(IntPtr pointer, int offset) { }

	[CallerCount(Count = 1987)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static bool op_Equality(IntPtr value1, IntPtr value2) { }

	[CallerCount(Count = 2063)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	public static IntPtr op_Explicit(Void* value) { }

	[CallerCount(Count = 2063)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public static Void* op_Explicit(IntPtr value) { }

	[CallerCount(Count = 207)]
	[DeduplicatedMethod]
	public static long op_Explicit(IntPtr value) { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	public static IntPtr op_Explicit(int value) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	public static IntPtr op_Explicit(long value) { }

	[CallerCount(Count = 19)]
	[DeduplicatedMethod]
	public static int op_Explicit(IntPtr value) { }

	[CallerCount(Count = 544)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static bool op_Inequality(IntPtr value1, IntPtr value2) { }

	[CalledBy(Type = typeof(SpanHelpers), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(byte), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(Byte&), typeof(ulong)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SpanHelpers), Member = "SequenceCompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(int), typeof(Char&), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	public static IntPtr op_Subtraction(IntPtr pointer, int offset) { }

	[CallerCount(Count = 9)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private override bool System.IEquatable<System.IntPtr>.Equals(IntPtr other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public int ToInt32() { }

	[CallerCount(Count = 223)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public long ToInt64() { }

	[CallerCount(Count = 138)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public Void* ToPointer() { }

	[CalledBy(Type = typeof(ValueTuple`5), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ValueTuple`5), Member = "System.IValueTupleInternal.ToStringEnd", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "System.IValueTupleInternal.ToStringEnd", ReturnType = typeof(string))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(long), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(long), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public string ToString(string format) { }

}


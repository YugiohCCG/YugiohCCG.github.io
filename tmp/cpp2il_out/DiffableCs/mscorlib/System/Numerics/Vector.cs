namespace System.Numerics;

[Intrinsic]
public static class Vector
{

	public static bool IsHardwareAccelerated
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		[Intrinsic]
		 get { } //Length: 3
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector`1), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.Vector`1<T>"}, ReturnType = typeof(System.Numerics.Vector`1<System.UInt64>))]
	[CallsUnknownMethods(Count = 2)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public static Vector<UInt64> AsVectorUInt64(Vector<T> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static Vector<T> Equals(Vector<T> left, Vector<T> right) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	[Intrinsic]
	public static bool get_IsHardwareAccelerated() { }

}


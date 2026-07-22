namespace System;

public static class Tuple
{

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal static int CombineHashCodes(int h1, int h2) { }

	[CalledBy(Type = typeof(Tuple`3), Member = "System.Collections.IStructuralEquatable.GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	internal static int CombineHashCodes(int h1, int h2, int h3) { }

	[CalledBy(Type = typeof(Tuple`4), Member = "System.Collections.IStructuralEquatable.GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4) { }

	[CalledBy(Type = typeof(TextReader), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Char>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CalledBy(Type = typeof(TextWriter), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Char>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static Tuple<T1, T2> Create(T1 item1, T2 item2) { }

	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "ReceiveAsyncApm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Memory`1<Byte>", "System.Net.Sockets.SocketFlags"}, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Tuple`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static Tuple<T1, T2, T3> Create(T1 item1, T2 item2, T3 item3) { }

}


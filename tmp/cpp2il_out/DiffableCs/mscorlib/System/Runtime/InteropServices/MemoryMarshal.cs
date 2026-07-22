namespace System.Runtime.InteropServices;

public static class MemoryMarshal
{

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static Span<Byte> AsBytes(Span<T> span) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static ReadOnlySpan<Byte> AsBytes(ReadOnlySpan<T> span) { }

	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	public static Memory<T> AsMemory(ReadOnlyMemory<T> memory) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static ReadOnlySpan<T> CreateReadOnlySpan(ref T reference, int length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static T GetNonNullPinnableReference(Span<T> span) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static T GetNonNullPinnableReference(ReadOnlySpan<T> span) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public static T GetReference(Span<T> span) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public static T GetReference(ReadOnlySpan<T> span) { }

	[CalledBy(Type = typeof(MemoryStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CalledBy(Type = typeof(MemoryStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CalledBy(Type = typeof(TextReader), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Char>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CalledBy(Type = typeof(TextWriter), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Char>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CalledBy(Type = typeof(Stream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CalledBy(Type = typeof(Stream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "ReceiveAsyncApm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Memory`1<Byte>", "System.Net.Sockets.SocketFlags"}, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "SendAsyncApm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlyMemory`1<Byte>", "System.Net.Sockets.SocketFlags"}, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool TryGetArray(ReadOnlyMemory<T> memory, out ArraySegment<T>& segment) { }

}


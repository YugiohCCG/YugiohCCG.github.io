namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(2)]
internal static class BufferUtils
{

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static Char[] EnsureBufferSize(IArrayPool<Char> bufferPool, int size, Char[] buffer) { }

	[CallerCount(Count = 23)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(1)]
	public static Char[] RentBuffer(IArrayPool<Char> bufferPool, int minSize) { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "PrepareBufferForReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter+<CloseBufferAndWriterAsync>d__9", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "EnsureWriteBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Char[]))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "CloseBufferAndWriter", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StringBuffer), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StringBuffer), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StringBuffer), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StringBuffer), Member = "EnsureSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 1)]
	public static void ReturnBuffer(IArrayPool<Char> bufferPool, Char[] buffer) { }

}


namespace Mono.Net.Security;

internal class BufferOffsetSize2 : BufferOffsetSize
{
	public readonly int InitialSize; //Field offset: 0x28

	[CalledBy(Type = typeof(UnityTlsProvider), Member = "CreateSslStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SslStream), typeof(Stream), typeof(bool), typeof(MonoTlsSettings)}, ReturnType = typeof(MobileAuthenticatedStream))]
	[CalledBy(Type = typeof(UnityTlsStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(SslStream), typeof(MonoTlsSettings), typeof(MobileTlsProvider)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MobileAuthenticatedStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(SslStream), typeof(MonoTlsSettings), typeof(MobileTlsProvider)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public BufferOffsetSize2(int size) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void AppendData(Byte[] buffer, int offset, int size) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void MakeRoom(int size) { }

	[CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream+<ProcessAuthentication>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream+<StartOperation>d__57", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "InternalWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncProtocolRequest), typeof(BufferOffsetSize2), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+ValueCollection", Member = "get_Count", ReturnType = typeof(int))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	public void Reset() { }

}


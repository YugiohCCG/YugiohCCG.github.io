namespace System.Diagnostics;

internal class AsyncStreamReader
{
	private Stream stream; //Field offset: 0x10
	private Encoding encoding; //Field offset: 0x18
	private Decoder decoder; //Field offset: 0x20
	private Byte[] byteBuffer; //Field offset: 0x28
	private Char[] charBuffer; //Field offset: 0x30
	private bool cancelOperation; //Field offset: 0x38
	private ManualResetEvent eofEvent; //Field offset: 0x40
	private object syncObject; //Field offset: 0x48
	private IAsyncResult asyncReadResult; //Field offset: 0x50

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void CancelOperation() { }

	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Close() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = "System.IO.MonoIO", Member = "Cancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(MonoIOError&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	protected override void Dispose(bool disposing) { }

}


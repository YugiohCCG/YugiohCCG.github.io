namespace System.Text;

internal sealed class InternalDecoderBestFitFallbackBuffer : DecoderFallbackBuffer
{
	private static object s_InternalSyncObject; //Field offset: 0x0
	private char _cBestFit; //Field offset: 0x20
	private int _iCount; //Field offset: 0x24
	private int _iSize; //Field offset: 0x28
	private InternalDecoderBestFitFallback _oFallback; //Field offset: 0x30

	private static object InternalSyncObject
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 146
	}

	public virtual int Remaining
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 13
	}

	[CalledBy(Type = typeof(InternalDecoderBestFitFallback), Member = "CreateFallbackBuffer", ReturnType = typeof(DecoderFallbackBuffer))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public InternalDecoderBestFitFallbackBuffer(InternalDecoderBestFitFallback fallback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InternalDecoderBestFitFallbackBuffer), Member = "TryBestFit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Fallback(Byte[] bytesUnknown, int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static object get_InternalSyncObject() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual int get_Remaining() { }

	[CallerCount(Count = 0)]
	public virtual char GetNextChar() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	internal virtual int InternalFallback(Byte[] bytes, Byte* pBytes) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual void Reset() { }

	[CalledBy(Type = typeof(InternalDecoderBestFitFallbackBuffer), Member = "Fallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private char TryBestFit(Byte[] bytesCheck) { }

}


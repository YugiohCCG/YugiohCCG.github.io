namespace System.Text;

internal sealed class InternalEncoderBestFitFallbackBuffer : EncoderFallbackBuffer
{
	private static object s_InternalSyncObject; //Field offset: 0x0
	private char _cBestFit; //Field offset: 0x30
	private InternalEncoderBestFitFallback _oFallback; //Field offset: 0x38
	private int _iCount; //Field offset: 0x40
	private int _iSize; //Field offset: 0x44

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
		 get { } //Length: 13
	}

	[CalledBy(Type = typeof(InternalEncoderBestFitFallback), Member = "CreateFallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public InternalEncoderBestFitFallbackBuffer(InternalEncoderBestFitFallback fallback) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool Fallback(char charUnknown, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public virtual bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static object get_InternalSyncObject() { }

	[CallerCount(Count = 0)]
	public virtual int get_Remaining() { }

	[CallerCount(Count = 0)]
	public virtual char GetNextChar() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public virtual bool MovePrevious() { }

	[CallerCount(Count = 0)]
	public virtual void Reset() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private char TryBestFit(char cUnknown) { }

}


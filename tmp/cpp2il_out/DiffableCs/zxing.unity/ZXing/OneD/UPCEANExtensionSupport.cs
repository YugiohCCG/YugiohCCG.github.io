namespace ZXing.OneD;

internal sealed class UPCEANExtensionSupport
{
	private static readonly Int32[] EXTENSION_START_PATTERN; //Field offset: 0x0
	private readonly UPCEANExtension2Support twoSupport; //Field offset: 0x10
	private readonly UPCEANExtension5Support fiveSupport; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static UPCEANExtensionSupport() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public UPCEANExtensionSupport() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UPCEANReader), Member = "findGuardPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(bool), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(UPCEANExtension5Support), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(Int32[])}, ReturnType = typeof(Result))]
	[Calls(Type = typeof(UPCEANExtension2Support), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(Int32[])}, ReturnType = typeof(Result))]
	[CallsUnknownMethods(Count = 1)]
	internal Result decodeRow(int rowNumber, BitArray row, int rowOffset) { }

}


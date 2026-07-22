namespace System.IO.Compression;

internal sealed class CopyEncoder
{

	[CalledBy(Type = typeof(DeflaterManaged), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DeflaterManaged), Member = "WriteFinal", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(OutputBuffer), Member = "WriteBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void GetBlock(DeflateInput input, OutputBuffer output, bool isFinal) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void WriteLenNLen(ushort len, OutputBuffer output) { }

}


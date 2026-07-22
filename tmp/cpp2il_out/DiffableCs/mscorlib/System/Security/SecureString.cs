namespace System.Security;

[MonoTODO("work in progress - encryption is missing")]
public sealed class SecureString : IDisposable
{
	private int length; //Field offset: 0x10
	private bool disposed; //Field offset: 0x14
	private Byte[] data; //Field offset: 0x18

	public int Length
	{
		[CalledBy(Type = typeof(Marshal), Member = "SecureStringToBSTR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString)}, ReturnType = typeof(IntPtr))]
		[CalledBy(Type = typeof(Marshal), Member = "SecureStringToUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString), typeof(SecureStringAllocator)}, ReturnType = typeof(IntPtr))]
		[CalledBy(Type = "System.Net.UnsafeNclNativeMethods+SecureStringHelper", Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString)}, ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 100
	}

	[CalledBy(Type = "System.Net.UnsafeNclNativeMethods+SecureStringHelper", Member = "CreateSecureString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SecureString))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public SecureString() { }

	[CalledBy(Type = "System.Net.UnsafeNclNativeMethods+SecureStringHelper", Member = "CreateSecureString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SecureString))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SecureString), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[CLSCompliant(False)]
	public SecureString(Char* value, int length) { }

	[CalledBy(Type = typeof(SecureString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private void Alloc(int length, bool realloc) { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void Decrypt() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void Dispose() { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void Encrypt() { }

	[CalledBy(Type = typeof(Marshal), Member = "SecureStringToBSTR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(Marshal), Member = "SecureStringToUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString), typeof(SecureStringAllocator)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = "System.Net.UnsafeNclNativeMethods+SecureStringHelper", Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public int get_Length() { }

	[CalledBy(Type = typeof(Marshal), Member = "SecureStringToBSTR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(Marshal), Member = "SecureStringToUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString), typeof(SecureStringAllocator)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal Byte[] GetBuffer() { }

}


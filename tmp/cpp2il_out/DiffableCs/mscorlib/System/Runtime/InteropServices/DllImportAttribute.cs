namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets::Method (64), Inherited = False)]
[ComVisible(True)]
public sealed class DllImportAttribute : Attribute
{
	internal string _val; //Field offset: 0x10
	public string EntryPoint; //Field offset: 0x18
	public CharSet CharSet; //Field offset: 0x20
	public bool SetLastError; //Field offset: 0x24
	public bool ExactSpelling; //Field offset: 0x25
	public bool PreserveSig; //Field offset: 0x26
	public CallingConvention CallingConvention; //Field offset: 0x28
	public bool BestFitMapping; //Field offset: 0x2C
	public bool ThrowOnUnmappableChar; //Field offset: 0x2D

	public string Value
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal DllImportAttribute(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar) { }

	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public DllImportAttribute(string dllName) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_Value() { }

	[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(Object[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeMethodInfo), Member = "GetPInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PInvokeAttributes&), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	internal static Attribute GetCustomAttribute(RuntimeMethodInfo method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool IsDefined(RuntimeMethodInfo method) { }

}


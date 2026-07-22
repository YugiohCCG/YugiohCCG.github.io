namespace System;

internal class ByteMatcher
{
	private Hashtable map; //Field offset: 0x10
	private Hashtable starts; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public ByteMatcher() { }

	[CalledBy(Type = typeof(TermInfoDriver), Member = "InitKeys", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "AddStringMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TermInfoStrings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void AddMapping(TermInfoStrings key, Byte[] val) { }

	[CalledBy(Type = typeof(TermInfoDriver), Member = "GetKeyFromBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 20)]
	public TermInfoStrings Match(Char[] buffer, int offset, int length, out int used) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public void Sort() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool StartsWith(int c) { }

}


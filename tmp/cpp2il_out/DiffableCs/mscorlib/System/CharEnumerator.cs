namespace System;

public sealed class CharEnumerator : IEnumerator, IEnumerator<Char>, IDisposable, ICloneable
{
	private string _str; //Field offset: 0x10
	private int _index; //Field offset: 0x18
	private char _currentElement; //Field offset: 0x1C

	public override char Current
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 9)]
		 get { } //Length: 194
	}

	private override object System.Collections.IEnumerator.Current
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 9)]
		private get { } //Length: 216
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal CharEnumerator(string str) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal CharEnumerator() { }

	[CallerCount(Count = 113)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override object Clone() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public override char get_Current() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	public override bool MoveNext() { }

	[CallerCount(Count = 0)]
	public override void Reset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	private override object System.Collections.IEnumerator.get_Current() { }

}


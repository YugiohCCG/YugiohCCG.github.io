namespace System;

public abstract class FormattableString : IFormattable
{

	public abstract int ArgumentCount
	{
		 get { } //Length: 0
	}

	public abstract string Format
	{
		 get { } //Length: 0
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected FormattableString() { }

	public abstract int get_ArgumentCount() { }

	public abstract string get_Format() { }

	public abstract object GetArgument(int index) { }

	public abstract Object[] GetArguments() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private override string System.IFormattable.ToString(string ignored, IFormatProvider formatProvider) { }

	public abstract string ToString(IFormatProvider formatProvider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual string ToString() { }

}


namespace System.Dynamic.Utils;

internal sealed class ListArgumentProvider : ListProvider<Expression>
{
	private readonly IArgumentProvider _provider; //Field offset: 0x10
	private readonly Expression _arg0; //Field offset: 0x18

	protected virtual int ElementCount
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 73
	}

	protected virtual Expression First
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal ListArgumentProvider(IArgumentProvider provider, Expression arg0) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual int get_ElementCount() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	protected virtual Expression get_First() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual Expression GetElement(int index) { }

}


namespace NGettext.Plural;

public sealed class PluralRuleEvaluatorDelegate : MulticastDelegate
{

	[CallerCount(Count = 21)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public PluralRuleEvaluatorDelegate(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override IAsyncResult BeginInvoke(long number, AsyncCallback callback, object object) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override int EndInvoke(IAsyncResult result) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override int Invoke(long number) { }

}


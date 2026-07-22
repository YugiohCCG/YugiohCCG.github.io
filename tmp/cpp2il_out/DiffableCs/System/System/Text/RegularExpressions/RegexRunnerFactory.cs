namespace System.Text.RegularExpressions;

public abstract class RegexRunnerFactory
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected RegexRunnerFactory() { }

	protected private abstract RegexRunner CreateInstance() { }

}


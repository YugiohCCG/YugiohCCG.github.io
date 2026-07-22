namespace Newtonsoft.Json;

public abstract class JsonNameTable
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected JsonNameTable() { }

	[NullableContext(1)]
	public abstract string Get(Char[] key, int start, int length) { }

}


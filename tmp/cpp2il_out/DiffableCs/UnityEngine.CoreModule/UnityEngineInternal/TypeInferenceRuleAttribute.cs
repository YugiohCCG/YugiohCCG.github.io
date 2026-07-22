namespace UnityEngineInternal;

[AttributeUsage(AttributeTargets::Method (64))]
public class TypeInferenceRuleAttribute : Attribute
{
	private readonly string _rule; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public TypeInferenceRuleAttribute(TypeInferenceRules rule) { }

	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public TypeInferenceRuleAttribute(string rule) { }

	[CallerCount(Count = 206)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}


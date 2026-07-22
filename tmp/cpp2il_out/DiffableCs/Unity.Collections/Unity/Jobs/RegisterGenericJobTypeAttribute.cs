namespace Unity.Jobs;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = True)]
[MovedFrom(True, "Unity.Entities", "Unity.Entities", null)]
public class RegisterGenericJobTypeAttribute : Attribute
{
	public Type ConcreteType; //Field offset: 0x10

	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public RegisterGenericJobTypeAttribute(Type type) { }

}


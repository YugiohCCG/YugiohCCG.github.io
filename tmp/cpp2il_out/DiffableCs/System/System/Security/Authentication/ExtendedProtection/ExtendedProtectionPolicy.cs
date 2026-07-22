namespace System.Security.Authentication.ExtendedProtection;

[MonoTODO]
[TypeConverter(typeof(ExtendedProtectionPolicyTypeConverter))]
public class ExtendedProtectionPolicy : ISerializable
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MonoTODO("Not implemented.")]
	public ExtendedProtectionPolicy(PolicyEnforcement policyEnforcement) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected ExtendedProtectionPolicy(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "ToString", ReturnType = typeof(string))]
	[DeduplicatedMethod]
	[MonoTODO]
	public virtual string ToString() { }

}


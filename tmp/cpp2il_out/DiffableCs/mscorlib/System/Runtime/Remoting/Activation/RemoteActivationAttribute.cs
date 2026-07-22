namespace System.Runtime.Remoting.Activation;

internal class RemoteActivationAttribute : Attribute, IContextAttribute
{
	private IList _contextProperties; //Field offset: 0x10

	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public RemoteActivationAttribute(IList contextProperties) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public override void GetPropertiesForNewContext(IConstructionCallMessage ctor) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool IsContextOK(Context ctx, IConstructionCallMessage ctor) { }

}


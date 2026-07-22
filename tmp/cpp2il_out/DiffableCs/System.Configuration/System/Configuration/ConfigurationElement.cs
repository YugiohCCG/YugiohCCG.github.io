namespace System.Configuration;

[DefaultMember("Item")]
public abstract class ConfigurationElement
{

	protected private override ConfigurationPropertyCollection Properties
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 44
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected private override ConfigurationPropertyCollection get_Properties() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected private override bool IsModified() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected private override void Reset(ConfigurationElement parentElement) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected private override void ResetModified() { }

}


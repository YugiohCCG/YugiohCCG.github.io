namespace System.Configuration;

public sealed class IgnoreSection : ConfigurationSection
{

	protected private virtual ConfigurationPropertyCollection Properties
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 44
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public IgnoreSection() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected private virtual void DeserializeSection(XmlReader xmlReader) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected private virtual ConfigurationPropertyCollection get_Properties() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected private virtual bool IsModified() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected private virtual void Reset(ConfigurationElement parentSection) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected private virtual void ResetModified() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected private virtual string SerializeSection(ConfigurationElement parentSection, string name, ConfigurationSaveMode saveMode) { }

}


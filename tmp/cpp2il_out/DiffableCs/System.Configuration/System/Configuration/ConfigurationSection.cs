namespace System.Configuration;

public abstract class ConfigurationSection : ConfigurationElement
{

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected private override void DeserializeSection(XmlReader reader) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected private virtual bool IsModified() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected private virtual void ResetModified() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected private override string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode) { }

}


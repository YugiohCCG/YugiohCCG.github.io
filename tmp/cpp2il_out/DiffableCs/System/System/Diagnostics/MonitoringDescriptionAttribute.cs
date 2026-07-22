namespace System.Diagnostics;

[AttributeUsage(AttributeTargets::All (32767))]
public class MonitoringDescriptionAttribute : DescriptionAttribute
{

	public virtual string Description
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 7
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public MonitoringDescriptionAttribute(string description) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual string get_Description() { }

}


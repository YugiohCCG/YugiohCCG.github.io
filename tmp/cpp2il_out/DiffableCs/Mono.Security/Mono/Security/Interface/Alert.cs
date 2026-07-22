namespace Mono.Security.Interface;

public class Alert
{
	private AlertLevel level; //Field offset: 0x10
	private AlertDescription description; //Field offset: 0x11

	public AlertDescription Description
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public AlertLevel Level
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AlertDescription)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AlertDescription), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Alert(AlertDescription description) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public AlertDescription get_Description() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public AlertLevel get_Level() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void inferAlertLevel() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}


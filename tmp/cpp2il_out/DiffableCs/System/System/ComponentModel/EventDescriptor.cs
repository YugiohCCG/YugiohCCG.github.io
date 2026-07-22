namespace System.ComponentModel;

public abstract class EventDescriptor : MemberDescriptor
{

	[CallerCount(Count = 10)]
	[Calls(Type = typeof(MemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Attribute[])}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected EventDescriptor(string name, Attribute[] attrs) { }

}


namespace SQLite;

[AttributeUsage(AttributeTargets::Property (128))]
public class UniqueAttribute : IndexedAttribute
{

	public virtual bool Unique
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public UniqueAttribute() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public virtual bool get_Unique() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void set_Unique(bool value) { }

}


namespace System.ComponentModel;

public class AddingNewEventArgs : EventArgs
{
	[CompilerGenerated]
	private object <NewObject>k__BackingField; //Field offset: 0x10

	public object NewObject
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = "Newtonsoft.Json.Linq.JContainer", Member = "System.ComponentModel.IBindingList.AddNew", ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public AddingNewEventArgs() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public object get_NewObject() { }

}


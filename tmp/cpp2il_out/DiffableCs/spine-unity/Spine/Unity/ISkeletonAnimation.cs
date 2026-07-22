namespace Spine.Unity;

public interface ISkeletonAnimation : ISpineComponent
{

	public event UpdateBonesDelegate UpdateComplete
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event UpdateBonesDelegate UpdateLocal
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event UpdateBonesDelegate UpdateWorld
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public Skeleton Skeleton
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_UpdateComplete(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	public void add_UpdateLocal(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	public void add_UpdateWorld(UpdateBonesDelegate value) { }

	public Skeleton get_Skeleton() { }

	[CompilerGenerated]
	public void remove_UpdateComplete(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	public void remove_UpdateLocal(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	public void remove_UpdateWorld(UpdateBonesDelegate value) { }

}


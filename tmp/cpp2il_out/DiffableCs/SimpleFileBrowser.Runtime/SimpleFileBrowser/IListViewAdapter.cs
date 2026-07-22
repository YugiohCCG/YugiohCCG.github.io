namespace SimpleFileBrowser;

public interface IListViewAdapter
{

	public int Count
	{
		 get { } //Length: 0
	}

	public float ItemHeight
	{
		 get { } //Length: 0
	}

	public OnItemClickedHandler OnItemClicked
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public ListItem CreateItem() { }

	public int get_Count() { }

	public float get_ItemHeight() { }

	public OnItemClickedHandler get_OnItemClicked() { }

	public void set_OnItemClicked(OnItemClickedHandler value) { }

	public void SetItemContent(ListItem item) { }

}


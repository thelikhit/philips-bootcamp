using System;

public class SearchWindow
{
	Button clearButton = new Button();
	TextBox searchBox = new TextBox();
	
	public SearchWindow() {
		Action action = new Action(this.ClearButton_clicked);
		this.clearButton.Click += action;
	}
	
	public void SimulateClearButtonClick()
	{
		clearButton.OnClick();
	}
	
	private void ClearButton_clicked() {
		searchBox.Clear();
	}
	
}

public class Button
{
	
	// event click
	public event Action Click;

	public void OnClick()
	{
		this.Click?.Invoke();
	}
}

public class TextBox
{
	public void Clear()
	{
		Console.WriteLine("TextBox Content Cleared");
	}

}

public class Program
{
	public static void Main()
	{
		SearchWindow searchWindow = new SearchWindow();
		
		while (true)
		{
			Console.WriteLine("Press Any Key To Click Clear Button");
			System.Threading.Tasks.Task.Delay(1000).Wait();
			searchWindow.SimulateClearButtonClick();
		}
	}
}

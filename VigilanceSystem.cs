using  System;  

//Publisher
public class SmartDoor
{
	public void Open()
	{
		OnActionChanged("Open");
	}

	public void Close()
	{
		OnActionChanged("Close");
	}

	//Events (Distributor Object)
	public event Action<string> OnAction = null;
	
	private void OnActionChanged(string status)
	{ 
		if (OnAction != null)
		{ 
			//Publisher Notifying the Distributor
			OnAction.Invoke(status);
		} 
	} 
}

//Subscriber
public class VigilanceSystem
{  
	//Publisher Ref
	SmartDoor smartDoor;
	public VigilanceSystem(SmartDoor doorRef)
	{
		smartDoor = doorRef;
		//Distributor Object
		Action<string> _eventHadnlerAddress = new Action<string>(Notify);
		//Set Distributor Object @Publisher
		smartDoor.OnAction += _eventHadnlerAddress;
	}

	//Event Handler 
	public void Notify(string doorStatus)
	{
		Console.WriteLine("Door Status :{0}", doorStatus);
	}

}

public class Program
{
	public static void Main()
	{
		SmartDoor publisher = new SmartDoor();
		VigilanceSystem subscriber = new VigilanceSystem(publisher);
		publisher.Open();
		publisher.Close();
	}
}

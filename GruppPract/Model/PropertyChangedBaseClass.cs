using System.ComponentModel;

namespace GruppPract
{
	public class PropertyChangedBaseClass : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public void NotifyPropertyChanged(string propName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
		}

		public void ClearSubscribers()
		{
			PropertyChanged = null;
		}
	}
}

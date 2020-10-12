using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    class TodoModel: INotifyPropertyChanged
    {
        public DateTime CreationDate { get; set; } = DateTime.Now;

		private bool _isDone;
		private string _text;

		public bool IsDone
		{
			get { return _isDone; }
			set {
				if (IsDone == value)
					return;
				_isDone = value;
				OnPropertyChanched("IsDone");
			}
		}

		public string Text
		{
			get { return _text; }
			set 
			{
				if (_text == value)
					return;
				_text = value;
				OnPropertyChanched("Text");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanched(string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

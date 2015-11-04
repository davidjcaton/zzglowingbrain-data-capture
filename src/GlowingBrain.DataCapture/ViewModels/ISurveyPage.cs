using System.ComponentModel;
using System.Windows.Input;

namespace GlowingBrain.DataCapture.ViewModels
{
	public interface ISurveyPage : INotifyPropertyChanged
	{
		ICommand NavigateBack { get; }
		ICommand SubmitPage { get; }
		bool IsFirstPage { get; }
		bool IsLastPage { get; }
	}
	
}

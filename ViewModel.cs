using MvvmHelpers;

namespace SwipeView
{
    internal class ViewModel : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
    {
        public ObservableRangeCollection<String> Tracklist { get; } = new();

    }
}

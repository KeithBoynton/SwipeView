using System.Collections.ObjectModel;

namespace SwipeView
{
    internal class ViewModel
    {
        public ObservableCollection<String> Tracklist { get; } = new();

        public ViewModel()
        {
            for (int i = 0; i < 100; i++)
            {
                Tracklist.Add($"Track {i}");
            }
        }
    }
}

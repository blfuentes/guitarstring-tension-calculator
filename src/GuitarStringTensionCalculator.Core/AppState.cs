namespace GuitarStringTensionCalculator.Core
{
    public class AppState
    {
        public int SelectedNumberOfStrings { get; private set; }
        public double SelectedScaleLength { get; private set; }
        public int SelectedTuning { get; private set; }

        public event Action OnChange;

        public void SetNumberOfStrings(int strings)
        {
            SelectedNumberOfStrings = strings;
            NotifyStateChanged();
        }

        public void SetScaleLength(double scalelength)
        {
            SelectedScaleLength = scalelength;
            NotifyStateChanged();
        }

        public void SetTuning(int tuning)
        {
            SelectedTuning = tuning;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}

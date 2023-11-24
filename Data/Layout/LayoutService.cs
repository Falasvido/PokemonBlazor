namespace PokemonBlazor.Data.Layout
{
    public delegate void MyEventHandler();

    public class LayoutService
    {
        public event MyEventHandler LayoutChanged;
        public bool UnokwnMode = false;

        public bool IsUnokwnModeActive()
        {
            return UnokwnMode;
        }

        public void ChangeUnokwnMode()
        {
            UnokwnMode = !UnokwnMode;
            LayoutChanged?.Invoke();
        }
    }
}

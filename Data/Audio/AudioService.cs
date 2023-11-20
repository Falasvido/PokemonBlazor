namespace PokemonBlazor.Data.Audio
{
    public class AudioService
    {
        private static bool SoundActive = false;

        public bool IsSoundActive()
        {
            return SoundActive;
        }

        public void ToggleSound()
        {
            SoundActive = !SoundActive;
        }
    }
}

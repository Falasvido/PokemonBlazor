﻿namespace PokemonBlazor.Data.Audio
{
    public class AudioService
    {
        private static double Volume = 0.0;

        public double GetVolume()
        {
            return Volume;
        }

        public void SetVolume(double volume)
        {
            Volume = volume / 100.0;
        }
    }
}

﻿namespace IIASA.FotoQuestApi.Configuration
{
    public class ImageConfigration
    {
        public const string ImageOptions = "ImageOptions";
        public int Thumbnail { get; set; }
        public int Small { get; set; }
        public int Large { get; set; }
        public int MinAllowedSize { get; set; }
        public int MaxAllowedSize { get; set; }
    }
}
﻿namespace PixelIt.Contracts
{
    public class ImagePart
    {
        public Guid ImageId { get; set; }
        public Guid Identificator { get; set; }
        public int TotalPart { get; set; }
        public int PartNumber { get; set; }
        public string StringBytes { get; set; }
    }
}
﻿using SkiaSharp;
using FFMpegCore;
using FFMpegCore.Pipes;

namespace CG.Areas.adm.Models
{
    public class SKBitmapFrame : IVideoFrame, IDisposable
    {
        public int Width => Source.Width;
        public int Height => Source.Height;
        public string Format => "bgra";

        private readonly SKBitmap Source;

        public SKBitmapFrame(SKBitmap bmp)
        {
            if (bmp.ColorType != SKColorType.Bgra8888)
                throw new NotImplementedException("only 'bgra' color type is supported");
            Source = bmp;
        }

        public void Dispose() =>
            Source.Dispose();

        public void Serialize(Stream pipe) =>
            pipe.Write(Source.Bytes, 0, Source.Bytes.Length);

        public Task SerializeAsync(Stream pipe, CancellationToken token) =>
            pipe.WriteAsync(Source.Bytes, 0, Source.Bytes.Length, token);
    }
}

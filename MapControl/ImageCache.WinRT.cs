﻿// XAML Map Control - http://xamlmapcontrol.codeplex.com/
// Copyright © 2014 Clemens Fischer
// Licensed under the Microsoft Public License (Ms-PL)

using System;
using System.Threading.Tasks;
using Windows.Storage.Streams;

namespace MapControl.Caching
{
    public class ImageCacheItem
    {
        public IBuffer Buffer { get; set; }
        public DateTime Expires { get; set; }
    }

    public interface IImageCache
    {
        Task<ImageCacheItem> GetAsync(string key);
        Task SetAsync(string key, IBuffer buffer, DateTime expires);
    }
}

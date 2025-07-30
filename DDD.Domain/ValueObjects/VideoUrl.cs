using DDD.Domain.Exception.CourseManagementException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ValueObjects
{
    public record VideoUrl
    {
        public string Value { get; }
        public VideoUrl(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new VideoUrlNullOrEmptyException  ();
       
            if(!value.EndsWith(".mp4"))
                throw new InvalidVideoExtensionException ();
            Value = value;

        }

        public static implicit operator string(VideoUrl video) => video.Value;
        public static implicit operator VideoUrl(string video) => new(video);
    }
}

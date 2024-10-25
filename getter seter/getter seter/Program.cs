using System;
using getter_seter;

Console.WriteLine(Video.video_count);
Video video1 = new Video("真D舒服!", "小白", "你媽");
video1.Type = "教育";

Console.WriteLine(video1.getVideoCount());

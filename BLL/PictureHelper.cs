using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace BLL
{
    public class PictureHelper
    {
        /// <summary>
        /// 生成缩略图
        /// </summary>
        /// <param name="picUrl">原图路径</param>
        /// <param name="mhbUrl">缩略图路径</param>
        /// <param name="hbWidth">缩略图的宽</param>
        /// <param name="hbHeight">缩略图的高</param>
        /// <param name="hbHeight">缩略图的高是否按比例</param>
        public static void MakeThumbnail(string picUrl, string mhbUrl, int hbWidth, int hbHeight, bool heihtIsScale)
        {
            if (!File.Exists(picUrl))
            {
                return;
            }

            //源图像文件的绝对路径,图片类型："png", "gif", "jpg"
            String src = picUrl;// "D:/xzhsxwork/work/Appraise/Appraise/Content/Temp/17010100000006/图集/图集1/1.jpg"; 

            //利用Image对象装载源图像
            Image image = Image.FromFile(src);
            //源图像的宽度和高度。
            int srcWidth = image.Width;
            int srcHeight = image.Height;

            //生成的缩略图图像文件的绝对路径
            String dest = mhbUrl;//"D:/xzhsxwork/work/Appraise/Appraise/Content/Temp/17010100000006/图集/图集1/1_hb_1.jpg";
            //要生成的缩略图的宽度
            int thumbWidth = hbWidth;
            //要生成的缩略图的高度
            int thumbHeight = hbHeight;
            //按比例计算高度
            if (heihtIsScale == true)
            {
                double scale = Math.Round((srcHeight / (srcWidth * 1.0)), 2);
                thumbHeight = Convert.ToInt32(scale * thumbWidth);
            }

            //初始化缩略图的宽和高
            Bitmap bmp = new Bitmap(thumbWidth, thumbHeight);
            //从Bitmap创建一个System.Drawing.Graphics对象，用来绘制高质量的缩小图。
            Graphics gr = Graphics.FromImage(bmp);

            //设置 System.Drawing.Graphics对象的SmoothingMode属性为HighQuality
            //gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //设成高质量
            //gr.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            //设成High
            //gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;

            //把原始图像绘制成上面所设置宽高的缩小图
            System.Drawing.Rectangle rectDestination = new System.Drawing.Rectangle(0, 0, thumbWidth, thumbHeight);
            gr.DrawImage(image, rectDestination, 0, 0, srcWidth, srcHeight, GraphicsUnit.Pixel);

            //保存图像
            bmp.Save(dest);
            //释放资源
            bmp.Dispose();
            image.Dispose();
        }
    }
}

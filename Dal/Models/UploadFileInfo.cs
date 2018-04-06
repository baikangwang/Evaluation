using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    public enum FileType
    {
        DeclarationAppendix,
        DeclarationAtlas,
        DeclarationMedia,
        DeclarationImage,
        NoticeImage,
        NoticeAppendix,
        UpdateContent,
        UpdateSqlText,
        UpdatePackage,
        UpdateSourceCode
    }

  public class UploadFileInfo : BaseEntity
    {
      /// <summary>
      /// 上传文件编号
      /// </summary>
      public int? UploadFileID { get; set; }

      /// <summary>
      /// 文件类别
      /// </summary>
      public FileType? Type
      {
          get
          {
              if (string.IsNullOrEmpty(TypeCode))
              {
                  return null;
              }
              else
              {
                  return (Dal.Models.FileType)Enum.Parse(typeof(Dal.Models.FileType), TypeCode);
              }
          }
          set
          {
              TypeCode = Enum.GetName(typeof(FileType), value);
          }
      }

      /// <summary>
      /// 类别编码
      /// </summary>
      public string TypeCode { get; set; }

      /// <summary>
      /// 关联ID
      /// </summary>
      public int? CorrelationID { get; set; }

      /// <summary>
      /// 关联者名称
      /// </summary>
      public string CorrelationName { get; set; }

      /// <summary>
      /// 归属
      /// </summary>
      public int? OwnerID { get; set; }

      /// <summary>
      /// 文件名称
      /// </summary>
      public string FileName { get; set; }

      /// <summary>
      /// 文件存储路径
      /// </summary>
      public string URL { get; set; }

      /// <summary>
      /// 上传时间
      /// </summary>
      public DateTime? UploadTime { get; set; }

      /// <summary>
      /// 上传文件的大小限制
      /// </summary>
      public int? SizeLimit { get; set; }

      /// <summary>
      /// 上传文件的数量限制
      /// </summary>
      public int? AmountLimit { get; set; }

      /// <summary>
      /// 附件编号
      /// </summary>
      public int? AppendixID { get; set; }

      /// <summary>
      /// 图集编号
      /// </summary>
      public int? AtlasID { get; set; }

      /// <summary>
      /// 视频编号
      /// </summary>
      public int? MediaID { get; set; }

      /// <summary>
      /// 文件对应的类别是否是必须项
      /// </summary>
      public bool? IsRequired { get; set; }
    }
}

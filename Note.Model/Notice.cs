using System;
using System.ComponentModel.DataAnnotations;

namespace Note.Model
{
    public class Notice
    {
        [Key]   //primary key
        public int NoticeNo { get; set; }

        [Required]  //not null
        public string NoticeTitle { get; set; }

        [Required]
        public string NoticeContents { get; set; }

        [Required]
        public DateTime NoticeWriteDate { get; set; }

    }
}

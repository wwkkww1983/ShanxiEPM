//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace hc.Plat.FileServer.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class TempFiles
    {
        public int Id { get; set; }
        public string App { get; set; }
        public string FileGuid { get; set; }
        public int Chunk { get; set; }
        public int Chunks { get; set; }
        public string FileName { get; set; }
        public string ChunkName { get; set; }
        public string FileLastModifiedDate { get; set; }
        public long ChunkSize { get; set; }
        public long FileSize { get; set; }
        public string ChunkPath { get; set; }
        public System.DateTime UploadTime { get; set; }
        public string RequetURL { get; set; }
        public string IP { get; set; }
        public string Browser { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.SessionState;


/// <summary>
/// UploadHandler 的摘要说明
/// </summary>
public class UploadHandler : Handler
{

    public UploadConfig UploadConfig { get; private set; }
    public UploadResult Result { get; private set; }

    public UploadHandler(HttpContext context, UploadConfig config)
        : base(context)
    {
        this.UploadConfig = config;
        this.Result = new UploadResult() { State = UploadState.Unknown };
    }

    public override void Process()
    {
        byte[] uploadFileBytes = null;
        string uploadFileName = null;

        if (UploadConfig.Base64)
        {
            uploadFileName = UploadConfig.Base64Filename;
            uploadFileBytes = Convert.FromBase64String(Request[UploadConfig.UploadFieldName]);
        }
        else
        {
            var file = Request.Files[UploadConfig.UploadFieldName];
            uploadFileName = file.FileName;

            if (!CheckFileType(uploadFileName))
            {
                Result.State = UploadState.TypeNotAllow;
                WriteResult();
                return;
            }
            if (!CheckFileSize(file.ContentLength))
            {
                Result.State = UploadState.SizeLimitExceed;
                WriteResult();
                return;
            }

            uploadFileBytes = new byte[file.ContentLength];
            try
            {
                file.InputStream.Read(uploadFileBytes, 0, file.ContentLength);
            }
            catch (Exception)
            {
                Result.State = UploadState.NetworkError;
                WriteResult();
            }
        }

        Result.OriginFileName = uploadFileName;
        var savePath = PathFormatter.Format(uploadFileName, UploadConfig.PathFormat);
        string localPath = Server.MapPath(savePath);

        try
        {
            #region 新增将附件上传到指定路径 2019-08-27

            // 获取是否指定资源服务器路径
            string resourceUrl = System.Configuration.ConfigurationManager.AppSettings.Get("EditorResourceUrl");

            // 如果指定，就上传至指定路径
            if (!string.IsNullOrWhiteSpace(resourceUrl))
            {
                string rootPath = System.Configuration.ConfigurationManager.AppSettings.Get("EditorResource");
                if (string.IsNullOrWhiteSpace(rootPath))
                {
                    rootPath = "C:\\Editor\\upload\\";
                }
                localPath = rootPath + savePath.Replace("/", "\\");
                savePath = resourceUrl + "/" + savePath;
            }

            #endregion

            if (!Directory.Exists(Path.GetDirectoryName(localPath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(localPath));
            }

            File.WriteAllBytes(localPath, uploadFileBytes);
            Result.Url = savePath;
            Result.State = UploadState.Success;
        }
        catch (Exception e)
        {
            Result.State = UploadState.FileAccessError;
            Result.ErrorMessage = e.Message;
            WriteUploadExLog(e.Message);
        }
        finally
        {
            WriteResult();
        }
    }

    private void WriteResult()
    {
        if (!string.IsNullOrWhiteSpace(Result.Url) && Result.Url.ToLower().StartsWith("http"))
        {
            this.WriteJson(new
            {
                state = GetStateMessage(Result.State),
                url = Result.Url,
                filePathName = Result.FilePathName,
                title = Result.OriginFileName,
                original = Result.OriginFileName,
                error = Result.ErrorMessage
            });
        }
        else
        {
            WriteUploadExLog("上传资源服务器失败(资源服务地址http)");
        }
    }

    private void WriteUploadExLog(string exMsg)
    {
        string FilePath = AppDomain.CurrentDomain.BaseDirectory;
        FilePath = FilePath + "fileUplodEx.txt";
        FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate, FileAccess.Write);
        StreamWriter m_streamWriter = new StreamWriter(fs);
        m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
        string msg = DateTime.Now.ToString();
        if (!string.IsNullOrWhiteSpace(Result.Url))
        {
            msg = msg + "  Url:" + Result.Url;
        }
        else
        {
            msg = msg + "  Url:NULL";
        }

        if (!string.IsNullOrWhiteSpace(Result.OriginFileName))
        {
            msg = msg + "  FileName:" + Result.OriginFileName;
        }
        else
        {
            msg = msg + "  FileName:NULL";
        }
        msg = msg + "  ExMessage:" + exMsg;
        m_streamWriter.WriteLine("UploadHandler:" + msg);
        m_streamWriter.Flush();
        m_streamWriter.Close();
        fs.Close();
    }

    private string GetStateMessage(UploadState state)
    {
        switch (state)
        {
            case UploadState.Success:
                return "SUCCESS";
            case UploadState.FileAccessError:
                return "文件访问出错，请检查写入权限";
            case UploadState.SizeLimitExceed:
                return "文件大小超出服务器限制";
            case UploadState.TypeNotAllow:
                return "不允许的文件格式";
            case UploadState.NetworkError:
                return "网络错误";
        }
        return "未知错误";
    }

    private bool CheckFileType(string filename)
    {
        var fileExtension = Path.GetExtension(filename).ToLower();
        return UploadConfig.AllowExtensions.Select(x => x.ToLower()).Contains(fileExtension);
    }

    private bool CheckFileSize(int size)
    {
        return size < UploadConfig.SizeLimit;
    }
}

public class UploadConfig
{
    /// <summary>
    /// 文件命名规则
    /// </summary>
    public string PathFormat { get; set; }

    /// <summary>
    /// 上传表单域名称
    /// </summary>
    public string UploadFieldName { get; set; }

    /// <summary>
    /// 上传大小限制
    /// </summary>
    public int SizeLimit { get; set; }

    /// <summary>
    /// 上传允许的文件格式
    /// </summary>
    public string[] AllowExtensions { get; set; }

    /// <summary>
    /// 文件是否以 Base64 的形式上传
    /// </summary>
    public bool Base64 { get; set; }

    /// <summary>
    /// Base64 字符串所表示的文件名
    /// </summary>
    public string Base64Filename { get; set; }
}

public class UploadResult
{
    public UploadState State { get; set; }
    public string Url { get; set; }
    public string OriginFileName { get; set; }

    public string ErrorMessage { get; set; }

    /// <summary>
    /// 文件夹/文件名
    /// </summary>
    public string FilePathName { get; set; }
}

public enum UploadState
{
    Success = 0,
    SizeLimitExceed = -1,
    TypeNotAllow = -2,
    FileAccessError = -3,
    NetworkError = -4,
    Unknown = 1,
}


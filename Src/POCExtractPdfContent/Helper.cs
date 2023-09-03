namespace POCExtractPdfContent;

/// <summary>
/// Class Helper.
/// </summary>
public static class Helper
{
    /// <summary>
    /// Downloads the content.
    /// </summary>
    /// <param name="url">The URL.</param>
    /// <returns>System.Byte[].</returns>
    public static byte[] DownloadContent(string url)
    {
        using var httpClient = new HttpClient();
        return httpClient.GetByteArrayAsync(url).Result;
    }
}

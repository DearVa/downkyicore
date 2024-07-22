using System.Text.Json;
using System.Text.Json.Serialization;

namespace DownKyi.Core.BiliApi.Models;

public abstract class BaseModel
{
    public string ToString(string format = "")
    {
        return format switch
        {
            "F" =>
                // 整理json格式
                JsonSerializer.Serialize(this,
                    new JsonSerializerOptions
                    {
                        WriteIndented = true
                    }),
            "N" =>
                // 去掉null后，转换为json字符串
                JsonSerializer.Serialize(this,
                    new JsonSerializerOptions
                    {
                        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
                    }),
            _ => JsonSerializer.Serialize(this)
        };
    }
}
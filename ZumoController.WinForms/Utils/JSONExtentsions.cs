using Newtonsoft.Json;

namespace ZumoController.WinForms.Utils
{
    public static class JSONExtensions
    {
        public static string ToJSON(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static T? FromJson<T>(this string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}

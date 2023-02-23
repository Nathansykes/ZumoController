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

    public static class ExtensionMethods
    {
        public static int Remap(this decimal value, decimal from1, decimal to1, decimal from2, decimal to2)
        {
            return (int)Math.Round((value - from1) / (to1 - from1) * (to2 - from2) + from2);
        }
    }
}

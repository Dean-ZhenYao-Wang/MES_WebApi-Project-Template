namespace MES.CoreComponents
{
    /// <summary>
    /// 用于任何需要字符串值的元素
    /// </summary>
    public class TextType
    {
        public string 值 { get; set; }

        public TextType(string 值, string 语言ID = null)
        {
            this.值 = 值;
            this.语言ID = 语言ID;
        }

        public string 语言ID { get; set; }
    }
}

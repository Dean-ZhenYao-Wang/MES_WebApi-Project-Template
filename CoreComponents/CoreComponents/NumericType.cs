namespace MES.CoreComponents
{
    /// <summary>
    /// 用于任何需要数值的元素
    /// </summary>
    public struct NumericType
    {
        public decimal 值 { get; set; }

        public NumericType(decimal 值, string 格式 = null) : this()
        {
            this.值 = 值;
            this.格式 = 格式;
        }

        public string 格式 { get; set; }
    }
}

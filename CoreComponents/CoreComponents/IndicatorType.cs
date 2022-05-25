namespace MES.CoreComponents
{
    /// <summary>
    /// 用于任何布尔值元素
    /// </summary>
    public struct IndicatorType
    {
        public bool 值 { get; set; }

        public IndicatorType(bool 值) : this()
        {
            this.值 = 值;
        }
    }
}

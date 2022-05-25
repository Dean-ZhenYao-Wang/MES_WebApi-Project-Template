namespace MES.Common
{
    /// <summary>
    /// 持续时间类型
    /// </summary>
    public struct DurationType
    {
        /// <summary>
        /// 持续时间
        /// </summary>
        public long 值 { get; set; }

        public DurationType(long 值)
        {
            this.值 = 值;
        }
    }
}
